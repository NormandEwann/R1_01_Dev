using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo2_MesMaths_Conditionnel_Poussé
{
    internal class MesMaths
    {
        public static double Moyenne(double nb1, double nb2)
        {
            double res = (nb1 + nb2) / 2;
            res = Math.Round(res, 1);
            return res;
        }

        public static double Moyenne(double nb1, double nb2, double nb3)
        {
            double res = (nb1 + nb2 + nb3) / 3;
            res = Math.Round(res, 1);
            return res;
        }

        public static double Moyenne(double nb1, double nb2, double nb3, double nb4)
        {
            double res = (nb1 + nb2 + nb3 + nb4) / 4;
            res = Math.Round(res, 1);
            return res;
        }

        public static double Moyenne(double nb1, double nb2, double nb3, double nb4, double nb5)
        {
            double res = (nb1 + nb2 + nb3 + nb4 + nb5) / 5;
            res = Math.Round(res, 1);
            return res;
        }
    }
}
