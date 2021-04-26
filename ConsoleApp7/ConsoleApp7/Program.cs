using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    interface Vehicle
    {
        void changegear(int a);
        void speedup(int a);
        void applybrakes(int a);
    }
    class Bicycle: Vehicle
    {
        int speed;
        int gear;
        public void changegear(int newgear)
        {
            gear =newgear;
        }
        public void speedup(int increment)
        {
            speed = increment+speed;
        }
        public void applybrakes(int decrement)
        {
            speed = speed-decrement;
        }
        public void printstates()
        {
            Console.WriteLine("speed:"+speed+"gear:"+gear);
        }

    }
    class client
    {
        public static void Main()
        {
            Bicycle bicycle = new Bicycle();
            bicycle.changegear(2);
            bicycle.speedup(3);
            bicycle.applybrakes(1);
            bicycle.printstates();
            Console.ReadLine();
        }
    }
}
        
        
    

