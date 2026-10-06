namespace Exo3_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Création de variables
            int annee, mois, jour;
            DateTime dateT;

            //Attribution des valeurs
            Console.WriteLine("Entrez une année :");
            annee = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez un mois :");
            mois = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez un jour :");
            jour = int.Parse(Console.ReadLine());

            //Création du date time
            //Date Time est une variable de temps a part entiere (pas un string ou int par exemple..)
            //Il a beaucoup de surcharge (voir la doc) et ici on se sert de la surcharge
            //DateTime(int année, int mois, int jour)
            //Pour séléctionner/ définir une date a entrer dans notre variable (ici dateT)
            dateT = new DateTime(annee, mois, jour);

            //Les variables date time ont plusieurs méthodes d'instances pour l'affichage
            //comme .ToLongDateString() qui sert a écrire uniquement la date (sans le temps) de facon longue
            //Affichage du date time en version longue (ex : mercredi 03 mai 2006)
            Console.WriteLine(dateT.ToLongDateString());
            
        }
    }
}
