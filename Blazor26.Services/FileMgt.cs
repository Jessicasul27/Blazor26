
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor26.Services
{
    public class FileMgt : IFileMgt
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public FileMgt(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public bool FileDelete(string filePath)
        {
            if (File.Exists(_webHostEnvironment.WebRootPath + filePath))
            {
                File.Delete(_webHostEnvironment.WebRootPath + filePath);
                return true;
            }
            return false;
        }

        public async Task<string> FileUpLoad(IBrowserFile BrowserFile)
        {
           string wwwRootFolder = _webHostEnvironment.WebRootPath;
           FileInfo fileInfo = new FileInfo(BrowserFile.Name);
           
           string new_fileName = Guid.NewGuid().ToString() + fileInfo.Extension;
           var uploads = Path.Combine(wwwRootFolder, @"Images\products");
            var imagePath = @"/Images/products/" + new_fileName;
            var fullFilePath = Path.Combine(uploads, new_fileName);

            await using FileStream fs = new FileStream(fullFilePath, FileMode.Create);


            await BrowserFile.OpenReadStream().CopyToAsync(fs);
            return imagePath;
          
        }
    }
}
