using System.Text.RegularExpressions;

namespace Exo1_CourseAPied
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("COURSE A PIED");
            Console.WriteLine("------------------------");

            Console.WriteLine("Nombres de KM parcourus :");
            double nbKm = double.Parse(Console.ReadLine());

            Console.WriteLine("Temps (hh:mm) :");
            String temps = Console.ReadLine();

            //On se sert de la méthode ConvertitTempsEnMinutes(String au format hh:mm) de notre classe Course
            int nbMinutes = Course.ConvertitTempsEnMinutes(temps);

            //De meme avec la méthode CalculeVitesse(double nbKm, int nbMinutes)
            double vitesse = Course.CalculeVitesse(nbKm, nbMinutes);

            Console.WriteLine("------------------------");
            Console.WriteLine("VITESSE :");
            Console.WriteLine("------------------------");
            Console.WriteLine(vitesse + " Km/h");




            Console.WriteLine("\n \n --------------------Exo2-------------------------");

            Console.WriteLine("Vitesse à atteindre en km/h :");
            double kmh = double.Parse(Console.ReadLine());

            //De meme pour la méthode NbKmPourAtteindreVitesse(int nbMinutes, double kmh)
            double km = Course.NbKmPourAtteindreVitesse(nbMinutes, kmh);

            double difference = Math.Round(km - nbKm,2);
            Console.WriteLine($"Pour atteindre {kmh} km/h sur le même temps, il faudrait {km} km. \n" +
                $"Soit {difference} km de plus.");




            Console.WriteLine("\n \n --------------------Exo3-------------------------");

            Console.WriteLine("Vitesse à atteindre en km/h :");
            kmh = double.Parse(Console.ReadLine());

            //Et enfin, encore pareil avec la méthode NbMinPourAtteindreVitesse(double km, double kmh)
            int min = Course.NbMinPourAtteindreVitesse(km, kmh);
            double difference2 = min - nbMinutes;
            Console.WriteLine($"Pour atteindre {kmh} km/h sur la même distance, il faudrait {min} minutes. \n" +
                $"Soit {difference2} minutes de plus.");

            String transfo = Course.ConvertitMinutesEnTemps(min);
            Console.WriteLine($"Ou encore " + transfo);
        }
    }
}
