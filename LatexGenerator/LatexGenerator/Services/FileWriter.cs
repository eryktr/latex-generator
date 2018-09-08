using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LatexGenerator.Models;

namespace LatexGenerator.Services
{
    class FileWriter
    {
        private readonly FileStream _fileStream;
        private readonly AppConfiguration _appConfiguration;
        
        public FileWriter(FileStream fileStream, AppConfiguration appConfiguration)
        {
            _fileStream = fileStream;
            _appConfiguration = appConfiguration;
        }

        public void WriteFile()
        {
            using (var sw = new StreamWriter(_fileStream))
            {
                
                sw.WriteLine(LatexConfiguration.DocumentclassTag);
                foreach (var package in _appConfiguration.Packages)
                {
                    sw.WriteLine(LatexConfiguration.PackageTag + $" {{{package}}}");
                }
                sw.WriteLine(LatexConfiguration.AuthorTag);
                sw.WriteLine(LatexConfiguration.BeginDocTag);
                sw.WriteLine(LatexConfiguration.EndDocTag);
            }
        }
    }
}
