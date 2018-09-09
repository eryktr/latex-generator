using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using LatexGenerator.Models;

namespace LatexGenerator.Services
{
    internal class FileWriter
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
                foreach (var package in _appConfiguration.SimplePackages)
                {
                    sw.WriteLine(LatexConfiguration.PackageTag + $"{{{package}}}");
                }

                foreach (var package in _appConfiguration.ComplexPackages)
                {
                    sw.WriteLine(LatexConfiguration.PackageTag + package);
                }

                if (_appConfiguration.IncludeTColorBox == true)
                {
                    sw.WriteLine(LatexConfiguration.TColorBoxTag);
                }

                sw.WriteLine(LatexConfiguration.AuthorTag);
                sw.WriteLine(LatexConfiguration.BeginDocTag);
                if (_appConfiguration.IncludeSections == true)
                {
                    for (var j = 0; j < _appConfiguration.SectionCount; j++)
                    {
                        sw.WriteLine(Environment.NewLine + LatexConfiguration.SectionTag);

                        sw.WriteLine(LatexConfiguration.Indent + LatexConfiguration.BeginListTag);
                        for (var i = 0; i < _appConfiguration.ItemCount; i++)
                        {
                            sw.WriteLine(LatexConfiguration.Indent + LatexConfiguration.Indent + LatexConfiguration.ItemTag);
                        }
                        sw.WriteLine(LatexConfiguration.Indent + LatexConfiguration.EndListTag);
                    }
                }
                else
                {
                    sw.WriteLine(LatexConfiguration.BeginListTag);
                    for (var i = 0; i < _appConfiguration.ItemCount; i++)
                    {
                        sw.WriteLine(LatexConfiguration.Indent + LatexConfiguration.ItemTag);
                    }
                    sw.WriteLine(LatexConfiguration.EndListTag);
                }

                sw.WriteLine(LatexConfiguration.EndDocTag);
            }
        }
    }
}