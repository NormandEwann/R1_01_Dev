using System.Text;

namespace Exo5_CalculCarrelage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double largeurSol;
            double longueurSol;
            double largeurCar;
            double longueurCar;
            double tempLargeur;
            double tempLongueur;
            double nbCarrelage;
            double quantPaquet;
            double nbPaquet;
            Console.WriteLine("CALCUL DU NOMBRE DE PAQUETS TOTAL");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Largeur du sol (m) :");
            largeurSol = double.Parse(Console.ReadLine());
            Console.WriteLine("Longueur du sol (m) :");
            longueurSol = double.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Largeur du carrelage (cm) :");
            largeurCar = double.Parse(Console.ReadLine());
            Console.WriteLine("Longueur du carrelage (cm) :");
            longueurCar = double.Parse(Console.ReadLine());
            Console.WriteLine("Nombre de Carrelage par Paquets");
            quantPaquet = int.Parse(Console.ReadLine());
            tempLargeur = (largeurSol * 100) / largeurCar;
            tempLargeur = Math.Ceiling(tempLargeur);
            tempLongueur = (longueurSol * 100) / longueurCar;
            tempLongueur = Math.Ceiling(tempLongueur);
            nbCarrelage = tempLargeur * tempLongueur;
            nbPaquet = Math.Ceiling(nbPaquet = nbCarrelage / quantPaquet);
            Console.WriteLine("Il faudra " + nbPaquet + " paquets de carrelage.");
        }
    }
}
