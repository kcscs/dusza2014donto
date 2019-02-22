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
            Dictionary<char, int> paratlan = new Dictionary<char, int>();

            int sotet = 0;
            int vilagos = 0;
            string segitsegsor = "";
            string visszajelzes = "";
            probak.Add(tipp);
            for (int i = 0; i < feladvany.Length; i++)
            {
                if (!paratlan.ContainsKey(feladvany[i]))
                    paratlan.Add(feladvany[i], 0);

                if (tipp[i] == feladvany[i])
                {
                    sotet++;
                } else {
                    paratlan[feladvany[i]]++;
                }
                
            }

            for (int i = 0; i < feladvany.Length; i++) {
                if(feladvany[i] != tipp[i]) {
                    if(paratlan.ContainsKey(tipp[i]) && paratlan[tipp[i]] > 0) {
                        paratlan[tipp[i]]--;
                        vilagos++;
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
