using System.Text;

namespace Exo2_TarificationAggressive
{
    internal class Program
    {
        static readonly double PRIX_QT_9 = 149.99, PRIX_QT_40 = 134.99, PRIX_QT_AUTRES = 109.99;
        static readonly int QT_MINI = 9, QT_SUIVANTS = 40;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double prix = 0;
            Console.WriteLine("Quantité ?");
            string input = (Console.ReadLine());
            if (!int.TryParse(input, out int quantite) || quantite < 0)
            {
                Console.WriteLine("Veuillez choisir un nombre valide");
                return;
            }
            else if (quantite <= QT_MINI)
            {
                prix = quantite * PRIX_QT_9;
            }
            else if (quantite <= (QT_SUIVANTS+QT_MINI))
            {
                prix = quantite * PRIX_QT_40;
            }
            else
            {
                prix = quantite * PRIX_QT_AUTRES;
            }

            Console.WriteLine($"Le tarif est de {prix:C}.");
        }
    }
}