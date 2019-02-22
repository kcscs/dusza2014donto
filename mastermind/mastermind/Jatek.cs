using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastermind
{
    partial class Jatek
    {
        private List<string> probak = new List<string>();
        public List<string> visszajelzesek = new List<string>();
        public List<string> segitsegek = new List<string>();
        private string feladvany;
        /// <summary>
        /// a játék előkészítését végző konstruktor
        /// </summary>
        /// <param name="f">a kitalálandó feladvány</param>
        public Jatek(string f)
        {
            feladvany = f;
        }
        public string Proba(string tipp)
        {
            int sotet = 0;
            int vilagos = 0;
            char betu=' ';
            string segitsegsor = "";
            string visszajelzes = "";
            probak.Add(tipp);
            for (int i = 0; i < feladvany.Length; i++)
            {
                if (tipp[i] == feladvany[i])
                {
                    sotet++;
                    betu = tipp[i];
                }
                for (int j = 0; j < feladvany.Length; j++)
                {
                    if (tipp[i] == feladvany[j] && j!=i)
                    {
                        if (betu != tipp[i])
                        {
                            vilagos++;
                        }
                    }
                }
            }
            for (int i = 0; i < sotet; i++)
            {
                visszajelzes += ("s");
            }
            for (int j = 0; j < vilagos; j++)
            {
                visszajelzes += ("v");
            }
            visszajelzesek.Add(visszajelzes);
                return visszajelzes;
        }

        private string segitseg = "";
        public string Segitsegadas()
        {
            if (probak.Count < 6)
            {
                return "";
            }
            else if (segitseg == "")
            {
                for (int i = 0; i < probak.Count; i++)
                {
                    
                    segitseg = probak[i] + "\n" + visszajelzesek[i];
                }
                return segitseg;
            }
            return "";
            
        }
    }
}
