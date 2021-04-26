using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class class1
    {
        void sum(double a, double b)
        {
            double sum;
            sum = a + b;
            Console.WriteLine("sum of a+b=" +sum);
        }
        void sum(int a, int b)
        {
            int c;
            c = a + b;
            Console.WriteLine("sum of a+b=" + c);
        }
        static void Main(string[] args)
        {
            class1 class1 = new class1();
            class1.sum(2.3, 1.2);
            class1.sum(1, 2);
            Console.ReadLine();
        }
    }
}
