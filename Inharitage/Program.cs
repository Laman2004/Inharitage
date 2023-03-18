using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inharitage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle
            {
                Color = "Qirmizi",
                Name = "BMX"
            };
            Car car = new Car
            {
                Color = "Qara",
                Name = "Forsaj",
                Brand="Elektrikli",
                Model="Toyota"
            };
            Vehicle vehicle1 = new Vehicle();
            Car car1 = new Car();
            car.GetInfo();
        }
    }
    }
