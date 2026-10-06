namespace Exo1_NumeroSecu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Création des variables
            string annee, mois, dep, numSecu;

            //Attribution des valeurs
            Console.WriteLine("Entrez votre numéro de sécu (7 premiers) :");
            numSecu = Console.ReadLine();

            //Selon numSecu, on se sert de Substring (int position, int longueur) pour obtenir les valeurs voulues de la chaine de caractère.
            annee = numSecu.Substring(1, 2);
            mois = numSecu.Substring(3, 2);
            dep = numSecu.Substring(5, 2);

            //Afficher le résultat
            Console.WriteLine($"Vous êtes née en {mois}/{annee} dans le département {dep}");
        }
    }
}
