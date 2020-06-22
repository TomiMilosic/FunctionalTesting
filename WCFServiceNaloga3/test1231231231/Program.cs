using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1231231231
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();


            var stariAvtosaloni = client.VrniAvtoSalone();
            var avtosalon = stariAvtosaloni.LastOrDefault();
            client.poosodobiAvtoSalon(avtosalon.id, "Kia", "Maribor", 1999);
            var NoviAvtoSaloni = client.VrniAvtoSalone();

            var rezultat = NoviAvtoSaloni.Any(x => x.id == 1007 && x.naziv == "Kia");
            if (stariAvtosaloni.Count() == NoviAvtoSaloni.Count())
            {
                Console.WriteLine(rezultat);
            }
        }
    }
}
