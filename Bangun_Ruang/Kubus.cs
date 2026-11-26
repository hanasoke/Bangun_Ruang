using System;
using System.Collections.Generic;
using System.Text;

namespace Bangun_Ruang
{
    internal class Kubus
    {
        public double luas_kubus(double r)
        {
            return 6 * r * r;
        }

        public double volume_kubus(double r)
        {
            return r * r * r;
        }
    }
}
