using System.Text;

namespace Exo1_PlaceConcert
{
    internal class Program
    {
        static readonly decimal TARIF_ENFANT = 0m, TARIF_ADO = 15m, TARIF_ADULTE = 20m;
        static readonly int AGE_ENFANT = 10, AGE_ADO = 20;
        static readonly decimal REDUC_PREVENTE = 1.5m, TAUX_REDUC_ADHERENT = 0.2m;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            decimal prix = 0m;
            Console.WriteLine("Age du spectateur :");
            int age = int.Parse(Console.ReadLine());

            if (age < AGE_ENFANT)
                prix = TARIF_ENFANT;
            else if (age < AGE_ADO)
                prix = TARIF_ADO;
            else
                prix = TARIF_ADULTE;

            if (age >= AGE_ENFANT)
            {
                Console.WriteLine("Adhérent (O/N) :");
                string adherent = Console.ReadLine();
                Console.WriteLine("Prévente (O/N) :");
                string prevente = Console.ReadLine();

                if (adherent == "O")
                    prix -= prix * TAUX_REDUC_ADHERENT;
                if (prevente == "O")
                    prix -= REDUC_PREVENTE;
            }

            Console.WriteLine($"La place coutera à la personne {prix:C}.");
        }
    }
}
