using System;
using System.Collections.Generic;
using System.Text;

namespace Bangun_Ruang
{
    internal class Prisma
    {
        public double luas_prisma(double la, double ka, double t) 
        {
            return 2 * la + ka * t;
        }

        public double volume_prisma(double la, double t)
        {
            return la * t;
        }
    }
}
