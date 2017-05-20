using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBolnica.v1.Model
{
    public class Uposlenik : Osoba
    {
        private int id;
        private double plata;

        static int brojac = 0;

        public Uposlenik(string ime, string prezime, DateTime datumRodjenja, string jmbg, string adresaStanovanja, string brojTelefona, string email, double plata) : base(ime, prezime, datumRodjenja, jmbg, adresaStanovanja, brojTelefona, email)
        {
            this.plata = plata;
            brojac++;
            id = brojac;
        }

        /* public int Id { get => id; set => id = value; }
         public double Plata { get => plata; set => plata = value; }*/
        public int Id
        {
            get; set;
        }
        public double Plata
        {
            get; set;
        }

    }
}
