using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inharitage
{
    internal class Car : Vehicle
    {
        public Car()
        {
        }
        public Car(string color) : base(color)
        { 

        }

        public string Brand;
        public string Model;

        public void GetInfo()
        {
            Console.WriteLine($"Reng : {Color} - Ad : {Name} - Brend : {Brand} - Model : {Model}");
        }
    }
}
