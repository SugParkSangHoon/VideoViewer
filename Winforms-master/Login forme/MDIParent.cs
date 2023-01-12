using Login_forme.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_forme
{
    public partial class MDIParent : Form
    {
        private int childFormNumber = 0;
        public  void ProfilMenu()
        {
            this.profilToolStripMenuItem.Visible = true;
        }

        public MDIParent()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)

        {
            if (Application.OpenForms.OfType<Login>().Count() >= 1)
                Application.OpenForms.OfType<Login>().First().Close();
            Login frmLogin = new Login();
            frmLogin.MdiParent = this;
            frmLogin.Show();
        }

        private void registracijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (Application.OpenForms.OfType<Registracija>().Count() >= 1)
                Application.OpenForms.OfType<Registracija>().First().Close();

            Registracija frmRegistracija = new Registracija();
            frmRegistracija.MdiParent = this;
            frmRegistracija.Show();
        }

        private void korisniciToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Session.IsUserLoggedIn()==true)
            {
                
                if (Application.OpenForms.OfType<SviKorisnici>().Count() >= 1)

                    Application.OpenForms.OfType<SviKorisnici>().First().Close();
                SviKorisnici frmKorisnici = new SviKorisnici();
                frmKorisnici.MdiParent = this;
                frmKorisnici.Show();
            }
        }

        private void MDIParent_Load(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.Show(this);
            odjaviSeToolStripMenuItem.Enabled = false;


        }

        private void temaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dodajNovuToolStripMenuItem_Click(object sender, EventArgs e)
        {
             //if (!Request.IsAuthenticated)
             //   {
             //       Response.Redirect("Login.aspx");
             //   }
            
            if (Application.OpenForms.OfType<DodajTemu>().Count() >= 1)
                Application.OpenForms.OfType<DodajTemu>().First().Close();
            DodajTemu frmTema = new DodajTemu();
            frmTema.MdiParent = this;
            frmTema.Show();
        }

        private void sveTemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Teme>().Count() >= 1)
                Application.OpenForms.OfType<Teme>().First().Close();
            Teme frmTema = new Teme();
            frmTema.MdiParent = this;
            frmTema.Show();
        }

      

        public void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Session.IsUserLoggedIn() == true)
            {
                odjaviSeToolStripMenuItem.Enabled = true;
            }
        }

        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session.IsLogIn = false;
            Session.LogiraniKorisnik = null;
        }

        private void MDIParent_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
