using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using naloga7_unitTest.FirstWebService;

namespace naloga7_unitTest
{
    [TestClass]
    public class Uporabnik
    {
        

        ServiceClient client = new ServiceClient();

      

        [TestInitialize]
        public void Uporabnik_dodajUporabnika_returnTrue()
        {
            var StariUporabniki = client.VrniVseUporabnike();
            client.DodajUporabnika("Tomi","1234","Da"); // arrange
            var Uporabniki = client.VrniVseUporabnike();

            bool rezultat = Uporabniki.Any(x => x.uporabniskoIme == "Tomi" && x.geslo == "1234" && x.admin == UporabniskiRacun.Admin.da);//act

            if (StariUporabniki.Count() != Uporabniki.Count())
            {
                Assert.IsTrue(rezultat);//assert
            }
            else
            {
                Assert.Fail("Napaka!");
            }
            

        }

        [TestMethod]
        public void Uporabnik_poosodobiUporabnika_returnTrue()
        {
            var StariUporabniki = client.VrniVseUporabnike();
            var oseba = StariUporabniki.LastOrDefault();
            client.posodobiUporabniskiRacun(oseba.id, "Marko", "1235");
            var NoviUporabniki = client.VrniVseUporabnike();

            var rezultat = NoviUporabniki.Any(x => x.id == 1003 && x.uporabniskoIme == "Marko");
            if (StariUporabniki.Count()==NoviUporabniki.Count())
            {
                Assert.IsTrue(true);//assert
            }

        }

        [TestCleanup]
        public void Uporabnik_odstraniUporabnika_returnTrue()
        {
            var StariUporabniki = client.VrniVseUporabnike();

            var Oseba = StariUporabniki.LastOrDefault();
            client.OdstraniUporabnika(Oseba.id);//odstranis zadnjega iz seznama


            var NoviUporabniki = client.VrniVseUporabnike();

            if (NoviUporabniki.Count()-1==StariUporabniki.Count())
            {
                Assert.AreNotEqual(NoviUporabniki, StariUporabniki);
            }
           

        }

    }

    [TestClass]
    public class Avto
    {
         public ServiceClient client = new ServiceClient();

        [TestInitialize]
        public void Avto_dodajAvto_returnTrue()
        {
            var vsiAvtiStari = client.VrniAvte();
            client.DodajAvto("volkswagen","golf",19000); // arrange
            var vsiAvti = client.VrniAvte();

            bool rezultat = vsiAvti.Any(x => x.znamka == "volkswagen" && x.model == "golf" && x.cena==19000);//act
            if (vsiAvti.Count() != vsiAvtiStari.Count())
            {
                Assert.IsTrue(rezultat);//assert
            }
           
        }

        [TestMethod]
        public void Avto_poosodobiAvto_returnTrue()
        {
            var StariAvti = client.VrniAvte();
            var avto = StariAvti.LastOrDefault();
            client.poosodobiAvto(avto.id, "Kia", "StingerGT",20000);
            var NoviAvti = client.VrniAvte();

            var rezultat = NoviAvti.Any(x => x.id == 7 && x.model== "golf");
            if (StariAvti.Count() == NoviAvti.Count())
            {
                Assert.IsTrue(true);//assert
            }
        }

        [TestCleanup]
        public void Avto_odstraniAvto_returnTrue()
        {
            var StariAvti = client.VrniAvte();

            var avto = StariAvti.LastOrDefault();
            client.IzbrisiAvto(avto.id);//odstranis zadnjega iz seznama


            var NoviAvti = client.VrniAvte();

            if (NoviAvti.Count() - 1 == StariAvti.Count())
            {
                Assert.AreNotEqual(NoviAvti, StariAvti);
            }
            
        }
    }


    [TestClass]
    public class Avtosalon
    {
        public ServiceClient client = new ServiceClient();

        [TestInitialize]
        public void Avtosalon_dodajAvtosalon_returnTrue()
        {
            var StariAvtoSaloni = client.VrniAvtoSalone();
            client.DodajAvtoSalon("kia", "Maribor", 1987); // arrange
            var NoviAvtoSaloni = client.VrniAvtoSalone();

            bool rezultat = NoviAvtoSaloni.Any(x => x.naziv == "kia" && x.kraj == "Maribor" && x.letoUstanovitve == 1987);//act
            if (StariAvtoSaloni.Count() != NoviAvtoSaloni.Count())
            {
                Assert.IsTrue(rezultat);//assert
            }
           
        }

        [TestMethod]
        public void Avtosalon_poosodobiAvtosalon_returnTrue()
        {
            
            var stariAvtosaloni = client.VrniAvtoSalone();
            var avtosalon = stariAvtosaloni.FirstOrDefault();
            client.poosodobiAvtoSalon(avtosalon.id, "Kia", "Maribor", 1999);
            var NoviAvtoSaloni = client.VrniAvtoSalone();

            var rezultat = NoviAvtoSaloni.Any(x => x.id == avtosalon.id && x.naziv == "Kia" && x.letoUstanovitve==1999);
            if (stariAvtosaloni.Count() == NoviAvtoSaloni.Count())
            {
                Assert.IsTrue(rezultat);//assert
            }
        }

        [TestCleanup]
        public void Avtosalon_odstraniAvtosalon_returnTrue()
        {
            var StariAvtOSaloni = client.VrniAvtoSalone();

            var avtoSalon = StariAvtOSaloni.LastOrDefault();
            client.IzbrisiAvtoSalon(avtoSalon.id);//odstranis zadnjega iz seznama


            var NoviAvtoSaloni = client.VrniAvtoSalone();

            if (NoviAvtoSaloni.Count() - 1 == StariAvtOSaloni.Count())
            {
                Assert.AreNotEqual(NoviAvtoSaloni, StariAvtOSaloni);
            }
           
        }

    }


    [TestClass]
    public class AvtoVSalonu
    {
        public ServiceClient client = new ServiceClient();


        [TestInitialize]
        public void AvtoVSalonu_DodajAvtoVSalonu_returnTrue()
        {
            var vsiAvtiStari = client.VrniAvteVSalonu();
            client.DodajAvtoVavtoSalon(1008,1007); // arrange
            var vsiAvti = client.VrniAvteVSalonu();

            bool rezultat = vsiAvti.Any(x => x.avto==1008 && x.avtosaloni==1007);//act
            if (vsiAvti.Count() != vsiAvtiStari.Count())
            {
                Assert.IsTrue(rezultat);//assert
            }
           
        }

        [TestMethod]
        public void AvtoVSalonu_poosodobiAvtoVSalonu_returnTrue()
        {
            var StariAvtoVsalonu = client.VrniAvteVSalonu();
            var idAvta = StariAvtoVsalonu.LastOrDefault();
            var idAvto = client.VrniAvte().Last().id;
            var idsalona = client.VrniAvtoSalone().Last().id;
            client.poosodobiAvtoVSalonu(idAvta.id,idAvto,idsalona);
            var NoviAvtosaloni= client.VrniAvteVSalonu();

            var rezultat = NoviAvtosaloni.Any(x => x.avto == idAvto && x.avtosaloni == idsalona && x.id==idAvta.id);
            if (StariAvtoVsalonu.Count() == NoviAvtosaloni.Count())
            {
                Assert.IsTrue(rezultat);//assert
            }
        }

        [TestCleanup]
        public void AvtoVSalonu_odstraniAvtoVSalonu_retun()
        {
            var StariAvtoVsalonu = client.VrniAvteVSalonu();

            var avtoVsalonu = StariAvtoVsalonu.LastOrDefault();
            client.OdstraniAvtoVavtosalonu(avtoVsalonu.id);//odstranis zadnjega iz seznama

            var NoviAvtoVsalonu= client.VrniAvte();

            if (NoviAvtoVsalonu.Count() - 1 == StariAvtoVsalonu.Count())
            {
                Assert.AreNotEqual(NoviAvtoVsalonu, StariAvtoVsalonu);
            }
           
        }


    
    }


    [TestClass]
    public class Osebnitesti
    {
        ServiceClient client = new ServiceClient();

        [TestMethod]
        public void Avto_OdstraniAvto_returnFalse() 
        {
            var stariAvti = client.VrniAvte();
            client.IzbrisiAvto(9999999);
            var NoviAvti = client.VrniAvte();

            var rezultat = NoviAvti.Any(x => x.id == 9999999);
            Assert.IsFalse(rezultat);//Izbrisi Avto katerega ni!
        }

        [TestMethod]
        public void AvtoSalonn_poosodobiAvtosalon_returnFalse()
        {
            Assert.IsFalse(client.poosodobiAvtoSalon(233434, "asdaada", "asdasdas", 999999));//poosodobitev avtosalona katerega ni v bazi!
        }

        [TestMethod]
        public void Uporabnik_PrimerjavaUporabnikov_returnTrue()
        {
            UporabniskiRacun oseba1 = new UporabniskiRacun { uporabniskoIme="Tomi",geslo="1234",admin=UporabniskiRacun.Admin.da};//primerjava dveh objektov
            UporabniskiRacun oseba2 = new UporabniskiRacun {uporabniskoIme= "Marko", geslo = "asdf",admin= UporabniskiRacun.Admin.ne};
            Assert.AreNotEqual(oseba1,oseba2);
        }

        [TestMethod]
        public void Uporabnik_xuporabnik_returnFalse()
        {
            var rezultat = client.VrniVseUporabnike().Any(x=>x.id==9999);//ni uporabnika s tem idjem

            Assert.IsFalse(rezultat);
        }

    
    }
}
