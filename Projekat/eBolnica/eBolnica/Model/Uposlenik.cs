using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBolnica
{
    public class Uposlenik : Osoba
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int id;
        private double plata;
        private String username;
        public String Username { get { return username; } set { username = value; NotifyPropertyChanged(nameof(Username)); } }
        private String password;
        public String Password { get { return password; } set { password = value; NotifyPropertyChanged(nameof(Password)); } }
        static int brojac = 0;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public Uposlenik(string ime, string prezime, DateTime datumRodjenja, string jmbg, string adresaStanovanja, string brojTelefona, string email, double plata, String _username, String _password) : base(ime, prezime, datumRodjenja, jmbg, adresaStanovanja, brojTelefona, email)
        {
            username = _username;
            password = _password;
            this.plata = plata;
            //brojac++;
            id = datumRodjenja.Year;
        }

        /* public int Id { get => id; set => id = value; }
         public double Plata { get => plata; set => plata = value; }*/
        public int Id
        {
            get { return id; }
            set { id = value; NotifyPropertyChanged(nameof(Id)); }
        }
        public double Plata
        {
            get { return plata; }
            set { plata = value; NotifyPropertyChanged(nameof(Plata)); }
        }

    }
}
