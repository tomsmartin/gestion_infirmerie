namespace GUI
{
    partial class modifVisite
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.validerBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.dateTxt = new System.Windows.Forms.DateTimePicker();
            this.poulsTxt = new System.Windows.Forms.TextBox();
            this.motifTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.domicileCk = new System.Windows.Forms.CheckBox();
            this.prevenuCk = new System.Windows.Forms.CheckBox();
            this.hopitalCk = new System.Windows.Forms.CheckBox();
            this.commentaireTxt = new System.Windows.Forms.TextBox();
            this.eleveId = new System.Windows.Forms.TextBox();
            this.visiteID = new System.Windows.Forms.TextBox();
            this.prenomTxt = new System.Windows.Forms.TextBox();
            this.nomTxt = new System.Windows.Forms.TextBox();
            this.errorMotif = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEntree = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSortie = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPouls = new System.Windows.Forms.ErrorProvider(this.components);
            this.entreeTxt = new System.Windows.Forms.DateTimePicker();
            this.sortieTxt = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.qteMedics = new System.Windows.Forms.TextBox();
            this.qteMedic = new System.Windows.Forms.Label();
            this.cbMedic = new System.Windows.Forms.Label();
            this.gestion_infirmerieDataSet2 = new GUI.gestion_infirmerieDataSet2();
            this.medicamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicamentTableAdapter = new GUI.gestion_infirmerieDataSet2TableAdapters.medicamentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMotif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEntree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSortie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPouls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_infirmerieDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dgv.Location = new System.Drawing.Point(56, 12);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(492, 189);
            this.dgv.TabIndex = 65;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // validerBtn
            // 
            this.validerBtn.Location = new System.Drawing.Point(244, 404);
            this.validerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.validerBtn.Name = "validerBtn";
            this.validerBtn.Size = new System.Drawing.Size(132, 60);
            this.validerBtn.TabIndex = 66;
            this.validerBtn.Text = "Modifier";
            this.validerBtn.UseVisualStyleBackColor = true;
            this.validerBtn.Click += new System.EventHandler(this.validerBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 76;
            this.label5.Text = "Pouls : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 75;
            this.label4.Text = "Heure sortie :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 74;
            this.label3.Text = "Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 73;
            this.label2.Text = "Heure entré :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(59, 227);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(59, 24);
            this.lblNom.TabIndex = 72;
            this.lblNom.Text = "Motif :";
            // 
            // dateTxt
            // 
            this.dateTxt.Location = new System.Drawing.Point(56, 439);
            this.dateTxt.Margin = new System.Windows.Forms.Padding(2);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(151, 20);
            this.dateTxt.TabIndex = 71;
            // 
            // poulsTxt
            // 
            this.poulsTxt.Location = new System.Drawing.Point(56, 392);
            this.poulsTxt.Margin = new System.Windows.Forms.Padding(2);
            this.poulsTxt.Name = "poulsTxt";
            this.poulsTxt.Size = new System.Drawing.Size(151, 20);
            this.poulsTxt.TabIndex = 70;
            this.poulsTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.poulsTxt_KeyPress);
            // 
            // motifTxt
            // 
            this.motifTxt.Location = new System.Drawing.Point(56, 253);
            this.motifTxt.Margin = new System.Windows.Forms.Padding(2);
            this.motifTxt.Name = "motifTxt";
            this.motifTxt.Size = new System.Drawing.Size(151, 20);
            this.motifTxt.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 81;
            this.label1.Text = "Commentaire :";
            // 
            // domicileCk
            // 
            this.domicileCk.AutoSize = true;
            this.domicileCk.Location = new System.Drawing.Point(244, 386);
            this.domicileCk.Margin = new System.Windows.Forms.Padding(2);
            this.domicileCk.Name = "domicileCk";
            this.domicileCk.Size = new System.Drawing.Size(99, 17);
            this.domicileCk.TabIndex = 80;
            this.domicileCk.Text = "Retour domicile";
            this.domicileCk.UseVisualStyleBackColor = true;
            // 
            // prevenuCk
            // 
            this.prevenuCk.AutoSize = true;
            this.prevenuCk.Location = new System.Drawing.Point(244, 357);
            this.prevenuCk.Margin = new System.Windows.Forms.Padding(2);
            this.prevenuCk.Name = "prevenuCk";
            this.prevenuCk.Size = new System.Drawing.Size(99, 17);
            this.prevenuCk.TabIndex = 79;
            this.prevenuCk.Text = "Parent prevenu";
            this.prevenuCk.UseVisualStyleBackColor = true;
            // 
            // hopitalCk
            // 
            this.hopitalCk.AutoSize = true;
            this.hopitalCk.Location = new System.Drawing.Point(244, 325);
            this.hopitalCk.Margin = new System.Windows.Forms.Padding(2);
            this.hopitalCk.Name = "hopitalCk";
            this.hopitalCk.Size = new System.Drawing.Size(59, 17);
            this.hopitalCk.TabIndex = 78;
            this.hopitalCk.Text = "Hopital";
            this.hopitalCk.UseVisualStyleBackColor = true;
            // 
            // commentaireTxt
            // 
            this.commentaireTxt.Location = new System.Drawing.Point(244, 251);
            this.commentaireTxt.Margin = new System.Windows.Forms.Padding(2);
            this.commentaireTxt.Multiline = true;
            this.commentaireTxt.Name = "commentaireTxt";
            this.commentaireTxt.Size = new System.Drawing.Size(241, 69);
            this.commentaireTxt.TabIndex = 77;
            // 
            // eleveId
            // 
            this.eleveId.Location = new System.Drawing.Point(552, 488);
            this.eleveId.Name = "eleveId";
            this.eleveId.Size = new System.Drawing.Size(100, 20);
            this.eleveId.TabIndex = 83;
            this.eleveId.Text = "ID eleve";
            this.eleveId.Visible = false;
            // 
            // visiteID
            // 
            this.visiteID.Location = new System.Drawing.Point(552, 512);
            this.visiteID.Name = "visiteID";
            this.visiteID.Size = new System.Drawing.Size(100, 20);
            this.visiteID.TabIndex = 82;
            this.visiteID.Text = "visiteID";
            this.visiteID.Visible = false;
            // 
            // prenomTxt
            // 
            this.prenomTxt.Location = new System.Drawing.Point(511, 286);
            this.prenomTxt.Margin = new System.Windows.Forms.Padding(2);
            this.prenomTxt.Name = "prenomTxt";
            this.prenomTxt.Size = new System.Drawing.Size(151, 20);
            this.prenomTxt.TabIndex = 85;
            // 
            // nomTxt
            // 
            this.nomTxt.Location = new System.Drawing.Point(511, 253);
            this.nomTxt.Margin = new System.Windows.Forms.Padding(2);
            this.nomTxt.Name = "nomTxt";
            this.nomTxt.Size = new System.Drawing.Size(151, 20);
            this.nomTxt.TabIndex = 84;
            // 
            // errorMotif
            // 
            this.errorMotif.ContainerControl = this;
            // 
            // errorEntree
            // 
            this.errorEntree.ContainerControl = this;
            // 
            // errorSortie
            // 
            this.errorSortie.ContainerControl = this;
            // 
            // errorPouls
            // 
            this.errorPouls.ContainerControl = this;
            // 
            // entreeTxt
            // 
            this.entreeTxt.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.entreeTxt.Location = new System.Drawing.Point(56, 297);
            this.entreeTxt.Name = "entreeTxt";
            this.entreeTxt.ShowUpDown = true;
            this.entreeTxt.Size = new System.Drawing.Size(151, 20);
            this.entreeTxt.TabIndex = 90;
            // 
            // sortieTxt
            // 
            this.sortieTxt.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.sortieTxt.Location = new System.Drawing.Point(56, 347);
            this.sortieTxt.Name = "sortieTxt";
            this.sortieTxt.ShowUpDown = true;
            this.sortieTxt.Size = new System.Drawing.Size(151, 20);
            this.sortieTxt.TabIndex = 91;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.medicamentBindingSource;
            this.comboBox1.DisplayMember = "Libelle_medicament";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(427, 362);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 99;
            this.comboBox1.ValueMember = "Id_medicament";
            // 
            // qteMedics
            // 
            this.qteMedics.Location = new System.Drawing.Point(424, 425);
            this.qteMedics.Name = "qteMedics";
            this.qteMedics.Size = new System.Drawing.Size(149, 20);
            this.qteMedics.TabIndex = 98;
            // 
            // qteMedic
            // 
            this.qteMedic.AutoSize = true;
            this.qteMedic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qteMedic.Location = new System.Drawing.Point(422, 386);
            this.qteMedic.Name = "qteMedic";
            this.qteMedic.Size = new System.Drawing.Size(161, 24);
            this.qteMedic.TabIndex = 97;
            this.qteMedic.Text = "Quantité donnée :";
            // 
            // cbMedic
            // 
            this.cbMedic.AutoSize = true;
            this.cbMedic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedic.Location = new System.Drawing.Point(421, 335);
            this.cbMedic.Name = "cbMedic";
            this.cbMedic.Size = new System.Drawing.Size(133, 24);
            this.cbMedic.TabIndex = 96;
            this.cbMedic.Text = "Médicaments :";
            // 
            // gestion_infirmerieDataSet2
            // 
            this.gestion_infirmerieDataSet2.DataSetName = "gestion_infirmerieDataSet2";
            this.gestion_infirmerieDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicamentBindingSource
            // 
            this.medicamentBindingSource.DataMember = "medicament";
            this.medicamentBindingSource.DataSource = this.gestion_infirmerieDataSet2;
            // 
            // medicamentTableAdapter
            // 
            this.medicamentTableAdapter.ClearBeforeFill = true;
            // 
            // modifVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 579);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.qteMedics);
            this.Controls.Add(this.qteMedic);
            this.Controls.Add(this.cbMedic);
            this.Controls.Add(this.sortieTxt);
            this.Controls.Add(this.entreeTxt);
            this.Controls.Add(this.prenomTxt);
            this.Controls.Add(this.nomTxt);
            this.Controls.Add(this.eleveId);
            this.Controls.Add(this.visiteID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.domicileCk);
            this.Controls.Add(this.prevenuCk);
            this.Controls.Add(this.hopitalCk);
            this.Controls.Add(this.commentaireTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.dateTxt);
            this.Controls.Add(this.poulsTxt);
            this.Controls.Add(this.motifTxt);
            this.Controls.Add(this.validerBtn);
            this.Controls.Add(this.dgv);
            this.Name = "modifVisite";
            this.Text = "modifVisite";
            this.Load += new System.EventHandler(this.modifVisite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMotif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEntree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSortie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPouls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_infirmerieDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button validerBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.DateTimePicker dateTxt;
        private System.Windows.Forms.TextBox poulsTxt;
        private System.Windows.Forms.TextBox motifTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox domicileCk;
        private System.Windows.Forms.CheckBox prevenuCk;
        private System.Windows.Forms.CheckBox hopitalCk;
        private System.Windows.Forms.TextBox commentaireTxt;
        private System.Windows.Forms.TextBox eleveId;
        private System.Windows.Forms.TextBox visiteID;
        private System.Windows.Forms.TextBox prenomTxt;
        private System.Windows.Forms.TextBox nomTxt;
        private System.Windows.Forms.ErrorProvider errorMotif;
        private System.Windows.Forms.ErrorProvider errorEntree;
        private System.Windows.Forms.ErrorProvider errorSortie;
        private System.Windows.Forms.ErrorProvider errorPouls;
        private System.Windows.Forms.DateTimePicker sortieTxt;
        private System.Windows.Forms.DateTimePicker entreeTxt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox qteMedics;
        private System.Windows.Forms.Label qteMedic;
        private System.Windows.Forms.Label cbMedic;
        private gestion_infirmerieDataSet2 gestion_infirmerieDataSet2;
        private System.Windows.Forms.BindingSource medicamentBindingSource;
        private gestion_infirmerieDataSet2TableAdapters.medicamentTableAdapter medicamentTableAdapter;
    }
}