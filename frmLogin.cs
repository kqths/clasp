using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;

namespace CLASP
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {

        //DECLARATIONS

        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adap;
        DataTable tbl;

        public frmLogin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            btnLogin.Enabled = false;        
        }

        // SHOW/HIDE PASSWORD
        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        // LOGIN
        private void btnLogin_Click(object sender, EventArgs e)
        {
            con = new MySqlConnection(DBConnection.Constr);
            tbl = new DataTable();
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM accounts WHERE username=@username AND password=@password";
            cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
            cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
            adap = new MySqlDataAdapter(cmd);
            adap.Fill(tbl);
            con.Open();

            if(tbl.Rows.Count > 0)
            {
                cmd.CommandText = "SELECT userType FROM accounts WHERE username=@username";
                char userType = char.Parse(cmd.ExecuteScalar().ToString());
                switch (userType)
                {
                    //ADMIN ACCOUNT
                    case 'A':
                        var frmAdmin = new Thread(() => Application.Run(new frmMainAdmin()));
                        frmAdmin.SetApartmentState(ApartmentState.STA);
                        frmAdmin.Start();
                        this.Close();
                        break;
                    //CASHIER ACCOUNT
                    case 'C':
                        var frmCashier = new Thread(() => Application.Run(new frmMainAdmin()));
                        frmCashier.SetApartmentState(ApartmentState.STA);
                        frmCashier.Start();
                        this.Close();
                        break;  
                    //USER ACCOUNT                  
                    case 'U':
                        var frmUser = new Thread(() => Application.Run(new frmMainAdmin()));
                        frmUser.SetApartmentState(ApartmentState.STA);
                        frmUser.Start();
                        this.Close();
                        break;
                    default:
                        break;
                }                
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Incorrect username or password", "Try Again");               
                txtPassword.Focus();
                txtPassword.SelectAll();
            }

        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            Control ctl;
            ctl = (MetroFramework.Controls.MetroTextBox)sender;
            if(txtPassword.Text.Length > 0 && txtUsername.Text.Length > 0)
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }
        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && btnLogin.Enabled==true)
            {
                btnLogin_Click(this, e);
            }
        }
    }
}
