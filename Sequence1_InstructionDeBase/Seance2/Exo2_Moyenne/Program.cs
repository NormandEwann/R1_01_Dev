namespace Exo2_Moyenne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Création des variables
            double val1 = 0, val2 = 0;

            //Attribution de valeurs aux variables
            Console.WriteLine("Valeure 1 :");
            val1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Valeure 2 :");
            val2 = double.Parse(Console.ReadLine());
            
            //Maths (Moyenne = somme des valeurs divisé par leur nombre)
            //Attention a bien utiliser les parenthèse pour additionner
            double moy = (val1 + val2) / 2;

            //Afficher le résultat
            Console.WriteLine("------------------------");
            Console.WriteLine("La moyenne est de : " + moy + ".");
        }
    }
}
