using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exo1_CourseAPied
{
    internal class Course
    {
        public static int ConvertitTempsEnMinutes(String temps)
        {
            //Test Regex pour etre sur du format string qu'on nous as donné

            // Valide un format d'heure "HH:mm" (ex: "12:34", "08:59") :
            // ^           : Début de la chaîne
            // [0-9]{2}    : Exactement 2 chiffres pour les heures ({2} veut dire qu'on en as 2 comme ca)
            // :           : Le caractère deux-points obligatoire (séparateur)
            // [0-5]       : Un chiffre de 0 à 5 pour la dizaine des minutes (Les parenthèses servent de séléction de ce qui est autorisé)
            // [0-9]       : Un chiffre de 0 à 9 pour l'unité des minutes
            // $           : Fin de la chaîne


            if (Regex.IsMatch(temps, "^[0-9]{2}:[0-5][0-9]$") == false)
            {
                throw new FormatException("Format attendu hh:mm");
            }
            //Ensuite si c'est bon, on coupe notre string (Substring) et on transforme nos heures en int puis *60, et de meme pour les minutes qu'on additionne
            int minute = (int.Parse(temps.Substring(0, 2)) * 60) + int.Parse(temps.Substring(3, 2));
            return minute;
        }

        public static double CalculeVitesse(double nbKm, int nbMinutes)
        {
            double vitesse = Math.Round(nbKm * 60 / nbMinutes, 2);
            return vitesse;
        }

        public static double NbKmPourAtteindreVitesse(int nbMin, double vitesse)
        {
            double km = Math.Round((vitesse * nbMin) / 60.0, 2);
            return km;
        }

        public static int NbMinPourAtteindreVitesse(double nbKm, double vitesse)
        {
            int min = (int)((nbKm / vitesse) * 60);
            return min;
        }

        public static String ConvertitMinutesEnTemps(int nbMinutes)
        {
            //On utilise ToString(D2) qui transforme une variables en string 
            //Le 'D' signifie "Decimal" (nombre entier) et force un formatage à 2 chiffres (ex: 9 -> "09")
            String minutes = (nbMinutes/60).ToString("D2") + ":" + (nbMinutes % 60).ToString("D2");
            return minutes;
        }
    }
}
