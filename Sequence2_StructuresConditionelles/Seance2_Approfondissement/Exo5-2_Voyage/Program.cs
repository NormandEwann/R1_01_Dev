using System.Text;

namespace Exo5_Voyage
{
    internal class Program
    {
        static readonly decimal PLAZZA_SEM = 753m, PLAZZA_SUPP = 47m, RIVIERA_SEM = 784m, RIVIERA_SUPP = 44m;
        static readonly decimal PLAZZA_O = 29m, PLAZZA_L = 33m, RIVIERA_O = 27m, RIVIERA_L = 30m;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            decimal prixHotel = 0m, prixVoiture = 0m, prixTotal = 0m;

            Console.WriteLine("Nb de jours de voyage :");
            if (!int.TryParse(Console.ReadLine(), out int nbJour) || nbJour < 7)
            {
                Console.WriteLine("Erreur : le nombre de jours doit être un entier d'au moins 7.");
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
            if (!int.TryParse(Console.ReadLine(), out int jourVoiture) || jourVoiture < 0 || jourVoiture > nbJour)
            {
                Console.WriteLine("Erreur : nombre de jours de location invalide.");
                return;
            }

            Console.WriteLine("Voiture ordinaire (O) ou luxe (L)?");
            string typeVoiture = Console.ReadLine();
            if (typeVoiture != "O" && typeVoiture != "L")
            {
                Console.WriteLine("Erreur : type invalide, veuillez entrer O ou L");
                return;
            }

            if (hotel == "P")
            {
                prixHotel = nbJour > 7 ? (nbJour - 7) * PLAZZA_SUPP + PLAZZA_SEM : PLAZZA_SEM;
                if (vehicule == "O")
                    prixVoiture = (typeVoiture == "O" ? PLAZZA_O : PLAZZA_L) * jourVoiture;
            }
            else
            {
                prixHotel = nbJour > 7 ? (nbJour - 7) * RIVIERA_SUPP + RIVIERA_SEM : RIVIERA_SEM;
                if (vehicule == "O")
                    prixVoiture = (typeVoiture == "O" ? RIVIERA_O : RIVIERA_L) * jourVoiture;
            }

            prixTotal = prixHotel + prixVoiture;
            Console.WriteLine($"Votre voyage vous coutera au total {prixTotal:C}, pour {prixHotel:C} d'hôtel et {prixVoiture:C} de location de voiture.");
        }
    }
}
