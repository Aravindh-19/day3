using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        int a;
        int b;
        Program (int _a, int _b)
        {
            a = _a;
            b = _b;
        }
        public static Program  operator*(Program _obj1,Program _obj2)
        {
            Program _obj3 = new Program(0,0);
            _obj3.a = _obj1.a * _obj2.a;
            _obj3.b = _obj1.b * _obj2.b;
            return _obj3;
        }
        public static void showvalues(Program _obj)
        {
            Console.WriteLine("a=" + _obj.a);
            Console.WriteLine("b=" + _obj.b);
            Console.ReadLine();
        }
        public static void Main()
        {
            int a = 1;
            int b = 1;
            int c = a * b;
            Program obj1 = new Program(1,2);
            Program obj2 = new Program(2,2);
            Program obj3 = new Program(0,0);
            obj3 = obj2 * obj1;
            Program.showvalues(obj3);
            Console.ReadLine();
        }
    }
}
