using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBolnica.Model {
    public abstract class Osoba {
        private string ime;
        private string prezime;
        private DateTime datumRodjenja;
        private string jmbg;
        private string adresaStanovanja;
        private string brojTelefona;
        private string email;

        public Osoba(string ime, string prezime, DateTime datumRodjenja, string jmbg, string adresaStanovanja, string brojTelefona, string email) {
            if (datumRodjenja > DateTime.Now)
                throw new ArgumentException("Pogresan Datum Rodjenja");
            this.ime = ime;
            this.prezime = prezime;
            this.datumRodjenja = datumRodjenja;
            this.jmbg = jmbg;
            this.adresaStanovanja = adresaStanovanja;
            this.brojTelefona = brojTelefona;
            this.email = email;
        }

        /* public string Ime { get => ime; set => ime = value; }
         public string Prezime { get => prezime; set => prezime = value; }*/
        public string Ime
        {
            get;
            set;
        }
        public string Prezime
        {
            get; set;
        }
        public DateTime DatumRodjenja {
            get { return datumRodjenja; }
            set { if (value > DateTime.Now) throw new ArgumentException("Pogresan Datum Rodjenja"); datumRodjenja = value; }
        }
       /* public string Jmbg { get => jmbg; set => jmbg = value; }
        public string AdresaStanovanja { get => adresaStanovanja; set => adresaStanovanja = value; }
        public string BrojTelefona { get => brojTelefona; set => brojTelefona = value; }
        public string Email { get => email; set => email = value; }*/
         public string Jmbg
        {
            get; set; }
        public string AdresaStanovanja
        {
            get; set;
        }
        public string BrojTelefona
        {
            get; set;
        }
        public string Email
        {
            get; set;
        }
        }
}
