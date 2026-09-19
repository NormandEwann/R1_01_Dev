using System.Runtime.ConstrainedExecution;

namespace Exo1_Soldes
{
    internal class Program
    {
        // Création de variables statiques
        static readonly decimal TAUX_REMISE_ROUGE = 0.5m, TAUX_REMISE_VERT = 0.2m;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Les montants financiers sont représentés avec decimal.
            decimal final = 0m, remise = 0m, prixBase = 0m;
            string couleur = "";

            Console.WriteLine("Couleur de l'étiquette");
            Console.WriteLine("R. Rouge");
            Console.WriteLine("V. Vert");
            Console.Write("Votre choix : ");
            couleur = Console.ReadLine();

            Console.WriteLine("Prix de base :");
            prixBase = decimal.Parse(Console.ReadLine());

            if (couleur == "V" || couleur == "R")
            {
                if (couleur == "R")
                    remise = prixBase * TAUX_REMISE_ROUGE;
                else
                    remise = prixBase * TAUX_REMISE_VERT;

                final = prixBase - remise;
                Console.WriteLine("La remise est de " + remise + " €, pour un prix final de " + final + " €.");
            }
            else
            {
                Console.WriteLine("Erreur, ni V ni R n'as été reseigné correctement.");
            }
        }
    }
}
