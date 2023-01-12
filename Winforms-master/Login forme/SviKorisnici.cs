using Login_forme.Models;
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
    public partial class SviKorisnici : Form
    {
        public SviKorisnici()
        {
            InitializeComponent();
            dtgKorisnici.AutoGenerateColumns = false;
        }

      

       

        private void SviKorisnici_Load(object sender, EventArgs e)
        {
            using (var context = new UserContext())
            {
                dtgKorisnici.DataSource = context.RegistrovaniKorisnici.ToList();
            }
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            string Trazenisadrzaj = txtPretraga.Text.ToLower();
            using (var context=new UserContext())
            {
                var korisnik = context.RegistrovaniKorisnici
                    .Where(k => k.Ime.ToLower().Contains(Trazenisadrzaj)
                    || k.Prezime.ToLower().Contains(Trazenisadrzaj)
                    || k.KorisnickoIme.ToLower().Contains(Trazenisadrzaj)).ToList();
                dtgKorisnici.DataSource = null;
                dtgKorisnici.DataSource = korisnik;

            }
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Registracija>().Count() >= 1)
                Application.OpenForms.OfType<Registracija>().First().Close();
            Registracija novi = new Registracija();
            novi.MdiParent = this.ParentForm;
            novi.Show();
        }
    }
}
