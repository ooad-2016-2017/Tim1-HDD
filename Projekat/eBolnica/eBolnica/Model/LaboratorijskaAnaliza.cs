using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBolnica.Model {
    public class LaboratorijskaAnaliza {
        DateTime datumAnalize;
        int idMedicinskeSestre;
        string vrstaAnalize;
        string komentar; //rezultat

        public LaboratorijskaAnaliza(DateTime datumAnalize, int idMedicinskeSestre, string vrstaAnalize, string komentar) {
            this.datumAnalize = datumAnalize;
            this.idMedicinskeSestre = idMedicinskeSestre;
            this.vrstaAnalize = vrstaAnalize;
            this.komentar = komentar;
        }

        public DateTime DatumAnalize { get => datumAnalize; set => datumAnalize = value; }
        public int IdMedicinskeSestre { get => idMedicinskeSestre; set => idMedicinskeSestre = value; }
        public string VrstaAnalize { get => vrstaAnalize; set => vrstaAnalize = value; }
        public string Komentar { get => komentar; set => komentar = value; }
    }
}
