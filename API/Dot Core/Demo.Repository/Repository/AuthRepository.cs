using System;
using System.Linq;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Demo.Core.DTOs.Request;
using Demo.Core.Interfaces;
using Demo.Core.Model;
using Demo.Repository.Common.Helper;
using Demo.Repository.Enums;
using Demo.Repository.GenricRepo;

namespace Demo.Repository.Repository
{
    public class AuthRepository : GenericRepository<AspnetMembership>, IAuthRepository
    {
        private readonly UATDemoPortalContext _dbContext;
        private IConfiguration _configuration;
        public AuthRepository(UATDemoPortalContext dbContext,IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }

        public LoginResponseDTO AddLogin(AddLoginDTO addLoginDTO)
        {

            if ((addLoginDTO.UserName != null && addLoginDTO.UserName != "") && (addLoginDTO.Password != null && addLoginDTO.Password != ""))
            {
                var user = _dbContext.AspnetMemberships.Where(x => x.User.UserName == addLoginDTO.UserName).FirstOrDefault();
                var panelBeaterId = _dbContext.UserFunctionAllocations.Where(x => x.UserName == addLoginDTO.UserName).Select(x => x.AllocationId).FirstOrDefault();

                if (user == null)
                {
                    throw new Exception(ResponseMessages.InvalidLoginCredentials);
                }
                else
                {
                    var commonFunction = new GenerateToken(_configuration,_dbContext);
                    var (SecurityToken,token) = commonFunction.GenerateAccessToken(user,false);
                    return new LoginResponseDTO()
                    {
                        KeyId = 1,
                        ResponseCode = ResponseCode.Success,
                        ResponseMessage = ResponseMessages.LoginSuccessful,
                        Token = SecurityToken,
                        Email = user.Email,
                        UserId = user.UserId,
                        PanelBeaterId = panelBeaterId
                    };
                }
            }
            else
            {
                throw new Exception(ResponseMessages.PleaseEnterCredentials);
            }
        }
    }

}