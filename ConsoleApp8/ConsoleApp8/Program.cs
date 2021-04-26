using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    interface I1
    {
        void mymethod();

    }
    interface I2
    {
        void mymethod();
    }
    class Multipleinheritance : I1, I2
    {
         void I1.mymethod()
        {
            Console.WriteLine("I1 called");
        }
         void I2.mymethod()
        {
            Console.WriteLine("I2 called");
        }
    }
    public class client
    {
        public static void Main()
        {
            Multipleinheritance obj1 = new Multipleinheritance();
            I1 interface1 = obj1;
            interface1.mymethod();
            Multipleinheritance obj2 = new Multipleinheritance();
            I2 interface2 = obj2;
            interface2.mymethod();
            Console.ReadLine();
        }
    }
}

