using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class class11
    {
        abstract class wholeseller
        {
            public virtual string discount()
            {
                return "10% discount";
            }

        }
        class retailer : wholeseller
        {
            public override string discount()
            {
                base.discount();
                return " 5% discount";
            }

            public static void Main(string[] args)
            {
                retailer.class11 = new retailer();
                Console.WriteLine(class11.discount());
                Console.ReadLine();
            }
        }
    }
}
