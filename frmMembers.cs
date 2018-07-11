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
    public partial class frmMembers : MetroForm 
    {
        
        private void frmMembers_Load(object sender, EventArgs e)
        {
          
        }

        public frmMembers()
        {
            InitializeComponent();
           
        }
        private void frmMembers_FormClosed(object sender, FormClosedEventArgs e)
        {
            var th = new Thread(()=>Application.Run(new frmMainAdmin()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            //var th = new Thread(() => Application.Run(new frmAddNewMember()));
            //th.SetApartmentState(ApartmentState.STA);
            //th.Start();
            //this.Hide();
            frmAddNewMember add = new frmAddNewMember();
            add.ShowDialog();        
        }

     
    }
}
