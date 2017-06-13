using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBolnica2.Models;
using eBolnica2.Helper;
using Windows.UI.Popups;
using System.Windows.Input;

namespace eBolnica2.ViewModel
{
    class LogInViewModel
    {
        public string txtUser { get; set; }
        public string txtPass { get; set; }

        public List<Osoba> Osobe = new List<Osoba>();



        public ICommand btnClick { get; set; }
        public INavigationService NavigationService { get;  set;}

        //public INavigationService NavigationService { get;  set;}

        public LogInViewModel()
        {

            using (var db = new EBolnicaDbContext())
            {
                Osobe = db.Doktori.ToList<Osoba>();

                List<Osoba> pom = db.Pacijenti.ToList<Osoba>();
                for (int i = 0; i < pom.Count; i++)
                    Osobe.Add(pom[i]);
            }


            txtUser = "";
            txtPass = "";

            btnClick = new RelayCommand<object>(logInFun);
            NavigationService = new NavigationService();
        }

        public bool mozeLiLogin(object param)
        {
            if (txtPass.Length == 0 || txtUser.Length == 0) return false;
            return true;
        }

        public async void logInFun(object param)
        {

             
            if (txtUser == "admin" && txtPass == "admin")
            {
                MessageDialog poruka = new MessageDialog("Prijavili ste se kao admin");
                await poruka.ShowAsync();

                NavigationService.Navigate(typeof(Viewss.AdminView) );
            }
            else
            {
                

                int indexPronadjenog = -1;  
                for(int i = 0; i < Osobe.Count; i++)
                {
                    if(Osobe[i].Password == txtPass && Osobe[i].Username == txtUser)
                    {
                        indexPronadjenog = i;
                        break;
                    }
                }

                if(indexPronadjenog == -1 )
                {
                    MessageDialog poruka = new MessageDialog("Ne postoji korisnik");
                    await poruka.ShowAsync();
                }else
                {
                    if (Osobe[indexPronadjenog] is Doktor)
                    {
                        NavigationService.Navigate(typeof(Viewss.DoktorView));
                    }
                    else
                    {
                        NavigationService.Navigate(typeof(Viewss.PacijentView));
                    }
                }
            }
        }
    }
}
