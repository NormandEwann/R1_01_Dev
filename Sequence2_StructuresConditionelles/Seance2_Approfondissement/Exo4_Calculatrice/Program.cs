namespace Exo4_Calculatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creation de variables puis affectation de valeur
            double result = 0;
            Console.WriteLine(
                $"----------------------------------\n" +
                $"MENU\n" +
                $"----------------------------------\n" +
                $"+ pour additionner\n" +
                $"- pour soustraire\n" +
                $"* pour multiplier\n" +
                $"/ pour diviser\n" +
                $"----------------------------------");
            string operateur = Console.ReadLine()?.Trim();

            //On test si l'utilisateur a entré un opérateur valide grace a un TryParse, si ce n'est pas le cas on affiche un message d'erreur et on quitte le programme
            //Rappel : TryParse permet de tester si une valeur peut être convertie en un type spécifique, ici double. Si la conversion échoue, il retourne false.
            //Puis il retorune la valeur convertie dans la variable double A (pour nombre 1) ou B (pour nombre 2) grace a "out double".
            Console.Write("Nombre 1 : ");
            if (!double.TryParse(Console.ReadLine(), out double A))
            {
                Console.WriteLine("Entrée invalide. Veuillez entrer un nombre.");
                return;
            }
            Console.Write("Nombre 2 : ");
            if (!double.TryParse(Console.ReadLine(), out double B))
            {
                Console.WriteLine("Entrée invalide. Veuillez entrer un nombre.");
                return;
            }

            //Conditionnel avec switch pour effectuer l'opération en fonction de l'opérateur entré par l'utilisateur
            switch (operateur)
            {
                case "+":
                    result = (A + B);
                    break;

                case "-":
                    result = (A - B);
                    break;

                case "*":
                    result = (A * B);
                    break;

                case "/":
                    if (B == 0)
                    {
                        Console.WriteLine("Erreur : division par zéro.");
                        return;
                    }
                    else
                    {
                        result = A / B;
                    }
                    break;

                default:
                    Console.WriteLine("Erreur, composant invalide, veuillez entrer +, -, * ou /.");
                    break;
            }

            //Affichage du résultat
            Console.WriteLine($"Le résultat est {result}.");
        }
    }
}
