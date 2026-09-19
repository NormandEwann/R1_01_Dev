namespace Exo1_OperationsElementaires
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //création de variables et attribution directe de valeurs
            Console.WriteLine("Entrez 2 valeurs :");
            int val1 = int.Parse(Console.ReadLine());
            int val2 = int.Parse(Console.ReadLine());

            //Partie 1)
            Console.WriteLine("val1 + val2 = " + val1 + val2);
            Console.WriteLine("val1 + val2 = " + (val1 + val2));
            //l'un fait en sorte d'assembler bout a bout, tandisque l'autre prends en compte les opérations mathémathiques grace aux parenthèses

            //Partie 2)
            Console.WriteLine("val1 - val2 = " + (val1 - val2));
            Console.WriteLine("val1 * val2 = " + (val1 * val2));
            //Rien d'anormal, on a bien une soustraction et une multiplication
            
            //Partie 3)
            Console.WriteLine("val1 / val2 = " + (val1 / val2));
            Console.WriteLine("val1 / val2 = " + ((double)val1 / val2));
            //Le premier fait une opération mathémathique division euclidienne, et va en général de paire avec le reste dont l'opérateur mathémathique est % (en dessous) 
            //Le 2e lui donne un résultat plus exacte avec virgule grace au type double mis avant.
            
            //Partie 4)
            Console.WriteLine("val1 % val2 = " + (val1 % val2));
            //On obtient le reste
        }
    }
}
