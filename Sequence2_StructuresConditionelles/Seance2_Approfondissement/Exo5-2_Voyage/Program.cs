using System.Text;

namespace Exo5_Voyage
{
    internal class Program
    {
        static readonly double PLAZZA_SEM = 753, PLAZZA_SUPP = 47, RIVIERA_SEM = 784, RIVIERA_SUPP = 44;
        static readonly double PLAZZA_O = 29, PLAZZA_L = 33, RIVIERA_O = 27, RIVIERA_L = 30;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double prixHotel = 0, prixVoiture = 0, prixTotal = 0;

            //QUESTIONS ----------------------------------------------------------------------------------------------------------------------------------

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

            prixTotal = (prixHotel + prixVoiture);

            Console.WriteLine($"Votre voyage vous coutera au total {prixTotal:C}, pour {prixHotel:C} d'hôtel et {prixVoiture:C} de location de voiture.");


        }
    }
}
