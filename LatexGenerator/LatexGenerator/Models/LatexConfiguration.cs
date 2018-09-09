using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatexGenerator.Models
{
    public static class LatexConfiguration
    {
        public static string DocumentclassTag = @"\documentclass{article}";
        public static string BeginDocTag = @"\begin{document}";
        public static string EndDocTag  = @"\end{document}";
        public static string BeginListTag = @"\begin{enumerate}";
        public static string EndListTag = @"\end{enumerate}";
        public static string SectionTag = @"\section{}";
        public static string Indent = "   ";
        public static string PackageTag = @"\usepackage";
        public static string AuthorTag = @"\author{}";
        public static string ItemTag = @"\item";
        public static string TColorBoxTag = @"\newtcolorbox{explanation}[2][]{colframe = blue!80, title = #2}";
    }
}
