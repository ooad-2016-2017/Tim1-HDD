using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBolnica2.Models;

namespace eBolnica2.Helper
{
    class PopuniBazu
    {
        public static void Initialize(EBolnicaDbContext context)
        {
            if (!context.Pacijenti.Any())
            {
                context.Pacijenti.AddRange(
                new Pacijent("Test", "Test", new DateTime(1999, 2, 2), "1111111111111", "bb", "-", "", 23, "Test", "Test"));
                context.SaveChanges();
            }

            if (!context.Doktori.Any())
            {
                context.Doktori.AddRange(
                new Doktor("Testo", "Test", new DateTime(1999, 2, 2), "2222222222222", "bb", "-", "", 23, "Test1", "Test1"));
                context.SaveChanges();
            }
        }
    }
}
