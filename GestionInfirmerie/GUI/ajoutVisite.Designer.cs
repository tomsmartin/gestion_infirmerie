namespace GUI
{
    partial class ajoutVisite
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
            this.classeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dateVisite = new System.Windows.Forms.DateTimePicker();
            this.parentsVisite = new System.Windows.Forms.CheckBox();
            this.hopitalVisite = new System.Windows.Forms.CheckBox();
            this.domicileVisite = new System.Windows.Forms.CheckBox();
            this.btnApp = new System.Windows.Forms.Button();
            this.poulsVisite = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblSante = new System.Windows.Forms.Label();
            this.lblTelEleve = new System.Windows.Forms.Label();
            this.comVisite = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTelMere = new System.Windows.Forms.Label();
            this.lblTelPere = new System.Windows.Forms.Label();
            this.lblDateNaiss = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.errorMotif = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorArrivee = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDepart = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPrenom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPouls = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rechercheNom = new System.Windows.Forms.TextBox();
            this.heureArriveVisite = new System.Windows.Forms.DateTimePicker();
            this.heureDepartVisite = new System.Windows.Forms.DateTimePicker();
            this.medicamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbMedic = new System.Windows.Forms.Label();
            this.qteMedic = new System.Windows.Forms.Label();
            this.qteMedics = new System.Windows.Forms.TextBox();
            this.medicamentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.medicamentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.medicamentBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_infirmerieDataSet3 = new GUI.gestion_infirmerieDataSet3();
            this.gestion_infirmerieDataSet2 = new GUI.gestion_infirmerieDataSet2();
            this.motifVisite = new System.Windows.Forms.TextBox();
            this.medicamentTableAdapter = new GUI.gestion_infirmerieDataSet3TableAdapters.medicamentTableAdapter();
            this.errorQteMedic = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMotif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorArrivee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrenom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPouls)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_infirmerieDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_infirmerieDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorQteMedic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 86;
            this.label1.Text = "Motif visite :";
            // 
            // dateVisite
            // 
            this.dateVisite.Location = new System.Drawing.Point(106, 393);
            this.dateVisite.Margin = new System.Windows.Forms.Padding(2);
            this.dateVisite.Name = "dateVisite";
            this.dateVisite.Size = new System.Drawing.Size(151, 20);
            this.dateVisite.TabIndex = 85;
            this.dateVisite.Value = new System.DateTime(2018, 3, 29, 22, 29, 33, 0);
            // 
            // parentsVisite
            // 
            this.parentsVisite.AutoSize = true;
            this.parentsVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentsVisite.Location = new System.Drawing.Point(362, 485);
            this.parentsVisite.Name = "parentsVisite";
            this.parentsVisite.Size = new System.Drawing.Size(176, 28);
            this.parentsVisite.TabIndex = 83;
            this.parentsVisite.Text = "Parents prévenus";
            this.parentsVisite.UseVisualStyleBackColor = true;
            // 
            // hopitalVisite
            // 
            this.hopitalVisite.AutoSize = true;
            this.hopitalVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hopitalVisite.Location = new System.Drawing.Point(362, 452);
            this.hopitalVisite.Name = "hopitalVisite";
            this.hopitalVisite.Size = new System.Drawing.Size(87, 28);
            this.hopitalVisite.TabIndex = 82;
            this.hopitalVisite.Text = "Hopital";
            this.hopitalVisite.UseVisualStyleBackColor = true;
            // 
            // domicileVisite
            // 
            this.domicileVisite.AutoSize = true;
            this.domicileVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domicileVisite.Location = new System.Drawing.Point(362, 419);
            this.domicileVisite.Name = "domicileVisite";
            this.domicileVisite.Size = new System.Drawing.Size(161, 28);
            this.domicileVisite.TabIndex = 81;
            this.domicileVisite.Text = "Retour domicile";
            this.domicileVisite.UseVisualStyleBackColor = true;
            // 
            // btnApp
            // 
            this.btnApp.Location = new System.Drawing.Point(262, 712);
            this.btnApp.Name = "btnApp";
            this.btnApp.Size = new System.Drawing.Size(141, 48);
            this.btnApp.TabIndex = 80;
            this.btnApp.Text = "Ajouter une visite";
            this.btnApp.UseVisualStyleBackColor = true;
            this.btnApp.Click += new System.EventHandler(this.btnApp_Click);
            // 
            // poulsVisite
            // 
            this.poulsVisite.Location = new System.Drawing.Point(362, 394);
            this.poulsVisite.Name = "poulsVisite";
            this.poulsVisite.Size = new System.Drawing.Size(149, 20);
            this.poulsVisite.TabIndex = 79;
            this.poulsVisite.Enter += new System.EventHandler(this.poulsVisite_Enter);
            this.poulsVisite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.poulsVisite_KeyPress);
            this.poulsVisite.Leave += new System.EventHandler(this.poulsVisite_Leave);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(109, 727);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 78;
            this.textId.Text = "ID eleve";
            this.textId.Visible = false;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(106, 296);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(149, 20);
            this.txtNom.TabIndex = 77;
            // 
            // lblSante
            // 
            this.lblSante.AutoSize = true;
            this.lblSante.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSante.Location = new System.Drawing.Point(104, 606);
            this.lblSante.Name = "lblSante";
            this.lblSante.Size = new System.Drawing.Size(138, 24);
            this.lblSante.TabIndex = 72;
            this.lblSante.Text = "Commentaire  :";
            // 
            // lblTelEleve
            // 
            this.lblTelEleve.AutoSize = true;
            this.lblTelEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelEleve.Location = new System.Drawing.Point(358, 269);
            this.lblTelEleve.Name = "lblTelEleve";
            this.lblTelEleve.Size = new System.Drawing.Size(150, 24);
            this.lblTelEleve.TabIndex = 71;
            this.lblTelEleve.Text = "Heure d\'arrivée :";
            // 
            // comVisite
            // 
            this.comVisite.Location = new System.Drawing.Point(108, 633);
            this.comVisite.Multiline = true;
            this.comVisite.Name = "comVisite";
            this.comVisite.Size = new System.Drawing.Size(480, 60);
            this.comVisite.TabIndex = 75;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(106, 346);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(149, 20);
            this.txtPrenom.TabIndex = 76;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(415, 503);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 70;
            // 
            // lblTelMere
            // 
            this.lblTelMere.AutoSize = true;
            this.lblTelMere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelMere.Location = new System.Drawing.Point(358, 367);
            this.lblTelMere.Name = "lblTelMere";
            this.lblTelMere.Size = new System.Drawing.Size(67, 24);
            this.lblTelMere.TabIndex = 69;
            this.lblTelMere.Text = "Pouls :";
            // 
            // lblTelPere
            // 
            this.lblTelPere.AutoSize = true;
            this.lblTelPere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelPere.Location = new System.Drawing.Point(358, 319);
            this.lblTelPere.Name = "lblTelPere";
            this.lblTelPere.Size = new System.Drawing.Size(158, 24);
            this.lblTelPere.TabIndex = 68;
            this.lblTelPere.Text = "Heure de départ :";
            // 
            // lblDateNaiss
            // 
            this.lblDateNaiss.AutoSize = true;
            this.lblDateNaiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateNaiss.Location = new System.Drawing.Point(102, 367);
            this.lblDateNaiss.Name = "lblDateNaiss";
            this.lblDateNaiss.Size = new System.Drawing.Size(131, 24);
            this.lblDateNaiss.TabIndex = 67;
            this.lblDateNaiss.Text = "Date de visite :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(102, 319);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(87, 24);
            this.lblPrenom.TabIndex = 66;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(102, 269);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(61, 24);
            this.lblNom.TabIndex = 65;
            this.lblNom.Text = "Nom :";
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
            this.dgv.Location = new System.Drawing.Point(107, 77);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(492, 189);
            this.dgv.TabIndex = 64;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // errorMotif
            // 
            this.errorMotif.ContainerControl = this;
            // 
            // errorArrivee
            // 
            this.errorArrivee.ContainerControl = this;
            // 
            // errorDepart
            // 
            this.errorDepart.ContainerControl = this;
            // 
            // errorNom
            // 
            this.errorNom.ContainerControl = this;
            // 
            // errorPrenom
            // 
            this.errorPrenom.ContainerControl = this;
            // 
            // errorPouls
            // 
            this.errorPouls.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rechercheNom);
            this.groupBox1.Location = new System.Drawing.Point(261, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(188, 63);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche par nom d\'élève";
            // 
            // rechercheNom
            // 
            this.rechercheNom.Location = new System.Drawing.Point(4, 28);
            this.rechercheNom.Margin = new System.Windows.Forms.Padding(2);
            this.rechercheNom.Name = "rechercheNom";
            this.rechercheNom.Size = new System.Drawing.Size(174, 20);
            this.rechercheNom.TabIndex = 2;
            this.rechercheNom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rechercheNom_KeyUp);
            // 
            // heureArriveVisite
            // 
            this.heureArriveVisite.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.heureArriveVisite.Location = new System.Drawing.Point(362, 296);
            this.heureArriveVisite.Name = "heureArriveVisite";
            this.heureArriveVisite.ShowUpDown = true;
            this.heureArriveVisite.Size = new System.Drawing.Size(200, 20);
            this.heureArriveVisite.TabIndex = 89;
            // 
            // heureDepartVisite
            // 
            this.heureDepartVisite.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.heureDepartVisite.Location = new System.Drawing.Point(362, 346);
            this.heureDepartVisite.Name = "heureDepartVisite";
            this.heureDepartVisite.ShowUpDown = true;
            this.heureDepartVisite.Size = new System.Drawing.Size(200, 20);
            this.heureDepartVisite.TabIndex = 90;
            // 
            // medicamentBindingSource
            // 
            this.medicamentBindingSource.DataMember = "medicament";
            // 
            // cbMedic
            // 
            this.cbMedic.AutoSize = true;
            this.cbMedic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedic.Location = new System.Drawing.Point(103, 476);
            this.cbMedic.Name = "cbMedic";
            this.cbMedic.Size = new System.Drawing.Size(133, 24);
            this.cbMedic.TabIndex = 92;
            this.cbMedic.Text = "Médicaments :";
            // 
            // qteMedic
            // 
            this.qteMedic.AutoSize = true;
            this.qteMedic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qteMedic.Location = new System.Drawing.Point(104, 527);
            this.qteMedic.Name = "qteMedic";
            this.qteMedic.Size = new System.Drawing.Size(161, 24);
            this.qteMedic.TabIndex = 93;
            this.qteMedic.Text = "Quantité donnée :";
            // 
            // qteMedics
            // 
            this.qteMedics.Location = new System.Drawing.Point(106, 566);
            this.qteMedics.Name = "qteMedics";
            this.qteMedics.Size = new System.Drawing.Size(149, 20);
            this.qteMedics.TabIndex = 94;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.medicamentBindingSource3;
            this.comboBox1.DisplayMember = "Libelle_medicament";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 503);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 95;
            this.comboBox1.ValueMember = "Id_medicament";
            // 
            // medicamentBindingSource3
            // 
            this.medicamentBindingSource3.DataMember = "medicament";
            this.medicamentBindingSource3.DataSource = this.gestion_infirmerieDataSet3;
            // 
            // gestion_infirmerieDataSet3
            // 
            this.gestion_infirmerieDataSet3.DataSetName = "gestion_infirmerieDataSet3";
            this.gestion_infirmerieDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestion_infirmerieDataSet2
            // 
            this.gestion_infirmerieDataSet2.DataSetName = "gestion_infirmerieDataSet2";
            this.gestion_infirmerieDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // motifVisite
            // 
            this.motifVisite.Location = new System.Drawing.Point(106, 452);
            this.motifVisite.Name = "motifVisite";
            this.motifVisite.Size = new System.Drawing.Size(149, 20);
            this.motifVisite.TabIndex = 87;
            // 
            // medicamentTableAdapter
            // 
            this.medicamentTableAdapter.ClearBeforeFill = true;
            // 
            // errorQteMedic
            // 
            this.errorQteMedic.ContainerControl = this;
            // 
            // ajoutVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 765);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.qteMedics);
            this.Controls.Add(this.qteMedic);
            this.Controls.Add(this.cbMedic);
            this.Controls.Add(this.heureDepartVisite);
            this.Controls.Add(this.heureArriveVisite);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.motifVisite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateVisite);
            this.Controls.Add(this.parentsVisite);
            this.Controls.Add(this.hopitalVisite);
            this.Controls.Add(this.domicileVisite);
            this.Controls.Add(this.btnApp);
            this.Controls.Add(this.poulsVisite);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblSante);
            this.Controls.Add(this.lblTelEleve);
            this.Controls.Add(this.comVisite);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTelMere);
            this.Controls.Add(this.lblTelPere);
            this.Controls.Add(this.lblDateNaiss);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.dgv);
            this.Name = "ajoutVisite";
            this.Text = "ajoutVisite";
            this.Load += new System.EventHandler(this.ajoutVisite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMotif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorArrivee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrenom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPouls)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_infirmerieDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_infirmerieDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorQteMedic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource classeBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateVisite;
        private System.Windows.Forms.CheckBox parentsVisite;
        private System.Windows.Forms.CheckBox hopitalVisite;
        private System.Windows.Forms.CheckBox domicileVisite;
        private System.Windows.Forms.Button btnApp;
        private System.Windows.Forms.TextBox poulsVisite;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblSante;
        private System.Windows.Forms.Label lblTelEleve;
        private System.Windows.Forms.TextBox comVisite;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTelMere;
        private System.Windows.Forms.Label lblTelPere;
        private System.Windows.Forms.Label lblDateNaiss;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ErrorProvider errorMotif;
        private System.Windows.Forms.ErrorProvider errorArrivee;
        private System.Windows.Forms.ErrorProvider errorDepart;
        private System.Windows.Forms.ErrorProvider errorNom;
        private System.Windows.Forms.ErrorProvider errorPrenom;
        private System.Windows.Forms.ErrorProvider errorPouls;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox rechercheNom;
        private System.Windows.Forms.DateTimePicker heureArriveVisite;
        private System.Windows.Forms.DateTimePicker heureDepartVisite;
        private System.Windows.Forms.BindingSource medicamentBindingSource;
        private System.Windows.Forms.TextBox qteMedics;
        private System.Windows.Forms.Label qteMedic;
        private System.Windows.Forms.Label cbMedic;
        private System.Windows.Forms.BindingSource medicamentBindingSource1;
        private System.Windows.Forms.BindingSource medicamentBindingSource2;
        private System.Windows.Forms.ComboBox comboBox1;
        private gestion_infirmerieDataSet2 gestion_infirmerieDataSet2;
        private System.Windows.Forms.TextBox motifVisite;
        private gestion_infirmerieDataSet3 gestion_infirmerieDataSet3;
        private System.Windows.Forms.BindingSource medicamentBindingSource3;
        private gestion_infirmerieDataSet3TableAdapters.medicamentTableAdapter medicamentTableAdapter;
        private System.Windows.Forms.ErrorProvider errorQteMedic;
    }
}