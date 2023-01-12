using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_forme.Models
{
    class Tema
    {
        public int Id { get; set; }
        public string Naslov { get; set; }
        public string Text { get; set; }

        public int KorisnikID { get; set; }
        [ForeignKey("KorisnikID")]
        public Korisnik korisnik { get; set; }
        public DateTime Napravljena { get; set; }
        public DateTime Modifikovana { get; set; }
        public int BrojKomentara { get; set; }
        public string Autor { get; set; }
    }
}
