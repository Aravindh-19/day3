using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hi i am singh";
            var unique = new HashSet<char>(s);
            Console.WriteLine("Original string:"+s);
            Console.Write("Corrected string:");
            foreach (char c in unique)
            Console.Write( c);
            Console.ReadLine();
        }
    }
}
