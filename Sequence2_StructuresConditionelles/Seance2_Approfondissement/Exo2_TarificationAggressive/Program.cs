using System.Text;

namespace Exo2_TarificationAggressive
{
    internal class Program
    {
        static readonly decimal QT_MOINS_10 = 149.99m, QT_10_49 = 134.99m, QT_PLUS_49 = 109.99m;
        static readonly int PETITE_QUANTITE = 10, GRANDE_QUANTITE = 49;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            decimal prix = 0m;
            Console.WriteLine("Quantité ?");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int quantite) || quantite < 0)
            {
                Console.WriteLine("Veuillez choisir un nombre valide");
                return;
            }
            else if (quantite < PETITE_QUANTITE)
                prix = quantite * QT_MOINS_10;
            else if (quantite <= GRANDE_QUANTITE)
                prix = quantite * QT_10_49;
            else
                prix = quantite * QT_PLUS_49;

            Console.WriteLine($"Le tarif est de {prix:C}.");
        }
    }
}
