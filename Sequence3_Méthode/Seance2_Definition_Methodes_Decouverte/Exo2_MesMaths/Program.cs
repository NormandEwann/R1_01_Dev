namespace Exo2_MesMaths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------MOYENNE-----------------------------------------------

            //On execute la méthode Moyenne, qui a 4 surcharges d'entrée
            //C'est a dire qu'on peut mettre 2, jusqu'a 5 valeurs int.
            //Plus on veut en prendre, plus il faudra créer de surcharges dans la classe MesMaths.
            double moy = MesMaths.Moyenne(3, 4, 5, 10, 12);

            //Ici car trop compliqué, on met nos variables manuellement,
            //mais voir Exo2_MesMaths_Conditionnel pour voir une méthode qui demande a l'utilisateur de rentrer ses valeurs
            //Grace a une liste


            //---------------------------------RAYON & PERIMETRE-----------------------------------------------

            //Ici je demande le rayon
            //Et j'execute une fonction de MesMaths appelé PerimetreCercle
            Console.WriteLine("Rayon d'un cercle ?");
            double rayon = double.Parse(Console.ReadLine());

            double perimetre = MesMaths.PerimetreCercle(rayon);
            Console.WriteLine("Le périmètre du cercle est de " + perimetre);

            //---------------------------------DEGREE TO RADIANS-----------------------------------------------

            //La meme chose mais pour la fonction degree radians
            Console.WriteLine("Degrés?");
            double degree = double.Parse(Console.ReadLine());

            double radians = MesMaths.DegreeToRadian(degree);
            Console.WriteLine(degree + "° en radians fait " + radians + " rad");

            //---------------------------------RANDOM (ex4)-----------------------------------------------

            //La meme chose mais pour l'ex 4 : random
            Console.WriteLine("N1 : ");
            int N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("N2 : ");
            int N2 = int.Parse(Console.ReadLine());

            double random = MesMaths.TireAuSort(N1, N2);
            Console.WriteLine("Le résultat est " + random);
        }
    }
}
