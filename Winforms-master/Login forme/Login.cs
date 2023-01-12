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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Application.OpenForms.OfType<Registracija>().Count() >= 1)
                Application.OpenForms.OfType<Registracija>().First().Close();
            Registracija novi = new Registracija();
            novi.MdiParent = this.ParentForm;
            novi.Show();
        }
    
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string korisnickoIme = txtKorisnickoIme.Text;
            string lozinka = txtLozinka.Text;
            if (!string.IsNullOrEmpty(korisnickoIme) && !string.IsNullOrEmpty(lozinka))
            {

                using (var context = new UserContext())
                {
                    //Query syntax
                    var query = from i in context.RegistrovaniKorisnici 
                                where i.KorisnickoIme.Equals(korisnickoIme)
                                && i.Lozinka.Equals(lozinka) 
                                 select i;
                    var korisnik = query.FirstOrDefault<Korisnik>();

                    //Method syntax
                    var b = context.RegistrovaniKorisnici
                        .Where(s => s.KorisnickoIme.Equals(korisnickoIme) && s.Lozinka.Equals(lozinka))
                        .FirstOrDefault<Korisnik>();

                    if (korisnik != null) {
                      
                        Session.LogiraniKorisnik = korisnik;
                        Session.IsLogIn = true;


                       
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                        MessageBox.Show("Pogresno uneseni podaci");
                    

                   
                }
         
            }
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

        

        private void txtLozinka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // LoginButton.PerformClick();
                LoginButton_Click(sender, e);

            }
        }
    }
}
