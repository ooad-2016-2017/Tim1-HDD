using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;
using eBolnica.Model;
using Microsoft.WindowsAzure.MobileServices;

namespace eBolnica


{
    class AdminViewModel2 : INotifyPropertyChanged
    {
        public MessageDialog Poruka { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        //za azure 
        IMobileServiceTable<eBolnica.Migrations.DoktorTabela> userTableObj = App.MobileService.GetTable<eBolnica.Migrations.DoktorTabela>();
        IMobileServiceTable<eBolnica.Migrations.PacijentTabela> userTableObjPacijent = App.MobileService.GetTable<eBolnica.Migrations.PacijentTabela>();


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


        public String dadresa { get; set; }
        public String dJMBG { get; set; }
        public String demail { get; set; }
        public String dIme { get; set; }
        public String dPrezime { get; set; }
        public DateTime dDatumRodjenja { get; set; }
        public DateTimeOffset dDatumRodjenjaOffset { get; set; }
        public String dKorisnickoIme { get; set; }
        public String dLozinka { get; set; }
        public String dLozinkaPotvrda { get; set; }
        public ICommand RegistracijaKorisnika2 { get; set; }
        public ICommand KrajRegistracije2 { get; set; }
        public static Pacijent doktor { get; set; }

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
            dIme = "";
            dPrezime = "";
            dKorisnickoIme = "";
            dLozinka = "";
            dadresa = "";
            dJMBG = "";
            demail = "";

            RegistracijaKorisnika = new RelayCommand<object>(registracijaKorisnika);
            KrajRegistracije = new RelayCommand<object>(zavrsiRegistraciju);
            RegistracijaKorisnika2 = new RelayCommand<object>(registracijaKorisnika2);
            KrajRegistracije2 = new RelayCommand<object>(zavrsiRegistraciju2);
        }


        private async void registracijaKorisnika(object parametar)
        {
            using (var DB = new AdminDB())
            {
                if (rIme.Length < 3 || rPrezime.Length < 3 || rKorisnickoIme.Length < 3 || rLozinka.Length < 3)
                {
                    Poruka = new MessageDialog("Unesite sve tražene podatke.(Nepravilan unos nekih polja)");
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
                try
                {
                    DB.SaveChanges();

                    //Spasavanje na azure
                    Migrations.PacijentTabela obj = new Migrations.PacijentTabela();


                    obj.Ime = korisnik.Ime;
                    obj.Prezime = korisnik.Prezime;
                    obj.DatumRodjenja = korisnik.DatumRodjenja;
                    obj.Jmbg = korisnik.Jmbg;
                    obj.BrojTelefona = korisnik.BrojTelefona;
                    obj.Username = korisnik.Username;
                    obj.Password = korisnik.Password;
                    obj.Email = korisnik.Email;
                    obj.AdresaStanovanja = korisnik.AdresaStanovanja;
                    obj.id = korisnik.id.ToString();
                    obj.Prioritet = korisnik.Prioritet;

                    userTableObjPacijent.InsertAsync(obj);

                    Poruka = new MessageDialog("Uspješno kreiran račun.");
                    await Poruka.ShowAsync();
                }
                catch(Exception e)
                {
                    Poruka = new MessageDialog(e.Message);
                    await Poruka.ShowAsync();
                }

                
            }
        }

        private async void registracijaKorisnika2(object parametar)
        {
            using (var DB = new AdminDB())
            {
                if (dIme.Length < 3 || dPrezime.Length < 3 || dKorisnickoIme.Length < 3 || dLozinka.Length < 3)
                {
                    Poruka = new MessageDialog("Unesite sve tražene podatke.");
                    await Poruka.ShowAsync();
                    return;
                }


                if (dLozinka != dLozinkaPotvrda)
                {
                    Poruka = new MessageDialog("Lozinke se ne podudaraju.");
                    await Poruka.ShowAsync();
                    return;
                }
                dDatumRodjenja = dDatumRodjenjaOffset.Date;


            }
        }

        private async void zavrsiRegistraciju2(object parametar)
        {
            using (var DB = new AdminDB())
            {


                Doktor korisnik = new Doktor(dIme, dPrezime, dDatumRodjenja, dJMBG, dadresa, "brojTel", demail, 0, dKorisnickoIme, dLozinka);
                DB.Doktori.Add(korisnik);
                try
                {
                    DB.SaveChanges();

                    //----------------------------------
                    //pokusaj dodavanja u bazu na azure serveru 
                    Migrations.DoktorTabela obj = new Migrations.DoktorTabela();
                    obj.Ime = korisnik.Ime;
                    obj.Prezime = korisnik.Prezime;
                    obj.DatumRodjenja = korisnik.DatumRodjenja;
                    obj.Jmbg = korisnik.Jmbg;
                    obj.BrojTelefona = korisnik.BrojTelefona;
                    obj.Username = korisnik.Username;
                    obj.Password = korisnik.Password;
                    obj.Plata = korisnik.Plata;
                    obj.Email = korisnik.Email;
                    obj.AdresaStanovanja = korisnik.AdresaStanovanja;
                    obj.id = korisnik.Id.ToString();

                    userTableObj.InsertAsync(obj); 
                    //----------------------------------------
                }
                catch (Exception e)
                {
                    Poruka = new MessageDialog(e.ToString());
                    await Poruka.ShowAsync();

                }
                Poruka = new MessageDialog("Uspješno kreiran račun.");
                await Poruka.ShowAsync();
            }
        }
    }
}
