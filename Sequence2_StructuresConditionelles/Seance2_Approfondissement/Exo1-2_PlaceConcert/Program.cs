using System.Text;

namespace Exo1_PlaceConcert
{
    internal class Program
    {
        static readonly double TARIF_ENFANT = 0, TARIF_ADO = 15, TARIF_ADULTE = 20;
        static readonly int AGE_ENFANT = 10, AGE_ADO = 20;
        static readonly double REDUC_PREVENTE = 1.5, TAUX_REDUC_ADHERENT = 0.2;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double prix = 0;
            Console.WriteLine("Age du spectateur :");
            string input = (Console.ReadLine());

            if (!int.TryParse(input, out int age) || age < 0)
            {
                Console.WriteLine("Veuillez choisir un nombre valide");
                return;
            }
            else if (age < AGE_ENFANT)
            {
                prix = TARIF_ENFANT;

            }
            else
            {
                Console.WriteLine("Adhérent ?");
                string adherent = Console.ReadLine();
                if (adherent != "O" && adherent != "N")
                {
                    Console.WriteLine("Erreur : Type invalide, veuillez entrer O ou N");
                    return;
                }

                Console.WriteLine("Prévente ?");
                string prevente = Console.ReadLine();
                if (prevente != "O" && prevente != "N")
                {
                    Console.WriteLine("Erreur : Jour invalide, veuillez entrer O ou N");
                    return;
                }


                if (age < AGE_ADO)
                {
                    prix = TARIF_ADO; 
                }
                else
                {
                    prix = TARIF_ADULTE;
                }
                if (adherent == "O")
                    prix = (prevente == "O") ? prix - (prix * TAUX_REDUC_ADHERENT) - REDUC_PREVENTE : prix - (prix * TAUX_REDUC_ADHERENT);
                else
                    prix = (prevente == "O") ? prix - REDUC_PREVENTE : prix;
            }

            Console.WriteLine($"La place coutera à la personne {prix:C}.");
        }
    }
}
