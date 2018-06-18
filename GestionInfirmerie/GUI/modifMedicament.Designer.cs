namespace GUI
{
    partial class modifMedicament
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
            this.lblNom = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnSup = new System.Windows.Forms.Button();
            this.cbUtilisation = new System.Windows.Forms.CheckBox();
            this.cbArchive = new System.Windows.Forms.CheckBox();
            this.errorProviderNomMedicament = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNomMedicament)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(10, 11);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(306, 152);
            this.dgv.TabIndex = 1;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(10, 185);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(37, 13);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Libelle";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(2, 255);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 6;
            this.txtId.Text = "ID MEDICAMENT";
            this.txtId.Visible = false;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(10, 211);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 7;
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(60, 280);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(107, 39);
            this.btnModif.TabIndex = 10;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            this.btnModif.Validated += new System.EventHandler(this.btnModif_Validated);
            // 
            // btnSup
            // 
            this.btnSup.Location = new System.Drawing.Point(193, 280);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(100, 39);
            this.btnSup.TabIndex = 11;
            this.btnSup.Text = "Supprimer";
            this.btnSup.UseVisualStyleBackColor = true;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // cbUtilisation
            // 
            this.cbUtilisation.AutoSize = true;
            this.cbUtilisation.Location = new System.Drawing.Point(151, 213);
            this.cbUtilisation.Name = "cbUtilisation";
            this.cbUtilisation.Size = new System.Drawing.Size(80, 17);
            this.cbUtilisation.TabIndex = 12;
            this.cbUtilisation.Text = "A été utilisé";
            this.cbUtilisation.UseVisualStyleBackColor = true;
            // 
            // cbArchive
            // 
            this.cbArchive.AutoSize = true;
            this.cbArchive.Location = new System.Drawing.Point(151, 182);
            this.cbArchive.Name = "cbArchive";
            this.cbArchive.Size = new System.Drawing.Size(62, 17);
            this.cbArchive.TabIndex = 13;
            this.cbArchive.Text = "Archivé";
            this.cbArchive.UseVisualStyleBackColor = true;
            // 
            // errorProviderNomMedicament
            // 
            this.errorProviderNomMedicament.ContainerControl = this;
            // 
            // modifMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 343);
            this.Controls.Add(this.cbArchive);
            this.Controls.Add(this.cbUtilisation);
            this.Controls.Add(this.btnSup);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.dgv);
            this.Name = "modifMedicament";
            this.Text = "FormModifMedicament";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNomMedicament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnSup;
        private System.Windows.Forms.CheckBox cbUtilisation;
        private System.Windows.Forms.CheckBox cbArchive;
        private System.Windows.Forms.ErrorProvider errorProviderNomMedicament;
    }
}