using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatexGeneratorCLI.Model.Flags
{
    abstract class BooleanFlag : Flag
    {
        public override int GetNumberOfArguments()
        {
            return 0;
        }
    }
}
