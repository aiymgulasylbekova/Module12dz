using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12dz
{
    class Cargo_Car : Car
    {
        public string Name = "Cargo car";
        public void Ride()
        {
            Go(Name, My_Speed(new Random(), 700, 1000));
        }
    }
}
