using System.Collections.Generic;
using System.Linq;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    
    List<UporabniskiRacun> uporabniki = new List<UporabniskiRacun>();
    List<Avto> Avti = new List<Avto>();
    List<Avtosalon> Avtosaloni = new List<Avtosalon>();
    List<AvtoVAvtosalonu> AVS = new List<AvtoVAvtosalonu>();

    Service()
    {
        var db= new AvtosalonContext();
    }

    public List<AvtoVAvtosalonu> IzpisAdmin()
    {
        using (var db= new AvtosalonContext())
        {
            return db.avtoVAvtosaloni.ToList();
        }
        
    }

    public Avtosalon najstarejsiAvtosalon()
    {
        using (var db=new AvtosalonContext())
        {
            Avtosalon najstarejsi = db.avtosaloni.OrderBy(x => x.letoUstanovitve).First();

            return najstarejsi;
        }
        
    }

    public Avtosalon najvecAvtomobilov()
    {
        using (var fb= new AvtosalonContext())
        {
          //  int najvecavtomobilov = AVS.OrderBy(x => x.avto.id).Count();

            //AvtoVAvtosalonu najvecAvtomobilov = AVS.First(x => x.avto.id == 3);


            return new Avtosalon(1, "Porsche", "Maribor", 1984);
        }
        
    }

    public double PovprecnavrednostAvtov()
    {
        using (var db= new AvtosalonContext())
        {
            double povprecna = db.avti.Average(x => x.cena);

            return povprecna;
        }
        
    }

    public bool Uporabnik(string Ime, string geslo)
    {

        using (var db= new AvtosalonContext())
        {
            foreach (var item in db.uporabniskiRacuni.ToList())
            {
                if (item.uporabniskoIme==Ime && item.geslo==geslo)
                {
                    return true;
                }
            }
        }

        return false;

    }

    

    //naloga 4l elelellelelellelelelelleleleleleeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee
    public List<Avto> VrniAvte()
    {
        using (var db = new AvtosalonContext())
        {
            db.Configuration.ProxyCreationEnabled= false;
            var test = db.avti.ToList();
            return db.avti.ToList();
        }
    }

    public List<AvtoVAvtosalonu> VrniAvteVSalonu()
    {
        using (var db= new AvtosalonContext())
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.avtoVAvtosaloni.ToList();
        }
    }

    //prikaz vseh avtov
    public List<Avtosalon> VrniAvtoSalone()
    {
        using (var db = new AvtosalonContext())
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.avtosaloni.ToList();
        }
    }





    public bool DodajAvto(string znamka, string model, int cena)
    {

        Avto avto = new Avto { znamka = znamka, model = model, cena = cena };
        using (var db = new AvtosalonContext())
        {
            db.avti.Add(avto);
            db.SaveChanges();
            return true;
        }
    }

    public bool DodajAvtoSalon(string naziv,string kraj, int LetoUstanovitve)
    {
        using (var db= new AvtosalonContext())
        {
            Avtosalon avtoSalon = new Avtosalon { naziv = naziv, kraj = kraj, letoUstanovitve = LetoUstanovitve };
            db.avtosaloni.Add(avtoSalon);
            db.SaveChanges();
            return true;
        }
        
        
    }

    public bool DodajAvtoVSalon(int idAvtosalona, int idavta)
    {

        using (var db = new AvtosalonContext())
        {

            var EnAvtoSalon = db.avtosaloni.Find(idAvtosalona);
            var avto = db.avti.Find(idavta);
            EnAvtoSalon.avti.Add(avto);
            db.avtosaloni.Add(EnAvtoSalon);
            db.SaveChanges();
            return true;
        }
    }


    public bool poosodobiAvto(int a,string znamka,string model,int cena)
    {
        bool flag = false;
        using (var db = new AvtosalonContext())
        {
            foreach (var item in db.avti.ToList())
            {
                if (item.id==a)
                {
                    item.znamka = znamka;
                    item.model = model;
                    item.cena = cena;
                    flag = true;
                    db.SaveChanges();

                }
            }

            
            return flag;
        }
    }




    public bool poosodobiAvtoSalon(int a, string naziv, string kraj, int leto)
    {
        using (var db = new AvtosalonContext())
        {

            bool flag = false;
            foreach (var item in db.avtosaloni.ToList())
            {
                if (item.id == a)
                {
                    item.naziv = naziv;
                    item.kraj = kraj;
                    item.letoUstanovitve = leto; 
                    
                    flag = true; 

                }
            }



            db.SaveChanges();
            return flag;
        }
    }



    public bool poosodobiAvtoVSalonu(int ID,int NoviAvto,int NoviAvtoSalon)
    {
        bool flag = false;
        using (var db = new AvtosalonContext())
        {

            foreach (var item in db.avtoVAvtosaloni.ToList())
            {
                if (item.id==ID)
                {
                    item.avto = NoviAvto;
                    item.avtosaloni = NoviAvtoSalon;
                    flag = true;
                    db.SaveChanges();
                }
            }
             
            return flag;
        }
    }


    public bool IzbrisiAvto(int id)
    {
        using (var db = new AvtosalonContext())
        {
            bool flag = false;
            int nekaj = 0;
    
            foreach (var item in db.avti.ToList())
            {
                if (item.id==id)
                {
                    flag = true;
                    nekaj = id;
                    db.avti.Remove(item);
                    db.SaveChanges();
                    OdstraniOdvecneSalone(nekaj, 0);
                }
                
            }
            return flag;
            
        }

    }



    public bool IzbrisiAvtoSalon(int id)
    {
        using (var db = new AvtosalonContext())
        {
            bool flag = false;
            int nekaj = 0;
            foreach (var item in db.avtosaloni.ToList())
            {
                if (item.id==id)
                {
                    flag = true;
                    nekaj = id;
                    db.avtosaloni.Remove(item);
                    db.SaveChanges();
                    
                    OdstraniOdvecneSalone(0, nekaj);
                }
            }
            
            return flag; ;
        }

    }


    public bool DodajAvtoVavtoSalon(int avtoid, int savtolonid)
    {
        using (var db = new AvtosalonContext())
        {
            db.avtoVAvtosaloni.Add(new AvtoVAvtosalonu { avto = avtoid, avtosaloni= savtolonid });
            db.SaveChanges();
            return true;
        }
    }

    public bool DodajAvtosalonAvtu(int avtoid, int savtolonid)
    {
        using (var db = new AvtosalonContext())
        {
            Avto avto = db.avti.Find(avtoid);
            Avtosalon avtosalon = db.avtosaloni.Find(savtolonid);
            avto.avtosaloni.Add(avtosalon);
            db.avti.Add(avto);
            db.SaveChanges();
            return true;
        }
    }

    public bool OdstraniAvtoVavtosalonu(int ID)
    {
        using (var db = new AvtosalonContext())
        {
            bool flag = false;
            foreach (var item in db.avtoVAvtosaloni)
            {
                if (item.id==ID)
                {
                    db.avtoVAvtosaloni.Remove(item);
                    flag = true;
                    
                }
            }
            db.SaveChanges();
            return flag;
        }
    }

    public bool DodajUporabnika(string Ime, string geslo, string admin)
    {
        using (var db= new AvtosalonContext())
        {
            if (admin == "Da" || admin == "DA" || admin == "Ja" || admin == "JA" || admin=="True")
            {
                UporabniskiRacun racun = new UporabniskiRacun(Ime,geslo,UporabniskiRacun.Admin.da);
                db.uporabniskiRacuni.Add(racun);
                db.SaveChanges();
            }
            else
            {
                UporabniskiRacun racun = new UporabniskiRacun(Ime, geslo, UporabniskiRacun.Admin.ne);
                db.uporabniskiRacuni.Add(racun);
                db.SaveChanges();
            }
            return true;
        }
    }

    public bool OdstraniUporabnika(int id)
    {
        using (var db= new AvtosalonContext())
        {
            bool flag = false;
            UporabniskiRacun neke = new UporabniskiRacun();
            foreach (var item in db.uporabniskiRacuni.ToList())
            {
                if (item.id==id)
                {
                    neke = item;
                    flag = true;
                }
            }
            db.uporabniskiRacuni.Remove(neke);
            db.SaveChanges();
            return flag;
        }
    }

    public List<UporabniskiRacun> VrniVseUporabnike()
    {
        using (var db= new AvtosalonContext())
        {
            return db.uporabniskiRacuni.ToList<UporabniskiRacun>();
        }
    }

    public bool IzbrisiVseAvte()
    {
        using (var db= new AvtosalonContext())
        {
            foreach (var item in db.avti)
            {
                db.avti.Remove(item);
            }
            db.SaveChanges();
            return true;
        }
    }

    public bool OdstraniAvtomobilIzsalona(int avtoid, int avtosalonid)
    {
        using (var db = new AvtosalonContext())
        {
            Avto avto = new Avto();
            Avtosalon avtosalon = new Avtosalon();

            foreach (var item in db.avti.ToList())
            {
                if (item.id == avtoid)
                {
                    avto = item;
                }
            }

            foreach (var item in db.avtosaloni.ToList())
            {
                if (item.id == avtosalonid)
                {
                    avtosalon = item;
                }
            }

           //db.avtoVAvtosaloni.Remove(new AvtoVAvtosalonu { avto = avto, avtosalon = avtosalon });

            db.SaveChanges();
            return true;
        }
    }

    public bool Odstranilastnistvoavtosalonanadavtom(int avtoid, int avtosalonid)
    {
        using (var db = new AvtosalonContext())
        {
            Avto avto = new Avto();
            Avtosalon avtosalon = new Avtosalon();

            foreach (var item in db.avti.ToList())
            {
                if (item.id == avtoid)
                {
                    avto = item;
                }
            }

            foreach (var item in db.avtosaloni.ToList())
            {
                if (item.id == avtosalonid)
                {
                    avtosalon = item;
                }
            }

           // db.avtoVAvtosaloni.Remove(new AvtoVAvtosalonu { avto = avto, avtosalon = avtosalon });

            db.SaveChanges();
            return true;
        }
    }

    public bool posodobiUporabniskiRacun(int id, string Ime, string geslo)
    {
        using (var db = new AvtosalonContext())
        {
            foreach (var item in db.uporabniskiRacuni.ToList())
            {
                if (item.id == id)
                {
                    item.uporabniskoIme = Ime;
                    item.geslo = geslo;
                }
            }



            db.SaveChanges();
            return true;
        }
    }



    public bool OdstraniOdvecneSalone(int a, int b)
    {
        using (var db=new  AvtosalonContext())
        {

            foreach (var item in db.avtoVAvtosaloni.ToList())
            {
                if (a==item.avto)
                {
                    db.avtoVAvtosaloni.Remove(item);
                }
                if (b==item.avtosaloni)
                {
                    db.avtoVAvtosaloni.Remove(item);
                }
            }

            db.SaveChanges();
            return true;
        }
    }
}

