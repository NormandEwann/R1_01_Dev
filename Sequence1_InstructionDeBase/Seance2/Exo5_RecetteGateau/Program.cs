namespace Exo5_RecetteGateau
{
    internal class Program
    {
        //Création de variables statiques pour le poids des ingrédients en %
        static readonly decimal POID_SUCRE = 0.10m;
        static readonly decimal POID_BEURRE = 0.25m;
        static readonly decimal POID_FARINE = 0.5m;
        static readonly decimal POID_CHOCO = 0.15m;

        static void Main(string[] args)
        {
            //Création des variables
            decimal poid = 0, sucre = 0, beurre = 0, farine = 0, choco = 0;

            //Attribution des valeurs aux variables
            Console.WriteLine("Poid du Gateau voulu en grammes :");
            poid = decimal.Parse(Console.ReadLine());

            //Maths
            sucre = Math.Ceiling(poid * POID_SUCRE);
            beurre = Math.Ceiling(poid * POID_BEURRE);
            farine = Math.Ceiling(poid * POID_FARINE);
            choco = Math.Ceiling(poid * POID_CHOCO);

            //Afficher les résultats
            Console.WriteLine("------------------------");
            Console.WriteLine("Il faudra " + sucre + "g de sucre, " + beurre + "g de beurre, " + farine + "g de farine et " + choco + "g de chocolat.");
        }
    }
}
