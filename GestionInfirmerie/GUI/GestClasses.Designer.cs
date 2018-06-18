namespace GUI
{
    partial class gestClasses
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
            this.ajoutClasse = new System.Windows.Forms.Button();
            this.listeClasse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ajoutClasse
            // 
            this.ajoutClasse.Location = new System.Drawing.Point(101, 27);
            this.ajoutClasse.Name = "ajoutClasse";
            this.ajoutClasse.Size = new System.Drawing.Size(217, 51);
            this.ajoutClasse.TabIndex = 0;
            this.ajoutClasse.Text = "Ajouter une classe";
            this.ajoutClasse.UseVisualStyleBackColor = true;
            this.ajoutClasse.Click += new System.EventHandler(this.ajoutClasse_Click);
            // 
            // listeClasse
            // 
            this.listeClasse.Location = new System.Drawing.Point(101, 233);
            this.listeClasse.Name = "listeClasse";
            this.listeClasse.Size = new System.Drawing.Size(217, 54);
            this.listeClasse.TabIndex = 1;
            this.listeClasse.Text = "Liste des classes";
            this.listeClasse.UseVisualStyleBackColor = true;
            this.listeClasse.Click += new System.EventHandler(this.listeClasse_Click);
            // 
            // gestClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 337);
            this.Controls.Add(this.listeClasse);
            this.Controls.Add(this.ajoutClasse);
            this.Name = "gestClasses";
            this.Text = "GestClasses";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ajoutClasse;
        private System.Windows.Forms.Button listeClasse;
    }
}