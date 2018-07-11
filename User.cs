using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASP
{
    public static class User
    {
        public static void Logout(Form f)
        {
            var frmUser = new Thread(() => Application.Run(new frmLogin()));
            frmUser.SetApartmentState(ApartmentState.STA);
            frmUser.Start();
            f.Close();
        }
    }
}
