namespace Exo3_ConversionCelsiusFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Création des variables
            double celsius = 0;

            //Attribution de la variable
            Console.WriteLine("Valeur en Celsius :");
            celsius = double.Parse(Console.ReadLine());

            //Maths (Fahrenheit = 32 + 1,8*celsius)
            //Attention, j'ai fait mon calcul dans "Math.Round(variable,2)" 
            //pour arrondir directement ma variable a 2 chiffres après la virgule en une ligne.
            double fahren = Math.Round(((1.8 * celsius) + 32),2);

            //Afficher le résultat
            Console.WriteLine("------------------------");
            Console.WriteLine("La température en Fahrenheit est de : " + fahren + "°F.");
        }
    }
}
