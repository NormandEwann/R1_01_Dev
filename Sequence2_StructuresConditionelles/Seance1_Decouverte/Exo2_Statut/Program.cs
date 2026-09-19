namespace Exo2_Statut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Création et attribution directe de la valeur a la variable
            Console.WriteLine("Age de l'utilisateur :");
            string input = Console.ReadLine();

            //Comme pour l"exercice 1, on vérifie que l'utilisateur a bien entré un nombre *et* que ce nombre est positif
            //On utilise TryParse pour convertir la valeur entrée string en int, et on vérifie que le résultat est supérieur ou égal à 0
            //De plus, cette opéartion ressort la valeur dans une variable age, que l'on peut ensuite utiliser pour les conditions suivantes (out int age)

            //On utilise une structure if/else if/else pour vérifier les différentes conditions et afficher le statut correspondant
            //Sachant que les contitions sont en cascade, pas besoin de vérifier que l'age est supérieur à 9 pour la condition "Pré-Ado", car si l'age est inférieur ou égal à 9, le programme ne rentrera pas dans cette condition etc.

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
