using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatexGeneratorCLI.Model.Flags
{
    class FlagWrapper
    {
        public Flag Flag;
        public readonly int Index;

        public FlagWrapper(Flag flag, int index)
        {
            Flag = flag;
            Index = index;
        }
    }
}
