using System.Text;

namespace Exo3_TarificationAggressive
{
    internal class Program
    {
        static readonly decimal PRIX_QT_9 = 149.99m, PRIX_QT_40 = 134.99m, PRIX_QT_AUTRES = 109.99m;
        static readonly int QT_MINI = 9, QT_SUIVANTS = 40;
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
            else if (quantite <= QT_MINI)
                prix = quantite * PRIX_QT_9;
            else if (quantite <= QT_SUIVANTS + QT_MINI)
                prix = quantite * PRIX_QT_40;
            else
                prix = quantite * PRIX_QT_AUTRES;

            Console.WriteLine($"Le tarif est de {prix:C}.");
        }
    }
}
