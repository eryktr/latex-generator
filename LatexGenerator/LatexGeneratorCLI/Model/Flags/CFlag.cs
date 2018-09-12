﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LatexGenerator.Services;

namespace LatexGeneratorCLI.Model.Flags
{
    class CFlag : BooleanFlag
    {
     
        public override void Execute(AppConfiguration configuration)
        {
            configuration.IncludeTColorBox = true;
        }
    }
}
