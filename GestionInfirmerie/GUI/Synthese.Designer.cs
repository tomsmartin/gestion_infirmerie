namespace GUI
{
    partial class Synthese
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.btnTempMoyen = new System.Windows.Forms.Button();
            this.btnTotalEle = new System.Windows.Forms.Button();
            this.btnMoyVisite = new System.Windows.Forms.Button();
            this.btnTotalVisite = new System.Windows.Forms.Button();
            this.btnNbMoyenMed = new System.Windows.Forms.Button();
            this.btnTotalMedi = new System.Windows.Forms.Button();
            this.errorPeriodeInfo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPeriode = new System.Windows.Forms.ErrorProvider(this.components);
            this.erreurAucuneVisite = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorPeriodeInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPeriode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erreurAucuneVisite)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Date de fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Date de début";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Période";
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Location = new System.Drawing.Point(296, 74);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(200, 20);
            this.dtpDateFin.TabIndex = 20;
            this.dtpDateFin.ValueChanged += new System.EventHandler(this.dtpDateFin_ValueChanged);
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Checked = false;
            this.dtpDateDebut.Location = new System.Drawing.Point(56, 74);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(200, 20);
            this.dtpDateDebut.TabIndex = 19;
            // 
            // btnTempMoyen
            // 
            this.btnTempMoyen.Location = new System.Drawing.Point(56, 134);
            this.btnTempMoyen.Name = "btnTempMoyen";
            this.btnTempMoyen.Size = new System.Drawing.Size(177, 41);
            this.btnTempMoyen.TabIndex = 27;
            this.btnTempMoyen.Text = "Temps moyen des visites";
            this.btnTempMoyen.UseVisualStyleBackColor = true;
            this.btnTempMoyen.Click += new System.EventHandler(this.btnTempMoyen_Click);
            // 
            // btnTotalEle
            // 
            this.btnTotalEle.Location = new System.Drawing.Point(296, 134);
            this.btnTotalEle.Name = "btnTotalEle";
            this.btnTotalEle.Size = new System.Drawing.Size(177, 41);
            this.btnTotalEle.TabIndex = 26;
            this.btnTotalEle.Text = "Nombre total d\'élève pa période";
            this.btnTotalEle.UseVisualStyleBackColor = true;
            this.btnTotalEle.Click += new System.EventHandler(this.btnTotalEle_Click);
            // 
            // btnMoyVisite
            // 
            this.btnMoyVisite.Location = new System.Drawing.Point(56, 190);
            this.btnMoyVisite.Name = "btnMoyVisite";
            this.btnMoyVisite.Size = new System.Drawing.Size(177, 41);
            this.btnMoyVisite.TabIndex = 25;
            this.btnMoyVisite.Text = "Nombre de visites moyennes par élèves";
            this.btnMoyVisite.UseVisualStyleBackColor = true;
            this.btnMoyVisite.Click += new System.EventHandler(this.btnMoyVisite_Click);
            this.btnMoyVisite.Validated += new System.EventHandler(this.btnMoyVisite_Validated);
            // 
            // btnTotalVisite
            // 
            this.btnTotalVisite.Location = new System.Drawing.Point(56, 253);
            this.btnTotalVisite.Name = "btnTotalVisite";
            this.btnTotalVisite.Size = new System.Drawing.Size(177, 41);
            this.btnTotalVisite.TabIndex = 24;
            this.btnTotalVisite.Text = "Nombre de visites totales par élèves";
            this.btnTotalVisite.UseVisualStyleBackColor = true;
            this.btnTotalVisite.Click += new System.EventHandler(this.btnTotalVisite_Click);
            // 
            // btnNbMoyenMed
            // 
            this.btnNbMoyenMed.Location = new System.Drawing.Point(296, 253);
            this.btnNbMoyenMed.Name = "btnNbMoyenMed";
            this.btnNbMoyenMed.Size = new System.Drawing.Size(177, 41);
            this.btnNbMoyenMed.TabIndex = 29;
            this.btnNbMoyenMed.Text = "Moyennes de médicaments utilisés par visite";
            this.btnNbMoyenMed.UseVisualStyleBackColor = true;
            this.btnNbMoyenMed.Click += new System.EventHandler(this.btnNbMoyenMed_Click);
            this.btnNbMoyenMed.Validated += new System.EventHandler(this.btnNbMoyenMed_Validated);
            // 
            // btnTotalMedi
            // 
            this.btnTotalMedi.Location = new System.Drawing.Point(296, 190);
            this.btnTotalMedi.Name = "btnTotalMedi";
            this.btnTotalMedi.Size = new System.Drawing.Size(177, 41);
            this.btnTotalMedi.TabIndex = 28;
            this.btnTotalMedi.Text = "Total de médicaments donnés";
            this.btnTotalMedi.UseVisualStyleBackColor = true;
            this.btnTotalMedi.Click += new System.EventHandler(this.btnTotalMedi_Click);
            // 
            // errorPeriodeInfo
            // 
            this.errorPeriodeInfo.ContainerControl = this;
            // 
            // errorPeriode
            // 
            this.errorPeriode.ContainerControl = this;
            // 
            // erreurAucuneVisite
            // 
            this.erreurAucuneVisite.ContainerControl = this;
            // 
            // Synthese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 337);
            this.Controls.Add(this.btnNbMoyenMed);
            this.Controls.Add(this.btnTotalMedi);
            this.Controls.Add(this.btnTempMoyen);
            this.Controls.Add(this.btnTotalEle);
            this.Controls.Add(this.btnMoyVisite);
            this.Controls.Add(this.btnTotalVisite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDateFin);
            this.Controls.Add(this.dtpDateDebut);
            this.Name = "Synthese";
            this.Text = "Synthese";
            ((System.ComponentModel.ISupportInitialize)(this.errorPeriodeInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPeriode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erreurAucuneVisite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.Button btnTempMoyen;
        private System.Windows.Forms.Button btnTotalEle;
        private System.Windows.Forms.Button btnMoyVisite;
        private System.Windows.Forms.Button btnTotalVisite;
        private System.Windows.Forms.Button btnNbMoyenMed;
        private System.Windows.Forms.Button btnTotalMedi;
        private System.Windows.Forms.ErrorProvider errorPeriodeInfo;
        private System.Windows.Forms.ErrorProvider errorPeriode;
        private System.Windows.Forms.ErrorProvider erreurAucuneVisite;
    }
}