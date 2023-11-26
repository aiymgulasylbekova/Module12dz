using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12dz
{
    class Bus : Car
    {
        public string Name = "Bus";
        public void Ride()
        {
            Go(Name, My_Speed(new Random(), 800, 1100));
        }
    }
}
