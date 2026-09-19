using System.Text;

namespace Exo3_TarificationAggressive
{
    internal class Program
    {
        //Meme exercice que le 2.
        //Cependant je n'ai pas eu le temps de faire vérifier cet exercice par la prof. Donc prenez la suite avec des pincettes.
        //Selon moi, c'est un problème de francais. Avant, on a demandé moins de 10, puis jusqu'a 49.
        //Ici c'est jusqu'a 9, puis 40 de plus ! Donc 9, puis 49. Mais le prix est différent pour les 40 suivants, et pour les "autres"...

        //Creation de vriables statiques
        static readonly decimal PRIX_QT_9 = 149.99m, PRIX_QT_40 = 134.99m, PRIX_QT_AUTRES = 109.99m;
        static readonly int QT_MINI = 9, QT_SUIVANTS = 40;
        static void Main(string[] args)
        {
            //Ecnodage UTF8
            Console.OutputEncoding = Encoding.UTF8;

            //Variables
            decimal prix = 0m;
            Console.WriteLine("Quantité ?");
            string input = (Console.ReadLine());

            //Test rapide de la validité de l'input. Si c'est un nombre, on le convertit en int. Sinon, on affiche un message d'erreur.

            if (!int.TryParse(input, out int quantite) || quantite < 0)
            {
                Console.WriteLine("Veuillez choisir un nombre valide");
                return;
            }

            //Conditionnel logique
            else if (quantite <= QT_MINI)
            {
                prix = quantite * PRIX_QT_9;
            }
            else if (quantite <= (QT_SUIVANTS + QT_MINI))
            {
                prix = quantite * PRIX_QT_40;
            }
            else
            {
                prix = quantite * PRIX_QT_AUTRES;
            }

            //Afficher le resultat
            Console.WriteLine($"Le tarif est de {prix:C}.");
        }
    }
}
