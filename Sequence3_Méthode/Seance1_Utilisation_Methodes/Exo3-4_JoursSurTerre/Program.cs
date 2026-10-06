namespace Exo3_4_JoursSurTerre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Création de variables
            int annee, mois, jour;
            DateTime dateT, dateN;
            TimeSpan nbJours;

            //Attribution des valeurs
            Console.WriteLine("Entrez votre année de naissance :");
            annee = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez votre mois de naissance :");
            mois = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez votre jour de naissance :");
            jour = int.Parse(Console.ReadLine());

            //Création du date time
            dateT = new DateTime(annee, mois, jour);
            dateN = DateTime.Today;

            //On peut effectuer des opérations entre les DateTime
            nbJours = dateN - dateT;



            //Affichage de la difference entre date de naissance et date today (aujourd'hui sans les heures)
            //puis la propriété d'instance .TotalDays pour ne garder que le nombre de jours au total.
            //Vous pouvez aussi prendre .second, .TotalNanoseconds si vous voulez vous amuser
            Console.WriteLine($"Tu as passé {nbJours.TotalDays} jours sur Terre.");
            Console.WriteLine($"Tu as passé {nbJours.TotalNanoseconds} nanosecondes sur Terre.");

        }
    }
}