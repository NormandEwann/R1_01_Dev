namespace Exo3_ConversionCelsiusFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius = 0;
            Console.WriteLine("Valeur en Celsius :");
            celsius = double.Parse(Console.ReadLine());
            double fahren = Math.Round(((1.8 * celsius) + 32),2);
            Console.WriteLine("------------------------");
            Console.WriteLine("La température en Fahrenheit est de : " + fahren + "°F.");
        }
    }
}
