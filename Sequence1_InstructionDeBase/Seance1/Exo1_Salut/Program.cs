namespace Exo1_Salut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nom;
            Console.WriteLine("Nom:");
            nom = Console.ReadLine();
            String prénom;
            Console.WriteLine("Prenom:");
            prénom = Console.ReadLine();
            Console.WriteLine("-----------");
            Console.WriteLine("Salut " + nom + " " + prénom + "!");
        }
    }
}
