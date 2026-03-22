using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor26.Services
{
    public interface IFileMgt
    {
        Task<string> FileUpLoad(IBrowserFile BrowserFile);
        bool FileDelete(string filePath);
    }
}
