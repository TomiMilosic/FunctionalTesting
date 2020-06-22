using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstWebService.ServiceClient client= new FirstWebService.ServiceClient();

            var StariUporabniki = client.VrniVseUporabnike();
            client.posodobiUporabniskiRacun(1003, "Marko", "1235");
            var NoviUporabniki = client.VrniVseUporabnike();
            var rezultat = false;//arrange

            var list = StariUporabniki.Except(NoviUporabniki);
            if (list.Any(x => x.id == 1003 && x.uporabniskoIme == "Marko" && x.geslo == "1235"))
            {
                rezultat = true;//act
            }

            
            Console.WriteLine(rezultat);
        }
    }
}
