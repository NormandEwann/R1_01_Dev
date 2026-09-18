using System.Runtime.ConstrainedExecution;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exo1_Soldes
{
    internal class Program
    {
        static readonly double TAUX_REMISE_ROUGE = 0.5, TAUX_REMISE_VERT = 0.2;
        static void Main(string[] args)
        {
            double final = 0, remise = 0;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Couleur de l'étiquette");
            Console.WriteLine("R. Rouge");
            Console.WriteLine("V. Vert");
            Console.Write("Votre choix : ");


            string couleur = Console.ReadLine();

            Console.WriteLine("Prix de base :");
            double prixBase = double.Parse(Console.ReadLine());


            if (couleur != "V" && couleur != "R")
            {
                Console.WriteLine("Erreur : Couleur invalide, veuillez entrer V ou R");
                return;
            }

            remise = (couleur == "R") ? TAUX_REMISE_ROUGE*prixBase : TAUX_REMISE_VERT*prixBase;

            final = Math.Round(prixBase - remise, 2);
            Console.WriteLine("La remise est de " + remise + " €, pour un prix final de " + final + " €.");
        }
    }
}