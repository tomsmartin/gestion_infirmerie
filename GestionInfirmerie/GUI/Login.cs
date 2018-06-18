using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using BLL;
using BO;



namespace GUI
{
    public partial class Login : Form
    {
        Main frmMenu;


        public Login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (this.txt_username.TextLength == 0 || this.txt_password.TextLength == 0)
            {
                if (this.txt_username.TextLength == 0)
                {
                    errorProviderLog.SetError(txt_username, "Connexion échouée. Le champ ne peut pas être vide!");
                }
                else
                {
                    errorProviderMDP.SetError(txt_password, "Connexion échouée. Le champ ne peut pas être vide!");
                }

            }
            else 
            {
                // création d'un objet connexion 
                Connexion maConnexion = new Connexion();

                // 
                DataTable verifUser = maConnexion.Con(txt_username.Text, txt_password.Text);


                if (verifUser.Rows[0][0].ToString() == "1")
                {
                    // Les identifiants sont correct on ouvre le form Main
                    frmMenu = new Main();
                    frmMenu.Show();
                    this.Hide();
                }
                else
                {
                    // les identifiants sont faux
                    MessageBox.Show("Connection échoué");
                }
            }
        }
    }
}