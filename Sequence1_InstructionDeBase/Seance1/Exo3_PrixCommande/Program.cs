using System.Text;

namespace Exo3_PrixCommande
{
    internal class Program
    {
        //attribution de variables statiques
        static readonly decimal TVA = 0.20m;
        
        static void Main(string[] args)
        {
            //en-tete pour encoder en UTF8 (écrire "€")
            Console.OutputEncoding = Encoding.UTF8;

            //création des variables
            decimal prixHT;
            decimal prixTTC;
            decimal prixTotal;
            int quantité;

            //atribution des variables
            Console.WriteLine("CALCUL DE LA TAXE ET DU PRIX TOTAL");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Prix Hors Taxes :");
            prixHT = decimal.Parse(Console.ReadLine());
            
            Console.WriteLine("Nombre d'objets :");
            quant = int.Parse(Console.ReadLine());

            //Calculs            
            prixTTC = prixHT * (1 + TVA);
            prixTTC = Math.Round(prixTTC, 2);
            prixTotal = prixTTC * quantité;
            
            //Afficher les résultats
            Console.WriteLine("Le prix de l'objet toutes taxes comprises est de " + prixTTC + "€ et votre total est de " + total + "€!");
        }
    }
}
