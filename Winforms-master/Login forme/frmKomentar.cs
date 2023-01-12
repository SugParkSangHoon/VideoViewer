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
    public partial class frmKomentar : Form
    {
        public frmKomentar()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTekst.Text)) {
                using (var context = new UserContext())
                {
                    var kom = context.Komentari.Where(k => k.Id.Equals(CommentSession.Id)).FirstOrDefault<Komentar>();
                    if (kom != null && CommentSession.CommentSelected==true)
                    {
                        kom.Modifikovan = DateTime.Now;
                        kom.Text = txtTekst.Text;
                        context.SaveChanges();
                    }
                    else
                    {
                        Komentar novi = new Komentar
                        {
                            Text = txtTekst.Text,
                            KorisnikID = Session.LogiraniKorisnik.Id,
                            Napisan = DateTime.Now,
                            Modifikovan = DateTime.Now,
                            TemaID = TopicSession.TrenutnaTema.Id
                        };
                        context.Komentari.Add(novi);

                        var tema = context.Teme
                            .Where(t => t.Id.Equals(TopicSession.TrenutnaTema.Id))
                            .FirstOrDefault<Tema>();
                        tema.BrojKomentara += 1;

                    }
                        context.SaveChanges();
                }
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void frmKomentar_Load(object sender, EventArgs e)
        {
            using (var context=new UserContext())
            {
                var kom = context.Komentari.Where(k => k.Id.Equals(CommentSession.Id)).FirstOrDefault<Komentar>();
                if (kom != null && CommentSession.CommentSelected==true)
                {
                    txtTekst.Text = CommentSession.Tekst;
                    btnDodaj.Text = "Izmjeni";
                }
            }
                
            
        }
    }
}
