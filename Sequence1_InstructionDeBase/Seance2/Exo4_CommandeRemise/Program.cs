using System.Text;

namespace Exo4_CommandeRemise
{
    internal class Program
    {
        static readonly decimal TAUX_REMISE = 0.05m;
        static readonly decimal FRAIS_PORT = 0.02m;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            decimal prixUnitaire = 0, quantite = 0;
            Console.WriteLine("Prix unitaire :");
            prixUnitaire = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Qt demandée :");
            quantite = decimal.Parse(Console.ReadLine());

            Console.WriteLine("------------------------");

            decimal montant = prixUnitaire * quantite;
            decimal remise = Math.Round(montant * TAUX_REMISE, 2);
            decimal fraisPort = Math.Round(montant * FRAIS_PORT, 2);
            

            decimal total = Math.Round((montant - remise + fraisPort),2);

            Console.WriteLine("Le total est de " + total + "€ en comptant les frais de port.");
            Console.WriteLine("------------------------");
            Console.WriteLine("Détails /");
            Console.WriteLine("Montant : " + montant + "€");
            Console.WriteLine("total : " + total + "€");
            Console.WriteLine("Remise : " + remise + "€");
            Console.WriteLine("Frais de port :" + fraisPort + "€");
        }
    }
}
