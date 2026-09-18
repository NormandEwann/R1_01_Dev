using System.Numerics;

namespace Exo4_LocationMobilite
{
    internal class Program
    {
        static readonly double TAUX_VELO_SEM = 0.1, TAUX_VELO_WEEK = 0.14, TAUX_TROT_SEM = 0.18, TAUX_TROT_WEEK = 0.24;
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            double total = 0;
            Console.WriteLine("Durée (heures, puis minutes) :");
            int dureeH = int.Parse(Console.ReadLine());
            int dureeM = int.Parse(Console.ReadLine());
            int dureeT = (60 * dureeH + dureeM);
            Console.WriteLine("Type de véhicule (V pour vélo, T pour Trotinette)");
            string type = Console.ReadLine();
            Console.WriteLine("Quel jour (S pour semaine, W pour weekend) :");
            string jour = Console.ReadLine();



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
            }
            total = Math.Round(total,2);
            Console.WriteLine("La location vous coutera " + total + "€ pour une durée de " + dureeT + " minutes");
        }
    }
}
