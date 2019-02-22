using System;
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

            MenuElem eredetigepme = new MenuElem(eredetigep, "Gép által sorsolt feladvány");
            MenuElem eredetilathatme = new MenuElem(eredetigep, "Gép által sorsolt feladvány látható kisorsolt színsorral");
            MenuElem eredetizsurime = new MenuElem(eredetigep, "Zsűri által megadott feladvány");
            MenuElem modositottgepme = new MenuElem(modositottgep, "Gép által sorsolt feladvány");
            MenuElem modositottlathatme = new MenuElem(modositottgep, "Gép által sorsolt feladvány látható kisorsolt színsorral");
            MenuElem modositottzsurime = new MenuElem(modositottgep, "Zsűri által megadott feladvány");

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
