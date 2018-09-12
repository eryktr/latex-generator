using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatexGeneratorCLI.Model
{
    class State
    {
        public int CurrentIndex;
        public readonly int NumberOfArgs;
        public readonly List<Flag> Flags;
        public readonly int RequiredNumberOfArgs;

        public State(string[] args)
        {
            NumberOfArgs = args.Length;
        }

        public bool IsValid()
        {
            return RequiredNumberOfArgs == NumberOfArgs;
        }
    }
}
