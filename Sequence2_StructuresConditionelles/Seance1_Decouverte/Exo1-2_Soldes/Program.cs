using System.Runtime.ConstrainedExecution;


namespace Exo1_Soldes
{
    internal class Program
    {
        //Ceci est une version alternative de l'exo 1 séance 1 sequence 1.
        //Elle introduit une manière différente de traiter les if / else.
        //Elle n'est pas obligatoire et pas demandée, cet exemple sert surtout a montrer d'autres outils.


        
        //Création de variables statiques
        static readonly decimal TAUX_REMISE_ROUGE = 0.5m, TAUX_REMISE_VERT = 0.2m;

        static void Main(string[] args)
        {
            //Encodage UTF-8
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Création de variables (rappel : decimal pour quand on parle d'argent)
            decimal final = 0m, remise = 0m, prixBase = 0m;
            string couleur = "";

            //Attribution de variables
            Console.WriteLine("Couleur de l'étiquette");
            Console.WriteLine("R. Rouge");
            Console.WriteLine("V. Vert");
            Console.Write("Votre choix : ");

            couleur = Console.ReadLine();

            Console.WriteLine("Prix de base :");
            prixBase = decimal.Parse(Console.ReadLine());

            //Conditions
            //On teste si la couleur est rouge ou verte, sinon on affiche un message d'erreur

            if (couleur != "V" && couleur != "R")
            {
                Console.WriteLine("Erreur : Couleur invalide, veuillez entrer V ou R");
                return;
            }

            //Implication de la remise selon la couleur de l'étiquette
            //On utilise ? pour simplifier le code, c'est un opérateur ternaire
            //Elle permet de faire un if/else en une seule ligne
            //Voici comment elle fonctionne : condition ? valeur_si_vrai : valeur_si_faux

            //Dans la ligne suivante, on teste si la couleur est rouge, si c'est le cas on applique le taux de remise rouge, sinon on applique le taux de remise vert al a variable "remise"

            remise = (couleur == "R") ? TAUX_REMISE_ROUGE * prixBase : TAUX_REMISE_VERT * prixBase;

            //Rappel : Math.Round permet d'arrondir un nombre à un certain nombre de décimales, ici 2 pour les centimes
            final = Math.Round(prixBase - remise, 2);

            //Affichage des résultats
            Console.WriteLine("La remise est de " + remise + " €, pour un prix final de " + final + " €.");
        }
    }
}
