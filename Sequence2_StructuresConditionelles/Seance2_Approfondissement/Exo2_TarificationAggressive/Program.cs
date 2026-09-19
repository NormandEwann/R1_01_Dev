using System.Text;

namespace Exo1-2_PlaceConcert
{
    internal class Program
    {
        //Créations des variables statiques
        static readonly decimal TARIF_ENFANT = 0m, TARIF_ADO = 15m, TARIF_ADULTE = 20m;
        static readonly int AGE_ENFANT = 10, AGE_ADO = 20;
        static readonly decimal REDUC_PREVENTE = 1.5m, TAUX_REDUC_ADHERENT = 0.2m;
        static void Main(string[] args)
        {
            //Ce code est une version plus poussé que ce qu'on demande. Il permet de vérifier si l'utilisateur entre des valeurs correctes, et ceux "en direct".
            //Il sert donc surtout d'exemple avancé pour une certaine érgonomie de l'utilisateur, mais n'est pas nécessaire pour la base de l'exercice.
            //Voir exo1_PlaceConcert pour la version demandée en cours
            //Encodage en UTF8
            Console.OutputEncoding = Encoding.UTF8;

            //Déclaration des variables
            decimal prix = 0m;

            Console.WriteLine("Age du spectateur :");
            string input = (Console.ReadLine());

            //On verifie que l'utilisateur entre bien un nombre, et que ce nombre est positif. Si ce n'est pas le cas, on quitte le programme avec un message d'erreur.
            if (!int.TryParse(input, out int age) || age < 0)
            {
                Console.WriteLine("Veuillez choisir un nombre valide");
                return;
            }

            //On met aussi une vérification pour les enfants, qui sont gratuits. Si l'utilisateur entre un âge inférieur à 10 ans, on lui indique que c'est gratuit. 
            //Pas besoin de continuer la suite car les calculs ne seront pas nécessaires.
            else if (age < AGE_ENFANT)
            {
                prix = TARIF_ENFANT;
            }

            //Si les conditions précédentes ne sont pas remplies, on continue le programme pour calculer le prix en fonction de l'âge, de l'adhésion et de la prévente.
            else
            {
                Console.WriteLine("Adhérent ?");
                string adherent = Console.ReadLine();

                //On vérifie que l'utilisateur entre bien O ou N pour adhérent. Si ce n'est pas le cas, on quitte le programme avec un message d'erreur.
                if (adherent != "O" && adherent != "N")
                {
                    Console.WriteLine("Erreur : Type invalide, veuillez entrer O ou N");
                    return;
                }

                Console.WriteLine("Prévente ?");
                string prevente = Console.ReadLine();

                //de meme, on vérifie que l'utilisateur entre bien O ou N pour prévente. Si ce n'est pas le cas, on quitte le programme avec un message d'erreur.
                if (prevente != "O" && prevente != "N")
                {
                    Console.WriteLine("Erreur : Jour invalide, veuillez entrer O ou N");
                    return;
                }

                //Conditionnel pour déterminer le prix en fonction de l'âge, de l'adhésion et de la prévente.
                if (age < AGE_ADO)
                {
                    prix = TARIF_ADO; 
                }
                else
                {
                    prix = TARIF_ADULTE;
                }

                //Si adherent est O, on devra appliquer la réduction pour les adhérents. 
                //On se sert ensuite d'une condition ternaire pour appliquer la réduction pour la prévente si l'utilisateur est adhérent, ou juste la réduction pour les adhérents si l'utilisateur est non adhérent.
                //Rappel : une condition ternaire est une manière plus concise d'écrire un if/else. La syntaxe est la suivante : condition ? valeur_si_vrai : valeur_si_faux;

                if (adherent == "O")
                    prix = (prevente == "O") ? prix - (prix * TAUX_REDUC_ADHERENT) - REDUC_PREVENTE : prix - (prix * TAUX_REDUC_ADHERENT);
                else
                    prix = (prevente == "O") ? prix - REDUC_PREVENTE : prix;
            }

            //Affichage des résultats. Le formatage {prix:C} permet d'afficher le prix avec le symbole monétaire correspondant à la culture de l'utilisateur.
            //Exemple : 20,00 € pour la France, $20.00 pour les États-Unis, etc.
            //Il faut mettre $ devant le string pour pouvoir utiliser l'interpolation de string, et la variable entre des accolades pour qu'elle soit évaluée et affichée dans le string.
            
            Console.WriteLine($"La place coutera à la personne {prix:C}.");
        }
    }
}
