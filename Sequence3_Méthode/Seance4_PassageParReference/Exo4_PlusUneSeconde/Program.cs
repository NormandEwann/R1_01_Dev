namespace Exo4_PlusUneSeconde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan temps = new TimeSpan(11, 44, 59);
            Console.WriteLine(temps);

            Program.PlusUneSeconde(ref temps);
            Console.WriteLine(temps);

            temps = PlusUneSeconde(temps);
            Console.WriteLine(temps);
        }

        //On utilise ref TimeSpan en entrée pour le public static void
        //On ne retourne rien mais on change avec +1s la variable temps
        public static void PlusUneSeconde(ref TimeSpan temps)
        {
            temps = temps + new TimeSpan(0, 0, 1);
        }

        //On utilise public static TimeSpan pour retourner cette fois ci un time span
        //Meme méthode qu'au dessus sinon
        public static TimeSpan PlusUneSeconde(TimeSpan temps)
        {
            temps = temps + new TimeSpan(0, 0, 1);
            return temps;
        }
    }
}
