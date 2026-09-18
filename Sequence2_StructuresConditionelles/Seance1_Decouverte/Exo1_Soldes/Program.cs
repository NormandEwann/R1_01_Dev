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


            if (couleur == "V" || couleur == "R")
            {
                if (couleur == "R")
                {
                    remise = prixBase * TAUX_REMISE_ROUGE;
                    
                }
                else if (couleur == "V")
                {
                    remise = prixBase * TAUX_REMISE_VERT;
                   
                }
                final = prixBase - remise;
                Console.WriteLine("La remise est de " + remise + " €, pour un prix final de " + final + " €.");
            }
            else
            {
                Console.WriteLine("Erreur, ni V ni R n'as été reseigné correctement.");
                return;
            }
        }
    }
}