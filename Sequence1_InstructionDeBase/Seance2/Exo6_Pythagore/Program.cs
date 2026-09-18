using System.Text;

namespace Exo6_Pythagore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double longueurEchelle = 0, hauteur = 0;
            Console.WriteLine("Longueur Echelle en mètres :");
            longueurEchelle = double.Parse(Console.ReadLine());

            Console.WriteLine("Hauteur à atteindre en mètres :");
            hauteur = double.Parse(Console.ReadLine());

            Console.WriteLine("------------------------");

            double ecartement = Math.Pow(longueurEchelle,2) - Math.Pow(hauteur,2);
            ecartement = Math.Sqrt(ecartement);
            ecartement = Math.Round(ecartement, 2);

            Console.WriteLine("Il faut espacer le pied de l'échelle de " + ecartement + "m pour atteindre " + hauteur + "m de haut.");
        }
    }
}
