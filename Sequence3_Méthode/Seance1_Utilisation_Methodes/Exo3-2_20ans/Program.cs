namespace Exo3_20ans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Création de variables
            int annee, mois, jour;
            DateTime dateT;

            //Attribution des valeurs
            Console.WriteLine("Entrez votre année de naissance :");
            annee = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez votre mois de naissance :");
            mois = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez votre jour de naissance :");
            jour = int.Parse(Console.ReadLine());

            //Création du date time
            dateT = new DateTime(annee, mois, jour);
            //On ajoute 20 ans grace a l'instance .AddYears(int valeur)
            dateT = dateT.AddYears(20);

            //Affichage du date time en version longue (ex : mercredi 03 mai 2006)
            Console.WriteLine($"Tes 20 ans se passeront le {dateT.ToLongDateString()}");

        }
    }
}