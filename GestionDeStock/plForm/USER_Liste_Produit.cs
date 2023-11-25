using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock.plForm
{
    public partial class USER_Liste_Produit : UserControl
    {
        private static USER_Liste_Produit Userclient;
        private GESTION_DE_STOCKEntities db;
        //creer une instance pour les usercontrolw
        public static USER_Liste_Produit Instance
        {
            get
            {
                if (Userclient == null)
                {
                    Userclient = new USER_Liste_Produit();
                }
                return Userclient;
            }

        }
        //actualiser le tableau de prosuits
        public void actualiserdvg()
        {
            db = new GESTION_DE_STOCKEntities();
            dvgProduit.Rows.Clear();
            // Pour aficher le Nom de categorie a partir de idcategorie
            Categorie Cat = new Categorie();
            foreach (var lis in db.Produits)
            {
                Cat = db.Categories.SingleOrDefault(s => s.ID_CATEGORIE == lis.ID_CATEGORIE); //si idcategorie dans le table de prosuit == idcategorie dans la categorie 
                if (Cat!=null) //si existe 
                {
                    dvgProduit.Rows.Add(false, lis.id_produit, lis.Nom_produit, lis.Qte_produit, lis.Prix_produit, Cat.Nom_categorie);//cat com de categorie pour afficher le nom de categorie


                }
            }
        }


        public USER_Liste_Produit()
        {
            InitializeComponent();
            db = new GESTION_DE_STOCKEntities();
        }

        private void USER_Liste_Produit_Load(object sender, EventArgs e)
        {
            actualiserdvg();
        }

        private void txtrecherche_Enter(object sender, EventArgs e)
        {
            if (txtrecherche.Text == "Recherche")
            {
                txtrecherche.Text = "";
                txtrecherche.ForeColor = Color.Black;
            }
        }

        private void btnajouterp_Click(object sender, EventArgs e)
        {
            plForm.FRM_A_M_Produit frmProduit = new plForm.FRM_A_M_Produit(this);
            frmProduit.ShowDialog();
        }

        private void bntmodifierp_Click(object sender, EventArgs e)
        {
            plForm.FRM_A_M_Produit frmproduit = new FRM_A_M_Produit(this);
            frmproduit.lbltitre.Text = "Modifier Produit";
            frmproduit.btnactualiser.Visible = false;
            frmproduit.ShowDialog();
        }

        private void dvgProduit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
