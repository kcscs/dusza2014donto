using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastermind
{
    partial class Jatek
    {

        /// <summary>
        /// Megadja a feladványban többször is előforduló színeket
        /// </summary>
        /// <returns></returns>
        public List<char> TobbszorSzereplok() {
            // ide kerulnek majd a feladvanyban elofordulo karakterek, es hozzajuk rendelve, hogy hanyszor forulnak elo
            Dictionary<char, int> tsz = new Dictionary<char, int>();

            for (int i = 0; i < feladvany.Length; i++) {    // tsz feltoltese, karakterek megszamlalasa
                if (tsz.ContainsKey(feladvany[i]))
                    ++tsz[feladvany[i]];
                else
                    tsz.Add(feladvany[i], 1);
            }
            
            return (from KeyValuePair<char,int> par in tsz where par.Value > 1 select par.Key).ToList();    // az 1-nel tobbszor elofordulo karakterek kivalogatasa
        }

        /// <summary>
        /// Megadja, hogy a játékos utolsó (legutóbbi) tippelésénél melyik színek szerepeltek jó helyen
        /// Figyelem: Csak a színeket adja meg, azt nem, hogy mely helyeken voltak 
        /// </summary>
        /// <returns></returns>
        public List<char> UtolsoTippnelJoSzinek() {
            List<char> jok = new List<char>();  // a jo szinek ide kerulnek majd
            
            for (int i = 0; i < feladvany.Length; i++) {
                if (feladvany[i] == probak.Last()[i])
                    jok.Add(feladvany[i]);
            }

            return jok;
        }

        /// <summary>
        /// Megadja, hogy a feladvány színei, hanyadik tippelésnél kerültek először a helyükre
        /// Ha egy színt egyszer sem találtak el, int.MaxValue-t ad meg a hozzá tartozó sorszámnak
        /// </summary>
        /// <returns>A visszaadott int tömbben az i. helyen az a sorszám van, ahanyadjára a feladvány i. karakterét először sikerült eltalálni</returns>
        public int[] HanyadikTippelesnelJoEloszor() {
            int[] elsoJo = new int[feladvany.Length];

            for (int i = 0; i < feladvany.Length; i++) {    // egyesevel vizsgaljuk a feladvany szineit
                int j = 0;
                while (j < probak.Count && probak[j][i] != feladvany[i])    // addig megyunk a probakon ameddig vegig nem ertunk vagy a szint eltalaltak
                    ++j;
                if (j == probak.Count)
                    elsoJo[i] = int.MaxValue;
                else
                    elsoJo[i] = j;
            }

            return elsoJo;
        }

        /// <summary>
        /// Megadja, hogy a feladványban szereplő színek közül melyek azok, amelyek egyszer sem szerepeltek a tippek között
        /// </summary>
        /// <returns></returns>
        public List<char> EgyszerSemSzerepeltSzinek() {
            HashSet<char> szinek = new HashSet<char>();

            for (int i = 0; i < feladvany.Length; i++) { // a feladvanyban elofordulo szinek kigyujtese (mindegyik csak 1-szer)
                if (!szinek.Contains(feladvany[i]))
                    szinek.Add(feladvany[i]);
            }

            for (int i = 0; i < probak.Count; i++) { // a probak kozott is elofordulo szineket kivesszuk
                for (int j = 0; j < feladvany.Length; j++) {
                    if (szinek.Contains(probak[i][j]))
                        szinek.Remove(probak[i][j]);
                }
            }

            return szinek.ToList(); // a megmaradt szinek azok, amelyek egy probaban sem szerepeltek
        }

        /// <summary>
        /// Megadja azokat a feladványban szereplő színeket, amelyek az összes próba során csak a megfelelő helyen szerepeltek
        /// </summary>
        /// <returns></returns>
        public List<char> CsakSzinhelyesenSzerepelt() {
            HashSet<char> szinek = new HashSet<char>();

            for (int i = 0; i < feladvany.Length; i++) { // a feladvanyban elofordulo szinek kigyujtese (mindegyik csak 1-szer)
                if (!szinek.Contains(feladvany[i]))
                    szinek.Add(feladvany[i]);
            }

            for (int i = 0; i < probak.Count; i++) {
                for (int j = 0; j < feladvany.Length; j++) {
                    if (szinek.Contains(probak[i][j])) {    // a feladvanyban is szereplo szinnel van dolgunk
                        if (feladvany[j] != probak[i][j])   // ami nem szinhelyesen szerepel
                            szinek.Remove(probak[i][j]);    // eldobjuk
                    }
                }
            }

            List<char> egyszerSem = EgyszerSemSzerepeltSzinek();
            foreach (char c in egyszerSem) {    // azokat is ki kell venni, amik egy tipp-ben se voltak benne
                if (szinek.Contains(c))
                    szinek.Remove(c);
            }

            return szinek.ToList(); // a megmaradt szinek azok, amelyek csak szinhelyesen szerepeltek
        }

        /// <summary>
        /// Megadja, hogy az utolsó lépés 
        /// </summary>
        /// <returns></returns>
        /*public int UtolsoLepesLehetosegei() {

        }*/
    }
}
