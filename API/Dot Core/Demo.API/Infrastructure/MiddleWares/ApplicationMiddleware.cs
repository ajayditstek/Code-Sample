using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Threading.Tasks;
using Shyjus.BrowserDetection;
using Newtonsoft.Json;
using System.IO;
using Demo.Core.DTOs.Response;
using Demo.Core.DTOs.Request;
using Demo.Core.Interfaces;
using System.Text;

namespace Demo.API.Infrastructure.MiddleWares
{
    public class ApplicationMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        private readonly IAPILogRepository _apiLogRepository;

        public ApplicationMiddleware(RequestDelegate next, ILoggerFactory loggerFactory, IAPILogRepository apiLogRepository)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<ApplicationMiddleware>();
            _apiLogRepository = apiLogRepository;
        }

        public async Task Invoke(HttpContext httpContext, IWebHostEnvironment env, IBrowserDetector detector)
        {
            //Copy a pointer to the original response body stream
            var originalBodyStream = httpContext.Response.Body;
            var addAPILogDTO = new AddAPILogDTO();
            try
            {
                using (var responseBodyStream = new MemoryStream())
                {
                    httpContext.Request.EnableBuffering();
                    addAPILogDTO.APIParams = await FormatRequestBody(httpContext.Request);
                    //First, get the incoming request
                    httpContext.Request.Body.Seek(0, SeekOrigin.Begin);

                    httpContext.Response.Body = responseBodyStream;
                    //Read API URL
                    string host = httpContext.Request.Host.ToString();
                    string prefix = "";

                    addAPILogDTO.APIUrl = httpContext.Request.Scheme + "://" + httpContext.Request.Host + prefix + httpContext.Request.Path;

                    //Read Authorization Header
                    addAPILogDTO.Headers = httpContext.Request.Headers["Authorization"];

                    // Read Method
                    addAPILogDTO.Method = httpContext.Request.Method;
                    if (httpContext.Request.Method != "POST" && httpContext.Request.Method != "PUT")
                    {
                        addAPILogDTO.APIParams = httpContext.Request.QueryString.ToString();
                    }

                    addAPILogDTO.APILogId = (await _apiLogRepository.AddAPILog(addAPILogDTO)).KeyId;

                    await _next(httpContext);

                    //Format the response from the server
                    var response = FormatResponse(httpContext.Response, httpContext);

                    //Copy the contents of the new memory stream (which contains the response) to the original stream, which is then returned to the client.
                    await responseBodyStream.CopyToAsync(originalBodyStream);

                    await _apiLogRepository.UpdateAPILog(new UpdateAPILogDTO() { APILogId = addAPILogDTO.APILogId, Success = true });

                }
            }
            catch (Exception ex)
            {
                httpContext.Response.Body = originalBodyStream;
                await HandleExceptionAsync(httpContext, ex, env, detector, addAPILogDTO);
            }
        }
        private Task HandleExceptionAsync(HttpContext httpContext, Exception exception, IWebHostEnvironment env, IBrowserDetector detector, AddAPILogDTO addAPILogDTO)
        {
            HttpStatusCode statusCode = HttpStatusCode.InternalServerError;
            string Message = String.Empty;
            string Log = String.Empty;
            Message = exception.Message;
            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = (int)statusCode;
            LogExceptionInDB(exception, addAPILogDTO, _apiLogRepository);
            return httpContext.Response.WriteAsync(new ErrorDetailDTO()
            {
                keyId = -1,
                responseCode = httpContext.Response.StatusCode,
                responseMessage = exception.Message
            }.ToString());
        }
        private void LogExceptionInDB(Exception exception, AddAPILogDTO addAPILogDTO, IAPILogRepository _apiLogRepository)
        {
            var updateAPILogDTO = new UpdateAPILogDTO();
            updateAPILogDTO.ExceptionMsg = exception.Message;
            updateAPILogDTO.ExceptionType = exception.GetType().Name;
            updateAPILogDTO.ExceptionSource = GenerateExceptionMessage(exception, addAPILogDTO);
            updateAPILogDTO.APILogId = addAPILogDTO.APILogId;
            _apiLogRepository.UpdateAPILog(updateAPILogDTO);
        }

        public string GenerateExceptionMessage(Exception exception, AddAPILogDTO addAPILogDTO)
        {
            return "APIURL : " + addAPILogDTO.APIUrl + System.Environment.NewLine + "APIParams : " + addAPILogDTO.APIParams + System.Environment.NewLine + "Method : " + addAPILogDTO.Method + System.Environment.NewLine +
            "Error Message : " + exception.Message + System.Environment.NewLine + "Inner Exception : " + exception.InnerException + System.Environment.NewLine +
            "Source : " + exception.Source + System.Environment.NewLine + "StackTrace : " + exception.StackTrace;
        }
        private async Task<string> FormatResponse(HttpResponse response, HttpContext httpContext)
        {
            //We need to read the response stream from the beginning...
            response.Body.Seek(0, SeekOrigin.Begin);

            //...and copy it into a string
            string text = await new StreamReader(response.Body).ReadToEndAsync();

            //We need to reset the reader for the response so that the client can read it.
            response.Body.Seek(0, SeekOrigin.Begin);

            var responseCode = JsonConvert.DeserializeObject<ResponseDTO>(text);
            // if (response.StatusCode != 200)
            // {
            if (responseCode != null && responseCode.ResponseCode != 200 && responseCode.ResponseCode != 0)
            {
                response.StatusCode = 500;
            }
            // }
            //Return the string for the response, including the status code (e.g. 200, 404, 401, etc.)
            return $"{response.StatusCode}: {text}";
        }

        private async Task<string> FormatRequestBody(HttpRequest request)
        {
            var body = request.Body;

            //We now need to read the request stream. First, we create a new byte[] with the same length as the request stream...
            var buffer = new byte[Convert.ToInt32(request.ContentLength)];

            //...Then we copy the entire request stream into the new buffer.
            await request.Body.ReadAsync(buffer, 0, buffer.Length);

            //We convert the byte[] into a string using UTF8 encoding...
            var bodyAsText = Encoding.UTF8.GetString(buffer);

            //..and finally, assign the read body back to the request body, which is allowed because of EnableRewind()
            request.Body = body;

            return bodyAsText;
        }
    }
}