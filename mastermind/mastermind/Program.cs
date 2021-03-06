﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastermind
{
    class Program
    {
        static void Main(string[] args) {


            Menu fm = new Menu();

            Menu eredeti = new Menu();
            Menu modositott = new Menu();

            Menu eredetigep = new Menu();
            Menu eredetilathato = new Menu();
            Menu eredetizsuri = new Menu();
            Menu modositottgep = new Menu();
            Menu modositottlathato = new Menu();
            Menu modositottzsuri = new Menu();



            MenuElem eredetime = new MenuElem(eredeti, "Eredeti változat");
            MenuElem modositottme = new MenuElem(modositott, "Módosított változat");

            List<char> Feladvany = new List<char>();


            MenuElem eredetigepme = new MenuElem(() => { Console.Clear();
                for(int i=0;i<4;i++)
                {
                Feladvany.Add('A'); Feladvany.Add('B'); Feladvany.Add('C'); Feladvany.Add('D'); Feladvany.Add('E'); Feladvany.Add('F'); Feladvany.Add('G');
                }

                Feladvany.Kever();


                var stringFeladvany = String.Concat(Feladvany);
                /*String.Concat(
                Feladvany.Where(c => Feladvany.Contains(c))); */

                
                stringFeladvany = stringFeladvany.Substring(0, 4);
                Jatek jatek = new Jatek(stringFeladvany);
                string probalkozas = "";
                for(int i=0;i<10;i++)
                {   

                    probalkozas = Console.ReadLine();
                    
                    if(probalkozas == "s")
                    {
                        jatek.Segitsegadas();
                        i--;
                    }
                     else
                    {
                        Console.WriteLine(jatek.Proba(probalkozas));
                    }



                        
                }
                for(int i=0;i<jatek.TobbszorSzereplok().Count;i++)
                {
                    Console.Write(jatek.TobbszorSzereplok()[i] +" ");
                }
                Console.WriteLine();
                for(int i=0;i<jatek.UtolsoTippnelJoSzinek().Count;i++)
                {
                    Console.Write(jatek.UtolsoTippnelJoSzinek()[i] + " ");
                }
                Console.WriteLine();
                for(int i=0;i<jatek.HanyadikTippelesnelJoEloszor().Length;i++)
                {
                    Console.Write(jatek.HanyadikTippelesnelJoEloszor()[i] + " ");
                }
                Console.WriteLine();
                for(int i=0;i<jatek.EgyszerSemSzerepeltSzinek().Count;i++)
                {
                    Console.Write(jatek.EgyszerSemSzerepeltSzinek()[i] + " ");
                }
                Console.WriteLine();
                for(int i=0;i<jatek.CsakSzinhelyesenSzerepelt().Count;i++)
                {
                    Console.Write(jatek.CsakSzinhelyesenSzerepelt()[i] + " ");
                }
                Console.WriteLine();
            } , "Gép által sorsolt feladvány");





            MenuElem eredetilathatme = new MenuElem(() => { Console.Clear();

                for (int i = 0; i < 4; i++)
                {
                    Feladvany.Add('A'); Feladvany.Add('B'); Feladvany.Add('C'); Feladvany.Add('D'); Feladvany.Add('E'); Feladvany.Add('F'); Feladvany.Add('G');
                }
                Feladvany.Kever();
                var stringFeladvany = String.Concat(
                Feladvany.Where(c => Feladvany.Contains(c)));
                string vegfeladvany = stringFeladvany.Substring(0, 4);
                Jatek jatek = new Jatek(vegfeladvany);
                string probalkozas = "";
                Console.WriteLine("A gép által generált feladvány: ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(vegfeladvany);
                Console.ResetColor();
                Console.WriteLine();

                for (int i = 0; i < 10; i++)
                {

                    probalkozas = Console.ReadLine();

                    if (probalkozas == "s")
                    {
                        jatek.Segitsegadas();
                        i--;
                    }
                    else
                    {
                        Console.WriteLine(jatek.Proba(probalkozas));
                    }


                }

                for (int i = 0; i < jatek.TobbszorSzereplok().Count; i++)
                {
                    Console.Write(jatek.TobbszorSzereplok()[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < jatek.UtolsoTippnelJoSzinek().Count; i++)
                {
                    Console.Write(jatek.UtolsoTippnelJoSzinek()[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < jatek.HanyadikTippelesnelJoEloszor().Length; i++)
                {
                    Console.Write(jatek.HanyadikTippelesnelJoEloszor()[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < jatek.EgyszerSemSzerepeltSzinek().Count; i++)
                {
                    Console.Write(jatek.EgyszerSemSzerepeltSzinek()[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < jatek.CsakSzinhelyesenSzerepelt().Count; i++)
                {
                    Console.Write(jatek.CsakSzinhelyesenSzerepelt()[i] + " ");
                }
                Console.WriteLine();

            }, "Gép által sorsolt feladvány látható színsorral");




            MenuElem eredetizsurime = new MenuElem(() => { Console.Clear();

                Console.WriteLine("Írd be, hogy mi legyen a látható feladvány: ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                string stringFeladvany = Console.ReadLine();
                Console.ResetColor();
                Feladvany.Add(stringFeladvany[0]);
                Feladvany.Add(stringFeladvany[1]);
                Feladvany.Add(stringFeladvany[2]);
                Feladvany.Add(stringFeladvany[3]);
                Jatek jatek = new Jatek(stringFeladvany);
                string probalkozas = "";
                for (int i = 0; i < 10; i++)
                {

                    probalkozas = Console.ReadLine();

                    if (probalkozas == "s")
                    {
                        jatek.Segitsegadas();
                        i--;
                    }
                    else
                    {
                        Console.WriteLine(jatek.Proba(probalkozas));
                    }




                }
                for (int i = 0; i < jatek.TobbszorSzereplok().Count; i++)
                {
                    Console.Write(jatek.TobbszorSzereplok()[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < jatek.UtolsoTippnelJoSzinek().Count; i++)
                {
                    Console.Write(jatek.UtolsoTippnelJoSzinek()[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < jatek.HanyadikTippelesnelJoEloszor().Length; i++)
                {
                    Console.Write(jatek.HanyadikTippelesnelJoEloszor()[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < jatek.EgyszerSemSzerepeltSzinek().Count; i++)
                {
                    Console.Write(jatek.EgyszerSemSzerepeltSzinek()[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < jatek.CsakSzinhelyesenSzerepelt().Count; i++)
                {
                    Console.Write(jatek.CsakSzinhelyesenSzerepelt()[i] + " ");
                }
                Console.WriteLine();



            }, "Zsűri által sorsolt feladvány");





            MenuElem modositottgepme = new MenuElem(() => { Console.Clear();
                Feladvany.Add('A'); Feladvany.Add('B'); Feladvany.Add('C'); Feladvany.Add('D'); Feladvany.Add('E'); Feladvany.Add('F'); Feladvany.Add('G');
                Feladvany.Kever();
                var stringFeladvany = String.Concat(
                Feladvany.Where(c => Feladvany.Contains(c)));
                string vegfeladvany = stringFeladvany.Substring(0, 4);
                Jatek jatek = new Jatek(vegfeladvany);
                string probalkozas = "";
                for (int i = 0; i < 10; i++)
                {

                    probalkozas = Console.ReadLine();

                    if (probalkozas == "s")
                    {
                        jatek.Segitsegadas();
                        i--;
                    }
                    else
                    {
                        Console.WriteLine(jatek.Proba(probalkozas));
                    }




                }
                for (int i = 0; i < jatek.TobbszorSzereplok().Count; i++)
                {
                    Console.Write(jatek.TobbszorSzereplok()[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < jatek.UtolsoTippnelJoSzinek().Count; i++)
                {
                    Console.Write(jatek.UtolsoTippnelJoSzinek()[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < jatek.HanyadikTippelesnelJoEloszor().Length; i++)
                {
                    Console.Write(jatek.HanyadikTippelesnelJoEloszor()[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < jatek.EgyszerSemSzerepeltSzinek().Count; i++)
                {
                    Console.Write(jatek.EgyszerSemSzerepeltSzinek()[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < jatek.CsakSzinhelyesenSzerepelt().Count; i++)
                {
                    Console.Write(jatek.CsakSzinhelyesenSzerepelt()[i] + " ");
                }
                Console.WriteLine();


            }, "Gép által sorsolt feladvány");





            MenuElem modositottlathatme = new MenuElem(() => { Console.Clear();

                Feladvany.Add('A'); Feladvany.Add('B'); Feladvany.Add('C'); Feladvany.Add('D'); Feladvany.Add('E'); Feladvany.Add('F'); Feladvany.Add('G');
                Feladvany.Kever();
                var stringFeladvany = String.Concat(
                Feladvany.Where(c => Feladvany.Contains(c)));
                string vegfeladvany = stringFeladvany.Substring(0, 4);
                Jatek jatek = new Jatek(vegfeladvany);
                string probalkozas = "";
                Console.WriteLine("A gép által generált feladvány: ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(vegfeladvany);
                Console.ResetColor();
                Console.WriteLine();

                for (int i = 0; i < 10; i++)
                {

                    probalkozas = Console.ReadLine();

                    if (probalkozas == "s")
                    {
                        jatek.Segitsegadas();
                        i--;
                    }
                    else
                    {
                        Console.WriteLine(jatek.Proba(probalkozas));
                    }




                }
                for (int i = 0; i < jatek.TobbszorSzereplok().Count; i++)
                {
                    Console.Write(jatek.TobbszorSzereplok()[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < jatek.UtolsoTippnelJoSzinek().Count; i++)
                {
                    Console.Write(jatek.UtolsoTippnelJoSzinek()[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < jatek.HanyadikTippelesnelJoEloszor().Length; i++)
                {
                    Console.Write(jatek.HanyadikTippelesnelJoEloszor()[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < jatek.EgyszerSemSzerepeltSzinek().Count; i++)
                {
                    Console.Write(jatek.EgyszerSemSzerepeltSzinek()[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < jatek.CsakSzinhelyesenSzerepelt().Count; i++)
                {
                    Console.Write(jatek.CsakSzinhelyesenSzerepelt()[i] + " ");
                }
                Console.WriteLine();

            }, "Gép által sorsolt feladvány látható színsorral");




            MenuElem modositottzsurime = new MenuElem(() => { Console.Clear();


                Console.WriteLine("Írd be, hogy mi legyen a látható feladvány: ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                string stringFeladvany = Console.ReadLine();
                Console.ResetColor();
                Feladvany.Add(stringFeladvany[0]);
                Feladvany.Add(stringFeladvany[1]);
                Feladvany.Add(stringFeladvany[2]);
                Feladvany.Add(stringFeladvany[3]);
                Jatek jatek = new Jatek(stringFeladvany);
                string probalkozas = "";
                for (int i = 0; i < 10; i++)
                {

                    probalkozas = Console.ReadLine();

                    if (probalkozas == "s")
                    {
                        jatek.Segitsegadas();
                        i--;
                    }
                    else
                    {
                        Console.WriteLine(jatek.Proba(probalkozas));
                    }
                }
                for (int i = 0; i < jatek.TobbszorSzereplok().Count; i++)
                {
                    Console.Write(jatek.TobbszorSzereplok()[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < jatek.UtolsoTippnelJoSzinek().Count; i++)
                {
                    Console.Write(jatek.UtolsoTippnelJoSzinek()[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < jatek.HanyadikTippelesnelJoEloszor().Length; i++)
                {
                    Console.Write(jatek.HanyadikTippelesnelJoEloszor()[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < jatek.EgyszerSemSzerepeltSzinek().Count; i++)
                {
                    Console.Write(jatek.EgyszerSemSzerepeltSzinek()[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < jatek.CsakSzinhelyesenSzerepelt().Count; i++)
                {
                    Console.Write(jatek.CsakSzinhelyesenSzerepelt()[i] + " ");
                }
                Console.WriteLine();

            }, "Zsűri által megadott feladvány");





            MenuElem vissza = new MenuElem(fm, "vissza");
            MenuElem vissza2 = new MenuElem(fm, "vissza");
            MenuElem kilep = new MenuElem(() => fm.Bezar(), "Kilépés");

            fm.HozzaadMenuElem(eredetime);
            fm.HozzaadMenuElem(modositottme);
            fm.HozzaadMenuElem(kilep);

            eredeti.HozzaadMenuElem(eredetigepme);
            eredeti.HozzaadMenuElem(eredetilathatme);
            eredeti.HozzaadMenuElem(eredetizsurime);
            eredeti.HozzaadMenuElem(vissza);
            modositott.HozzaadMenuElem(modositottgepme);
            modositott.HozzaadMenuElem(modositottlathatme);
            modositott.HozzaadMenuElem(modositottzsurime);
            modositott.HozzaadMenuElem(vissza2);

            fm.Megnyit();

        }
    }

    public class Menu
    {
        private List<MenuElem> elemek = new List<MenuElem>();
        public static ConsoleColor kijelolesSzin = ConsoleColor.DarkGreen;
        public string felsoszoveg = "<MASTERMIND>";
        public string alsoszoveg = "< " + DateTime.Now.ToString("hh:mm:ss" + " >");
        private const string kijelolesSzov = " <";
        private bool fut;

        public void Megnyit()
        {
            fut = true;
            Console.Clear();
            Console.WriteLine(felsoszoveg);
            int elsoSor = Console.CursorTop;
            int kijelolesIndex = 0;
            ConsoleKeyInfo gomb;

            if (elemek.Count > 0)
            {
                KiirSzines(elemek[0].szoveg + kijelolesSzov, kijelolesSzin);
            }
            Console.WriteLine();

            for(int i=1;i<elemek.Count;i++)
            {
                Console.WriteLine(elemek[i].szoveg);
            }
            Console.WriteLine(alsoszoveg);

            Console.CursorTop = elsoSor;


            if(elemek.Count > 0)
            {
                Console.CursorLeft = elemek[0].szoveg.Length + kijelolesSzov.Length;
            }


            do
            {
                gomb = Console.ReadKey();

                if(gomb.Key == ConsoleKey.UpArrow && kijelolesIndex > 0)
                {
                    Console.CursorLeft = 0;
                    Console.Write(elemek[kijelolesIndex].szoveg + new string(' ', kijelolesSzov.Length));
                    Console.CursorLeft = 0;
                    Console.CursorTop = elsoSor + --kijelolesIndex;
                    KiirSzines(elemek[kijelolesIndex].szoveg + kijelolesSzov, kijelolesSzin);
                    
           
                } else if (gomb.Key == ConsoleKey.DownArrow && kijelolesIndex < elemek.Count -1)
                {
                    Console.CursorLeft = 0;
                    Console.Write(elemek[kijelolesIndex].szoveg + new string(' ', kijelolesSzov.Length));
                    Console.CursorLeft = 0;
                    Console.CursorTop = elsoSor + ++kijelolesIndex;
                    KiirSzines(elemek[kijelolesIndex].szoveg + kijelolesSzov, kijelolesSzin);
                } else if(gomb.Key == ConsoleKey.Enter)
                {
                    elemek[kijelolesIndex].Kivalaszt();
                }





            } while (fut);
        }

        public void Bezar()
        {
            fut = false;
        }

        public void HozzaadMenuElem (MenuElem elem)
        {
            elem.menu = this;
            elemek.Add(elem);
        }

        private void KiirSzines (object szoveg, ConsoleColor szin)
        {
            Console.ForegroundColor = szin;
            Console.Write(szoveg);
            Console.ResetColor();
        }



    }

    public class MenuElem
    {
        public Menu menu;
        public delegate void Feladat();

        Feladat amikorKivalaszt;

        public string szoveg;

        public MenuElem(string szov)
        {
            szoveg = szov;
        }

        public MenuElem(Menu masikMenu, string szov)
        {
            szoveg = szov;

            amikorKivalaszt = () =>
            {
                menu.Bezar();
                masikMenu.Megnyit();
            };

            
        }

        public MenuElem(Feladat f, string szov)
        {
            amikorKivalaszt = f;
            szoveg = szov;
        }

       

        public void Kivalaszt()
        {
            if(amikorKivalaszt != null)
            {
                amikorKivalaszt();
            }
        }
    }
}
