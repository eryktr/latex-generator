using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    }
}
