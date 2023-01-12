using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login_forme.Models;

namespace Login_forme.Models
{
    class Komentar
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public int KorisnikID { get; set; }
        [ForeignKey("KorisnikID")]
        public Korisnik korisnik { get; set; }
        public DateTime Napisan { get; set; }
        public DateTime Modifikovan { get; set; }

        public int TemaID { get; set; }
        [ForeignKey("TemaID")]
        public Tema Tema { get; set; }
    }
}
