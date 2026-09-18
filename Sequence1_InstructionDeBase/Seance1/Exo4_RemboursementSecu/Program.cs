using System.Text;

namespace Exo4_RemboursementSecu
{
    internal class Program
    {
        static readonly decimal TAUXSECU = 0.70m;
        static readonly decimal TAUXMUTUELLE = 0.30m;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            decimal prixBase;
            decimal prixCharges;
            decimal secu;
            decimal mutuelle;
            Console.WriteLine("CALCUL DE LA SECU ET MUTUELLE");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Prix Payé en Consultation :");
            prixBase = decimal.Parse(Console.ReadLine());
            prixCharges = prixBase - 2;
            Console.WriteLine("Prix sans charges : " + prixCharges);
            secu = prixCharges * TAUXSECU;
            secu = Math.Round(secu, 2);
            mutuelle = prixCharges * TAUXMUTUELLE;
            mutuelle = Math.Round(mutuelle, 2);
            Console.WriteLine("Le remboursement de la sécu est de " + secu + "€ et la mutuelle rembourse " + mutuelle + "€!");
        }
    }
}
