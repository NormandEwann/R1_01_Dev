using System.Text;

namespace Exo5_Voyage
{
    internal class Program
    {
        //Creation de variables statiques
        static readonly decimal PLAZZA_SEM = 753m, PLAZZA_SUPP = 47m, RIVIERA_SEM = 784m, RIVIERA_SUPP = 44m;
        static readonly decimal PLAZZA_O = 29m, PLAZZA_L = 33m, RIVIERA_O = 27m, RIVIERA_L = 30m;
        static void Main(string[] args)
        {
            //Cet exemple de code sert à utiliser d'autres outils comme vu dans d'autres exercice. On se sert d'un opérateur ternaire pour alléger le code et remplacer les else/if
            //Il introduit aussi une suite de conditions pour vérifier que l'utilisateur ne rentre pas de mauvaises valeurs.

            //Encodage UTF8
            Console.OutputEncoding = Encoding.UTF8;

            //Variables
            decimal prixHotel = 0m, prixVoiture = 0m, prixTotal = 0m;

            //QUESTIONS ----------------------------------------------------------------------------------------------------------------------------------

            //On poses nos questions et on vérifie si les réponses sont valides, sinon on affiche un message d'erreur et on quitte le programme
            //Si nbJour est bien un nombre et = ou supérieur à 7
            //Si hotel est bien R ou P
            //Si vehicule est bien O ou N
            //Et si jourVoiture est bien un nombre et inférieur ou égal à nbJour (en gros pas plus de jours de location que de jours de voyage)

            Console.WriteLine("Nb de jours de voyage :");
            if (!int.TryParse(Console.ReadLine(), out int nbJour))
            {
                Console.WriteLine("Erreur : veuillez entrer un nombre entier.");
                return;
            }

            if (nbJour < 7)
            {
                Console.WriteLine("Erreur : le nombre de jours doit être au moins 7.");
                return;
            }

            Console.WriteLine("Riviera (R) ou Plazza (P)?");
            string hotel = Console.ReadLine();

            if (hotel != "R" && hotel != "P")
            {
                Console.WriteLine("Erreur : hotel invalide, veuillez entrer R ou P");
                return;
            }

            Console.WriteLine("Location de véhicule ?");
            string vehicule = Console.ReadLine();
            if (vehicule != "O" && vehicule != "N")
            {
                Console.WriteLine("Erreur : entrée invalide, veuillez entrer O ou N");
                return;
            }

            Console.WriteLine("Combien de jours ?");
            if (!int.TryParse(Console.ReadLine(), out int jourVoiture))
            {
                Console.WriteLine("Erreur : veuillez entrer un nombre entier.");
                return;
            }

            if (jourVoiture > nbJour)
            {
                Console.WriteLine("Erreur : le nombre de jours de locations ne peut pas dépasser le nombre de jour du voyage.");
                return;
            }
            Console.WriteLine("Voiture ordinaire (O) ou luxe (L)?");
            string typeVoiture = Console.ReadLine();
            if (typeVoiture != "O" && typeVoiture != "L")
            {
                Console.WriteLine("Erreur : type invalide, veuillez entrer O ou L");
                return;
            }

            //Conditionel------------------------------------------------------------------------------------------------------------------------------

            //Une fois nos questions posées, on s'occupe du conditionnel

            //Si l'hotel est le Plazza, on calcule le prix de l'hotel et de la voiture grace a des opérateurs ternaires, sinon on fait pareil pour le Riviera
            //Rappel : une condition ternaire est une manière plus concise d'écrire un if/else. La syntaxe est la suivante : condition ? valeur_si_vrai : valeur_si_faux;

            if (hotel == "P")
            {
                prixHotel = (nbJour > 7) ? (nbJour - 7) * PLAZZA_SUPP + PLAZZA_SEM : PLAZZA_SEM;

                if (vehicule == "O")
                {
                    prixVoiture = (typeVoiture == "O") ? PLAZZA_O * jourVoiture : PLAZZA_L * jourVoiture;
                }
            }
            else
            {
                prixHotel = (nbJour > 7) ? (nbJour - 7) * RIVIERA_SUPP + RIVIERA_SEM : RIVIERA_SEM;

                if (vehicule == "O")
                {
                    prixVoiture = (typeVoiture == "O") ? RIVIERA_O * jourVoiture : RIVIERA_L * jourVoiture;
                }
            }

            //On calcule le prix total du voyage en additionnant le prix de l'hotel et de la voiture, puis on affiche le résultat avec un format monétaire

            prixTotal = (prixHotel + prixVoiture);
            Console.WriteLine($"Votre voyage vous coutera au total {prixTotal:C}, pour {prixHotel:C} d'hôtel et {prixVoiture:C} de location de voiture.");

            //Rappel, le fromat monétaire est défini par la culture de l'ordinateur, donc si vous êtes en Suisse, le format sera CHF, si vous êtes en France, le format sera €, etc.
            //Il s'écrit avec un entête "$" sur le string, puis "{valeur:C}" dans le string pour indiquer le format monétaire.

        }
    }
}
