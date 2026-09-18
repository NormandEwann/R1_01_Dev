using System.ComponentModel.Design;

namespace Exo3_Min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double min = 0;
            Console.WriteLine("Tapez 3 numéros :");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            min = num1;
            if (num1 >= num2)
            {
                min = num2;
            }
            if (num1 >= num3)
            {
                min = num3;
            }
            Console.WriteLine(min + " est le plus petit");
        }
    }
}
