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
            
            return "";
        }
    }
}
