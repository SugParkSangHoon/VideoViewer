using Login_forme.Controllers;
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
    public partial class DodajTemu : Form
    {
        public DodajTemu()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Application.OpenForms.OfType<Login>().Count() >= 1)
                Application.OpenForms.OfType<Login>().First().Close();
            Login frmLogin = new Login();
            frmLogin.MdiParent = this.ParentForm;
            frmLogin.Show();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            bool postoji = false;
            if (Session.IsUserLoggedIn() == true)
            {

                Korisnik trenutni = Session.LogiraniKorisnik;
                if (!string.IsNullOrWhiteSpace(txtNaslov.Text) || !string.IsNullOrWhiteSpace(txtTekst.Text))
                {
                    using (var db = new UserContext())
                    {
                        //find if topic name already exist
                        var teme = db.Teme
                        .Where(s => s.Naslov.Equals(txtNaslov.Text));
                        foreach (var naslov in teme)
                        {
                            if (naslov.Naslov == txtNaslov.Text)
                            {
                                MessageBox.Show("Tema vec postoji");
                                postoji = true;
                            }

                        }
                        if (!postoji)
                        {
                            var korisnik = db.RegistrovaniKorisnici
                                .Where(s => s.Id.Equals(trenutni.Id))
                                   .FirstOrDefault<Korisnik>();
                            korisnik.Uloga = "Autor";


                            Tema nova = new Tema()
                            {
                                Naslov = txtNaslov.Text,
                                Text = txtTekst.Text,
                                KorisnikID = trenutni.Id,
                                Napravljena = DateTime.Now,
                                Modifikovana = DateTime.Now,
                                Autor = trenutni.KorisnickoIme,
                                BrojKomentara = 0

                            };


                            db.Teme.Add(nova);
                            db.SaveChanges();
                            MessageBox.Show("Uspjesno ste dodali temu");
                            Close();
                        }
                    }
                }
            }
            

        }
    }
}
