internal class Program
{
    //Void main : C'est notre code principal
    static void Main(string[] args)
    {
        Program.AfficheBonjour();
        String prenom = "Noé";
        String nom = "Bidule";
        Program.AfficheBonjour(prenom);
        Program.AfficheBonjour(prenom, nom);
        Program.AfficheBonjourAvecDate(prenom, nom);
    }

    //public state void AfficheBonjour() est une fonction qu'on vient définir nous même. Plus on en fait, plus il y aura de charges.

    //Simple affichage bonjour : pas besoin de variables en entrée.
    public static void AfficheBonjour()
    {
        Console.WriteLine("Bonjour");
    }

    //Affichage bonjour avec prénom : On entre dans les parenthèse une variable String nommé prenom.
    public static void AfficheBonjour(String prenom)
    {
        Console.WriteLine("Bonjour " + prenom);
    }

    //Affichage bonjour avec prénom & nom : On entre dans les parenthèse une variable String nommé prenom et une autre nommé nom.
    public static void AfficheBonjour(String prenom, String nom)
    {
        Console.WriteLine("Bonjour " + nom + " " + prenom);
    }

    //Nouvelle fonction (on a ajouté dans le nom "AvecDate") qui prends la même base que la précédente, a laquelle on rajoute un DateTime.
    //Ce DateTime, je prends sa valeur now (date + heure actuelle a l'éxécution du code) puis je l'affiche en séléctionnant les propriétés 
    //"ToLongDateString()" --> Affiche la date d'aujourd'hui en long, puis "ToShortTimeString()" pour afficher l'here actuelle format réduit
    public static void AfficheBonjourAvecDate(String prenom, String nom)
    {
        DateTime date = DateTime.Now;
        Console.WriteLine("Bonjour " + nom + " " + prenom + ", on est le " + date.ToLongDateString() + " et il est " + date.ToShortTimeString());
    }

    
}