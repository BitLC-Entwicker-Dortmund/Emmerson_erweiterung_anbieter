using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emmerson_erweiterung_anbieter {
    internal class Anbieter {
        private string name;

        public void SetName(string name) {
            this.name = name;
        }

        public string GetName() { 
            return this.name; 
        }

        public Anbieter(string name) {
            this.name = name;
        }
    }
}
