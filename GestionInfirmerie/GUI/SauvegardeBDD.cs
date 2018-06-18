using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using System.Data.SqlClient;
namespace GUI
{
    public partial class SauvegardeBDD : Form
    {
        SqlConnection con = new SqlConnection("Persist Security Info = False; Trusted_Connection = True;database = gestion_infirmerie; server=localhost");
        public SauvegardeBDD()
        {
            InitializeComponent();            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();

            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("please enter backup file location");
            }
            else
            {
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + textBox1.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                using (SqlCommand command = new SqlCommand(cmd, con))
                {
                    if (con.State != ConnectionState.Open)
                    {
                        this.con.Open();
                    }
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("database backup done successefully");
                    SaveButton.Enabled = false;
                }
            }
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dlg.SelectedPath;
                SaveButton.Enabled = true;
            }
        }

    }
}
