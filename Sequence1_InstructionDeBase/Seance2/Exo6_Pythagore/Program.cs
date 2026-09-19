using System.Text;

namespace Exo6_Pythagore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creation des variables
            double longueurEchelle = 0, hauteur = 0; ecartement = 0;

            //Attribution des variables
            Console.WriteLine("Longueur Echelle en mètres :");
            longueurEchelle = double.Parse(Console.ReadLine());

            Console.WriteLine("Hauteur à atteindre en mètres :");
            hauteur = double.Parse(Console.ReadLine());

            //Maths (pythagore : a² + b² = c², donc a² = c² - b²)
            //Math.Pow permet de faire des puissances, Math.Sqrt permet de faire la racine carré, Math.Round permet d'arrondir à 2 chiffres après la virgule
            ecartement = Math.Pow(longueurEchelle,2) - Math.Pow(hauteur,2);
            ecartement = Math.Sqrt(ecartement);
            ecartement = Math.Round(ecartement, 2);

            //Affichage du résultat
            Console.WriteLine("------------------------");
            Console.WriteLine("Il faut espacer le pied de l'échelle de " + ecartement + "m pour atteindre " + hauteur + "m de haut.");
        }
    }
}
