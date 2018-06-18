namespace GUI
{
    partial class gestionEleve
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.classeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_infirmerieDataSet = new GUI.gestion_infirmerieDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.classeTableAdapter = new GUI.gestion_infirmerieDataSetTableAdapters.classeTableAdapter();
            this.tableAdapterManager = new GUI.gestion_infirmerieDataSetTableAdapters.TableAdapterManager();
            this.visiteTableAdapter = new GUI.gestion_infirmerieDataSetTableAdapters.visiteTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.visiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestioninfirmerieDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_infirmerieDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioninfirmerieDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classeBindingSource, "Libelle_classe", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(128, 28);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 21);
            this.comboBox1.TabIndex = 0;
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(403, 28);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(139, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Classe de l\'élève:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom de l\'élève:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(545, 89);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Afficher";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // classeTableAdapter
            // 
            this.classeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.classeTableAdapter = this.classeTableAdapter;
            this.tableAdapterManager.eleveTableAdapter = null;
            this.tableAdapterManager.medicamentTableAdapter = null;
            this.tableAdapterManager.niveauTableAdapter = null;
            this.tableAdapterManager.prescrireTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUI.gestion_infirmerieDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            this.tableAdapterManager.visiteTableAdapter = this.visiteTableAdapter;
            // 
            // visiteTableAdapter
            // 
            this.visiteTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 103);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(586, 213);
            this.dataGridView1.TabIndex = 5;
            // 
            // visiteBindingSource
            // 
            this.visiteBindingSource.DataMember = "visite";
            this.visiteBindingSource.DataSource = this.gestioninfirmerieDataSetBindingSource;
            // 
            // gestioninfirmerieDataSetBindingSource
            // 
            this.gestioninfirmerieDataSetBindingSource.DataSource = this.gestion_infirmerieDataSet;
            this.gestioninfirmerieDataSetBindingSource.Position = 0;
            // 
            // gestionEleve_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 316);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "gestionEleve_frm";
            this.Text = "Gestion élèves";
            this.Load += new System.EventHandler(this.gestionEleve_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_infirmerieDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioninfirmerieDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private gestion_infirmerieDataSet gestion_infirmerieDataSet;
        private System.Windows.Forms.BindingSource classeBindingSource;
        private gestion_infirmerieDataSetTableAdapters.classeTableAdapter classeTableAdapter;
        private gestion_infirmerieDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private gestion_infirmerieDataSetTableAdapters.visiteTableAdapter visiteTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gestioninfirmerieDataSetBindingSource;
        private System.Windows.Forms.BindingSource visiteBindingSource;
        private System.Windows.Forms.Button button1;
    }
}