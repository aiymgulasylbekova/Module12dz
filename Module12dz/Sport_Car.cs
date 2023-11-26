using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12dz
{
    class Sport_Car : Car
    {
        public string Name = "Sport car";

        public void Ride()
        {
            Go(Name, My_Speed(new Random(), 500, 800));
        }
    }
}
