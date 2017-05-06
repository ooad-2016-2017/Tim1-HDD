using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBolnica.Model {
    public class Apotekar : Osoba {
        private int id;

        private static int brojac = 0;
        
        public Apotekar(string ime, string prezime, DateTime datumRodjenja, string jmbg, string adresaStanovanja, string brojTelefona, string email) : base(ime, prezime, datumRodjenja, jmbg, adresaStanovanja, brojTelefona, email) {
            brojac++;
            this.id = brojac;
        }
        public static int Brojac { get => brojac; set => brojac = value; }
    }
}
