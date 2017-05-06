using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBolnica.Model {
    public class Bolnica {
        private string naziv;
        private List<Pacijent> pacijenti = new List<Pacijent>();
        private List<Odjel> odjeli = new List<Odjel>();
        //private double finansije = 0; 

        public Bolnica(string naziv) {
            this.naziv = naziv;
        }

        public void DodajPacijenta(Pacijent pacijent) {
            pacijenti.Add(pacijent);
        }
        public void IzbaciPacijenta(Pacijent pacijent) {
            pacijenti.Remove(pacijent);
        }
        public void DodajOdjel(Odjel odjel) {
            odjeli.Add(odjel);
        }
        public void IzbaciOdjel(Odjel odjel) {
            odjeli.Remove(odjel);
        }

        //dodati jos metoda

        //public void IzlistajOsoblje(){}

    }
}
