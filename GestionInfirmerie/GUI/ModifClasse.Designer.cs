namespace GUI
{
    partial class modifClasse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modifClasse));
            this.errorNomClasse = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbPossedeEDT = new System.Windows.Forms.CheckBox();
            this.errorSuppClasse = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAfficheEDT = new System.Windows.Forms.Button();
            this.btnFrmAjoutClasse = new System.Windows.Forms.Button();
            this.cbPossedeEleve = new System.Windows.Forms.CheckBox();
            this.txtEDT = new System.Windows.Forms.TextBox();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblNomClasse = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.pdfReaderEDT = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.errorNomClasse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSuppClasse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfReaderEDT)).BeginInit();
            this.SuspendLayout();
            // 
            // errorNomClasse
            // 
            this.errorNomClasse.ContainerControl = this;
            // 
            // cbPossedeEDT
            // 
            this.cbPossedeEDT.AutoSize = true;
            this.cbPossedeEDT.Location = new System.Drawing.Point(216, 198);
            this.cbPossedeEDT.Name = "cbPossedeEDT";
            this.cbPossedeEDT.Size = new System.Drawing.Size(103, 17);
            this.cbPossedeEDT.TabIndex = 26;
            this.cbPossedeEDT.Text = "Emploi du temps";
            this.cbPossedeEDT.UseVisualStyleBackColor = true;
            // 
            // errorSuppClasse
            // 
            this.errorSuppClasse.ContainerControl = this;
            // 
            // btnAfficheEDT
            // 
            this.btnAfficheEDT.Location = new System.Drawing.Point(227, 244);
            this.btnAfficheEDT.Name = "btnAfficheEDT";
            this.btnAfficheEDT.Size = new System.Drawing.Size(75, 26);
            this.btnAfficheEDT.TabIndex = 25;
            this.btnAfficheEDT.Text = "Afficher";
            this.btnAfficheEDT.UseVisualStyleBackColor = true;
            this.btnAfficheEDT.Click += new System.EventHandler(this.btnAfficheEDT_Click);
            // 
            // btnFrmAjoutClasse
            // 
            this.btnFrmAjoutClasse.Location = new System.Drawing.Point(238, 4);
            this.btnFrmAjoutClasse.Name = "btnFrmAjoutClasse";
            this.btnFrmAjoutClasse.Size = new System.Drawing.Size(112, 23);
            this.btnFrmAjoutClasse.TabIndex = 24;
            this.btnFrmAjoutClasse.Text = "Ajouter une classe";
            this.btnFrmAjoutClasse.UseVisualStyleBackColor = true;
            this.btnFrmAjoutClasse.Click += new System.EventHandler(this.btnFrmAjoutClasse_Click);
            // 
            // cbPossedeEleve
            // 
            this.cbPossedeEleve.AutoSize = true;
            this.cbPossedeEleve.Location = new System.Drawing.Point(183, 276);
            this.cbPossedeEleve.Name = "cbPossedeEleve";
            this.cbPossedeEleve.Size = new System.Drawing.Size(150, 17);
            this.cbPossedeEleve.TabIndex = 23;
            this.cbPossedeEleve.Text = "Elève(s) dans cette classe";
            this.cbPossedeEleve.UseVisualStyleBackColor = true;
            // 
            // txtEDT
            // 
            this.txtEDT.Location = new System.Drawing.Point(227, 221);
            this.txtEDT.Name = "txtEDT";
            this.txtEDT.Size = new System.Drawing.Size(64, 20);
            this.txtEDT.TabIndex = 22;
            this.txtEDT.Visible = false;
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(212, 299);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(107, 37);
            this.btnSupp.TabIndex = 21;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(29, 299);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(105, 37);
            this.btnModif.TabIndex = 20;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            this.btnModif.Validated += new System.EventHandler(this.btnModif_Validated);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(3, 273);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(60, 20);
            this.txtId.TabIndex = 19;
            this.txtId.Text = "ID CLASSE";
            this.txtId.Visible = false;
            // 
            // lblNomClasse
            // 
            this.lblNomClasse.AutoSize = true;
            this.lblNomClasse.Location = new System.Drawing.Point(26, 199);
            this.lblNomClasse.Name = "lblNomClasse";
            this.lblNomClasse.Size = new System.Drawing.Size(37, 13);
            this.lblNomClasse.TabIndex = 18;
            this.lblNomClasse.Text = "Libelle";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(3, 233);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 17;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 33);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(307, 149);
            this.dgv.TabIndex = 16;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // pdfReaderEDT
            // 
            this.pdfReaderEDT.Enabled = true;
            this.pdfReaderEDT.Location = new System.Drawing.Point(408, 4);
            this.pdfReaderEDT.Name = "pdfReaderEDT";
            this.pdfReaderEDT.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfReaderEDT.OcxState")));
            this.pdfReaderEDT.Size = new System.Drawing.Size(952, 475);
            this.pdfReaderEDT.TabIndex = 27;
            // 
            // modifClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 482);
            this.Controls.Add(this.pdfReaderEDT);
            this.Controls.Add(this.cbPossedeEDT);
            this.Controls.Add(this.btnAfficheEDT);
            this.Controls.Add(this.btnFrmAjoutClasse);
            this.Controls.Add(this.cbPossedeEleve);
            this.Controls.Add(this.txtEDT);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblNomClasse);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.dgv);
            this.Name = "modifClasse";
            this.Text = "ModifClasse";
            ((System.ComponentModel.ISupportInitialize)(this.errorNomClasse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSuppClasse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfReaderEDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorNomClasse;
        private System.Windows.Forms.CheckBox cbPossedeEDT;
        private System.Windows.Forms.Button btnAfficheEDT;
        private System.Windows.Forms.Button btnFrmAjoutClasse;
        private System.Windows.Forms.CheckBox cbPossedeEleve;
        private System.Windows.Forms.TextBox txtEDT;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNomClasse;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ErrorProvider errorSuppClasse;
        private AxAcroPDFLib.AxAcroPDF pdfReaderEDT;

    }
}