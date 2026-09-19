using System.Text;

namespace Exo7_InteretsBancaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            decimal depot;
            decimal taux;
            int annee;
            decimal total;
            decimal gain;

            Console.WriteLine("Dépot :");
            depot = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Taux  :");
            taux = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Nombre d'Année :");
            annee = int.Parse(Console.ReadLine());

            total = depot;
            for (int i = 0; i < annee; i++)
            {
                total *= 1 + taux;
            }

            total = Math.Round(total, 2);
            gain = total - depot;

            Console.WriteLine("------------------------");
            Console.WriteLine("Dans " + annee + " ans, tu auras " + total + "€, soit un gain de " + gain + "€.");
        }
    }
}
