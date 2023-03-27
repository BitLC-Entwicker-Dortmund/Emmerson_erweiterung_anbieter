namespace Emmerson_erweiterung_anbieter {
    internal class Program {
        static void Main(string[] args) {
            Anbieter einAnbieter = new Anbieter("Tonys Shop");
            Anbieter einAnbieter2 = new Anbieter("Mattins Shop");

            //Console.WriteLine( einAnbieter.GetName() );
            //Console.WriteLine( einAnbieter2.GetName() );

            Artikel a1 = new Artikel("Gyrostorte", 9.99);
            Artikel a2 = new Artikel("Kefünf", 1.5);
            Artikel a3 = new Artikel("Veganer Mozzarella", 3.89);
            Artikel a4 = new Artikel("Grillhändel", 4.5);

            //Console.WriteLine(  a1.GetBezeichnung());

            //// eine Liste von Artikeln
            List<Artikel> eineListe = new List<Artikel>();
            eineListe .Add(a1);
            eineListe .Add(a2);
            eineListe .Add(a3);
            eineListe .Add(a4);

            // Ausgabe der Liste von oben
            foreach (Artikel einEintrag in eineListe) {
                Console.WriteLine(  einEintrag.GetBezeichnung() + "  " +einEintrag.GetPreis() );
            }

            //// neuer Artikelanbieter
            ArtikelAnbieter aa = new ArtikelAnbieter();
            aa.AddAnbieter(einAnbieter);
            aa.AddArtikel(a1);
            aa.AddArtikel(a2);

            Console.WriteLine(  aa.GetAnbieter("Tonys Shop").GetName());
            Console.WriteLine(   aa.GetArtikel("Gyrostorte").GetBezeichnung() +"  " + aa.GetArtikel("Gyrostorte").GetPreis());

            ArtikelAnbieter ab = new ArtikelAnbieter(eineListe, einAnbieter2);
            Console.WriteLine(ab.GetAnbieter("Mattins Shop").GetName());

            Console.Read();
        }
    }
}