using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace GestionDeStock.plForm
{
    public partial class FRM_A_M_Produit : Form
    {
        private GESTION_DE_STOCKEntities db;
        private UserControl userProduit;




        public FRM_A_M_Produit(UserControl user)
        {
            InitializeComponent();
            db = new GESTION_DE_STOCKEntities();
            this .userProduit = user;
            //afficher les categorie dans le comboboxcategorie
            combocategorie.DataSource = db.Categories.ToList();
            // pour filtrer seulment les nom des categorie
            combocategorie.DisplayMember = "Nom_categorie";//affiche les nom des categorie 
            combocategorie.ValueMember = "ID_CATEGORIE";
            this.userProduit = userProduit;
        }
        // champ obligatoir 
        string testobligatoir()
        {
            if (txtnprduit.Text == "" || txtnprduit.Text == "Nom de Produit")
            {
                return "Entrer Nom de Produit";
            }
            if (txtqte.Text == "" || txtqte.Text == "QTE")
            {
                return "Entrer QTE";
            }
            if (txtprix.Text == "" || txtprix.Text == "Prix")
            {
                return "Entrer Prix";
            }
            if (picproduits.Image == null)
            {
                return "Entrer Image de Produit";
            }
            if (combocategorie.Text == "")
            {
                return "Entrer Categorie de Produit";
            }



            return null;
        }


            private void txtnprduit_TextChanged(object sender, EventArgs e)
        {

        }
     

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        //vide
        private void txtnprduit_Enter_1(object sender, EventArgs e)
        {
            // pour vider le champ pour ecrire 
            if (txtnprduit.Text == "Nom de Produit")
            {
                txtnprduit.Text = "";
                txtnprduit.ForeColor = Color.WhiteSmoke;// changer le couleur de text 
            }
        }

        private void txtnprduit_Leave_1(object sender, EventArgs e)
        {
            if (txtnprduit.Text == "")
            {
                txtnprduit.Text = "Nom de Produit";
                txtnprduit.ForeColor = Color.Silver;// changer le couleur de text 
            }
        }

        private void txtqte_Enter_1(object sender, EventArgs e)
        {
            // pour vider le champ pour ecrire 
            if (txtqte.Text == "QTE")
            {
                txtqte.Text = "";
                txtqte.ForeColor = Color.WhiteSmoke;// changer le couleur de text 
            }
        }

        private void txtqte_Leave_1(object sender, EventArgs e)
        {
            if (txtqte.Text == "")
            {
                txtqte.Text = "QTE";
                txtqte.ForeColor = Color.Silver;// changer le couleur de text 
            }
        }

        private void txtprix_Enter_1(object sender, EventArgs e)
        {
            if (txtprix.Text == "Prix")
            {
                txtprix.Text = "";
                txtprix.ForeColor = Color.WhiteSmoke;// changer le couleur de text 
            }
        }

        private void txtprix_Leave_1(object sender, EventArgs e)
        {
            if (txtprix.Text == "")
            {
                txtprix.Text = "Prix";
                txtprix.ForeColor = Color.Silver;// changer le couleur de text 
            }
        }

        private void FRM_A_M_Produit_Load(object sender, EventArgs e)
        {

        }

        private void btnparcourire_Click(object sender, EventArgs e)
        {
            // afficher fichier 
            OpenFileDialog OP=new OpenFileDialog();
            OP.Filter = "|*.JRB;*.PNG;*.GIF;*.BMP";//pour afficher juste les image 
            if (OP.ShowDialog()== DialogResult.OK)
            {
                picproduits.Image = Image.FromFile(OP.FileName);    
            }
        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            // vider le formulaire 
            txtnprduit.Text = "Nom de Produit";
            txtnprduit.ForeColor = Color.Silver;
            txtqte.Text = "QTE";
            txtqte.ForeColor = Color.Silver;
            txtprix.Text = "Prix";
            txtprix.ForeColor = Color.Silver;
            combocategorie.Text = "";
            picproduits.Image = null;

        }

        private void txtqte_KeyPress(object sender, KeyPressEventArgs e)
        {
            // textbox numerique 
            if (e.KeyChar < 48 || e.KeyChar > 57) // code asci numero
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            {

            }
        }

        private void txtprix_KeyPress(object sender, KeyPressEventArgs e)
        {
            // textbox numerique 
            if (e.KeyChar < 48 || e.KeyChar > 57) // code asci numero
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            {

            }
        }

        private void txtprix_TextChanged(object sender, EventArgs e)
        {

        }
        public int IDPRODUIT;
        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            if (testobligatoir()!=null)
            {
                MessageBox.Show(testobligatoir(), "Obligatoir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (lbltitre.Text=="Ajouter Produit")
                {
                    blCLasses.CLS_Produit clproduit = new blCLasses.CLS_Produit();
                    //convertir image en format byte 
                    //ajouter systeme.IO 
                    MemoryStream MR = new MemoryStream();
                    picproduits.Image.Save(MR, picproduits.Image.RawFormat);
                    byte[] byteimageP = MR.ToArray();// convertir image en format byte[]
                    if (clproduit.Ajouter_Produit(txtnprduit.Text,txtqte.Text, txtprix.Text, byteimageP, Convert.ToInt32(combocategorie.SelectedValue))== true)
                    {
                        MessageBox.Show("Produit ajouter avec succes","Ajouter",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (userProduit as USER_Liste_Produit).actualiserdvg();
                    }else
                    {
                        MessageBox.Show("Produits Existe deja", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
                else // modification 
                {
                    MemoryStream MR = new MemoryStream();
                    picproduits.Image.Save(MR, picproduits.Image.RawFormat);
                    byte[] byteimageP = MR.ToArray();// convertir image en format byte[]
                    blCLasses.CLS_Produit clsproduit = new blCLasses.CLS_Produit();
                    DialogResult RS = MessageBox.Show("Volez-vous vraiment modifier","Modification",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (RS == DialogResult.Yes)
                    {
                    clsproduit.Modifier_Produit(IDPRODUIT, txtnprduit.Text,txtqte.Text, txtprix.Text, byteimageP, Convert.ToInt32(combocategorie.SelectedValue));
                    MessageBox.Show("Produit Modifier avec succer","modification",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        // actualiser la datagrid de produits
                        (userProduit as USER_Liste_Produit).actualiserdvg();
                        Close();// pour quitter le formulaire si la modification terminer 


                    }
                    else
                    {
                        MessageBox.Show("Modfication annuler ", "modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
        }
    }
}
