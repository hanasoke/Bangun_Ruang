using System;
using System.Collections.Generic;
using System.Text;

namespace Bangun_Ruang
{
    internal class Limas_Segitiga
    {
        public double luas(double a, double t)
        {
            return (0.5 * a * t) + (3 * (0.5 * a * t));
        }

        public double volume(double a, double t, double tl)
        {
            return 0.33 * (0.5 * a * t) * tl;
        }
    }
}
