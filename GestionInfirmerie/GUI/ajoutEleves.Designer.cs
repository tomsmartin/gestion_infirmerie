namespace GUI
{
    partial class ajoutEleves
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
            this.label8 = new System.Windows.Forms.Label();
            this.dateNaissance = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelMere = new System.Windows.Forms.TextBox();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbClasse = new System.Windows.Forms.ComboBox();
            this.classeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_infirmerieDataSet1 = new GUI.gestion_infirmerieDataSet1();
            this.classeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_infirmerieDataSet = new GUI.gestion_infirmerieDataSet();
            this.txtTelEleve = new System.Windows.Forms.TextBox();
            this.txtTelPere = new System.Windows.Forms.TextBox();
            this.txtSante = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.classeTableAdapter = new GUI.gestion_infirmerieDataSetTableAdapters.classeTableAdapter();
            this.classeTableAdapter1 = new GUI.gestion_infirmerieDataSet1TableAdapters.classeTableAdapter();
            this.errorProviderNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPrenom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTelEl = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTelPere = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTelMere = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_infirmerieDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_infirmerieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrenom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelEl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelPere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelMere)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 24);
            this.label8.TabIndex = 97;
            this.label8.Text = "Date de naissance:";
            // 
            // dateNaissance
            // 
            this.dateNaissance.Location = new System.Drawing.Point(12, 181);
            this.dateNaissance.Name = "dateNaissance";
            this.dateNaissance.Size = new System.Drawing.Size(257, 20);
            this.dateNaissance.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(310, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 24);
            this.label7.TabIndex = 93;
            this.label7.Text = "Téléphone mère:";
            // 
            // txtTelMere
            // 
            this.txtTelMere.Location = new System.Drawing.Point(316, 114);
            this.txtTelMere.Name = "txtTelMere";
            this.txtTelMere.Size = new System.Drawing.Size(257, 20);
            this.txtTelMere.TabIndex = 92;
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enregistrer.Location = new System.Drawing.Point(241, 388);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(168, 40);
            this.btn_enregistrer.TabIndex = 91;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.UseVisualStyleBackColor = true;
            this.btn_enregistrer.Click += new System.EventHandler(this.btn_enregistrer_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 24);
            this.label6.TabIndex = 90;
            this.label6.Text = "Téléphone élève:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(310, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 24);
            this.label5.TabIndex = 89;
            this.label5.Text = "Téléphone Père:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 88;
            this.label4.Text = "Santé:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 87;
            this.label3.Text = "Classe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 86;
            this.label2.Text = "Prenom:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 85;
            this.label1.Text = "Nom:";
            // 
            // cbClasse
            // 
            this.cbClasse.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.classeBindingSource1, "Id_classe", true));
            this.cbClasse.DataSource = this.classeBindingSource1;
            this.cbClasse.DisplayMember = "Libelle_classe";
            this.cbClasse.FormattingEnabled = true;
            this.cbClasse.Location = new System.Drawing.Point(180, 256);
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Size = new System.Drawing.Size(257, 21);
            this.cbClasse.TabIndex = 84;
            this.cbClasse.ValueMember = "Id_classe";
            // 
            // classeBindingSource1
            // 
            this.classeBindingSource1.DataMember = "classe";
            this.classeBindingSource1.DataSource = this.gestion_infirmerieDataSet1;
            // 
            // gestion_infirmerieDataSet1
            // 
            this.gestion_infirmerieDataSet1.DataSetName = "gestion_infirmerieDataSet1";
            this.gestion_infirmerieDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classeBindingSource
            // 
            this.classeBindingSource.DataMember = "classe";
            this.classeBindingSource.DataSource = this.gestion_infirmerieDataSet;
            // 
            // gestion_infirmerieDataSet
            // 
            this.gestion_infirmerieDataSet.DataSetName = "gestion_infirmerieDataSet";
            this.gestion_infirmerieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTelEleve
            // 
            this.txtTelEleve.Location = new System.Drawing.Point(316, 183);
            this.txtTelEleve.Name = "txtTelEleve";
            this.txtTelEleve.Size = new System.Drawing.Size(257, 20);
            this.txtTelEleve.TabIndex = 83;
            // 
            // txtTelPere
            // 
            this.txtTelPere.Location = new System.Drawing.Point(316, 46);
            this.txtTelPere.Name = "txtTelPere";
            this.txtTelPere.Size = new System.Drawing.Size(257, 20);
            this.txtTelPere.TabIndex = 82;
            // 
            // txtSante
            // 
            this.txtSante.Location = new System.Drawing.Point(12, 314);
            this.txtSante.Multiline = true;
            this.txtSante.Name = "txtSante";
            this.txtSante.Size = new System.Drawing.Size(599, 68);
            this.txtSante.TabIndex = 81;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(12, 114);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(257, 20);
            this.txtPrenom.TabIndex = 80;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(12, 46);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(257, 20);
            this.txtNom.TabIndex = 79;
            // 
            // classeTableAdapter
            // 
            this.classeTableAdapter.ClearBeforeFill = true;
            // 
            // classeTableAdapter1
            // 
            this.classeTableAdapter1.ClearBeforeFill = true;
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
            // ajoutEleves
            // 
            this.ClientSize = new System.Drawing.Size(623, 436);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateNaissance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTelMere);
            this.Controls.Add(this.btn_enregistrer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbClasse);
            this.Controls.Add(this.txtTelEleve);
            this.Controls.Add(this.txtTelPere);
            this.Controls.Add(this.txtSante);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Name = "ajoutEleves";
            this.Text = "Ajout élève";
            this.Load += new System.EventHandler(this.ajoutEleves_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_infirmerieDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_infirmerieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrenom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelEl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelPere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelMere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateNaissance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelMere;
        private System.Windows.Forms.Button btn_enregistrer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClasse;
        private System.Windows.Forms.BindingSource classeBindingSource;
        private gestion_infirmerieDataSet gestion_infirmerieDataSet;
        private System.Windows.Forms.TextBox txtTelEleve;
        private System.Windows.Forms.TextBox txtTelPere;
        private System.Windows.Forms.TextBox txtSante;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private gestion_infirmerieDataSetTableAdapters.classeTableAdapter classeTableAdapter;
        private gestion_infirmerieDataSet1 gestion_infirmerieDataSet1;
        private System.Windows.Forms.BindingSource classeBindingSource1;
        private gestion_infirmerieDataSet1TableAdapters.classeTableAdapter classeTableAdapter1;
        private System.Windows.Forms.ErrorProvider errorProviderNom;
        private System.Windows.Forms.ErrorProvider errorProviderPrenom;
        private System.Windows.Forms.ErrorProvider errorProviderTelEl;
        private System.Windows.Forms.ErrorProvider errorProviderTelPere;
        private System.Windows.Forms.ErrorProvider errorProviderTelMere;
    }
}