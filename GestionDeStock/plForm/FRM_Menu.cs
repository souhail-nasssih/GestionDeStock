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
    public partial class FRM_Menu : Form
    {
        public FRM_Menu()
        {
            InitializeComponent();
            panel1.Size = new Size(233, 523);
            panelpara.Visible = false;
        }
        //desactiver le formulaire
        public void desactiverFrom()
        {
            btnClient.Enabled = false;  
            btnproduits.Enabled = false;
            btncategorie.Enabled = false;
            btncomnande.Enabled = false;
            btnutilisateur.Enabled = false;
            btncopie.Enabled = false;
            btnrestaurer.Enabled = false;
            btndeconnecter.Enabled = false;
            panelm.Enabled = false;
            // btn de connextion 
            btnconnecter.Enabled = true;
        }
        public void activerFrom()
        {
            btnClient.Enabled = true;
            btnproduits.Enabled = true;
            btncategorie.Enabled = true;
            btncomnande.Enabled = true;
            btnutilisateur.Enabled = true;
            btncopie.Enabled = true;
            btnrestaurer.Enabled = true;
            btndeconnecter.Enabled = true;
            panelm.Enabled = true;

            btnconnecter.Enabled = false;
            panelpara.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelm.Top = btncategorie.Top;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void FRM_Menu_Load(object sender, EventArgs e)
        {
            desactiverFrom();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 233)
            {
                panel1.Size = new Size(77, 523);
            }
            else
            {
                panel1.Size = new Size(233, 523);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnproduits_Click(object sender, EventArgs e)
        {
            panelm.Top=btnproduits.Top;
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            panelm.Top= btnClient.Top;
            if (!pnlaficher.Controls.Contains(USER_Liste_Client.Instance))
            {
                pnlaficher.Controls.Add(USER_Liste_Client.Instance);
                USER_Liste_Client.Instance.Dock = DockStyle.Fill;
                USER_Liste_Client.Instance.BringToFront();
            }
            else
            {
                USER_Liste_Client.Instance.BringToFront();
            }
        }

        private void btncomnande_Click(object sender, EventArgs e)
        {
            panelm.Top = btncomnande.Top;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelm.Top = btnutilisateur.Top;

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // afficher le formulaire de connextion 
            FRM_Connexion1 frmC = new FRM_Connexion1(this);//this = FRM_menu
            frmC.ShowDialog();
        }

        private void panelpara_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            panelpara.Size = new Size(348, 226);
            panelpara.Visible = !panelpara.Visible;
        }

  

        private void btndeconnecter_Click_1(object sender, EventArgs e)
        {
            desactiverFrom();

        }

        private void btnconnecter_Click_1(object sender, EventArgs e)
        {
            // afficher le formulaire de connextion 
            FRM_Connexion1 frmC = new FRM_Connexion1(this);//this = FRM_menu
            frmC.ShowDialog();
        }
    }
}
