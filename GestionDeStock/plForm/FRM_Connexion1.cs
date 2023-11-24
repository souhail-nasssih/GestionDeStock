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
    public partial class FRM_Connexion1 : Form
    {
        private GESTION_DE_STOCKEntities db;
        private Form frmmenu;

        // classe de connextion 
        blCLasses.CLS_Connexion C= new blCLasses.CLS_Connexion();

        



        public FRM_Connexion1(Form Menu)
        {
            InitializeComponent();
            this.frmmenu = Menu;
            //inistialiser la base de donner 
            db = new GESTION_DE_STOCKEntities();
        }
        // pour verifier les champ obligatatoir
        string testobligatoir()
        {
            if (txtnom.Text=="" || txtnom.Text== "Nom d'utilisateur")
               
            {
                return "Entrer votre Nom";
            }
            if (txtmotdepasse.Text == "" || txtmotdepasse.Text == "Mot de Passe")

            {
                return "Entrer votre Mot de Passe";
            }
            return null;
        }
        private void FRM_Connexion1_Load(object sender, EventArgs e)
        {

        }

        private void btnfermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnom_Enter(object sender, EventArgs e)
        {
            // pour vider le champ pour ecrire 
            if (txtnom.Text == "Nom d'utilisateur")
            {
                txtnom.Text = "";
                txtnom.ForeColor = Color.WhiteSmoke;// changer le couleur de text 
            }
        }

        private void txtmotdepasse_Enter(object sender, EventArgs e)
        {
            if (txtmotdepasse.Text == "Mot de Passe")
            {
                txtmotdepasse.Text = "";
                txtmotdepasse.UseSystemPasswordChar = false;
                txtmotdepasse.PasswordChar= '*';
                txtmotdepasse.ForeColor = Color.WhiteSmoke;// changer le couleur de text 
            }
        }

        private void txtmotdepasse_Leave(object sender, EventArgs e)
        {
            if (txtmotdepasse.Text == "")
            {
                txtmotdepasse.Text = "Mot de Passe";
                txtmotdepasse.UseSystemPasswordChar= true;//desactiver passwordchar
                txtmotdepasse.ForeColor = Color.Silver;// changer le couleur de text 
            }
        }

        private void txtnom_Leave(object sender, EventArgs e)
        {
            if (txtnom.Text == "")
            {
                txtnom.Text = "Nom d'utilisateur";
                txtnom.ForeColor = Color.Silver;// changer le couleur de text 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (testobligatoir()==null)
            {
                if (C.ConneionValide(db,txtnom.Text,txtmotdepasse.Text)==true)//utilisateurs existe
                {
                    MessageBox.Show("Connexion a reussi", " Connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (frmmenu as FRM_Menu).activerFrom();
                    this.Close();// quitter le form de connxion 
                }
                else // false si existe pas
                {
                    MessageBox.Show("Connexion a echoue", " Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show(testobligatoir(),"Obligatoire",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
