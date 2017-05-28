using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace eBolnica
{
    public class Doktor : Uposlenik
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int idD;

        public Doktor(string ime, string prezime, DateTime datumRodjenja, string jmbg, string adresaStanovanja, string brojTelefona, string email, double plata, String un, String pass) : base(ime, prezime, datumRodjenja, jmbg, adresaStanovanja, brojTelefona, email, plata, un, pass)
        {
            idD = datumRodjenja.Year;
        }
    }
}
