using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LatexGeneratorCLI.Model.Flags;

namespace LatexGeneratorCLI.Model
{
    class FlagBuilder
    {
        public readonly string[] Args;

        public FlagBuilder(string[] args)
        {
            Args = args;
        }

        public List<FlagWrapper> GetFlags()
        {
            var flags = new List<FlagWrapper>();
            var currentIndex = 0;
            foreach (var arg in Args)
            {
                if (!arg.StartsWith("-"))
                {
                    currentIndex++;
                    continue;
                }
                var command = arg.TrimStart('-');
                switch (command)
                {
                    case "i":
                        flags.Add(new FlagWrapper(new IFlag(), currentIndex));
                        break;    
                                  
                    case "s":     
                        flags.Add(new FlagWrapper(new SFlag(), currentIndex));
                        break;    
                                  
                    case "c":     
                        flags.Add(new FlagWrapper(new CFlag(), currentIndex));
                        break;

                    default:
                        throw new ArgumentException($"{command} is not a valid flag" );
                }

                currentIndex++;

            }

            return flags;
        }
    }
}