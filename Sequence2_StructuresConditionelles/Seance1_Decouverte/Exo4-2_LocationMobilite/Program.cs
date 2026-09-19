namespace Exo4_LocationMobilite
{
    internal class Program
    {
        //attributions de variables statiques
        static readonly double TAUX_VELO_SEM = 0.1;
        static readonly double TAUX_VELO_WEEK = 0.14;
        static readonly double TAUX_TROT_SEM = 0.18;
        static readonly double TAUX_TROT_WEEK = 0.24;

        static void Main(string[] args)
        {
            //Cet exercice, comme l'ex 1, se sert d'une opérateur ternaire
            //Cet exemple sert surtout de démo pour l'uttilisation d'outils autres que if/else

            //encodage en UTF8
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Création des variables puis attribution de valeurs
            double taux = 0, total = 0;
            Console.WriteLine("Durée (heures, puis minutes) :");
            int dureeH = int.Parse(Console.ReadLine());
            int dureeM = int.Parse(Console.ReadLine());

            //Rapide calcul pour transformer les heures en minutes et avoir un résultat final qu'en minutes
            int dureeT = 60 * dureeH + dureeM;

            Console.WriteLine("Type de véhicule (V pour vélo, T pour trottinette) :");
            string type = Console.ReadLine();

            Console.WriteLine("Quel jour (S pour semaine, W pour weekend) :");
            string jour = Console.ReadLine();


            //Conditionnel rapide pour vérifier si le type et le jour sont valides, sinon on affiche un message d'erreur et on quitte le programme grace a return
            if (type != "V" && type != "T")
            {
                Console.WriteLine("Erreur : Type invalide, veuillez entrer V ou T");
                return;
            }

            if (jour != "S" && jour != "W")
            {
                Console.WriteLine("Erreur : Jour invalide, veuillez entrer S ou W");
                return;
            }

            //Conditionnel rapide pour savoir si on est en vélo, puis utilisation d'un opérateur ternaire pour savoir si on est en semaine ou en weekend, et ainsi attribuer le bon taux
            //Rappel : l'opérateur ternaire s'utilise avec la syntaxe suivante : condition ? valeur_si_vrai : valeur_si_faux

            if (type == "V")
                taux = (jour == "S") ? TAUX_VELO_SEM : TAUX_VELO_WEEK;
            else
                taux = (jour == "S") ? TAUX_TROT_SEM : TAUX_TROT_WEEK;

            //Maths et arrondissement
            total = Math.Round(dureeT * taux, 2);

            //Afficher les résultats
            Console.WriteLine(
                "La location vous coûtera " + total +
                "€ pour une durée de " + dureeT + " minutes"
            );
        }
    }
}
