using System.Runtime.ConstrainedExecution;


namespace Exo1_Soldes
{
    internal class Program
    {
        //Création de variables statiques
        static readonly double TAUX_REMISE_ROUGE = 0.5, TAUX_REMISE_VERT = 0.2;

        static void Main(string[] args)
        {
            //Encodage UTF-8
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Création de variables (rappel : double pour quand on parle d'argent)
            double final = 0, remise = 0, prixBase = 0;
            string couleur = "";

            //Attribution de variables
            Console.WriteLine("Couleur de l'étiquette");
            Console.WriteLine("R. Rouge");
            Console.WriteLine("V. Vert");
            Console.Write("Votre choix : ");

            couleur = Console.ReadLine();

            Console.WriteLine("Prix de base :");
            prixBase = double.Parse(Console.ReadLine());

            //Conditions
            //Dans l'exercice, on suppose qu'on ne fait pas d'erreur.
            //Cependant, on peut imaginer que l'utilisateur se trompe et qu'il entre une couleur qui n'est pas R ou V.
            //Cette version vérifie donc en plus, que la couleur est bien R ou V, sinon on affiche un message d'erreur
            if (couleur == "V" || couleur == "R")
            {
                //Puis voici la partie conditionelle de tests "normale", avec les calculs de remise et de prix final
                if (couleur == "R")
                {
                    remise = prixBase * TAUX_REMISE_ROUGE;
                }
                else if (couleur == "V")
                {
                    remise = prixBase * TAUX_REMISE_VERT;
                }
                final = prixBase - remise;

                //Afficher les résultats
                Console.WriteLine("La remise est de " + remise + " €, pour un prix final de " + final + " €.");
            }
            else
            {
                //Message d'erreur si la couleur n'est pas R ou V
                Console.WriteLine("Erreur, ni V ni R n'as été reseigné correctement.");
            }
        }
    }
}
