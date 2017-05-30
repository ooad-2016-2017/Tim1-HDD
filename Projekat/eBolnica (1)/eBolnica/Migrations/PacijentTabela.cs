using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBolnica.Migrations
{
    class PacijentTabela { 
    
        public string id { get; set; }
        public string AdresaStanovanja { get; set; }
        public string BrojTelefona { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Jmbg { get; set; }
        public string Email { get; set; }
        public string Prezime { get; set; }
        public string Ime { get; set; }
        public bool Prioritet { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
    }
}
