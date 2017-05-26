using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eBolnica
{
    public abstract class Osoba : INotifyPropertyChanged
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private string jmbg;
        private string ime;
        private string prezime;
        private DateTime datumRodjenja;

        private string adresaStanovanja;
        private string brojTelefona;
        private string email;

        public event PropertyChangedEventHandler PropertyChanged;

        public Osoba(string ime, string prezime, DateTime datumRodjenja, string jmbg, string adresaStanovanja, string brojTelefona, string email)
        {
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

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }


        /* public string Ime { get => ime; set => ime = value; }
         public string Prezime { get => prezime; set => prezime = value; }*/
        public string Ime
        {
            get { return ime; }
            set { ime = value; NotifyPropertyChanged(nameof(Ime)); }
        }
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; NotifyPropertyChanged(nameof(Prezime)); }
        }
        public DateTime DatumRodjenja
        {
            get { return datumRodjenja; }
            set { if (value > DateTime.Now) throw new ArgumentException("Pogresan Datum Rodjenja"); datumRodjenja = value; NotifyPropertyChanged(nameof(DatumRodjenja)); }
        }
        /* public string Jmbg { get => jmbg; set => jmbg = value; }
         public string AdresaStanovanja { get => adresaStanovanja; set => adresaStanovanja = value; }
         public string BrojTelefona { get => brojTelefona; set => brojTelefona = value; }
         public string Email { get => email; set => email = value; }*/
        public string Jmbg
        {
            get { return jmbg; }
            set { jmbg = value; NotifyPropertyChanged(nameof(Jmbg)); }
        }
        public string AdresaStanovanja
        {
            get { return adresaStanovanja; }
            set { adresaStanovanja = value; NotifyPropertyChanged(nameof(AdresaStanovanja)); }
        }
        public string BrojTelefona
        {
            get { return brojTelefona; }
            set { brojTelefona = value; NotifyPropertyChanged(nameof(BrojTelefona)); }

        }
        public string Email
        {
            get { return email; }
            set { email = value; NotifyPropertyChanged(nameof(Email)); }
        }
    }
}
