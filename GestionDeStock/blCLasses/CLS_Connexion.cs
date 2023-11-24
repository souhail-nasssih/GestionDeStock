using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.blCLasses
{
    internal class CLS_Connexion
    {
        // function pour verifier la connection 
        public bool ConneionValide(GESTION_DE_STOCKEntities db, string Nom, string Mot_De_Passe)
        {
            utilisateur U = new utilisateur();
            U.Nom_utilisateur = Nom;
            U.Mot_De_Passe = Mot_De_Passe;
            if (db.utilisateurs.SingleOrDefault(s => s.Nom_utilisateur == Nom && s.Mot_De_Passe == Mot_De_Passe) != null)// si le nom de l utilisateurs et le mots de passe existe dans la base de donner 

            {
                return true;
            }
            else // si n existe pas
            {
                return false;
            }
            {

            }


        }
    }
}
