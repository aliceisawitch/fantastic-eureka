using System;

namespace Komis.Models
{
    public class Samochod
    {
        public int Id { get; set; }

        public String Marka { get; set; }

        public String Model { get; set; }

        public int RokProdukcji { get; set; }

        public String Przebieg { get; set; }

        public String Pojemnosc { get; set; }

        public String RodzajPaliwa { get; set; }

        public String Moc { get; set; }

        public String Opis { get; set; }

        public decimal Cena { get; set; }

        public String ZdjecieUrl { get; set; }

        public String MiniaturkaUrl { get; set; }

        public bool JestSamochodemTygodnia { get; set; }

    }
}
