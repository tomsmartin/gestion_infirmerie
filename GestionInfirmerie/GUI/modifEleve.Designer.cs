namespace GUI
{
    partial class modifEleve
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
            this.btnSup = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblDateNaiss = new System.Windows.Forms.Label();
            this.lblTelPere = new System.Windows.Forms.Label();
            this.lblTelMere = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTelEleve = new System.Windows.Forms.Label();
            this.lblSante = new System.Windows.Forms.Label();
            this.txtTelEleve = new System.Windows.Forms.TextBox();
            this.txtTelPere = new System.Windows.Forms.TextBox();
            this.txtSante = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.txtTelMere = new System.Windows.Forms.TextBox();
            this.btnApp = new System.Windows.Forms.Button();
            this.cbArchive = new System.Windows.Forms.CheckBox();
            this.cbTiersTemps = new System.Windows.Forms.CheckBox();
            this.cbVisite = new System.Windows.Forms.CheckBox();
            this.cbClasse = new System.Windows.Forms.ComboBox();
            this.classeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_infirmerieDataSet1 = new GUI.gestion_infirmerieDataSet1();
            this.dateNaissance = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.classeTableAdapter = new GUI.gestion_infirmerieDataSet1TableAdapters.classeTableAdapter();
            this.errorProviderNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPrenom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTelEl = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTelPere = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTelMere = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.erreurSupEleve = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_infirmerieDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrenom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelEl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelPere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelMere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erreurSupEleve)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSup
            // 
            this.btnSup.Location = new System.Drawing.Point(293, 533);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(141, 48);
            this.btnSup.TabIndex = 1;
            this.btnSup.Text = "Supprimer";
            this.btnSup.UseVisualStyleBackColor = true;
            this.btnSup.Click += new System.EventHandler(this.btnSup_CLick);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(10, 11);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(492, 189);
            this.dgv.TabIndex = 17;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(5, 203);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(61, 24);
            this.lblNom.TabIndex = 21;
            this.lblNom.Text = "Nom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(5, 253);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(87, 24);
            this.lblPrenom.TabIndex = 23;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblDateNaiss
            // 
            this.lblDateNaiss.AutoSize = true;
            this.lblDateNaiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateNaiss.Location = new System.Drawing.Point(5, 301);
            this.lblDateNaiss.Name = "lblDateNaiss";
            this.lblDateNaiss.Size = new System.Drawing.Size(175, 24);
            this.lblDateNaiss.TabIndex = 25;
            this.lblDateNaiss.Text = "Date de naissance :";
            // 
            // lblTelPere
            // 
            this.lblTelPere.AutoSize = true;
            this.lblTelPere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelPere.Location = new System.Drawing.Point(261, 253);
            this.lblTelPere.Name = "lblTelPere";
            this.lblTelPere.Size = new System.Drawing.Size(157, 24);
            this.lblTelPere.TabIndex = 27;
            this.lblTelPere.Text = "Téléphone père :";
            // 
            // lblTelMere
            // 
            this.lblTelMere.AutoSize = true;
            this.lblTelMere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelMere.Location = new System.Drawing.Point(261, 301);
            this.lblTelMere.Name = "lblTelMere";
            this.lblTelMere.Size = new System.Drawing.Size(162, 24);
            this.lblTelMere.TabIndex = 29;
            this.lblTelMere.Text = "Téléphone mère :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(318, 437);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 37;
            // 
            // lblTelEleve
            // 
            this.lblTelEleve.AutoSize = true;
            this.lblTelEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelEleve.Location = new System.Drawing.Point(261, 203);
            this.lblTelEleve.Name = "lblTelEleve";
            this.lblTelEleve.Size = new System.Drawing.Size(164, 24);
            this.lblTelEleve.TabIndex = 39;
            this.lblTelEleve.Text = "Téléphone élève :";
            // 
            // lblSante
            // 
            this.lblSante.AutoSize = true;
            this.lblSante.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSante.Location = new System.Drawing.Point(5, 427);
            this.lblSante.Name = "lblSante";
            this.lblSante.Size = new System.Drawing.Size(68, 24);
            this.lblSante.TabIndex = 41;
            this.lblSante.Text = "Santé :";
            // 
            // txtTelEleve
            // 
            this.txtTelEleve.Location = new System.Drawing.Point(265, 232);
            this.txtTelEleve.Name = "txtTelEleve";
            this.txtTelEleve.Size = new System.Drawing.Size(149, 20);
            this.txtTelEleve.TabIndex = 42;
            // 
            // txtTelPere
            // 
            this.txtTelPere.Location = new System.Drawing.Point(265, 280);
            this.txtTelPere.Name = "txtTelPere";
            this.txtTelPere.Size = new System.Drawing.Size(149, 20);
            this.txtTelPere.TabIndex = 43;
            // 
            // txtSante
            // 
            this.txtSante.Location = new System.Drawing.Point(9, 454);
            this.txtSante.Multiline = true;
            this.txtSante.Name = "txtSante";
            this.txtSante.Size = new System.Drawing.Size(480, 60);
            this.txtSante.TabIndex = 44;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(9, 280);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(149, 20);
            this.txtPrenom.TabIndex = 46;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(9, 230);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(149, 20);
            this.txtNom.TabIndex = 47;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(10, 548);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 48;
            this.textId.Text = "ID eleve";
            this.textId.Visible = false;
            // 
            // txtTelMere
            // 
            this.txtTelMere.Location = new System.Drawing.Point(265, 328);
            this.txtTelMere.Name = "txtTelMere";
            this.txtTelMere.Size = new System.Drawing.Size(149, 20);
            this.txtTelMere.TabIndex = 52;
            // 
            // btnApp
            // 
            this.btnApp.Location = new System.Drawing.Point(96, 533);
            this.btnApp.Name = "btnApp";
            this.btnApp.Size = new System.Drawing.Size(141, 48);
            this.btnApp.TabIndex = 55;
            this.btnApp.Text = "Appliquer";
            this.btnApp.UseVisualStyleBackColor = true;
            this.btnApp.Click += new System.EventHandler(this.btnApp_Click_1);
            // 
            // cbArchive
            // 
            this.cbArchive.AutoSize = true;
            this.cbArchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArchive.Location = new System.Drawing.Point(265, 353);
            this.cbArchive.Name = "cbArchive";
            this.cbArchive.Size = new System.Drawing.Size(93, 28);
            this.cbArchive.TabIndex = 56;
            this.cbArchive.Text = "Archivé";
            this.cbArchive.UseVisualStyleBackColor = true;
            // 
            // cbTiersTemps
            // 
            this.cbTiersTemps.AutoSize = true;
            this.cbTiersTemps.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTiersTemps.Location = new System.Drawing.Point(265, 386);
            this.cbTiersTemps.Name = "cbTiersTemps";
            this.cbTiersTemps.Size = new System.Drawing.Size(225, 28);
            this.cbTiersTemps.TabIndex = 57;
            this.cbTiersTemps.Text = "Possède un tiers temps";
            this.cbTiersTemps.UseVisualStyleBackColor = true;
            // 
            // cbVisite
            // 
            this.cbVisite.AutoSize = true;
            this.cbVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVisite.Location = new System.Drawing.Point(265, 419);
            this.cbVisite.Name = "cbVisite";
            this.cbVisite.Size = new System.Drawing.Size(254, 28);
            this.cbVisite.TabIndex = 58;
            this.cbVisite.Text = "A effectué une/des visite(s)";
            this.cbVisite.UseVisualStyleBackColor = true;
            // 
            // cbClasse
            // 
            this.cbClasse.DataSource = this.classeBindingSource;
            this.cbClasse.DisplayMember = "Libelle_classe";
            this.cbClasse.FormattingEnabled = true;
            this.cbClasse.Location = new System.Drawing.Point(9, 373);
            this.cbClasse.Margin = new System.Windows.Forms.Padding(2);
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Size = new System.Drawing.Size(149, 21);
            this.cbClasse.TabIndex = 60;
            this.cbClasse.ValueMember = "Id_classe";
            // 
            // classeBindingSource
            // 
            this.classeBindingSource.DataMember = "classe";
            this.classeBindingSource.DataSource = this.gestion_infirmerieDataSet1;
            // 
            // gestion_infirmerieDataSet1
            // 
            this.gestion_infirmerieDataSet1.DataSetName = "gestion_infirmerieDataSet1";
            this.gestion_infirmerieDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateNaissance
            // 
            this.dateNaissance.Location = new System.Drawing.Point(9, 327);
            this.dateNaissance.Margin = new System.Windows.Forms.Padding(2);
            this.dateNaissance.Name = "dateNaissance";
            this.dateNaissance.Size = new System.Drawing.Size(151, 20);
            this.dateNaissance.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 62;
            this.label1.Text = "Classe :";
            // 
            // classeTableAdapter
            // 
            this.classeTableAdapter.ClearBeforeFill = true;
            // 
            // errorProviderNom
            // 
            this.errorProviderNom.ContainerControl = this;
            // 
            // errorProviderPrenom
            // 
            this.errorProviderPrenom.ContainerControl = this;
            // 
            // errorProviderTelEl
            // 
            this.errorProviderTelEl.ContainerControl = this;
            // 
            // errorProviderTelPere
            // 
            this.errorProviderTelPere.ContainerControl = this;
            // 
            // errorProviderTelMere
            // 
            this.errorProviderTelMere.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // erreurSupEleve
            // 
            this.erreurSupEleve.ContainerControl = this;
            // 
            // modifEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 583);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateNaissance);
            this.Controls.Add(this.cbClasse);
            this.Controls.Add(this.cbVisite);
            this.Controls.Add(this.cbTiersTemps);
            this.Controls.Add(this.cbArchive);
            this.Controls.Add(this.btnApp);
            this.Controls.Add(this.txtTelMere);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtSante);
            this.Controls.Add(this.txtTelPere);
            this.Controls.Add(this.txtTelEleve);
            this.Controls.Add(this.lblSante);
            this.Controls.Add(this.lblTelEleve);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTelMere);
            this.Controls.Add(this.lblTelPere);
            this.Controls.Add(this.lblDateNaiss);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnSup);
            this.Name = "modifEleve";
            this.Text = "Gestion élève";
            this.Load += new System.EventHandler(this.txtId_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_infirmerieDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrenom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelEl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelPere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelMere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erreurSupEleve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSup;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblDateNaiss;
        private System.Windows.Forms.Label lblTelPere;
        private System.Windows.Forms.Label lblTelMere;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTelEleve;
        private System.Windows.Forms.Label lblSante;
        private System.Windows.Forms.TextBox txtTelEleve;
        private System.Windows.Forms.TextBox txtTelPere;
        private System.Windows.Forms.TextBox txtSante;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox txtTelMere;
        private System.Windows.Forms.Button btnApp;
        private System.Windows.Forms.CheckBox cbArchive;
        private System.Windows.Forms.CheckBox cbTiersTemps;
        private System.Windows.Forms.CheckBox cbVisite;
        private System.Windows.Forms.ComboBox cbClasse;
        private System.Windows.Forms.DateTimePicker dateNaissance;
        private System.Windows.Forms.Label label1;
        private gestion_infirmerieDataSet1 gestion_infirmerieDataSet1;
        private System.Windows.Forms.BindingSource classeBindingSource;
        private gestion_infirmerieDataSet1TableAdapters.classeTableAdapter classeTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProviderNom;
        private System.Windows.Forms.ErrorProvider errorProviderPrenom;
        private System.Windows.Forms.ErrorProvider errorProviderTelEl;
        private System.Windows.Forms.ErrorProvider errorProviderTelPere;
        private System.Windows.Forms.ErrorProvider errorProviderTelMere;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider erreurSupEleve;
    }
}