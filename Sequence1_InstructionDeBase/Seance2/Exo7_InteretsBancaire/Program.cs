using System.Text;

namespace Exo7_InteretsBancaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double depot = 0, taux = 0, annee = 0;
            Console.WriteLine("Dépot :");
            depot = double.Parse(Console.ReadLine());

            Console.WriteLine("Taux  :");
            taux = double.Parse(Console.ReadLine());

            Console.WriteLine("Nb Année :");
            annee = double.Parse(Console.ReadLine());

            Console.WriteLine("------------------------");

            double total = depot * (Math.Pow((1 + taux), annee));
            total = Math.Round(total, 2);
            double gain = total - depot;

            Console.WriteLine("Dans " + annee + " ans, tu auras " + total + "€, soit un gain de " + gain + "€.");
        }
    }
}
