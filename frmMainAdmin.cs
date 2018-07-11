using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASP
{
    public partial class frmMainAdmin : MetroFramework.Forms.MetroForm
    {
        public frmMainAdmin()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblDateTime.Text = dateTime.ToString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DialogResult res =  MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to logout?", "", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
                User.Logout(this);
        }
        private void tileMembers_MouseEnter(object sender, EventArgs e)
        {
            Control ctl;
            ctl = (MetroFramework.Controls.MetroTile)sender;
            ((MetroFramework.Controls.MetroTile)sender).BackColor = Color.DodgerBlue;
            
        }
        private void tileMembers_MouseLeave(object sender, EventArgs e)
        {
            Control ctl;
            ctl = (MetroFramework.Controls.MetroTile)sender;
            ((MetroFramework.Controls.MetroTile)sender).BackColor = Color.Gray;
            switch (ctl.Name)
            {
                case "tileMembers":
                    tileMembers.Style = MetroFramework.MetroColorStyle.Green;
                    break;
                case "tileLoans":
                    tileLoans.Style = MetroFramework.MetroColorStyle.Green;
                    break;
                default:
                    break;
            }
        }

        private void tileMembers_Click(object sender, EventArgs e)
        {
            var frmMembers = new Thread(() => Application.Run(new frmMembers()));
            frmMembers.SetApartmentState(ApartmentState.STA);
            frmMembers.Start();
            this.Close();
        }

        private void frmMainAdmin_Load(object sender, EventArgs e)
        {

        }

        private void tileSMS_Click(object sender, EventArgs e)
        {
            var frmMembers = new Thread(() => Application.Run(new frmSMS()));
            frmMembers.SetApartmentState(ApartmentState.STA);
            frmMembers.Start();
            this.Close();
        }
    }
}
