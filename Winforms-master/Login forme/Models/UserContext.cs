using Login_forme.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Login_forme.Models
{
    class UserContext:DbContext
    {
        //public static List<Korisnik> RegistrovaniKorisnici = new List<Korisnik>();
        public DbSet<Korisnik> RegistrovaniKorisnici { get; set; }
        public DbSet<Komentar> Komentari { get; set; }
        public DbSet<Tema> Teme { get; set; }

        //static DBMemory()
        //{


        //}


    }


}
