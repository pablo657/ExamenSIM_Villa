using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSIM_Villa
{
    class Distribuciones
    {

        public static double Exponencial(int m, double rdn)
        {
            return (double)Math.Log(1-rdn )*(-m);
        }
    }
}
