namespace Exo3_ConversionHeureMin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h, m, nbMin = 98;
            Program.NbMinEnHeureMin(nbMin, out h, out m);
            Console.WriteLine(nbMin + " <=> " + h + ":" + m);

            TimeSpan temps = Program.NbMinEnTimeSpan(nbMin); 
            Console.WriteLine(nbMin + " <=> " + temps); 
        }


        /* 
         * EXPLICATION DU MOT-CLÉ "out" EN C# :
         * --------------------------------------------------
         * - Permet à une fonction de renvoyer PLUSIEURS valeurs à la fois (le type peut être int, double, decimal, etc., selon le besoin).
         * - Les paramètres "out" sont des SORTIES : ils n'ont pas besoin d'être créés ou initialisés à l'avance (on peut les déclarer directement à l'appel).
         * - La fonction a l'OBLIGATION de donner une valeur à chaque variable "out" avant de se terminer.
         */

        public static void NbMinEnHeureMin(int nbMin, out int h, out int m)
        {
            h = nbMin / 60;
            m = nbMin % 60;
        }

        //Pour ce programme, j'utilise TimeSpan.FromMinutes(valeur)
        //Qui enregistre donc dans le time span une valeur déjà en minutes !
        //Vous êtes probablement tombé sur un résultat comme 00:00:00.00000098
        //C'est parce que vous avez entré dans le time span juste "98"
        //Sans définir qu'il s'agit de minutes.

        //Il existe d'autres méthodes, mais c'est la plus efficace.

        public static TimeSpan NbMinEnTimeSpan(int nbMin)
        {
            return TimeSpan.FromMinutes(nbMin);
        }
    }
}
