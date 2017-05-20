using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBolnica.v1.Model
{
    public class Pacijent
    {
        private int id;
        List<Pregled> pregledi = new List<Pregled>();
        List<Lijek> terapija = new List<Lijek>();
        List<LaboratorijskaAnaliza> nalazi = new List<LaboratorijskaAnaliza>();
        private bool prioritet = false;

        private static int brojac = 0;

        public Pacijent()
        {
            brojac++;
            id = brojac;
        }

        /*public List<Pregled> Pregledi { get => pregledi; }
        public List<Lijek> Terapije { get => terapija; set => terapija = value; }
        public List<LaboratorijskaAnaliza> Nalazi { get => nalazi; }*/

        public List<Pregled> Pregledi
        {
            get;
        }
        public List<Lijek> Terapije
        {
            get; set;
        }
        public List<LaboratorijskaAnaliza> Nalazi
        {
            get;
        }


        public void DodajPregled(Pregled pregled)
        {
            pregledi.Add(pregled);
        }

        public void UkljuciTerapiju(Lijek lijek)
        {
            terapija.Add(lijek);
        }

        public void IskljuciTerapiju(Lijek lijek)
        {
            terapija.Remove(lijek);
        }

        public void DodajAnalizu(LaboratorijskaAnaliza analiza)
        {
            nalazi.Add(analiza);
        }
        //public bool Prioritet { get => prioritet; set => prioritet = value; }
        public bool Prioritet
        {
            get;
            set;
        }
    }
}
