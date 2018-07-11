using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Threading;

namespace CLASP
{
    public partial class frmAddNewMember : MetroForm
    {
        private int tabIndex = 0;
        public frmAddNewMember()
        {
            InitializeComponent();
           
        }

        private void frmAddNewMember_Load(object sender, EventArgs e)
        {          
            if (tabCtrlAddMember.SelectedIndex == 0)
            {
                btnPrevious.Visible = false;
            }

        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tabCtrlAddMember.SelectedIndex--;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            tabCtrlAddMember.SelectedIndex++;
        }
        private void tabCtrlAddMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = tabCtrlAddMember.SelectedIndex;

            if (selectedIndex == 0)
            {
                btnPrevious.Visible = false;

            }
            else
            {
                btnPrevious.Visible = true;
            }
        }        
        private void cboCivilStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCivilStatus.SelectedIndex == 0)
            {
                txtSpouse.ReadOnly = true;
                txtSpouse.Style = MetroFramework.MetroColorStyle.Silver;
               
                txtSpouse.Text = "N/A";

                txtSpouseJob.ReadOnly = true;
                txtSpouseJob.Style = MetroFramework.MetroColorStyle.Silver;
                txtSpouseJob.Text = "N/A";

                this.Refresh();
            }
            else
            {
                txtSpouse.ReadOnly = false;
                txtSpouse.Style = MetroFramework.MetroColorStyle.Blue;

                txtSpouseJob.ReadOnly = false;
                txtSpouseJob.Style = MetroFramework.MetroColorStyle.Blue;

                txtSpouseJob.Clear();
                txtSpouse.Clear();

                this.Refresh();
            }
        }

        private void tabCtrlAddMember_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //if (e.TabPageIndex != tabIndex)
            //{
            //    e.Cancel = true;
            //}
        }

        private void txtTelNum_Validating(object sender, CancelEventArgs e)
        {
            Control ctrl;
            ctrl = (MetroFramework.Controls.MetroTextBox)sender;
            int num;
            bool result = int.TryParse(ctrl.Text, out num);

            if (ctrl.Text != String.Empty && !result)
            {
                e.Cancel = true;
                errorProvider1.SetError(ctrl, "Invalid input. Try again");
                
                (sender as MetroFramework.Controls.MetroTextBox).SelectAll();
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(ctrl, "");
            }
        }

        private void frmAddNewMember_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.CausesValidation = false;
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private void dtDOB_Validating(object sender, CancelEventArgs e)
        {
            if (dtDOB.Value.AddYears(18) >= DateTime.Today)
            {
                e.Cancel = true;
                errorProvider1.SetError(dtDOB, "Member must be at least 18 years old");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(dtDOB, "");
            }
        }
    }
}
