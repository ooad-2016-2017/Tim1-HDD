using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBolnica
{
    public class Pacijent : Osoba, INotifyPropertyChanged
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        // List<Pregled> pregledi = new List<Pregled>();
        // List<Lijek> terapija = new List<Lijek>();
        private bool prioritet = false;


        //List<LaboratorijskaAnaliza> nalazi = new List<LaboratorijskaAnaliza>();

        private static int brojac = 0;

        public event PropertyChangedEventHandler PropertyChanged;


        public Pacijent(int _id, String _ime, String _prezime, String _korisnickoIme, String _lozinka, DateTime _datumRodjenja, String _email) :
            base(_ime, _prezime, _datumRodjenja, "JMBG", "adresa", "broj", _email)
        {
            id = _id;

            Username = _korisnickoIme;
            Password = _lozinka;



            // pregledi = new List<Pregled>();
            //terapija = new List<Lijek>();
            //brojac++;
            //id = brojac;
        }


        /* public Pacijent() ({
             brojac++;
             id = brojac;
         }*/

        /*public List<Pregled> Pregledi { get => pregledi; }
        public List<Lijek> Terapije { get => terapija; set => terapija = value; }
        public List<LaboratorijskaAnaliza> Nalazi { get => nalazi; }*/

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        //  public List<Pregled> Pregledi
        //{
        //  get;
        //}
        /* public List<Lijek> Terapije
         {
             get { return terapija; }
             set { terapija = value; NotifyPropertyChanged(nameof(Terapije)); }
         }*/
        /*public List<LaboratorijskaAnaliza> Nalazi
        {
            get { return nalazi; }
            set { nalazi = value; NotifyPropertyChanged(nameof(Nalazi)); }
        }*/


        //public void DodajPregled(Pregled pregled)
        //  {
        //  pregledi.Add(pregled);
        //  }

        //public void UkljuciTerapiju(Lijek lijek)
        //{
        // terapija.Add(lijek);
        //  }

        //  public void IskljuciTerapiju(Lijek lijek)
        // {
        //terapija.Remove(lijek);
        //  }

        // public void DodajAnalizu(LaboratorijskaAnaliza analiza)
        //    {
        //nalazi.Add(analiza);
        //    }
        //public bool Prioritet { get => prioritet; set => prioritet = value; }
        public bool Prioritet
        {
            get { return prioritet; }
            set { prioritet = value; NotifyPropertyChanged(nameof(Prioritet)); }
        }
    }
}
