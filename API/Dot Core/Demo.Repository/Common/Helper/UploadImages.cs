using System;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace Demo.Repository.Common.Helper
{
    public class UploadImages
    {

        public string UploadImage(string folderPath, string fileName, IFormFile image)
        {
            try
            {
                // Email commonFunction = new Email();
                string newFileName = fileName.Replace(" ", "") + "_"+Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);
                var path = Path.Combine("wwwroot",folderPath, newFileName);
                var returnPath = Path.Combine(folderPath, newFileName);

                bool exists = System.IO.Directory.Exists(folderPath);
                // Check folder exists.
                if (!exists)
                {
                    System.IO.Directory.CreateDirectory(folderPath);
                }

                if (image.Length > 0)
                {
                    using var fileStream = new FileStream(path, FileMode.Create);
                    image.CopyTo(fileStream);
                    fileStream.Dispose();
                    fileStream.Close();
                }

                path = path.Replace("\\", "/");
                returnPath = returnPath.Replace("\\", "/");
                return returnPath;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string UploadDocumentImage(string folderPath, string fileName, IFormFile image)
        {

            string basePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
            string newFileName = Path.GetFileName(image.FileName);
            var path = Path.Combine(folderPath, newFileName + "###" + Convert.ToString(Guid.NewGuid()));

            bool exists = System.IO.Directory.Exists(folderPath);
            // Check folder exists.
            if (!exists)
            {
                System.IO.Directory.CreateDirectory(folderPath);
            }

            if (image.Length > 0)
            {
                image.CopyToAsync(new FileStream(path, FileMode.Create));
            }
            path = path.Replace(basePath, "").Replace("\\", "/");
            return path;
        }
        public string UploadMultipleImage(string folderPath, string fileName, IFormFile image)
        {
            string basePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
            Random random = new Random();
            string newFileName = fileName + Convert.ToString(Guid.NewGuid()) + Path.GetExtension(image.FileName);
            var path = Path.Combine(folderPath, newFileName);

            bool exists = System.IO.Directory.Exists(folderPath);
            // Check folder exists.
            if (!exists)
            {
                System.IO.Directory.CreateDirectory(folderPath);
            }

            if (image.Length > 0)
            {
                image.CopyTo(new FileStream(path, FileMode.Create));
            }
            path = path.Replace(basePath, "").Replace("\\", "/");
            return path;
        }

        public string FormatSize(Int64 bytes)
        {
            string[] suffixes = { "Bytes", "KB", "MB", "GB", "TB", "PB" };
            int counter = 0;
            decimal number = (decimal)bytes;
            while (Math.Round(number / 1024) >= 1)
            {
                number /= 1024;
                counter++;
            }
            return string.Format("{0:n1}{1}", number, suffixes[counter]);
        }

    }
   
}

