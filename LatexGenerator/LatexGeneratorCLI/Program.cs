using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LatexGenerator.Services;
using LatexGeneratorCLI.Model;

namespace LatexGeneratorCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            AppConfiguration config;
            State state = new State(args);
            if (state.IsValid())
            {
                config = state.ExecuteFlags();
                var fg = new FileGenerator(config);
                var file = fg.CreateFile();
                var fw = new FileWriter(file, config);
                fw.WriteFile();

            }
            else
            {
                Console.WriteLine($"Error. Required:{state.RequiredNumberOfArgs} whereas got: {state.NumberOfArgs}");
       
            }

            Console.ReadKey();
        }
       
    }
}
