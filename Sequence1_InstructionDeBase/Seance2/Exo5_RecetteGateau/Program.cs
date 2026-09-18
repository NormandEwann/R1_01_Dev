namespace Exo5_RecetteGateau
{
    internal class Program
    {
        static readonly double POID_SUCRE = 0.10;
        static readonly double POID_BEURRE = 0.25;
        static readonly double POID_FARINE = 0.5;
        static readonly double POID_CHOCO = 0.15;
        static void Main(string[] args)
        {
            double poid = 0;
            Console.WriteLine("Poid du Gateau voulu en grammes :");
            poid = double.Parse(Console.ReadLine());

            double sucre = Math.Ceiling(poid * POID_SUCRE), beurre = Math.Ceiling(poid * POID_BEURRE), farine = Math.Ceiling(poid * POID_FARINE), choco = Math.Ceiling(poid * POID_CHOCO);

            Console.WriteLine("------------------------");
            Console.WriteLine("Il faudra " + sucre + "g de sucre, " + beurre + "g de beurre, " + farine + "g de farine et " + choco + "g de de chocolat.");
        }
    }
}
