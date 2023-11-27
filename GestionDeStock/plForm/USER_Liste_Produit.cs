using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        //verifier combien de ligne est selectionner 
        public string selecVerif()
        {
            int nombreligneselect = 0;
            for (int i = 0; i < dvgProduit.Rows.Count; i++)
            {
                if ((bool)dvgProduit.Rows[i].Cells[0].Value == true)//si ligne est selectionner 
                {
                    nombreligneselect++;//nombre de liogne +1
                }
            }
            if (nombreligneselect == 0)
            {
                return "Selectionner Produit ";
            }
            if (nombreligneselect > 1)
            {
                return "Selectionner un seule Produit ";
            }
            return null;
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
            Produit PR = new Produit();
            if (selecVerif()!=null)
            {
                MessageBox.Show(selecVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
            plForm.FRM_A_M_Produit frmproduit = new FRM_A_M_Produit(this);
            frmproduit.lbltitre.Text = "Modifier Produit";
            frmproduit.btnactualiser.Visible = false;
                for (int i = 0; i < dvgProduit.Rows.Count; i++)//verifier la ligne selectionner 
                {

                    if ((bool)dvgProduit.Rows[i].Cells[0].Value == true)// si ligne selectionner 
                    {
                        int MYIDSELECT = (int)dvgProduit.Rows[i].Cells[1].Value;// le id la ligne selectionner 
                        PR = db.Produits.SingleOrDefault(s => s.id_produit == MYIDSELECT); // verifier si id de produit = id selectionner dans le table 
                        if (PR != null)
                        {
                        frmproduit.combocategorie.Text = dvgProduit.Rows[i].Cells[5].Value.ToString();
                        frmproduit.txtnprduit.Text= dvgProduit.Rows[i].Cells[2].Value.ToString();
                        frmproduit.txtqte.Text = dvgProduit.Rows[i].Cells[3].Value.ToString();
                        frmproduit.txtprix.Text = dvgProduit.Rows[i].Cells[4].Value.ToString();
                        frmproduit.IDPRODUIT=(int)dvgProduit.Rows[i].Cells[1].Value;

                            //afficher image de produit pour la modifier 
                        MemoryStream MS = new MemoryStream(PR.Image_produit);//pour covertir image de produits pour afficher dans la picture de produits 
                        frmproduit.picproduits.Image=Image.FromStream(MS);
                        }
                    }
                
            }
            frmproduit.ShowDialog();
        }}

        private void dvgProduit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnafficher_Click(object sender, EventArgs e)
        {
            Produit PR = new Produit();
            if (selecVerif()!=null)
            {
                MessageBox.Show(selecVerif(), "selectionner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for(int i = 0; i < dvgProduit.Rows.Count; i++) {

                    if ((bool)dvgProduit.Rows[i].Cells[0].Value==true)// si ligne selectionner 
                    {
                        int MYIDSELECT = (int)dvgProduit.Rows[i].Cells[1].Value;// le id la ligne selectionner 
                       PR = db.Produits.SingleOrDefault(s=>s.id_produit==MYIDSELECT); // verifier si id de produit = id selectionner dans le table 
                        if (PR!=null )
                        {
                            FRM_Photo_Produit frmP = new FRM_Photo_Produit();
                            // declarer le systeme.IO
                            MemoryStream MS = new MemoryStream(PR.Image_produit);//pour covertir image de produits pour afficher dans la picture de produits 
                            frmP.ProduitImage.Image=Image.FromStream(MS);
                            frmP.ProduitNom.Text = dvgProduit.Rows[i].Cells[2].Value.ToString();
                            //afficher formullaire
                            frmP.ShowDialog();

                        }
                    }


                }
            }
        }

        private void btnsupprimerp_Click(object sender, EventArgs e)
        {
            if (selecVerif()== "Selectionner Produit ")// verifier si le produits est selectionner
            {
                MessageBox.Show(selecVerif(), "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult DR = MessageBox.Show("Voulez-vous Supprimer", "Suppression",MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (DR == DialogResult.Yes)
                {
                // verifier combien de ligne selectionner 
                for(int i = 0; i < dvgProduit.Rows.Count; i++)
                {
                        
                        if ((bool)dvgProduit.Rows[i].Cells[0].Value == true)// si ligne cocher 
                        {
                            blCLasses.CLS_Produit clproduit = new blCLasses.CLS_Produit();
                        int idselect = (int)dvgProduit.Rows[i].Cells[1].Value;
                        clproduit.Supprimer_Produit(idselect);
                    }
                }
                    // actualiser la tableau de produit
                    actualiserdvg();
                    MessageBox.Show("Produit Supprimer avec succes ", "Supression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); 
                }
                else
                {
                    MessageBox.Show("Supression anuller ", "Supression", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }
    }
}
