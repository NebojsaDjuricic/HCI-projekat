using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI
{
    public class Resurs
    {
        public String OznakaResursa { get; set; }
        public String ImeResursa { get; set; }
        public String OpisResursa { get; set; }
        public Tip TipResursa { get; set; }
        public String Frekvencija { get; set; }
        public String IkonicaResursa { get; set; }
        public String Obnovljiv { get; set; }
        public String Vaznost { get; set; }
        public String Eksploatacija { get; set; }
        public String Jedinica { get; set; }
        public String Cena { get; set; }
        public String Datum { get; set; }
        public List<Etiketa> EtiketaResursa { get; set; }

        public Resurs(string oznakaResursa, string imeResursa, string opisResursa, Tip tipResursa, string frekvencijaPojavljivanja, string ikonicaResursa, string obnovljivost, string strateskaVaznost, string mogucnostEkspolatacije, string jedinicaMere, string cena, string datum, List<Etiketa> etiketaResursa)
        {
            this.OznakaResursa = oznakaResursa;
            this.ImeResursa = imeResursa;
            this.OpisResursa = opisResursa;
            this.TipResursa = tipResursa;
            this.Frekvencija = frekvencijaPojavljivanja;
            this.IkonicaResursa = ikonicaResursa;
            this.Obnovljiv = obnovljivost;
            this.Vaznost = strateskaVaznost;
            this.Eksploatacija = mogucnostEkspolatacije;
            this.Jedinica = jedinicaMere;
            this.Cena = cena;
            this.Datum = datum;
            this.EtiketaResursa = etiketaResursa;
        }

        public override string ToString()
        {
            return ImeResursa;
        }

        public String getOznakaResursa()
        {
            return OznakaResursa;
        }
    }
}
