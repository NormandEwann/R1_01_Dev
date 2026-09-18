namespace Exo2_Moyenne
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
            double moy = (val1 + val2) / 2;
            Console.WriteLine("La moyenne est de : " + moy + ".");
        }
    }
}
