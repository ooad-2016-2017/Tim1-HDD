using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBolnica.Model {
    public class Lijek {
        private int id;
        private string naziv;
        private double cijena;
        private int kolicina;
        private bool dostupnost;

        private static int brojac = 0;

        public Lijek(string naziv, double cijena, int kolicina, bool dostupnost) {
            this.naziv = naziv;
            this.cijena = cijena;
            this.kolicina = kolicina;
            this.dostupnost = dostupnost;
            brojac++;
            this.id = brojac;
        }
        public int Id { get => id; set => id = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public double Cijena { get => cijena; set => cijena = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        public bool Dostupnost { get => dostupnost; set => dostupnost = value; }
    }
}
