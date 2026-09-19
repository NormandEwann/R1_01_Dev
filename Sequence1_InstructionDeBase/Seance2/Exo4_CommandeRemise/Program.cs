using System.Text;

namespace Exo4_CommandeRemise
{
    internal class Program
    {
        //Creation de variable statiques
        static readonly decimal TAUX_REMISE = 0.05m;
        static readonly decimal FRAIS_PORT = 0.02m;
        static void Main(string[] args)
        {
            //Encodage en UTF8
            Console.OutputEncoding = Encoding.UTF8;

            //Creation de variables (prix donc en decimal)
            decimal prixUnitaire = 0, total = 0, montant = 0, remise = 0, fraisPort = 0;
            int quantite = 0;

            //Attribution de valeurs aux variables
            Console.WriteLine("Prix unitaire :");
            prixUnitaire = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Quantité demandée :");
            quantite = int.Parse(Console.ReadLine());

            //Maths
            montant = prixUnitaire * quantite;
            //Comme dans l'exo 3, je calcul directement avec "Math.Round(variable,2)" pour arrondir a 2 chiffres après la virgule
            remise = Math.Round(montant * TAUX_REMISE, 2);
            fraisPort = Math.Round(montant * FRAIS_PORT, 2);
            total = Math.Round((montant - remise + fraisPort),2);

            //Afficher les résultats
            Console.WriteLine("------------------------");
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
