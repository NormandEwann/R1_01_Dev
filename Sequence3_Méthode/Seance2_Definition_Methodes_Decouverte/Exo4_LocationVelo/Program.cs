using System.Text;

namespace Exo4_LocationVelo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //on demande et vérifie si les valeurs sont ok sinon coupe l'execution du code

            Console.WriteLine("Votre age ?");
            if (!int.TryParse(Console.ReadLine(), out int age) && (age < 12))
            {
                Console.WriteLine("Valeur Invalide.");
                return;
            }

            Console.WriteLine("Type de Vélo ?");

            String typeVelo = Console.ReadLine();
            if (typeVelo == null || (typeVelo != "V" && typeVelo != "VTT" && typeVelo != "VE"))
            {
                Console.WriteLine("Type Invalide, veuillez entrer V, Ve, ou VTT");
                return;
            }

            Console.WriteLine("Nombre d'Heure de Loc?");

            if (!int.TryParse(Console.ReadLine(), out int nbHeures) && (age < 0))
            {
                Console.WriteLine("Valeur Invalide.");
                return;
            }

            //On se sert de la méthode CalculePrixLocation qu'on a créer dans la classe LocVelo

            decimal prixLocation = LocVelo.CalculePrixLocation(nbHeures, age, typeVelo);
            Console.WriteLine($"Le prix de la location est de : {prixLocation:C}");
        }
    }
}
