namespace Exo2_PerimetreRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double largeur;
            double hauteur;
            String Unit;
            Console.WriteLine("CALCUL DU PERIMETRE D'UN RECTANGLE");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Unité de mesure (m, cm, mm...) :");
            Unit = Console.ReadLine();
            Console.WriteLine("Largeur :");
            largeur = double.Parse(Console.ReadLine());
            Console.WriteLine("Hauteur :");
            hauteur = double.Parse(Console.ReadLine());
            Console.WriteLine("Perimetre du rectangle : " + (hauteur + largeur)*2 + Unit);
        }
    }
}
