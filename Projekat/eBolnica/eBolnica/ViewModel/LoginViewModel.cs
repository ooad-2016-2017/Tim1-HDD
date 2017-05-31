using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;
using Microsoft.WindowsAzure.MobileServices;

namespace eBolnica.ViewModel {
    class LoginViewModel {
        string username;
        string password;

        //za azure 
        //IMobileServiceTable<eBolnica.Migrations.DoktorTabela> userTableObj = App.MobileService.GetTable<eBolnica.Migrations.DoktorTabela>();
        //IMobileServiceTable<eBolnica.Migrations.PacijentTabela> userTableObjPacijent = App.MobileService.GetTable<eBolnica.Migrations.PacijentTabela>();


        public LoginViewModel() {
            Ilogin = new RelayCommand<object>(LoginAsync);

            //var lista = userTableObj.ToCollectionAsync().Result;
            //password = lista[0].Ime;
        }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public ICommand Ilogin { get; set; }



        public async void LoginAsync(object param) {
            List<Doktor> doktori = new List<Doktor>();
            List<Pacijent> pacijenti = new List<Pacijent>();



            foreach (Doktor d in doktori) {
                if (d.Username == username)
                    if (d.Password == password) {
                        MessageDialog Poruka = new MessageDialog("Login complete");
                        await Poruka.ShowAsync();
                    }
                    else {
                        MessageDialog Poruka = new MessageDialog("Invalid password");
                        await Poruka.ShowAsync();
                        return;
                    }
            }
            foreach (Pacijent p in pacijenti) {
                if (p.Username == Username)
                    if (p.Password == Password) {
                        MessageDialog Poruka = new MessageDialog("Login complete");
                        await Poruka.ShowAsync();
                    }
                    else {
                        MessageDialog Poruka = new MessageDialog("Invalid password");
                        await Poruka.ShowAsync();
                        return;
                    }
            }
            MessageDialog Poruka2 = new MessageDialog("User not found");
            await Poruka2.ShowAsync();

        }
    }
}
