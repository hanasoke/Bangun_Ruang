using System;
using System.Collections.Generic;
using System.Text;

namespace Bangun_Ruang
{
    internal class Balok
    {
        public double luas_balok(double p, double l, double t)
        {
            return 2 * (p * l + p * t + l * t);
        }

        public double volume_balok(double p, double l, double t)
        {
            return p * l * t;
        }
    }
}
