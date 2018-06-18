namespace GUI
{
    partial class listeMedicament
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
            this.rechercheNom = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorPeriodeInfo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPeriode = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPeriodeInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPeriode)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(11, 80);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(568, 196);
            this.dgv.TabIndex = 7;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rechercheNom);
            this.groupBox1.Location = new System.Drawing.Point(200, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(188, 63);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche par nom";
            // 
            // errorPeriodeInfo
            // 
            this.errorPeriodeInfo.ContainerControl = this;
            // 
            // errorPeriode
            // 
            this.errorPeriode.ContainerControl = this;
            // 
            // listeMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 521);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.Name = "listeMedicament";
            this.Text = "listeMedicament";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPeriodeInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPeriode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox rechercheNom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorPeriodeInfo;
        private System.Windows.Forms.ErrorProvider errorPeriode;
    }
}