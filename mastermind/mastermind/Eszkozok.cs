using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastermind
{
    static class Eszkozok
    {
        /// <summary>
        /// Véletlenszerűen összekeveri a listát
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lista"></param>
        public static void Kever<T>(this List<T> lista) {
            Random rnd = new Random();
            for (int i = 0; i < lista.Count; i++) {
                int j = rnd.Next(0, lista.Count);
                T tmp = lista[i];   // atmeneti valtozo a cserehez
                lista[i] = lista[j];
                lista[j] = tmp;
            }
        }
    }
}
