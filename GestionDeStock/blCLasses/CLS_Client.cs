using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.blCLasses
{
    internal class CLS_Client
    {
        private GESTION_DE_STOCKEntities db = new GESTION_DE_STOCKEntities();
        private Client C; //table client

        // function pour ajouter un client dans la datbbase
        public bool Ajouter_Client(string Nom, string Prenom, string Adresse, string Telephone, string Email, string Ville, string Pays)
        {
            C = new Client();
            C.Nom_client = Nom;
            C.Prenom_client = Prenom;
            C.Adress_client = Adresse;
            C.TEl_client = Telephone;
            C.Email_Client = Email;
            C.Ville_client = Ville;
            C.Pays_client = Pays;
            // verifier le nom et le prenom existe dans la database 
            if (db.Clients.SingleOrDefault(s => s.Nom_client == Nom && C.Prenom_client == Prenom) == null) // si n existe pas

            {
                db.Clients.Add(C);// ajouter dans la table de cleints
                db.SaveChanges();// enregistrer dans la database
                return true;
            }
            else// si existe dans la table clients

            {
                return false;
            }

        }

        // function pour ajouter un client dans la datbbase
        public void Modifier_Client(int id,string Nom , string Prenom,string Adresse, string Telephone, string Email, string Ville,string Pays)
        {
            C= new Client();
            C = db.Clients.SingleOrDefault(s => s.id_client == id);//verifier si id de client existe
            if (C!=null)//existe 
            {
                C.Nom_client = Nom;//nouveau nom de clients
                C.Prenom_client= Prenom;//nouveau Prenom de clients
                C.Adress_client= Adresse;
                C.TEl_client = Telephone;
                C.Email_Client= Email;
                C.Pays_client = Pays;
                C.Ville_client = Ville;
                db.SaveChanges ();// sauvgarder les nouveau information dans la data base 
            }


        }

        // function pour SUPPRIMER un client dans la datbbase
        public void Suprimer_Client(int id)
        {
            C = new Client();
            C = db.Clients.SingleOrDefault(s => s.id_client == id);//verifier si id de client existe
            if (C != null)//existe 
            {
                db.Clients.Remove(C);// pour supprimer le client 

                db.SaveChanges();// sauvgarder les nouveau information dans la data base 
            }


        }

    }
}
