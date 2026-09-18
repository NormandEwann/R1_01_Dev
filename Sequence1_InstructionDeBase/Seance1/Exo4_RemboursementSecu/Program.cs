using System.Text;

namespace Exo4_RemboursementSecu
{
    internal class Program
    {
        //création de variables statiques
        static readonly decimal TAUXSECU = 0.70m;
        static readonly decimal TAUXMUTUELLE = 0.30m;
        static readonly int CHARGES = 2;
        
        static void Main(string[] args)
        {
            //en-tête d'encodage en UTF8
            Console.OutputEncoding = Encoding.UTF8;

            //création des variables
            decimal prixBase;
            decimal prixCharges;
            decimal secu;
            decimal mutuelle;

            //attribution de valeurs aux variables
            Console.WriteLine("CALCUL DE LA SECU ET MUTUELLE");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Prix Payé en Consultation :");
            prixBase = decimal.Parse(Console.ReadLine());
            
            //Maths            
            prixCharges = prixBase - CHARGES;
            secu = prixCharges * TAUXSECU;
            mutuelle = prixCharges * TAUXMUTUELLE;
            
            //Arrondir avec 2 chiffres après la virgule
            secu = Math.Round(secu, 2);
            mutuelle = Math.Round(mutuelle, 2);

            //Afficher le résultat
            Console.WriteLine("Le prix sans charges est de " + prixCharges + " €.\nLe remboursement de la sécu est de " + secu + "€ et la mutuelle rembourse " + mutuelle + "€!");
        }
    }
}
