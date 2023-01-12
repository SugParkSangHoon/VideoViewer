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
    
    public partial class Teme : Form
    {
        public void LoadDatagrid()
        {
            dtgTema.DataSource = null;
            using (var context = new UserContext())
            {
                dtgTema.DataSource = context.Teme.ToList();
            }
        }
        public Teme()
        {
            InitializeComponent();
            dtgTema.AutoGenerateColumns = false;
        }

     

        private void Tema_Load(object sender, EventArgs e)
        {
            LoadDatagrid();

            //refresh form every  5 second
            Timer timer = new Timer();
            timer.Interval = (5000); 
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            LoadDatagrid();
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            string Trazenisadrzaj = txtPretraga.Text.ToLower();
            using (var context = new UserContext())
            {
                

                var tema = context.Teme
                    .Where(t => t.Naslov.ToLower().Contains(Trazenisadrzaj) 
                    || t.Autor.ToLower().Contains(Trazenisadrzaj)).ToList();
                dtgTema.DataSource = null;
                dtgTema.DataSource = tema;

            }
        }

        private void btnTema_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<DodajTemu>().Count() >= 1)
                Application.OpenForms.OfType<DodajTemu>().First().Close();
            DodajTemu frmTema = new DodajTemu();
            frmTema.MdiParent = this.ParentForm;
            frmTema.Show();
            dtgTema.DataSource = null;
            LoadDatagrid();
        }

        private void dtgTema_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //var a = dtgTema.SelectedRows;
            //MessageBox.Show(a.ToString());
            
        }

        private void dtgTema_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //select Name of topic
            string value = dtgTema.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();

            using (var db = new UserContext())
            {
                //find topic by name
                var tema = db.Teme
                .Where(s => s.Naslov.Equals(value)).FirstOrDefault<Tema>();

                TopicSession.Autor = tema.Autor;
                TopicSession.Datum = tema.Napravljena.ToString();
                TopicSession.Naslov = tema.Naslov;
                TopicSession.Tekst = tema.Text;
                TopicSession.TrenutnaTema = tema;
            }

                frmTemaOptions frm = new frmTemaOptions();
            frm.MdiParent = this.ParentForm;
            frm.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDatagrid();
        }

        private void dtgTema_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
