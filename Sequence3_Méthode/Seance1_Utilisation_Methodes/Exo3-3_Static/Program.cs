namespace Exo3_3_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Création de variables
            DateTime dateT, dateN;
            DateOnly dateR;
            int nbJours, annee, mois;

            //assignation des valeurs
            Console.WriteLine("Une année, puis un mois");
            annee = int.Parse(Console.ReadLine());
            mois = int.Parse(Console.ReadLine());

            //Création des date time
            dateR = new DateOnly(annee, mois, 01);

            //Utilisation de .DaysInMonth(int annee, int mois) pour savoir combien de jours dans le mois
            //Ici on se sert des propriétés d'instance de dateR avec .Year et .Month pour séléctionner l'année et le mois en int de notre variable
            nbJours = DateTime.DaysInMonth(dateR.Year, dateR.Month);

            //on créer 2 date time pour observer la différence entre les propriétés statiques .Today et .Now (voir derniere ligne pour explication)
            dateT = DateTime.Today;
            dateN = DateTime.Now;

            //Affichage des résultats
            Console.WriteLine($"1) Dans la date renseignée, le mois compte {nbJours} jours");
            Console.WriteLine($"2)Aujourd'hui nous somme le {dateT.ToShortDateString()} \n" +
                $"plus exactement, nous somme le {dateN.ToLongDateString()}, à {dateN.ToLongTimeString()}");

            //On remarque que Today marque la date d'aujourd'hui a l'heure 00:00:00
            //Tandis que Now met la date d'aujourd'hui, en plus de l'heure exacte de l'ordinateur.

        }
    }
}