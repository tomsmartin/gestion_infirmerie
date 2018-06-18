namespace GUI
{
    partial class ajoutClasses
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
            this.txtNomClasse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjoutClasse = new System.Windows.Forms.Button();
            this.errorNomClasse = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorNomClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomClasse
            // 
            this.txtNomClasse.Location = new System.Drawing.Point(81, 74);
            this.txtNomClasse.Name = "txtNomClasse";
            this.txtNomClasse.Size = new System.Drawing.Size(100, 20);
            this.txtNomClasse.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom de la classe";
            // 
            // btnAjoutClasse
            // 
            this.btnAjoutClasse.Location = new System.Drawing.Point(68, 226);
            this.btnAjoutClasse.Name = "btnAjoutClasse";
            this.btnAjoutClasse.Size = new System.Drawing.Size(135, 30);
            this.btnAjoutClasse.TabIndex = 4;
            this.btnAjoutClasse.Text = "Enregistrer";
            this.btnAjoutClasse.UseVisualStyleBackColor = true;
            this.btnAjoutClasse.Click += new System.EventHandler(this.btnAjoutClasse_Click);
            // 
            // errorNomClasse
            // 
            this.errorNomClasse.ContainerControl = this;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(212, 30);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(51, 25);
            this.btnRetour.TabIndex = 5;
            this.btnRetour.Text = "Annuler";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // ajoutClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 268);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnAjoutClasse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomClasse);
            this.Name = "ajoutClasses";
            this.Text = "ajoutClasses";
            ((System.ComponentModel.ISupportInitialize)(this.errorNomClasse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomClasse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjoutClasse;
        private System.Windows.Forms.ErrorProvider errorNomClasse;
        private System.Windows.Forms.Button btnRetour;
    }
}