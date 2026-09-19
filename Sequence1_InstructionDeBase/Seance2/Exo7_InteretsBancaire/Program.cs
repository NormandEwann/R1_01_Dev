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
            double depot = 0, taux = 0, annee = 0, total = 0, gain = 0;

            //Atrtribution des valeurs aux variables
            Console.WriteLine("Dépot :");
            depot = double.Parse(Console.ReadLine());

            Console.WriteLine("Taux  :");
            taux = double.Parse(Console.ReadLine());

            Console.WriteLine("Nombre d'Année :");
            annee = double.Parse(Console.ReadLine());

            //Maths (rappel : Math.Pow(nombre, puissance))
            total = depot * (Math.Pow((1 + taux), annee));
            total = Math.Round(total, 2);
            gain = total - depot;

            //Affichage des résultats
            Console.WriteLine("------------------------");
            Console.WriteLine("Dans " + annee + " ans, tu auras " + total + "€, soit un gain de " + gain + "€.");
        }
    }
}
