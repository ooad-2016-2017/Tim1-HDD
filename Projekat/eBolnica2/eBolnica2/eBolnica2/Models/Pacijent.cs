using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBolnica2.Models
{
    class Pacijent:Osoba
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string id { get; set; } 
        public Pacijent(string ime, string prezime, DateTime datumRodjenja, string jmbg, string adresaStanovanja, string brojTelefona, string email, double plata, String un, String pass) : base(ime, prezime, datumRodjenja, jmbg, adresaStanovanja, brojTelefona, email, un, pass)
        {
            id = jmbg; 
        }

        public Pacijent() { }
    }
}
