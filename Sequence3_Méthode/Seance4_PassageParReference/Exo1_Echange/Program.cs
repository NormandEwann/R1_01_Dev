namespace Exo1_Echange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 3;
            Console.WriteLine("a = " + a + "    b = " + b);

            Program.Echange(ref a, ref b);
            Console.WriteLine("a = " + a + "    b = " + b);
        }

        /* 
         * EXPLICATION DU MOT-CLÉ "ref" EN C# :
         * --------------------------------------------------
         * - Permet de passer une variable par référence (la fonction modifie directement la variable originale, et non une simple copie).
         * - Contrairement à "out", la variable doit obligatoirement être créée et initialisée avant d'être passée à la fonction.
         * - La fonction peut lire sa valeur de départ ET la modifier (le type peut être int, double, decimal, etc., selon le besoin).
         */

        //On utilise une static "void" car on n'as pas de return/ On ne renvois aucune variables en sortie de méthode
        //Les variables sont modifiés directement via la ref
        public static void Echange(ref int a, ref int b)
        {
            int tmp = b;
            b = a;
            a = tmp;
        }
    }
}
