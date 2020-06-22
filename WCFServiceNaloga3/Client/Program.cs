using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Data.Entity;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstWebService.ServiceClient client = new FirstWebService.ServiceClient();
            client.DodajAvto("wv","golf",20000);
            client.DodajAvtoSalon("porsche","Maribor",1999);
            client.DodajAvtoVavtoSalon(1,1);
            var neke = client.VrniAvteVSalonu().ToList();
            //client.IzbrisiVseAvte();
            foreach (var item in client.VrniAvteVSalonu())
            {
                Console.WriteLine(item.id+" "+item.avto.id+" "+item.avtosaloni.id);
            }


            Console.WriteLine("Vnesite uporabnisko Ime: ");
            string Ime = Console.ReadLine();
            Console.WriteLine("Vnesite geslo: ");
            string geslo = Console.ReadLine();

            //Console.WriteLine(nekaj.Uporabnik(Ime, geslo));


            if (client.Uporabnik(Ime, geslo))
            {
                int a;
                Console.WriteLine("1. Pregled vseh avtohis.\n");
                Console.WriteLine("2. Pregled vseh avtov.\n");
                a = Convert.ToInt32(Console.ReadLine());

                if (a == 1)
                {
                    Console.WriteLine("Vsi Avtosaloni: ");
                    foreach (var item in client.VrniAvtoSalone())
                    {
                        Console.WriteLine(item.id+" "+item.naziv+" "+item.kraj+" "+item.letoUstanovitve);
                    }
                }

                if (a == 2)
                {
                    Console.WriteLine("Vsi avtomobili:");
                    foreach (var item in client.VrniAvte())
                    {
                        Console.WriteLine(item.id+ " "+item.znamka + " " + item.model+" "+item.cena);
                    }

                }



            }
            else
            {
                int b;
                Console.WriteLine("1. Pregled vseh avtosalonov: \n");
                Console.WriteLine("2. Pregled vseh avtov: \n");
                Console.WriteLine("3. Izpis podrobnosti avta: \n");
                Console.WriteLine("4. Avtosalon z najvec avtomobili: \n");
                Console.WriteLine("5. Izpis najstarejsega avtosalona: \n");
                Console.WriteLine("6. Povprecna vrednost avtomobilov: \n");
                Console.WriteLine("7. naloga 4");
                b = Convert.ToInt32(Console.ReadLine());
                if (b == 1)
                {
                    Console.WriteLine("Vsi Avtosaloni: ");
                    foreach (var item in client.VrniAvtoSalone())
                    {
                        Console.WriteLine(item.naziv);
                    }
                }

                if (b == 2)
                {
                    Console.WriteLine("Vsi avtomobili:");
                    foreach (var item in client.VrniAvte())
                    {
                        Console.WriteLine(item.znamka + " " + item.model);
                    }
                }
                if (b == 3)
                {
                    int c;
                    Console.WriteLine("Izberite avto:");
                    foreach (var item in client.VrniAvte())
                    {
                        Console.WriteLine(item.id + " " + item.znamka + " " + item.model);
                    }
                    c = Convert.ToInt32(Console.ReadLine());

                    foreach (var item in client.VrniAvte())
                    {
                        if (item.id == c)
                        {
                            Console.WriteLine("ID: " + item.id + " Znamka: " + item.model + "  Model: " + item.cena);
                        }
                        else
                        {
                            Console.WriteLine("Avta zal ni na seznamu!");
                        }
                    }



                }
                if (b == 4)
                {
                    Console.WriteLine(client.najvecAvtomobilov().naziv);
                }
                if (b == 5)
                {
                    Console.WriteLine(client.najstarejsiAvtosalon().naziv + " " + client.najstarejsiAvtosalon().letoUstanovitve);
                }
                if (b == 6)
                {
                    Console.WriteLine("Povprecna vrednost avtomobilov je: " + client.PovprecnavrednostAvtov());
                }
                if (b == 7)
                {




                    Console.WriteLine("1. Dodajanje novih primerkov vseh entitet (npr. uporabnikov, klubov, igralcev): ");
                    Console.WriteLine("2. Urejanje primerkov vseh entitet: ");
                    Console.WriteLine("3. Brisanje primerkov vseh entitet: ");
                    Console.WriteLine("4. Dodajanje obstoječih primerkov ene entitete k drugi (npr. dodajanje obstoječega igralca klubu): ");
                    Console.WriteLine("5. Odstranjevanje povezav med entitetami (npr. odstranjevanje igralca iz kluba): ");
                    int r = Convert.ToInt32(Console.ReadLine());

                    if (r == 1)
                    {

                        Console.WriteLine("Izberite tabelo na katero želite dodajati:");
                        Console.WriteLine("1. Avti ");
                        Console.WriteLine("2. Avtosalon");
                        Console.WriteLine("3. Dodajanje uporabnikov");
                        int c = Convert.ToInt32(Console.ReadLine());

                        if (c == 1)
                        {
                            Console.WriteLine("Podaj znamko: ");
                            string znamka = Console.ReadLine();
                            Console.WriteLine("Podaj model avta: ");
                            string model = Console.ReadLine();
                            Console.WriteLine("Podaj ceno: ");
                            int cena = Convert.ToInt32(Console.ReadLine());
                            client.DodajAvto(znamka, model, cena);
                            foreach (var item in client.VrniAvte())
                            {
                                Console.WriteLine($"{item.id} {item.znamka} {item.model} {item.cena}");
                            }
                        }
                        if (c == 2)
                        {
                            Console.WriteLine("Podaj naziv avtohise: ");
                            string naziv = Console.ReadLine();
                            Console.WriteLine("Podaj kraj avtohise: ");
                            string kraj = Console.ReadLine();
                            Console.WriteLine("Podaj leto ustanovitve: ");
                            int LetoUstanovitve = Convert.ToInt32(Console.ReadLine());
                            client.DodajAvtoSalon(naziv, kraj, LetoUstanovitve);
                            foreach (var item in client.VrniAvtoSalone())
                            {
                                Console.WriteLine($"{item.id} {item.naziv} {item.kraj} {item.letoUstanovitve}");
                            }



                        }
                        if (c == 3)
                        {
                            Console.WriteLine("Podaj ime uporabnika(Uporabnisko_ime): ");
                            string ime = Console.ReadLine();
                            Console.WriteLine("Podaj geslo uporabnika");
                            geslo = Console.ReadLine();
                            Console.WriteLine($"geslo je: {geslo}");
                            Console.WriteLine("Je uporabnik admin ali ne?");
                            string admin = Console.ReadLine();
                            client.DodajUporabnika(ime, geslo, admin);
                            Console.WriteLine("Uporabnik dodan!");



                        }

                    }

                    if (r == 2)
                    {
                        Console.WriteLine("Katero entiteto zelite urediti?");
                        Console.WriteLine("1. Avte");
                        Console.WriteLine("2. Avto salone");
                        Console.WriteLine("3. Uporabniski racun");
                        int izbira = Convert.ToInt32(Console.ReadLine());
                        if (izbira == 1)
                        {
                            Console.WriteLine("Izberite stevilko avta, katerega zelite posodobiti:");
                            foreach (var item in client.VrniAvte())
                            {
                                Console.WriteLine($"{item.id} {item.znamka} {item.model} {item.cena}");
                            }
                            int id = Convert.ToInt32(Console.ReadLine());

                            string znamka, model;
                            int cena;
                            Console.WriteLine("Vnesite znamko: ");
                            znamka = Console.ReadLine();
                            Console.WriteLine("Vnesite model: ");
                            model = Console.ReadLine();
                            Console.WriteLine("Vnesite ceno: ");
                            cena = Convert.ToInt32(Console.ReadLine());
                            if (znamka != null && model != null && cena > 0)
                            {
                                client.poosodobiAvto(id, znamka, model, cena);
                            }
                            else
                            {
                                Console.WriteLine("Neveljaven vnos!");
                            }


                        }
                        if (izbira == 2)
                        {
                            Console.WriteLine("Izberite stevilko avta salona, katerega zelite posodobiti:");
                            foreach (var item in client.VrniAvtoSalone())
                            {
                                Console.WriteLine($"{item.id} {item.naziv} {item.kraj} {item.letoUstanovitve}");
                            }
                            int id = Convert.ToInt32(Console.ReadLine());

                            string naziv, kraj;
                            int leto;
                            Console.WriteLine("Vnesite naziv: ");
                            naziv = Console.ReadLine();
                            Console.WriteLine("Vnesite kraj: ");
                            kraj = Console.ReadLine();
                            Console.WriteLine("Vnesite leto: ");
                            leto = Convert.ToInt32(Console.ReadLine());
                            if (naziv != null && kraj != null && leto > 0)
                            {
                                client.poosodobiAvtoSalon(id, naziv, kraj, leto);
                            }
                            else
                            {
                                Console.WriteLine("Neveljaven vnos!");
                            }
                        }
                        if (izbira == 3)
                        {
                            Console.WriteLine("Izberite stevilko racuna, katerega zelite posodobiti:");
                            foreach (var item in client.VrniVseUporabnike())
                            {
                                Console.WriteLine($"{item.id} {item.uporabniskoIme} {item.geslo}");
                            }
                            int id = Convert.ToInt32(Console.ReadLine());

                            string naziv, kraj;

                            Console.WriteLine("Vnesite Ime: ");
                            naziv = Console.ReadLine();
                            Console.WriteLine("Vnesite geslo: ");
                            kraj = Console.ReadLine();

                            if (naziv != null && kraj != null)
                            {
                                client.posodobiUporabniskiRacun(id, naziv, kraj);
                            }
                            else
                            {
                                Console.WriteLine("Neveljaven vnos!");
                            }
                        }
                    }

                    if (r == 3)
                    {
                        Console.WriteLine("Iz katere enitete zelite brisati primerke?");
                        Console.WriteLine("1. Avte");
                        Console.WriteLine("2. Avto salone");
                        Console.WriteLine("3. Uporabniski racun");
                        int izbira = Convert.ToInt32(Console.ReadLine());
                        if (izbira == 1)
                        {
                            Console.WriteLine("Izberite avto, ki ga želite izbrisati(stevilka): ");
                            foreach (var item in client.VrniAvte())
                            {
                                Console.WriteLine($"{item.id} {item.znamka} {item.model} {item.cena}");
                            }
                            int izbris = Convert.ToInt32(Console.ReadLine());
                            client.IzbrisiAvto(izbris);

                            foreach (var item in client.VrniAvte())
                            {
                                Console.WriteLine($"{item.id} {item.znamka} {item.model} {item.cena}");
                            }
                        }
                        if (izbira == 2)
                        {

                            Console.WriteLine("Izberite avtosalon, ki ga želite izbrisati(stevilka): ");
                            foreach (var item in client.VrniAvtoSalone())
                            {
                                Console.WriteLine($"{item.id} {item.naziv} {item.kraj}");
                            }
                            int izbris = Convert.ToInt32(Console.ReadLine());
                            client.IzbrisiAvtoSalon(izbris);
                            foreach (var item in client.VrniAvtoSalone())
                            {
                                Console.WriteLine($"{item.id} {item.naziv} {item.kraj}");
                            }
                        }
                        if (izbira == 3)
                        {
                            Console.WriteLine("Izberite uporabnika, ki ga želite izbrisati(stevilka): ");
                            foreach (var item in client.VrniVseUporabnike())
                            {
                                Console.WriteLine($"{item.id} {item.uporabniskoIme}");
                            }
                            int izbris = Convert.ToInt32(Console.ReadLine());
                            client.OdstraniUporabnika(izbris);
                            foreach (var item in client.VrniVseUporabnike())
                            {
                                Console.WriteLine($"{item.id} {item.uporabniskoIme}");
                            }
                        }

                    }

                    if (r == 4)
                    {
                        Console.WriteLine("1. Dodaj avto k avtosalonu: ");
                        Console.WriteLine("2. Dodaj avtosalon k avtu: ");
                        int izbira = Convert.ToInt32(Console.ReadLine());
                        if (izbira == 1)
                        {
                            Console.WriteLine("Avtomobili: ");
                            foreach (var item in client.VrniAvte())
                            {
                                Console.WriteLine($"{item.id} {item.znamka} {item.model} {item.cena}");
                            }

                            Console.WriteLine("Avtosaloni: ");
                            foreach (var item in client.VrniAvtoSalone())
                            {
                                Console.WriteLine($"{item.id} {item.naziv} {item.kraj} {item.letoUstanovitve}");
                            }
                            Console.WriteLine("Vnesite stevilo avtomobila: ");
                            int idavto = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Vnesite stevilo avtosalona: ");
                            int avtosalon = Convert.ToInt32(Console.ReadLine());
                            client.DodajAvtoVavtoSalon(idavto, avtosalon);
                            /*foreach (var item in client.VrniAvteVSalonu())
                            {
                                Console.WriteLine($"{item.avto.znamka} {item.avto.model} {item.avto.cena} je v salonu: {item.avtosalon.naziv} {item.avtosalon.kraj}");
                            }*/
                        }
                        if (izbira == 2)
                        {
                            Console.WriteLine("Avtosaloni: ");
                            foreach (var item in client.VrniAvtoSalone())
                            {
                                Console.WriteLine($"{item.id} {item.naziv} {item.kraj} {item.letoUstanovitve}");
                            }
                            Console.WriteLine("Vnesite stevilo avtosalona: ");
                            int avtosalon = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Avtomobili: ");
                            foreach (var item in client.VrniAvte())
                            {
                                Console.WriteLine($"{item.id} {item.znamka} {item.model} {item.cena}");
                            }
                            Console.WriteLine("Vnesite stevilo avtomobila: ");
                            int idavto = Convert.ToInt32(Console.ReadLine());
                            client.DodajAvtoVavtoSalon(idavto, avtosalon);
                            foreach (var item in client.VrniAvteVSalonu())
                            {
                               // Console.WriteLine($"{item.avtosalon.naziv} {item.avtosalon.kraj} ima avto: {item.avto.znamka} {item.avto.model} {item.avto.cena}");
                            }


                        }
                    }
                    if (r == 5)
                    {
                        Console.WriteLine("1. Odstrani avtomobil iz avtosalona: ");
                        Console.WriteLine("2. Odstrani lastnistvo avtosalona nad avtom: ");
                        int izbira = Convert.ToInt32(Console.ReadLine());
                        if (izbira == 1)
                        {
                            Console.WriteLine("Avtomobili: ");
                            foreach (var item in client.VrniAvte())
                            {
                                Console.WriteLine($"{item.id} {item.znamka} {item.model} {item.cena}");
                            }

                            Console.WriteLine("Avtosaloni: ");
                            foreach (var item in client.VrniAvtoSalone())
                            {
                                Console.WriteLine($"{item.id} {item.naziv} {item.kraj} {item.letoUstanovitve}");
                            }
                            Console.WriteLine("Vnesite stevilo avtomobila: ");
                            int idavto = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Vnesite stevilo avtosalona: ");
                            int avtosalon = Convert.ToInt32(Console.ReadLine());
                            client.OdstraniAvtomobilIzsalona(idavto, avtosalon);
                        }
                        if (izbira == 2)
                        {
                            Console.WriteLine("Avtomobili: ");
                            foreach (var item in client.VrniAvte())
                            {
                                Console.WriteLine($"{item.id} {item.znamka} {item.model} {item.cena}");
                            }

                            Console.WriteLine("Avtosaloni: ");
                            foreach (var item in client.VrniAvtoSalone())
                            {
                                Console.WriteLine($"{item.id} {item.naziv} {item.kraj} {item.letoUstanovitve}");
                            }
                            Console.WriteLine("Vnesite stevilo avtomobila: ");
                            int idavto = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Vnesite stevilo avtosalona: ");
                            int avtosalon = Convert.ToInt32(Console.ReadLine());
                            client.Odstranilastnistvoavtosalonanadavtom(idavto, avtosalon);
                        }

                    }


                }



            }
        }
    }


}

