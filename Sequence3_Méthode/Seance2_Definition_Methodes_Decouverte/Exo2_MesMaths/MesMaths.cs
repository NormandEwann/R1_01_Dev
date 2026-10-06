using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo2_MesMaths
{
    internal class MesMaths
    {

        //On copie le code DANS la classe
        //On créer une fonction publique
        public static double Moyenne(double nb1, double nb2)
        {
            double res = (nb1 + nb2) / 2;
            res = Math.Round(res, 1);
            return res;
        }

        //Puis on peut surcharger avec de plus en plus de valeurs ou de type de valeurs :

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

        //Fonction PerimetreCercle selon le (rayon).
        //La forumle est : 2 x Pi x Rayon
        public static double PerimetreCercle(double rayon)
        {
            if (rayon <= 0)
            {
                throw new ArgumentOutOfRangeException("Attention, le rayon ne peut pas être nul ou négatif");
            }
            //Pour utiliser PI, on utilise Math.PI
            double res = Math.Round(2 * Math.PI * rayon, 1);
            return res;
        }

        //De meme pour celle ci, on converti en radians des degrés
        //La formule est (pi/180)*degree

        public static double DegreeToRadian(double degree)
        {
            double res = Math.Round((Math.PI / 180) * degree, 2);
            return res;
        }

        //Ex 4 dans l'ex 2 : (voir PDF)

        public static int TireAuSort(int min, int max)
        {
            Random random = new Random();
            int nombreAleatoire = random.Next(min, max);
            return nombreAleatoire;
        }
    }
}
