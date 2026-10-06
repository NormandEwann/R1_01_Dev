namespace Exo3_MesFctString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables et valeurs..
            Console.WriteLine("Nom :");
            String nom = Console.ReadLine();
            Console.WriteLine("Prénom :");
            String prenom = Console.ReadLine();

            //Utilisations des méthiodes de la classe MesMethodesString
            String initiale = MesMethodesString.Initiales(nom, prenom);
            String mail = MesMethodesString.Email(nom, prenom);
            Console.WriteLine("Les initiales sont : " + initiale);
            Console.WriteLine("Le mail est : " + mail);
        }
    }
}
