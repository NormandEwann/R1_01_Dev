namespace Exo4_Calculatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            Console.WriteLine(
                $"----------------------------------\n MENU\n----------------------------------\n+ pour additionner\n- pour soustraire\n* pour multiplier\n/ pour diviser\n----------------------------------");
            string operateur = Console.ReadLine()?.Trim();

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
                    Console.WriteLine("Erreur, composant invalide, veuillez entrer +, _, * ou /.");
                    break;
            }

            Console.WriteLine($"Le résultat est {result}.");
        }
    }
}
