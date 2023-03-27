using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emmerson_erweiterung_anbieter {
    internal class Artikel {

        private string bezeichnung;
        private double preis;
        public void SetBezeichnung(string name) {
            bezeichnung = name;
        }
        public string GetBezeichnung() {
            return bezeichnung;
        }
        public void SetPreis(double preis) {
            this.preis = preis;
        }
        public double GetPreis() {
            return preis;
        }

        public Artikel(string bezeichnung, double preis ) {
            this.bezeichnung = bezeichnung;
            this.preis = preis;
        }

        // Konstuktor


    }
}
