namespace GUI
{
    partial class ajoutMedicament
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
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.cbArchive = new System.Windows.Forms.CheckBox();
            this.cbUtilisation = new System.Windows.Forms.CheckBox();
            this.errorProviderNomMedicament = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNomMedicament)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(9, 31);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(114, 20);
            this.txtNom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom du médicament:";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(28, 84);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(85, 29);
            this.btnEnregistrer.TabIndex = 2;
            this.btnEnregistrer.Text = "enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // cbArchive
            // 
            this.cbArchive.AutoSize = true;
            this.cbArchive.Location = new System.Drawing.Point(9, 54);
            this.cbArchive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbArchive.Name = "cbArchive";
            this.cbArchive.Size = new System.Drawing.Size(62, 17);
            this.cbArchive.TabIndex = 3;
            this.cbArchive.Text = "Archivé";
            this.cbArchive.UseVisualStyleBackColor = true;
            // 
            // cbUtilisation
            // 
            this.cbUtilisation.AutoSize = true;
            this.cbUtilisation.Location = new System.Drawing.Point(71, 54);
            this.cbUtilisation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbUtilisation.Name = "cbUtilisation";
            this.cbUtilisation.Size = new System.Drawing.Size(54, 17);
            this.cbUtilisation.TabIndex = 4;
            this.cbUtilisation.Text = "Utilisé";
            this.cbUtilisation.UseVisualStyleBackColor = true;
            // 
            // errorProviderNomMedicament
            // 
            this.errorProviderNomMedicament.ContainerControl = this;
            // 
            // ajoutMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(152, 123);
            this.Controls.Add(this.cbUtilisation);
            this.Controls.Add(this.cbArchive);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNom);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ajoutMedicament";
            this.Text = "ajoutMedicament";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNomMedicament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.CheckBox cbArchive;
        private System.Windows.Forms.CheckBox cbUtilisation;
        private System.Windows.Forms.ErrorProvider errorProviderNomMedicament;
    }
}