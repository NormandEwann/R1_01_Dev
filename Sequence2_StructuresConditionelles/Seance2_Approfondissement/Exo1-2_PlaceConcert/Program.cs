using System.Text;

namespace Exo1_PlaceConcert
{
    internal class Program
    {
        // Créations des variables statiques
        static readonly double TARIF_ENFANT = 0, TARIF_ADO = 15, TARIF_ADULTE = 20;
        static readonly int AGE_ENFANT = 10, AGE_ADO = 20;
        static readonly double REDUC_PREVENTE = 1.5, TAUX_REDUC_ADHERENT = 0.2;

        static void Main(string[] args)
        {
            // Encodage en UTF8 pour l'affichage correct du symbole €
            Console.OutputEncoding = Encoding.UTF8;

            double prix = 0;

            // Saisie de l'âge (supposé valide)
            Console.WriteLine("Age du spectateur :");
            int age = int.Parse(Console.ReadLine());

            // Lecture de la catégorie d'âge et détermination du tarif de base
            if (age < AGE_ENFANT)
            {
                prix = TARIF_ENFANT;
            }
            else if (age < AGE_ADO)
            {
                prix = TARIF_ADO;
            }
            else
            {
                prix = TARIF_ADULTE;
            }

            // Pour les enfants, le tarif est de 0€, pas besoin de demander les réductions
            if (age >= AGE_ENFANT)
            {
                Console.WriteLine("Adhérent (O/N) :");
                string adherent = Console.ReadLine();

                Console.WriteLine("Prévente (O/N) :");
                string prevente = Console.ReadLine();

                // Application de la réduction adhérent
                if (adherent == "O")
                {
                    prix = prix - (prix * TAUX_REDUC_ADHERENT);
                }

                // Application de la réduction prévente
                if (prevente == "O")
                {
                    prix = prix - REDUC_PREVENTE;
                }
            }

            // Affichage du résultat
            // Le formatage {prix:C} permet d'afficher le prix avec le symbole monétaire correspondant à la culture de l'utilisateur.
            // Exemple : 20,00 € pour la France, $20.00 pour les États-Unis, etc.
            // Il faut mettre $ devant le string pour pouvoir utiliser l'interpolation de string, et la variable entre des accolades pour qu'elle soit évaluée et affichée dans le string.
            Console.WriteLine($"La place coutera à la personne {prix:C}.");
        }
    }
}
