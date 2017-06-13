using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;
using eBolnica2.Models;
using eBolnica2.Helper;

namespace eBolnica2.ViewModel
{
    class AdminViewModel
    {
        public MessageDialog Poruka { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public INavigationService NavigationService { get; set; }


        public String rIme { get; set; }
        public String rPrezime { get; set; }
        public string rJmbg { get; set; }
        public DateTime rDatumRodjenja { get; set; }
        public DateTimeOffset rDatumRodjenjaOffset { get; set; }
        public String rKorisnickoIme { get; set; }
        public String rLozinka { get; set; }
        public String rLozinkaPotvrda { get; set; }
        public static Pacijent pacijent { get; set; }
        public static Doktor doktor { get; set; }
        public bool registracijaDoktora { get; set; }
        public string rAdresa { get; set; }
        public string rEmail { get; set;}
        public string tBroj { get; set; }


        public ICommand RegistracijaKorisnika { get; set; }
        public ICommand KrajRegistracije { get; set; }
        public ICommand backEvent { get; set; }


        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }


        public AdminViewModel()
        {

            rIme = "";
            rPrezime = "";
            rKorisnickoIme = "";
            rLozinka = "";
            registracijaDoktora = false;

            NavigationService = new NavigationService();

            RegistracijaKorisnika = new RelayCommand<object>(registracijaKorisnika);
            KrajRegistracije = new RelayCommand<object>(zavrsiRegistraciju);
            backEvent = new RelayCommand<object>(back);
           
        }

        public void back(object param)
        {
            NavigationService.GoBack(); 
        }


        public async void registracijaKorisnika(object parametar)
        {
            using (var DB = new EBolnicaDbContext())
            {
               


            }
        }

        public async void zavrsiRegistraciju(object parametar)
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
            if (rJmbg.Length != 13)
            {
                Poruka = new MessageDialog("Neispravan jmbg");
                await Poruka.ShowAsync();
                return;
            }
            rDatumRodjenja = rDatumRodjenjaOffset.Date;

            using (var DB = new EBolnicaDbContext())
            {

                if (!registracijaDoktora)
                {
                    Pacijent korisnik = new Pacijent(rIme,rPrezime,rDatumRodjenja,rJmbg,rAdresa,tBroj,rEmail,0,rKorisnickoIme,rLozinka);
                    DB.Pacijenti.Add(korisnik);
                    try
                    {
                        DB.SaveChanges();
                       
                       

                        


                        Poruka = new MessageDialog("Uspješno kreiran račun.");
                        await Poruka.ShowAsync();
                    }
                    catch (Exception e)
                    {
                        Poruka = new MessageDialog(e.Message);
                        await Poruka.ShowAsync();
                    }
                }else
                {
                    Doktor korisnik = new Doktor(rIme, rPrezime, rDatumRodjenja, rJmbg, rAdresa, tBroj, rEmail, 0, rKorisnickoIme, rLozinka);
                    DB.Doktori.Add(korisnik);
                    try
                    {
                        DB.SaveChanges();






                        Poruka = new MessageDialog("Uspješno kreiran račun.");
                        await Poruka.ShowAsync();
                    }
                    catch (Exception e)
                    {
                        Poruka = new MessageDialog(e.Message);
                        await Poruka.ShowAsync();
                    }
                }


            }
        }

       
    }
}

