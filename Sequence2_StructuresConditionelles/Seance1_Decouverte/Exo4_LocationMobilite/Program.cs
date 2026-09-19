using System.Numerics;

namespace Exo4_LocationMobilite
{
    internal class Program
    {
        //création des valeurs statiques
        static readonly double TAUX_VELO_SEM = 0.1, TAUX_VELO_WEEK = 0.14, TAUX_TROT_SEM = 0.18, TAUX_TROT_WEEK = 0.24;

        static void Main(string[] args)
        {
            //Encodage en UTF8
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Definition des variables et attribution de valeurs a ces dernieres
            double total = 0;
            Console.WriteLine("Durée (heures, puis minutes) :");
            int dureeH = int.Parse(Console.ReadLine());
            int dureeM = int.Parse(Console.ReadLine());

            Console.WriteLine("Type de véhicule (V pour vélo, T pour Trotinette)");
            string type = Console.ReadLine();

            Console.WriteLine("Quel jour (S pour semaine, W pour weekend) :");
            string jour = Console.ReadLine();

            //Maths rapide pour convertir la durée des heures et des minutes uniquement en minutes
            int dureeT = (60 * dureeH + dureeM);


            //Comme pour l'exercice 1, on rajoute les conditionnel "if (type == "V" || type == "T")" et "if (jour == "S" || jour == "W")" 
            //pour vérifier que l'utilisateur a bien entré les bonnes valeurs, sinon on lui renvoie un message d'erreur

            if (type == "V" || type == "T")
            {
                if (type == "V")
                {
                    if (jour == "S" || jour == "W")
                    {
                        if (jour == "S")
                        {
                            total = dureeT * TAUX_VELO_SEM;
                        }
                        else
                        {
                            total = dureeT * TAUX_VELO_WEEK;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Erreur : Jour invalide, veuillez entrer S ou W");
                        return;
                        //return permet de sortir du programme si l'utilisateur a entré une valeur invalide. Il stoppe son éxecution et ne continue pas le programme.
                    }
                }
                else
                {
                    if (jour == "S" || jour == "W")
                    {
                        if (jour == "S")
                        {
                            total = dureeT * TAUX_TROT_SEM;
                        }
                        else
                        {
                            total = dureeT * TAUX_TROT_WEEK;
                        }

                    }
                }

            }
            else 
            { 
                Console.WriteLine("Erreur : Type invalide, veuillez entrer V ou T");
                return;
                //return permet de sortir du programme si l'utilisateur a entré une valeur invalide. Il stoppe son éxecution et ne continue pas le programme.
            }

            total = Math.Round(total,2);

            //Affichage des resultats
            Console.WriteLine("La location vous coutera " + total + "€ pour une durée de " + dureeT + " minutes");
        }
    }
}
