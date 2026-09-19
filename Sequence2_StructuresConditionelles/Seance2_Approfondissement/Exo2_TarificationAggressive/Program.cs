using System.Text;

namespace Exo2_TarificationAggressive
{
    internal class Program
    {
        //Création des variables statiques
        static readonly double QT_MOINS_10 = 149.99, QT_10_49 = 134.99, QT_PLUS_49 = 109.99;
        static readonly int PETITE_QUANTITE = 10, GRANDE_QUANTITE = 49;

        static void Main(string[] args)
        {
            //encodage en UTF8
            Console.OutputEncoding = Encoding.UTF8;

            //Variables et attribution de valeurs
            double prix = 0;
            Console.WriteLine("Quantité ?");
            string input = (Console.ReadLine());

            //Conditionnel rapide pour vérifier si l'entrée est un nombre valide et calculer le prix en fonction de la quantité
            if (!int.TryParse(input, out int quantite) || quantite < 0)
            {
                Console.WriteLine("Veuillez choisir un nombre valide");
                return;
                //return pour stopper l'exécution du programme
            }

            //Conditionnel
            else if (quantite < PETITE_QUANTITE)
            {
                prix = quantite*QT_MOINS_10;
            }
            else if (quantite <= GRANDE_QUANTITE)
            {
                prix = quantite * QT_10_49;
            }
            else
            {
                prix = quantite * QT_PLUS_49;
            }

            //Afficher les réultats
            Console.WriteLine($"Le tarif est de {prix:C}.");
        }
    }
}
