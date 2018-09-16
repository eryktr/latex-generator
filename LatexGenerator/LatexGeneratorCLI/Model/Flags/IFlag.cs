using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LatexGenerator.Services;

namespace LatexGeneratorCLI.Model.Flags
{
    class IFlag : ArgumentFlag
    {
        public IFlag()
        {
            NumOfArguments = 1;
        }
        public override void Execute(AppConfiguration configuration)
        {
            configuration.ItemCount = int.Parse(Arguments[0]);
        }
    }
}
