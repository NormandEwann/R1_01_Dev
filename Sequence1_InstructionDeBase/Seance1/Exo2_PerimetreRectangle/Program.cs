namespace Exo2_PerimetreRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //création des variables
            double largeur;
            double hauteur;
            String unit;

            //attribution de valeurs aux variables
            Console.WriteLine("CALCUL DU PERIMETRE D'UN RECTANGLE");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Unité de mesure (m, cm, mm...) :");
            unit = Console.ReadLine();
            
            Console.WriteLine("Largeur :");
            largeur = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Hauteur :");
            hauteur = double.Parse(Console.ReadLine());

            //Afficher le résultat
            Console.WriteLine("Perimetre du rectangle : " + (hauteur + largeur)*2 + Unit);
        }
    }
}
