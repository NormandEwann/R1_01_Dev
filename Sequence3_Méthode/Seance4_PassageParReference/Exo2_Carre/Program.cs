namespace Exo2_Carre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val = 5;
            Console.WriteLine("Carré de " + val);
            val = Program.Carre(val);
            Console.WriteLine(" => " + val);


            val = 5;
            Program.Carre(ref val); 
            Console.WriteLine(" => " + val);
        }

        //Méthode normale
        public static int Carre(int val)
        {
            double tmp = Math.Pow(val, 2);
            val = (int)tmp;
            return val;

            //Ou alors méthode facile :
            //val = val * val;
            //return val;
        }

        //Nouvelle méthode par ref :
        //(c'est la même, mais le retrun est remplacé par ref en entrée)
        public static void Carre(ref int val)
        {
            val = val * val;

            //Ou alors méthode réelle du carré :
            //double tmp = Math.Pow(val, 2);
            //val = (int)tmp;
        }
    }
}
