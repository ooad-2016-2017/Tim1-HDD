using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBolnica.Model {
    public class Administrator : Osoba{
        private int id;

        private static int brojac = 0;

        public Administrator(string ime, string prezime, DateTime datumRodjenja, string jmbg, string adresaStanovanja, string brojTelefona, string email) : base(ime, prezime, datumRodjenja, jmbg, adresaStanovanja, brojTelefona, email) {
            brojac++;
            id = brojac;
        }
        public int Id { get => id; set => id = value; }

        //dodati metode
    }
}
