namespace Exo2_MesMaths_Conditionnel_Poussé
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //J'ai modifier le code de la prof pour demander a l'utilisateur ses propres valeurs
            //Mais l'important c'est de se servir de la classe "MesMaths" et de la fonction "Moyenne" séparé par un point

            List<double> valeur = new List<double>();
            double moy = 0;

            Console.WriteLine("Combien de valeurs ? (min 2, max 5)");
            double nb = double.Parse(Console.ReadLine());

            if ((nb < 2) && (nb > 5))
            {
                Console.WriteLine("Veuillez choisir un nombre entre 2 et 5");
                return;
            }
            else
            {

                //Nouvelle méthode : for i in range en version C# !
                //Meme fonctionnement, "for (valeur de i, fin de i, opération sur i) {code}"
                //Ici il nous sert a demander plusieurs fois le nombre pour le calcul de la moyenne

                for (double i = 1; i <= nb; i++)
                {
                    Console.WriteLine("Choisir le " + i + "e nombre");
                    // On lit la saisie de l'utilisateur
                    string saisie = Console.ReadLine();

                    // On convertit et on ajoute la valeur à la liste
                    if (double.TryParse(saisie, out double val))
                    {
                        valeur.Add(val); // Ajoute la valeur dans la liste
                    }
                    else
                    {
                        Console.WriteLine("Ce n'est pas un nombre valide. Réessaie.");
                        i--; // Optionnel : permet de répéter l'itération si l'utilisateur s'est trompé
                    }
                }

                //Ici un simple conditionnel if elseif else pour executer la commande. On pourrait réduire mais cela nécessiterait de aussi modifier
                //La fonction Moyenne dans MesMahs...

                if (nb == 2)
                {
                    moy = MesMaths.Moyenne(valeur[0], valeur[1]);
                }
                else if (nb == 3)
                {
                    moy = MesMaths.Moyenne(valeur[0], valeur[1], valeur[2]);
                }
                else if (nb == 4)
                {
                    moy = MesMaths.Moyenne(valeur[0], valeur[1], valeur[2], valeur[3]);
                }
                else
                {
                    moy = MesMaths.Moyenne(valeur[0], valeur[1], valeur[2], valeur[3], valeur[4]);
                }

                Console.WriteLine("Moyenne des nombres : " + moy);
            }
        }
    }
}
