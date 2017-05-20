using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBolnica.v1.Model
{
    public class Odjel
    {
        private string naziv;
        private List<Uposlenik> uposlenici = new List<Uposlenik>();
        private List<Pacijent> redCekanja = new List<Pacijent>();

        /*public string Naziv { get => naziv; set => naziv = value; }
        public List<Uposlenik> Uposlenici { get => uposlenici; }
        public List<Pacijent> Pacijenti { get => redCekanja; }*/

        public string Naziv
        {
            get; set;
        }
        public List<Uposlenik> Uposlenici
        {
            get; set;
        }
        public List<Pacijent> Pacijenti
        {
            get; set;
        }

        public Odjel(string naziv)
        {
            this.Naziv = naziv;
        }

        public void DodajUposlenika(Uposlenik uposlenik)
        {
            uposlenici.Add(uposlenik);
        }
        public void OtpustiUposlenika(Uposlenik uposlenik)
        {
            uposlenici.Remove(uposlenik);
        }
        public void DodajPacijenta(Pacijent pacijent)
        {
            redCekanja.Add(pacijent); //priority ?!
        }
        public void IzbaciPacijenta(Pacijent pacijent)
        {
            redCekanja.Remove(pacijent);
        }
    }
}
