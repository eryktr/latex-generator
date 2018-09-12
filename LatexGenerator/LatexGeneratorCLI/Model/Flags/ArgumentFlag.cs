using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LatexGeneratorCLI.Model.Flags;

namespace LatexGeneratorCLI.Model.Flags
{
    abstract class ArgumentFlag : Flag
    {
        public  int NumOfArguments;
        public List<string> Arguments;

        public void SetArguments()
        {

        }
    }
}
