using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace GestionDeStock.plForm
{
    public partial class FRM_Ajouter_Modifier_Client : Form
    {
        private UserControl usclient;
        public FRM_Ajouter_Modifier_Client(UserControl userC)
        {
            InitializeComponent();
            this.usclient = userC;
        }
        // champ obligatoir 
        string testobligatoir()
        {
            if (txtnc.Text == "" || txtnc.Text == "Nom de Client")
            {
                return "Entrer le Nom de Client";
            }
            if (txtnp.Text == "" || txtnp.Text == "Prenom de Client")
            {
                return "Entrer le Prenom de Client";
            }
            if (txtac.Text == "" || txtac.Text == "Adresse de Client")
            {
                return "Entrer Adresse de Client";

            }
            if (txttc.Text == "" || txttc.Text == "Telephone de Client")
            {
                return "Entrer le Telephone de Client";
            }
            if (txtpc.Text == "" || txtpc.Text == "Pays de Client")
            {
                return "Entrer le Pays de Client";
            }
        
            if (txtmc.Text == "" || txtmc.Text == "Email de Client")
            {
                return "Entrer le Email de Client";
            }

            if (txtvc.Text == "" || txtvc.Text == "Ville de Client")
            {
                return "Entrer Ville de Client";
            }
            // verifier si le email valide ou non 
            if (txtmc.Text!="" || txtmc.Text!= "Email de Client")
            {
                try
                {
                    new MailAddress(txtmc.Text); // verifier si le email valide ou non 

                }
                catch (Exception e)
                {
                    return "Email Invalide ";
                }
            }

            return null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            // pour vider le champ pour ecrire 
            if (txtnc.Text == "Nom de Client")
            {
                txtnc.Text = "";
                txtnc.ForeColor = Color.WhiteSmoke;// changer le couleur de text 
            }
        }

        private void txtnc_Leave(object sender, EventArgs e)
        {
            if (txtnc.Text == "")
            {
                txtnc.Text = "Nom de Client";
                txtnc.ForeColor = Color.Silver;// changer le couleur de text 
            }
        }

        private void txtnp_Enter(object sender, EventArgs e)
        {
            // pour vider le champ pour ecrire 
            if (txtnp.Text == "Prenom de Client")
            {
                txtnp.Text = "";
                txtnp.ForeColor = Color.WhiteSmoke;// changer le couleur de text 
            }
        }

        private void txtnp_Leave(object sender, EventArgs e)
        {
            if (txtnp.Text == "")
            {
                txtnp.Text = "Prenom de Client";
                txtnp.ForeColor = Color.Silver;// changer le couleur de text 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtac_Enter(object sender, EventArgs e)
        {
            if (txtac.Text == "Adresse de Client")
            {
                txtac.Text = "";
                txtac.ForeColor = Color.WhiteSmoke;// changer le couleur de text 
            }
        }

        private void txtac_Leave(object sender, EventArgs e)
        {
            if (txtac.Text == "")
            {
                txtac.Text = "Adresse de Client";
                txtac.ForeColor = Color.Silver;// changer le couleur de text 
            }
        }

        private void txtpc_Enter(object sender, EventArgs e)
        {
            if (txtpc.Text == "Pays de Client")
            {
                txtpc.Text = "";
                txtpc.ForeColor = Color.WhiteSmoke;// changer le couleur de text 
            }
        }

        private void txtpc_Leave(object sender, EventArgs e)
        {
            if (txtpc.Text == "")
            {
                txtpc.Text = "Pays de Client";
                txtpc.ForeColor = Color.Silver;// changer le couleur de text 
            }
        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            if (txttc.Text == "Telephone de Client")
            {
                txttc.Text = "";
                txttc.ForeColor = Color.WhiteSmoke;// changer le couleur de text 
            }
        }

        private void txttc_Leave(object sender, EventArgs e)
        {
            if (txttc.Text == "")
            {
                txttc.Text = "Telephone de Client";
                txttc.ForeColor = Color.Silver;// changer le couleur de text 
            }
        }

        private void txtmc_Enter(object sender, EventArgs e)
        {
            if (txtmc.Text == "Email de Client")
            {
                txtmc.Text = "";
                txtmc.ForeColor = Color.WhiteSmoke;// changer le couleur de text 
            }
        }

        private void txtmc_Leave(object sender, EventArgs e)
        {
            if (txtmc.Text == "")
            {
                txtmc.Text = "Email de Client";
                txtmc.ForeColor = Color.Silver;// changer le couleur de text 
            }
        }

        private void txtvc_Enter(object sender, EventArgs e)
        {
            if (txtvc.Text == "Ville de Client")
            {
                txtvc.Text = "";
                txtvc.ForeColor = Color.WhiteSmoke;// changer le couleur de text 
            }
        }

        private void txtvc_Leave(object sender, EventArgs e)
        {

        }

        private void txtvc_Leave_1(object sender, EventArgs e)
        {
            if (txtvc.Text == "")
            {
                txtvc.Text = "Ville de Client";
                txtvc.ForeColor = Color.Silver;// changer le couleur de text 
            }
        }

        private void txttc_KeyPress(object sender, KeyPressEventArgs e)
        {
            // textbox numerique 
            if (e.KeyChar<48 || e.KeyChar > 57) // code asci numero
            {
                e.Handled = true;
            }
            if (e.KeyChar==8)
            {
                e.Handled = false;
            }
            {
                
            }
        }

        private void FRM_Ajouter_Modifier_Client_Load(object sender, EventArgs e)
        {

        }
        public int IDselect;




        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            if (testobligatoir() != null)
            {
                MessageBox.Show(testobligatoir(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (lbltitre.Text == "Ajouter Client")
            {

                blCLasses.CLS_Client clclient = new blCLasses.CLS_Client();
                if (clclient.Ajouter_Client(txtnc.Text, txtnp.Text, txtac.Text, txttc.Text, txtmc.Text, txtvc.Text, txtpc.Text) == true)
                {
                    MessageBox.Show("Client Ajouter avec Succes", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (usclient as USER_Liste_Client).Actualiserdatagrid();
                }
                else
                {
                    MessageBox.Show("Nom prenom de client deja existe ", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else // si lbltitre = modifier le client  
            {
                blCLasses.CLS_Client clclient = new blCLasses.CLS_Client();
                //USER_Liste_Client user =new USER_Liste_Client();
                DialogResult R= MessageBox.Show("voulez-vous vraiment modifier le client ","Modification",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R== DialogResult.Yes)
                {
                clclient.Modifier_Client(IDselect, txtnc.Text, txtnp.Text, txtac.Text, txttc.Text, txtmc.Text, txtvc.Text, txtpc.Text);
                
                //pour actualiser la database
                (usclient as USER_Liste_Client).Actualiserdatagrid();
                    MessageBox.Show("Client Modifier avec succes","modifcation",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show("Modiifier est annulle","modification",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

            }
        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            // vider les text pour actualiser 
            txtnc.Text = "Nom de Client"; 
            txtnc.ForeColor = Color.Silver;
            txtnp.Text = "Prenom de Client"; 
            txtnp.ForeColor = Color.Silver;
            txtac.Text = "Adresse de Client";
            txtac.ForeColor = Color.Silver;
            txttc.Text = "Telephone de Client";
            txttc.ForeColor = Color.Silver;
            txtvc.Text = "Ville de Client";
            txtvc.ForeColor = Color.Silver;
            txtmc.Text = "Email de Client";
            txtmc.ForeColor = Color.Silver;
            txtpc.Text = "Pays de Client";
            txtpc.ForeColor = Color.Silver;
        }

        private void txtnp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
