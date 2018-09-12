using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LatexGenerator.Services;
using LatexGeneratorCLI.Model.Flags;

namespace LatexGeneratorCLI.Model
{
    class State
    {
        public int CurrentIndex;
        public readonly int NumberOfArgs;
        public readonly List<FlagWrapper> Flags;
        public readonly int RequiredNumberOfArgs;
        public readonly string[] Args;

        public State(string[] args)
        {
            Args = args;
            NumberOfArgs = args.Length;
            var fb = new FlagBuilder(args);
            Flags = fb.GetFlags();
            var req = Flags.Count;
            foreach (var flag in Flags)
            {
                req += flag.Flag.GetNumberOfArguments();
            }

            RequiredNumberOfArgs = req;
        }

        public AppConfiguration ExecuteFlags()
        {
            var configuration = new AppConfiguration();
            var ArgumentFlags = from Flag flag in Flags where flag.GetNumberOfArguments() != 0 select flag;
            foreach (var flag in Flags)
            {
                CurrentIndex = flag.Index;
                if (!ArgumentFlags.Contains(flag.Flag))
                {
                    flag.Flag.Execute(configuration);
                }
                else
                {
                    var argFlag = (ArgumentFlag) flag.Flag;
                    argFlag.SetArguments(this);
                    argFlag.Execute(configuration);
                }
            }

            return configuration;
        }

        public bool IsValid()
        {
            return RequiredNumberOfArgs == NumberOfArgs;
        }
    }
}
