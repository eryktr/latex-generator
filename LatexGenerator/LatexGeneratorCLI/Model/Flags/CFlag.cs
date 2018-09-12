using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LatexGenerator.Services;

namespace LatexGeneratorCLI.Model.Flags
{
    class CFlag : Flag
    {
     
        public override void execute(AppConfiguration configuration)
        {
            configuration.IncludeTColorBox = true;
        }
    }
}
