using System.Text;

namespace Exo1_OperationsElementaires2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double val1 = 0, val2 = 0;
            Console.WriteLine("Valeure 1 :");
            val1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Valeure 2 :");
            val2 = double.Parse(Console.ReadLine());

            Console.WriteLine("------------------------");

            Console.WriteLine(val1 + " & " + val2 + " = " + val1 + val2);
            Console.WriteLine(val1 + " + " + val2 + " = " + (val1 + val2));

            //l'un fait en sorte d'assembler bout a bout, tandisque l'autre prends en compte les opérations mathémathiques grace aux parenthèses

            Console.WriteLine(val1 + " - " + val2 + " = " + (val1 - val2));
            Console.WriteLine(val1 + " * " + val2 + " = " + (val1 * val2));

            Console.WriteLine(val1 + " / " + val2 + " = " + (val1 / val2));
            Console.WriteLine(val1 + " / " + val2 + " = " + ((double)val1 / val2));

            //Le premier fait une opération mathémathique division euclidienne, et va en général de paire avec le reste dont l'opérateur mathémathique est % (en dessous) 
            //Le 2e lui donne un résultat plus exacte avec virgule grace au type double mis avant.

            Console.WriteLine(val1 + " % " + val2 + " = " + (val1 % val2));
        }
    }
}
