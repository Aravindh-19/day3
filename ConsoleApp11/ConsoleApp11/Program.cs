using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string s = "It is a bad color";
            
            if(s.Contains("is a"))
            {
                Console.WriteLine("Yes!string present");
            }
            else
            {
                Console.WriteLine("No!string not present");
            }
            Console.ReadLine();

        }
    }
}
