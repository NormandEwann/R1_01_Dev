using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo4_LocationVelo
{
    
    internal class LocVelo
    {
        //Variables statiques
        static readonly int VELO_VILLE = 4, VTT = 5, VELO_ELECTRIQUE = 8, AGE_MINI = 18;
        static readonly decimal REDUCTION = 0.15m;
        
        //Méthode CalculePeixLocation(nbHeures, age, typeVelo)
        public static decimal CalculePrixLocation(int nbHeures, int age, string typeVelo)
        {
            //selon le type de velo
            decimal prixLocation = 0m;
            if (typeVelo == "V")
            {
                prixLocation = nbHeures * VELO_VILLE;
            }
            else if (typeVelo == "VTT")
            {
                prixLocation = nbHeures * VTT;
            }
            else
            {
                prixLocation = nbHeures * VELO_ELECTRIQUE;
            }

            //Réduction ou pas
            if (age < AGE_MINI)
            {
                prixLocation = prixLocation - (prixLocation * REDUCTION);
            }
            return prixLocation;
        }
    }
}
