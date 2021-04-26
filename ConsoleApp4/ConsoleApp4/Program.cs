using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Vehicle
    {
        public string brand { get; set; }
        public void honk()
        {
            Console.WriteLine("Tuut, tuut !");
        }
    }
    class car : Vehicle
    {
      car(string _model)
        {
            modelname = _model;
        }
        public string modelname { get; set; }
    
    
        static void Main(string[] args)
        {
            car mycar = new car("Mustang");
            mycar.honk();
            Console.WriteLine(mycar.brand + "" + mycar.modelname);
            Console.ReadLine();
        }
    }

}
