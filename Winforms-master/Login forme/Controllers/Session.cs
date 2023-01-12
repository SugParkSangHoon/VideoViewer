using Login_forme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_forme.Controllers
{
    static class Session
    {
        public static Korisnik LogiraniKorisnik { get; set; }
        public static bool IsLogIn { get; set; } = false;
        public static bool IsUserLoggedIn()
        {
            if (IsLogIn == false)
            {
                Login log = new Login();
                if (log.ShowDialog() == DialogResult.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                

            }
            return true;
        
            
        }
        public static Korisnik GetLogInUser()
        {
            return LogiraniKorisnik;
        }
    }
    static class TopicSession
    {
        public static Tema TrenutnaTema { get; set; }
        public static string Naslov { get; set; }
        public static string Autor { get; set; }
        public static string Tekst { get; set; }
        public static string Datum { get; set; }
        public static string Komentar { get; set; }


    }
    static class CommentSession
    {
        public static int Id { get; set; }
        public static string Tekst { get; set; }
        public static bool CommentSelected { get; set; }
    }
}
