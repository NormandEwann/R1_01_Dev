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

            if (couleur != "V" && couleur != "R")
            {
                Console.WriteLine("Erreur : Couleur invalide, veuillez entrer V ou R");
                return;
            }

            remise = couleur == "R" ? TAUX_REMISE_ROUGE * prixBase : TAUX_REMISE_VERT * prixBase;
            final = Math.Round(prixBase - remise, 2);

            Console.WriteLine("La remise est de " + remise + " €, pour un prix final de " + final + " €.");
        }
    }
}
