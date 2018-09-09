using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatexGenerator.Services
{
    public class AppConfiguration
    {
        public string ActiveDirectory { get; set; }
        public string FileName { get; set; }
        public int ItemCount { get; set; }
        public int SectionCount { get; set; }
        public bool? IncludeSections { get; set; }
        public bool? IncludeTColorBox { get; set; }
        public string[] SimplePackages { get; set; }
        public string[] ComplexPackages { get; set; }

        public AppConfiguration()
        {
            ActiveDirectory = ConfigurationManager.AppSettings["DefaultDirectory"];
        }
    }
}
