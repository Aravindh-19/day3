using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "My name is Aravindh";
            char ch;
            Console.WriteLine("String before converstion:" + s);
            System.Text.StringBuilder str = new System.Text.StringBuilder();
            for (int i = 0; i < s.Length; i++)
                if (char.IsLower(s[i]))
                {
                    ch = Char.ToUpper(s[i]);
                    str.Append(ch);
                }
                else if (char.IsUpper(s[i]))
                {
                    ch = Char.ToLower(s[i]);
                    str.Append(ch);
                }
                else
                {
                    ch = s[i];
                    str.Append(ch);
                }
            Console.WriteLine("String after converstion:" + str);
            Console.ReadLine();
        }
        
    }
  
}
