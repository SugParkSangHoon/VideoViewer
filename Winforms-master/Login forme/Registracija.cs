
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Login_forme.Models;

namespace Login_forme
{
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool postoji = false;
            if (!string.IsNullOrWhiteSpace(txtIme.Text) || !string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                using (var context = new UserContext())
                {
                    var korIme = context.RegistrovaniKorisnici
                        .Where(s => s.KorisnickoIme.Equals(txtKorisnickoIme.Text));
                    foreach (var korisnik in korIme)
                    {
                        if (korisnik.KorisnickoIme == txtKorisnickoIme.Text)
                        {
                            MessageBox.Show("Korisnicko ime vec postoji");
                            postoji = true;
                        }

                    }


                    if (!postoji)
                    {
                        Korisnik novi = new Korisnik()
                        {
                            Ime = txtIme.Text,
                            Prezime = txtPrezime.Text,
                            KorisnickoIme = txtKorisnickoIme.Text,
                            Lozinka = txtLozinka.Text,
                            Uloga="Citalac"
                        };

                        context.RegistrovaniKorisnici.Add(novi);
                        context.SaveChanges();
                        MessageBox.Show("Uspjesno ste registrovani");
                        Close();
                    }
                }
            }
           
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            char prazanChar = new char();
            if (txtLozinka.PasswordChar != prazanChar)
            {
                txtLozinka.PasswordChar = prazanChar;
            }
           
            else
                txtLozinka.PasswordChar = '*';


        }
    }
}
