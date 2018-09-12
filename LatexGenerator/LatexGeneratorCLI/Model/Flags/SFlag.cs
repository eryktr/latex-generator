using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LatexGenerator.Services;

namespace LatexGeneratorCLI.Model.Flags
{
    class SFlag : ArgumentFlag
    {

        public SFlag()
        {
            NumOfArguments = 1;
        }

        public override void Execute(AppConfiguration configuration)
        {
            configuration.IncludeSections = true;
            configuration.SectionCount = int.Parse(Arguments[0]);
        }


    }
}
