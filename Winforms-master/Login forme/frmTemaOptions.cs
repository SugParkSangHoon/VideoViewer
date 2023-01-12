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
    public partial class frmTemaOptions : Form
        
    {
        List<dgKomentar> Kom = new List<dgKomentar>();

        public void LoadAgain()
        {
            lblAutor.Text = TopicSession.Autor;
            lblNaslov.Text = TopicSession.Naslov;
            labelNapisano.Text = TopicSession.Datum;
            txtTekst.Text = TopicSession.Tekst;
          

            dgvKomentar.DataSource = null;

            //reset list to upload new one every time
            Kom = null;
            Kom = new List<dgKomentar>();


            using (var context = new UserContext())
            {
                //make new data source

                //Find all comments
                var komentari = context.Komentari.Where(k => k.TemaID.Equals(TopicSession.TrenutnaTema.Id));
                foreach (var kom in komentari)
                {
                  
                    var korisnikID = kom.KorisnikID;

                    //need to use new usercontext (exception)
                    using (var db = new UserContext())
                    {
                        //find who wrote comment
                        var korisnik = db.RegistrovaniKorisnici.Where(s => s.Id.Equals(korisnikID)).FirstOrDefault<Korisnik>();


                        Kom.Add(new dgKomentar
                        {
                            Komentar = kom.Text,
                            Napisao = korisnik.KorisnickoIme,
                            KomentarId=kom.Id
                        });
                    }
                }
                dgvKomentar.DataSource = Kom;

            }
        }
        public frmTemaOptions()
        {
            InitializeComponent();
            btnChange.Visible = false;
            btnDeleteTopic.Visible = false;
            btnSave.Visible = false;
            txtNaslovIzmijeni.Visible = false;
            dgvKomentar.AutoGenerateColumns = false;
            btnDelete.Visible = false;
            btnUredi.Enabled = false;
        }

        private void frmTemaOptions_Load(object sender, EventArgs e)
        {
            LoadAgain();
            if (Session.IsLogIn == true && Session.LogiraniKorisnik.KorisnickoIme == lblAutor.Text)
            {
                btnChange.Visible = true;
                btnSave.Visible = true;
                btnSave.Enabled = false;
                btnDeleteTopic.Visible = true;

            }
            if (Session.IsLogIn == true)
            {
                btnDelete.Visible = true;
                btnUredi.Enabled = true;

            }
           


        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            lblNaslov.Visible = false;
            txtNaslovIzmijeni.Text = lblNaslov.Text;
            txtNaslovIzmijeni.Visible = true;
            txtTekst.ReadOnly = false;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool postoji = false;
            using (var db = new UserContext())
            {
                //find old topic name to updat it
                var tema = db.Teme
                .Where(s => s.Naslov.Equals(lblNaslov.Text)).FirstOrDefault<Tema>();

                //check if new name already exist
                var teme = db.Teme
                       .Where(s => s.Naslov.Equals(txtNaslovIzmijeni.Text));
                foreach (var naslov in teme)
                {
                    if (naslov.Naslov == txtNaslovIzmijeni.Text && naslov.Naslov!=tema.Naslov)
                    {
                        MessageBox.Show("Tema vec postoji");
                        postoji = true;
                    }

                }

                if (!postoji)
                {
                    //Update in database
                    tema.Naslov = txtNaslovIzmijeni.Text;
                    tema.Text = txtTekst.Text;
                    tema.Modifikovana = DateTime.Now;

                    //Update the form
                    txtNaslovIzmijeni.Visible = false;
                    lblNaslov.Text = txtNaslovIzmijeni.Text;
                    lblNaslov.Visible = true;
                    txtTekst.ReadOnly = true;
                    txtTekst.Text = tema.Text;
                    labelDatum.Text = "Modifikovana";
                    labelNapisano.Text = tema.Modifikovana.ToString();

                    db.SaveChanges();
                }
            }
            btnSave.Enabled = false;
            LoadAgain();
        }

        private void dgvKomentari_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKomentar_Click(object sender, EventArgs e)
        {
            if (Session.IsUserLoggedIn() == true)
            {
                frmKomentar frm = new frmKomentar();
                //frm.MdiParent = this.ParentForm;
                if (frm.ShowDialog() == DialogResult.OK)
                {

                    LoadAgain();

                }
                
            }
        }

        private void dgvKomentar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvKomentar.CurrentCell.RowIndex;

            //get the value of comment ID
            string valueID = dgvKomentar.Rows[rowIndex].Cells[2].FormattedValue.ToString();

            if (Session.IsLogIn == true &&
                (Session.LogiraniKorisnik.KorisnickoIme == Kom[rowIndex].Napisao || Session.LogiraniKorisnik.KorisnickoIme == lblAutor.Text))
            {

                //Remove comment from list                     
                Kom.RemoveAt(rowIndex);

                using (var context = new UserContext())
                {
                    //remove comment form database
                    var komentar = context.Komentari.Where(k => k.Id.ToString().Equals(valueID)).FirstOrDefault<Komentar>();
                    context.Komentari.Remove(komentar);


                    using (var db = new UserContext())
                    {

                        var trenutnaTema = db.Teme.Where(t => t.Id.Equals(komentar.TemaID)).FirstOrDefault<Tema>();
                        trenutnaTema.BrojKomentara -= 1;
                        db.SaveChanges();
                    }
                    context.SaveChanges();


                }
                MessageBox.Show("komentar je obrisan");

                dgvKomentar.DataSource = null;
                dgvKomentar.DataSource = Kom;
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvKomentar.CurrentCell.RowIndex;

            //get the value of comment ID
            string valueID = dgvKomentar.Rows[rowIndex].Cells[2].FormattedValue.ToString();
            CommentSession.Id = int.Parse(valueID);

            //Get tekst from comment to display it in form
            string Tekst = dgvKomentar.Rows[rowIndex].Cells[0].FormattedValue.ToString();
            CommentSession.Tekst = Tekst;

            CommentSession.CommentSelected = true;

            if (Session.IsLogIn == true && Session.LogiraniKorisnik.KorisnickoIme == Kom[rowIndex].Napisao )
            {
                frmKomentar frm = new frmKomentar();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Izmijenili ste vas komentar");
                }

            }

            LoadAgain();
            CommentSession.CommentSelected = false;

        }

        private void btnDeleteTopic_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Da li ste sigurno da zelite obrisati temu?", "Upozorenje", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                string naslovTeme = lblNaslov.Text;
                using (var context = new UserContext())
                {
                    var tema = context.Teme.Where(t => t.Naslov.Equals(naslovTeme)).FirstOrDefault<Tema>();
                    context.Teme.Remove(tema);
                    context.SaveChanges();
                }
            }
            
            Close();

           
        }
    }
}
