using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_forme.Controllers
{
    class PomocneFunkcije
    {
        public void ProvjeriDaLiJeOtvorena(Form frm)
        {
            if (Application.OpenForms.OfType<object>().Count() >= 1)
                Application.OpenForms.OfType<Form>().First().Close();
        }
        public void showForm(Form _form, Form _main)
        {
            if (_main != null)
            {
                if (_main.ActiveMdiChild != null)
                {
                    _main.ActiveMdiChild.Close();
                }
                _form.MdiParent = _main;
                _form.Activate();
                _form.Show();
            }
            else
            {
                _form.Activate();
                _form.ShowDialog();
            }
        }
    }
}
