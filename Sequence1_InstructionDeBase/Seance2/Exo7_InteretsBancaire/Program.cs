using System.Text;

namespace Exo7_InteretsBancaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Encodage en UTF8
            Console.OutputEncoding = Encoding.UTF8;

            //Création des variables
            decimal depot = 0, taux = 0, total = 0, gain = 0;
            int annee = 0;

            //Atrtribution des valeurs aux variables
            Console.WriteLine("Dépot :");
            depot = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Taux  :");
            taux = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Nombre d'Année :");
            annee = int.Parse(Console.ReadLine());

            //Maths (rappel : Math.Pow(nombre, puissance))
            total = depot;
            for (int i = 0; i < annee; i++)
            {
                total *= 1 + taux;
            }
            total = Math.Round(total, 2);
            gain = total - depot;

            //Affichage des résultats
            Console.WriteLine("------------------------");
            Console.WriteLine("Dans " + annee + " ans, tu auras " + total + "€, soit un gain de " + gain + "€.");
        }
    }
}
