using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSIM_Villa
{
    class CalculoCosto
    {
        public static double calcularCosto(int m)
        {
            double c = 0;
            c = 6 + 5 * m + 0.2 * Math.Pow(m, 2);
        
            return c ;
        }
    }
}
