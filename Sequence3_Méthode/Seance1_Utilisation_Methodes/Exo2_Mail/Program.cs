namespace Exo2_Mail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creation des variables
            string mail, domaine, extension;
            int longueur, arobase, point;

            //Attribution des valeurs
            Console.WriteLine("Entrez votre adresse mail :");
            mail = Console.ReadLine();

            //On cherche la dernière apellation d'@ grace a variable.LastIndexOf (trad : la derniere fois qu'on peut lire @ dans la chaine)
            arobase = mail.LastIndexOf("@");

            //De même pour le point
            point = mail.LastIndexOf(".");

            //La longueur du mail graca a variable.Lenght (resultat en Int)
            longueur = mail.Length;

            //On cherche le domaine, situé entre @ et . donc qui commence un caractère après @ (arobase + 1)
            //et qui fait donc la longueur entre @ et .
            //Donc comme le numéro de sécu, on met Substring pour récupérer les valeurs a partir d'arobase +1, et de la longueur entre le point, et l'arobase+1
            domaine = mail.Substring(arobase + 1, point-(arobase+1));

            //Même chose, sauf que cette fois ci on se sert de la longueur totale pour trouver l'extension
            extension = mail.Substring(point+1, longueur-(point+1));

            //Afficher le résultat
            Console.WriteLine($"Le mail fait {longueur} caractères de longueur \n" +
                $"La position de l'arobase se situe au {arobase}e caractère \n" +
                $"Le domaine est {domaine} avec l'extension {extension}");
        }
    }
}
