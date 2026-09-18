namespace Exo4_LocationMobilite
{
    internal class Program
    {
        static readonly double TAUX_VELO_SEM = 0.1;
        static readonly double TAUX_VELO_WEEK = 0.14;
        static readonly double TAUX_TROT_SEM = 0.18;
        static readonly double TAUX_TROT_WEEK = 0.24;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Durée (heures, puis minutes) :");
            int dureeH = int.Parse(Console.ReadLine());
            int dureeM = int.Parse(Console.ReadLine());

            int dureeT = 60 * dureeH + dureeM;

            Console.WriteLine("Type de véhicule (V pour vélo, T pour trottinette) :");
            string type = Console.ReadLine();

            Console.WriteLine("Quel jour (S pour semaine, W pour weekend) :");
            string jour = Console.ReadLine();

            if (type != "V" && type != "T")
            {
                Console.WriteLine("Erreur : Type invalide, veuillez entrer V ou T");
                return;
            }

            if (jour != "S" && jour != "W")
            {
                Console.WriteLine("Erreur : Jour invalide, veuillez entrer S ou W");
                return;
            }

            double taux;

            if (type == "V")
                taux = (jour == "S") ? TAUX_VELO_SEM : TAUX_VELO_WEEK;
            else
                taux = (jour == "S") ? TAUX_TROT_SEM : TAUX_TROT_WEEK;

            double total = Math.Round(dureeT * taux, 2);

            Console.WriteLine(
                "La location vous coûtera " + total +
                "€ pour une durée de " + dureeT + " minutes"
            );
        }
    }
}
