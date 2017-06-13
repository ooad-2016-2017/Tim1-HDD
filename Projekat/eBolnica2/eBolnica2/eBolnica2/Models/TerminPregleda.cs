using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBolnica2.Models
{
    class TerminPregleda:INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        private string doktorJmbg;
        private string pacijentJmbg;
        private DateTime vrijemePregleda;

        public string DoktorJmbg
        {
            get
            {
                return doktorJmbg;
            }

            set
            {
                doktorJmbg = value;
                NotifyPropertyChanged(nameof(DoktorJmbg));
            }
        }

        public string PacijentJmbg
        {
            get
            {
                return pacijentJmbg;
            }

            set
            {
                pacijentJmbg = value;
                NotifyPropertyChanged(nameof(PacijentJmbg));
            }
        }

        public DateTime VrijemePregleda
        {
            get
            {
                return vrijemePregleda;
            }

            set
            {
                vrijemePregleda = value;
                NotifyPropertyChanged(nameof(VrijemePregleda));
            }
        }

        public TerminPregleda() { }
        public TerminPregleda(string _dJ ,string _pJ, DateTime vP)
        {
            DoktorJmbg = _dJ;
            PacijentJmbg = _pJ;
            VrijemePregleda = vP;
        }

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }


    }
}
