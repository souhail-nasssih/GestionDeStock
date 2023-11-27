namespace GestionDeStock.plForm
{
    partial class USER_Liste_Produit
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dvgProduit = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comborecherche = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnexcel = new System.Windows.Forms.Button();
            this.bntimprimertout = new System.Windows.Forms.Button();
            this.btnimpromer = new System.Windows.Forms.Button();
            this.btnafficher = new System.Windows.Forms.Button();
            this.btnsupprimerp = new System.Windows.Forms.Button();
            this.bntmodifierp = new System.Windows.Forms.Button();
            this.btnajouterp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgProduit
            // 
            this.dvgProduit.AllowUserToAddRows = false;
            this.dvgProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgProduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgProduit.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgProduit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgProduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dvgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6});
            this.dvgProduit.EnableHeadersVisualStyles = false;
            this.dvgProduit.Location = new System.Drawing.Point(21, 231);
            this.dvgProduit.Name = "dvgProduit";
            this.dvgProduit.RowHeadersVisible = false;
            this.dvgProduit.RowHeadersWidth = 51;
            this.dvgProduit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgProduit.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dvgProduit.RowTemplate.Height = 24;
            this.dvgProduit.Size = new System.Drawing.Size(1292, 380);
            this.dvgProduit.TabIndex = 18;
            this.dvgProduit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgProduit_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "select";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Id";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "QTE";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prix";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Categorie";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // comborecherche
            // 
            this.comborecherche.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comborecherche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comborecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comborecherche.FormattingEnabled = true;
            this.comborecherche.Items.AddRange(new object[] {
            "Nom",
            "Categorie"});
            this.comborecherche.Location = new System.Drawing.Point(287, 161);
            this.comborecherche.Name = "comborecherche";
            this.comborecherche.Size = new System.Drawing.Size(341, 37);
            this.comborecherche.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel4.Location = new System.Drawing.Point(662, 203);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(395, 3);
            this.panel4.TabIndex = 16;
            // 
            // txtrecherche
            // 
            this.txtrecherche.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtrecherche.BackColor = System.Drawing.SystemColors.Control;
            this.txtrecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrecherche.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrecherche.ForeColor = System.Drawing.Color.DimGray;
            this.txtrecherche.Location = new System.Drawing.Point(662, 155);
            this.txtrecherche.Multiline = true;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(395, 42);
            this.txtrecherche.TabIndex = 15;
            this.txtrecherche.Text = "Recherche";
            this.txtrecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtrecherche.Enter += new System.EventHandler(this.txtrecherche_Enter);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel3.Location = new System.Drawing.Point(21, 212);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1292, 3);
            this.panel3.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(21, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 3);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1292, 3);
            this.panel2.TabIndex = 4;
            // 
            // btnexcel
            // 
            this.btnexcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnexcel.FlatAppearance.BorderSize = 0;
            this.btnexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnexcel.Image = global::GestionDeStock.Properties.Resources.Excel_icon1;
            this.btnexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexcel.Location = new System.Drawing.Point(883, 617);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(430, 71);
            this.btnexcel.TabIndex = 22;
            this.btnexcel.Text = "    Sauvgarder dans Excel";
            this.btnexcel.UseVisualStyleBackColor = false;
            // 
            // bntimprimertout
            // 
            this.bntimprimertout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bntimprimertout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.bntimprimertout.FlatAppearance.BorderSize = 0;
            this.bntimprimertout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntimprimertout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntimprimertout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntimprimertout.Image = global::GestionDeStock.Properties.Resources.Imprimer2;
            this.bntimprimertout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntimprimertout.Location = new System.Drawing.Point(451, 617);
            this.bntimprimertout.Name = "bntimprimertout";
            this.bntimprimertout.Size = new System.Drawing.Size(408, 71);
            this.bntimprimertout.TabIndex = 21;
            this.bntimprimertout.Text = "Imprimet toutes";
            this.bntimprimertout.UseVisualStyleBackColor = false;
            // 
            // btnimpromer
            // 
            this.btnimpromer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnimpromer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnimpromer.FlatAppearance.BorderSize = 0;
            this.btnimpromer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimpromer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimpromer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnimpromer.Image = global::GestionDeStock.Properties.Resources.Imprimer1;
            this.btnimpromer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimpromer.Location = new System.Drawing.Point(21, 617);
            this.btnimpromer.Name = "btnimpromer";
            this.btnimpromer.Size = new System.Drawing.Size(407, 71);
            this.btnimpromer.TabIndex = 20;
            this.btnimpromer.Text = "    Imprimer PR cocher";
            this.btnimpromer.UseVisualStyleBackColor = false;
            // 
            // btnafficher
            // 
            this.btnafficher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnafficher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnafficher.FlatAppearance.BorderSize = 0;
            this.btnafficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnafficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnafficher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnafficher.Image = global::GestionDeStock.Properties.Resources.Pictures_icon1;
            this.btnafficher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnafficher.Location = new System.Drawing.Point(1002, 35);
            this.btnafficher.Name = "btnafficher";
            this.btnafficher.Size = new System.Drawing.Size(311, 71);
            this.btnafficher.TabIndex = 19;
            this.btnafficher.Text = "     Afficher Photo";
            this.btnafficher.UseVisualStyleBackColor = false;
            this.btnafficher.Click += new System.EventHandler(this.btnafficher_Click);
            // 
            // btnsupprimerp
            // 
            this.btnsupprimerp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsupprimerp.AutoEllipsis = true;
            this.btnsupprimerp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnsupprimerp.FlatAppearance.BorderSize = 0;
            this.btnsupprimerp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsupprimerp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimerp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsupprimerp.Image = global::GestionDeStock.Properties.Resources.Close_2_icon;
            this.btnsupprimerp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsupprimerp.Location = new System.Drawing.Point(684, 35);
            this.btnsupprimerp.Name = "btnsupprimerp";
            this.btnsupprimerp.Size = new System.Drawing.Size(312, 71);
            this.btnsupprimerp.TabIndex = 12;
            this.btnsupprimerp.Text = "Supprimer";
            this.btnsupprimerp.UseVisualStyleBackColor = false;
            this.btnsupprimerp.Click += new System.EventHandler(this.btnsupprimerp_Click);
            // 
            // bntmodifierp
            // 
            this.bntmodifierp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bntmodifierp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.bntmodifierp.FlatAppearance.BorderSize = 0;
            this.bntmodifierp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntmodifierp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntmodifierp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntmodifierp.Image = global::GestionDeStock.Properties.Resources.Recycle_iconaaa;
            this.bntmodifierp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntmodifierp.Location = new System.Drawing.Point(347, 35);
            this.bntmodifierp.Name = "bntmodifierp";
            this.bntmodifierp.Size = new System.Drawing.Size(320, 71);
            this.bntmodifierp.TabIndex = 11;
            this.bntmodifierp.Text = "Modifier";
            this.bntmodifierp.UseVisualStyleBackColor = false;
            this.bntmodifierp.Click += new System.EventHandler(this.bntmodifierp_Click);
            // 
            // btnajouterp
            // 
            this.btnajouterp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnajouterp.FlatAppearance.BorderSize = 0;
            this.btnajouterp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouterp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouterp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnajouterp.Image = global::GestionDeStock.Properties.Resources.Actions_list_add_icon;
            this.btnajouterp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajouterp.Location = new System.Drawing.Point(21, 35);
            this.btnajouterp.Name = "btnajouterp";
            this.btnajouterp.Size = new System.Drawing.Size(320, 71);
            this.btnajouterp.TabIndex = 10;
            this.btnajouterp.Text = "Ajouter";
            this.btnajouterp.UseVisualStyleBackColor = false;
            this.btnajouterp.Click += new System.EventHandler(this.btnajouterp_Click);
            // 
            // USER_Liste_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.bntimprimertout);
            this.Controls.Add(this.btnimpromer);
            this.Controls.Add(this.btnafficher);
            this.Controls.Add(this.dvgProduit);
            this.Controls.Add(this.comborecherche);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsupprimerp);
            this.Controls.Add(this.bntmodifierp);
            this.Controls.Add(this.btnajouterp);
            this.Name = "USER_Liste_Produit";
            this.Size = new System.Drawing.Size(1333, 720);
            this.Load += new System.EventHandler(this.USER_Liste_Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgProduit;
        private System.Windows.Forms.ComboBox comborecherche;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnsupprimerp;
        private System.Windows.Forms.Button bntmodifierp;
        private System.Windows.Forms.Button btnajouterp;
        private System.Windows.Forms.Button btnafficher;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Button bntimprimertout;
        private System.Windows.Forms.Button btnimpromer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
