using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo3_MesFctString
{
    internal class MesMethodesString
    {
        //On créer une méthode Initiale(nom, prénom)
        public static string Initiales(String nom, String prenom)
        {
            //La méthode d'instance .ToUpper() qu'on applique en même temps que .Substring permet de mettre en CAPS la chaine de caractère
            String initiale = prenom.Substring(0, 1).ToUpper() + "." + nom.Substring(0, 1).ToUpper() + ".";
            return initiale;
        }

        public static string Email(String nom, String prenom)
        {
            //Ici ToLower pour faire l'inverse de ToUpper.
            //Puis par concaténation on rajoute @etu.univ-smb.fr
            String mail = prenom.ToLower() + "." + nom.ToLower() + "@etu.univ-smb.fr";
            return mail;
        }
    }
}
