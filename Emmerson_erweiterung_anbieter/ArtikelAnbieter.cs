using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emmerson_erweiterung_anbieter {
    internal class ArtikelAnbieter {
        private List<Anbieter> anbieter = new List<Anbieter>();
        private List<Artikel> artikel = new List<Artikel>();

        public void AddArtikel(Artikel a) {
            artikel.Add(a);
        }

        public Artikel GetArtikel(string name) {
            Artikel ergebnis = null;
            foreach (Artikel einArtikel in artikel) {
                if (name == einArtikel.GetBezeichnung()) {
                    ergebnis = einArtikel;
                }
            }
            return ergebnis;
        }

        public void AddAnbieter(Anbieter a) {
            anbieter.Add(a);  
        }

        public Anbieter GetAnbieter(string name) {
            Anbieter ergebnis = null;

            for (int i = 0; i < anbieter.Count; i++) {
                if (name == anbieter[i].GetName()) {
                    ergebnis = anbieter[i];
                    break;
                }
            }
            return ergebnis;
        }

        public ArtikelAnbieter(List<Artikel> artikelListe, Anbieter einAnbieter) {
            this.artikel.AddRange(artikelListe);
            anbieter.Add(einAnbieter);
        }

        public ArtikelAnbieter() {

        }

    }
}
