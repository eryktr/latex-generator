using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LatexGeneratorCLI.Model.Flags;

namespace LatexGeneratorCLI.Model.Flags
{
    abstract class ArgumentFlag : Flag
    {
        public new List<string> Arguments = new List<string>();
        public int NumOfArguments;

        public override int GetNumberOfArguments()
        {
            return NumOfArguments;
        }

        public void SetArguments(State state)
        {
            for (int i = 0; i < NumOfArguments; i++)
            {
                var ci = state.CurrentIndex;
                var cs = state.Args[ci];
                Arguments.Add(cs);
                state.CurrentIndex++;
            }
        }
    }
}
