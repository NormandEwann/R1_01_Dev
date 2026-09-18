namespace Exo1_Salut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //définition de variables
            String nom;
            String prénom;

            //attribution de valeurs aux variables
            Console.WriteLine("Nom:");
            nom = Console.ReadLine();
            
            Console.WriteLine("Prenom:");
            prénom = Console.ReadLine();

            //afficher le résultat
            Console.WriteLine("-----------");
            Console.WriteLine("Salut " + nom + " " + prénom + "!");
        }
    }
}
