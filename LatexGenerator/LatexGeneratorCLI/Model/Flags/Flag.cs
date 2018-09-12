using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LatexGenerator.Services;
namespace LatexGeneratorCLI.Model.Flags
{
    abstract class Flag
    {
        public abstract void Execute(AppConfiguration configuration);
        public abstract int GetNumberOfArguments();
        
    }
}
