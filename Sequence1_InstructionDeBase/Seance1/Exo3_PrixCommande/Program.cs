using System.Text;

namespace Exo3_PrixCommande
{
    internal class Program
    {
        static readonly decimal TVA = 0.20m;
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            decimal prixHT;
            decimal total;
            decimal prixTTC;
            int quant;
            String nom;
            Console.WriteLine("CALCUL DE LA TAXE ET DU PRIX TOTAL");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Prix Hors Taxes :");
            prixHT = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Nombre d'objets :");
            quant = int.Parse(Console.ReadLine());
            prixTTC = prixHT * (1 + TVA);
            prixTTC = Math.Round(prixTTC, 2);
            total = prixTTC * quant;
            Console.WriteLine("Le prix de l'objet toutes taxes comprises est de " + prixTTC + "€ et votre total est de " + total + "€!");
        }
    }
}
