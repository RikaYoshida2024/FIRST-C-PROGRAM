using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Reimu Hakurei";
            Console.WriteLine(phrase.Substring(phrase.IndexOf("Hakurei")));

        }
    }
}