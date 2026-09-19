using System.ComponentModel.Design;

namespace Exo3_Min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creation de variables et attribution directe des valeurs
            double minimum = 0;
            Console.WriteLine("Tapez 3 numéros :");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            //On suppose que num1 est le plus petit
            minimum = num1;
            //On compare num1 avec num2 dans un premier temps, si num1 est plus grand que num2, on change la valeur de minimum pour num2
            if (num1 >= num2)
            {
                minimum = num2;
            }
            //On fait de meme pour num3, si num1 est plus grand que num3, on change la valeur de minimum pour num3
            if (num1 >= num3)
            {
                minimum = num3;
            }

            //Affichage du résultat
            Console.WriteLine(minimum + " est le plus petit");
        }
    }
}
