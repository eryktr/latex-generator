using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatexGeneratorCLI.Services
{
    static class CLIConfiguration
    {
        public static readonly List<string> PossibleFlags = new List<string>() {"s", "c", "i"};
        public static readonly int SFlagNumOfArgs = 1;
        public static readonly int IFlagNumOfArgs = 1;
    }
}
