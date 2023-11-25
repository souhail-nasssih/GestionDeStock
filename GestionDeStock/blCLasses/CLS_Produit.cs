using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.blCLasses
{
    internal class CLS_Produit
    {
        private GESTION_DE_STOCKEntities db = new GESTION_DE_STOCKEntities();
        private Produit PR;

        public bool Ajouter_Produit(string NomP, string QteP, string prixP, byte[] ImageP, int idCATEGORIE)//image produits doits etres byte pour sauvgarder dans la database 

        {
            PR= new Produit();
            PR.Nom_produit=NomP;
            PR.Qte_produit=QteP;
            PR.Prix_produit = prixP;
            PR.Image_produit = ImageP;
            PR.ID_CATEGORIE=idCATEGORIE;
            //verifier si le produits deja existe 
            if (db.Produits.SingleOrDefault(a=>a.Nom_produit==NomP)==null)
            {
                db.Produits.Add(PR);
                db.SaveChanges();
                return true;

            }
            else
            {
                return  false;

            }



        }
    }
}
