using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;

namespace eBolnica.v1
{
    class AdminViewModel2 : INotifyPropertyChanged
    {
        public MessageDialog Poruka { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;


        public String rIme { get; set; }
        public String rPrezime { get; set; }
        public DateTime rDatumRodjenja { get; set; }
        public DateTimeOffset rDatumRodjenjaOffset { get; set; }
        public String rKorisnickoIme { get; set; }
        public String rLozinka { get; set; }
        public String rLozinkaPotvrda { get; set; }
        public ICommand RegistracijaKorisnika { get; set; }
        public ICommand KrajRegistracije { get; set; }
        public static Pacijent pacijent { get; set; }

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }


        public AdminViewModel2()
        {

            rIme = "";
            rPrezime = "";
            rKorisnickoIme = "";
            rLozinka = "";
            //rEmail = "";

            RegistracijaKorisnika = new RelayCommand<object>(registracijaKorisnika);
            KrajRegistracije = new RelayCommand<object>(zavrsiRegistraciju);
        }


        private async void registracijaKorisnika(object parametar)
        {
            using (var DB = new AdminDB())
            {
                if (rIme.Length < 3 || rPrezime.Length < 3 || rKorisnickoIme.Length < 3 || rLozinka.Length < 3)
                {
                    Poruka = new MessageDialog("Unesite sve tražene podatke.");
                    await Poruka.ShowAsync();
                    return;
                }


                if (rLozinka != rLozinkaPotvrda)
                {
                    Poruka = new MessageDialog("Lozinke se ne podudaraju.");
                    await Poruka.ShowAsync();
                    return;
                }
                rDatumRodjenja = rDatumRodjenjaOffset.Date;


            }
        }

        private async void zavrsiRegistraciju(object parametar)
        {
            using (var DB = new AdminDB())
            {


                Pacijent korisnik = new Pacijent(rDatumRodjenja.Year, rIme, rPrezime, rKorisnickoIme, rLozinka, rDatumRodjenja, "email");
                DB.Pacijenti.Add(korisnik);
                DB.SaveChanges();
                Poruka = new MessageDialog("Uspješno kreiran račun.");
                await Poruka.ShowAsync();
            }
        }
    }
}
