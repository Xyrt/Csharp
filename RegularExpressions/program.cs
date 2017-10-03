using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regular
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Hello, world! im a homeless Nigga.";
            //foreach (var str in Regex.Split(text, @"\s*[,!.]+\s*"))
            //{
            //    Console.WriteLine(str);
            //}
            var expression = @"(0[1-9][0-2][0-9]|3[0-1])[\./](0[1-9]|1[0-2])[\./]20\d\d";
            var result = Regex.IsMatch("31.10.2000", expression);
            Console.WriteLine(result);

            var expr1 = @"(public private, protected)?\s+(static\s+)?\w+\s+[A-Z]\w*\(\)";
            var matches = Regex.Matches("public void Method(){}", expr1);
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
