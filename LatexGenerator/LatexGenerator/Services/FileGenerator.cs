using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using LatexGenerator.Models;

namespace LatexGenerator.Services
{
    internal class FileGenerator
    {
        private readonly AppConfiguration _configuration;
        private const string FileExtension = ".tex";
        

        public FileGenerator(AppConfiguration configuration)
        {
            _configuration = configuration;
        }

        public FileStream CreateFile()
        {
            var dir = _configuration.ActiveDirectory;
            var name = _configuration.FileName + FileExtension;
            var path = Path.Combine(dir, name);
            if (File.Exists(path))
            {
                WindowManager.DisplayError(ErrorType.FileExists);
                return null;
            }
            else
            {
                return File.Create(path);
            }
        }

    }
}
