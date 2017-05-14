using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBolnica.Model {
    public class Pregled {
        private DateTime datumPregleda;
        private int idDoktora;
        private IzvjestajPregleda izvjestaj;

        public Pregled(DateTime datumPregleda, int idDoktora, IzvjestajPregleda izvjestaj) {
            this.datumPregleda = datumPregleda;
            this.idDoktora = idDoktora;
            this.izvjestaj = izvjestaj;
        }

        /*public DateTime DatumPregleda { get => datumPregleda; set => datumPregleda = value; }
        public int IdDoktora { get => idDoktora; set => idDoktora = value; }
        public IzvjestajPregleda Izvjestaj { get => izvjestaj; set => izvjestaj = value; }*/

        public DateTime DatumPregleda
        {
            get; set; }
        public int IdDoktora
        {
            get; set; }
        public IzvjestajPregleda Izvjestaj
        {
            get; set; }
        }
}
