using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_string
{
    internal class Program
    {
        static string ExtractString(string input)
        {
            int start = input.IndexOf("##");
            int end = input.LastIndexOf("##");

            if (start >= 0 && end >= 0 && start < end)
            {
                return input.Substring(start + 2, end - start - 2);
            }

            return ""; // Return an empty string if no valid substring found.
        }
        static void Main(string[] args)

        {
            Console.WriteLine(ExtractString("##abc##def"));    // "abc"
            Console.WriteLine(ExtractString("12####78"));        // ""
            Console.WriteLine(ExtractString("gar##d#en"));       // ""
            Console.WriteLine(ExtractString("++##--##++"));      // "--"

        }
    }
}
