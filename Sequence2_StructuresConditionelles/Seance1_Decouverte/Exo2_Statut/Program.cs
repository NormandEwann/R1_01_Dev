namespace Exo2_Statut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Age de l'utilisateur :");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int age) || age < 0)
            {
                Console.WriteLine("Veuillez choisir un nombre valide");
            }
            else if (age <= 9)
            {
                Console.WriteLine("Enfant.");
            }
            else if (age <= 13)
            {
                Console.WriteLine("Pré-Ado");
            }
            else if (age <= 17)
            {
                Console.WriteLine("Ado");
            }
            else { Console.WriteLine("Adulte"); }
        }
    }
}
