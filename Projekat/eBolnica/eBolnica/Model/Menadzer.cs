using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBolnica.Model {
    public class Menadzer : Uposlenik {
        public Menadzer(string ime, string prezime, DateTime datumRodjenja, string jmbg, string adresaStanovanja, string brojTelefona, string email, double plata) : base(ime, prezime, datumRodjenja, jmbg, adresaStanovanja, brojTelefona, email, plata) {
        }
    }
}
