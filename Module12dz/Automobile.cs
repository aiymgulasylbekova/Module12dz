using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12dz
{
    class Automobile : Car
    {
        public string Name = "Automobile";

        public void Ride()
        {
            Go(Name, My_Speed(new Random(), 600, 900));
        }
    }
}
