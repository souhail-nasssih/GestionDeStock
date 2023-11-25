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

    public partial class USER_Liste_Client : UserControl
    {
        private static USER_Liste_Client Userclient;
        private GESTION_DE_STOCKEntities db;
        //creer une instance pour les usercontrolw
        public static USER_Liste_Client Instance {
            get
            {
                if (Userclient == null)
                {
                    Userclient = new USER_Liste_Client();
                }
                return Userclient;
            }
        
        }
       



        public USER_Liste_Client()
        {
            InitializeComponent();
            db = new GESTION_DE_STOCKEntities();
            // desactive texbox de recherche 
            txtrecherche.Enabled = false;
        }
        //ajouter datagridview
        public void Actualiserdatagrid()
        {
            db = new GESTION_DE_STOCKEntities();
            dvgclient.Rows.Clear();//vider la datagrid
            foreach(var s in db.Clients)
            {
                // ajouter un clients dans le datagrid
               dvgclient.Rows.Add(false,s.id_client,s.Nom_client,s.Prenom_client,s.Adress_client,s.TEl_client, s.Email_Client, s.Ville_client, s.Pays_client);
            } 
        }
        //verifier combien de ligne est selectionner 
        public string selecVerif()
        {
            int nombreligneselect = 0;
            for (int i = 0; i < dvgclient.Rows.Count; i++)
            {
                if ((bool)dvgclient.Rows[i].Cells[0].Value==true)//si ligne est selectionner 
                {
                    nombreligneselect++;//nombre de liogne +1
                }
            }
            if (nombreligneselect==0)
            {
                return "Selectionner le Client Que vous-voulez Modifier ";
            }
            if (nombreligneselect > 1)
            {
                return "Selectionner un seule ligne  Que vous-voulez Modifier ";
            }
            return null;
        }


        private void USER_Liste_Client_Load(object sender, EventArgs e)
        {
            Actualiserdatagrid();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            db = new GESTION_DE_STOCKEntities();
            var listerecherche = db.Clients.ToList();//listerechcher = liste des clients
            if (txtrecherche.Text!="")// pas vide 
            {
                switch (comborecherche.Text)
                {
                    case "Nom":
                        listerecherche=listerecherche.Where(s=>s.Nom_client.IndexOf(txtrecherche.Text,StringComparison.CurrentCultureIgnoreCase)!=-1).ToList();
                        //stringComparaison.CurrentCultureIgnoreCase == sois j'ai ecrit la premiere lettre en majuscule ou bien minusculle  
                        // !=-1 existe dans la database 
                        break;
                    case "Prenom":
                        listerecherche = listerecherche.Where(s => s.Prenom_client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();

                        break;
                    case "Telephone":
                        listerecherche = listerecherche.Where(s => s.TEl_client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();

                        break;
                    case "Adresse":
                    listerecherche = listerecherche.Where(s => s.Adress_client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();

                    break;
                    case "Email":
                        listerecherche = listerecherche.Where(s => s.Email_Client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();

                        break;
                    case "Ville":
                        listerecherche = listerecherche.Where(s => s.Ville_client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                     
                        break;
                    case "Pays":
                        listerecherche = listerecherche.Where(s => s.Pays_client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                      
                        break;
                 

                }
            }
            // vider la grid
            dvgclient.Rows.Clear();
            //ajouter listerecherche dans la datagrid clients 
            foreach (var l in listerecherche)
            {
                dvgclient.Rows.Add(false, l.id_client, l.Nom_client, l.Prenom_client, l.Adress_client,l.TEl_client,l.Email_Client,l.Ville_client,l.Pays_client) ;                
            }

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtrecherche.Text=="Recherche")
            {
                txtrecherche.Text = "";
                txtrecherche.ForeColor = Color.Black;
            }
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            //afficher formulaire de saisie
            plForm.FRM_Ajouter_Modifier_Client frmclient = new FRM_Ajouter_Modifier_Client(this);
            frmclient.ShowDialog();

        }

        //public int IDselect;

        private void bntmodifier_Click(object sender, EventArgs e)
        {
            plForm.FRM_Ajouter_Modifier_Client frmclient = new plForm.FRM_Ajouter_Modifier_Client(this);
            if(selecVerif()== null)
            {
                for(int i = 0; i < dvgclient.Rows.Count; i++)
                {
                    if ((bool)dvgclient.Rows[i].Cells[0].Value==true)//si le chekbox est vrai affiche les information dans le formulair de clients

                    {
                        frmclient.IDselect = (int)dvgclient.Rows[i].Cells[1].Value;
                        frmclient.txtnc.Text = dvgclient.Rows[i].Cells[2].Value.ToString();
                        frmclient.txtnp.Text = dvgclient.Rows[i].Cells[3].Value.ToString();
                        frmclient.txtac.Text = dvgclient.Rows[i].Cells[4].Value.ToString();
                        frmclient.txttc.Text = dvgclient.Rows[i].Cells[5].Value.ToString();
                        frmclient.txtmc.Text = dvgclient.Rows[i].Cells[6].Value.ToString();
                        frmclient.txtvc.Text = dvgclient.Rows[i].Cells[7].Value.ToString();
                        frmclient.txtpc.Text = dvgclient.Rows[i].Cells[8].Value.ToString();


                    }
                }
                    frmclient.lbltitre.Text = "Modifier le Client";
                    frmclient.btnactualiser.Visible = false;
                    frmclient.ShowDialog();
            }
            else
            {
                MessageBox.Show(selecVerif(),"Modification",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void dvgclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            blCLasses.CLS_Client clclient = new blCLasses.CLS_Client();
            // pour supprimer tous les clients selectionner 
           int select = 0;
            for (int i = 0; i < dvgclient.Rows.Count; i++)
            {
                if ((bool)dvgclient.Rows[i].Cells[0].Value==true)
                {
                    select++;      // combien de ligne a ete selectionner              
                }
            }
            if (select==0)
            {
                MessageBox.Show("Aucun client selectionner", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                DialogResult R = MessageBox.Show("Voulez-vous Vraiment Supprimer ", "Suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    // pour supprimer tous les clients selectionnez 
                    for (int i = 0; i < dvgclient.Rows.Count; i++)
                    {
                        if ((bool)dvgclient.Rows[i].Cells[0].Value == true)
                        {
                            clclient.Suprimer_Client(int.Parse(dvgclient.Rows[i].Cells[1].Value.ToString())); // id client 

                        }
                    }
                    //actualiser datagrid 
                    Actualiserdatagrid();
                    MessageBox.Show("Suppresion Effectuer", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        
                }
                else
                {
                    MessageBox.Show("Suppresion et Annuler", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void comborecherche_SelectedIndexChanged(object sender, EventArgs e)
        {
            //activer le textbox recherche si j ai choisie un champ
            txtrecherche.Enabled = true;
            txtrecherche.Text = "";//pour vider le textbox de recherch 
        }
    }
}
