using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBolnica.Model {
    public class IzvjestajPregleda {
        private int id;
        private string izvjestaj;

        private static int brojac = 0;

        public IzvjestajPregleda() {
            brojac++;
            this.id = brojac;
        }
        public IzvjestajPregleda(string izvjestaj) {
            this.izvjestaj = izvjestaj;
            brojac++;
            this.id = brojac;
        }

        public string Izvjestaj { get => izvjestaj; set => izvjestaj = value; }
    }
}
