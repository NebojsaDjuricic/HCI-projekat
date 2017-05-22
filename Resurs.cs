using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI
{
    public class Resurs
    {
        public string OznakaResursa { get; set; }
        public string ImeResursa { get; set; }
        public string OpisResursa { get; set; }
        public Tip TipResursa { get; set; }
        public string Frekvencija { get; set; }
        public string IkonicaResursa { get; set; }
        public string Obnovljiv { get; set; }
        public string Vaznost { get; set; }
        public string Eksploatacija { get; set; }
        public string Jedinica { get; set; }
        public string Cena { get; set; }
        public string Datum { get; set; }
        public Etiketa EtiketaResursa { get; set; }

        public Resurs(string oznakaResursa, string imeResursa, string opisResursa, Tip tipResursa, string frekvencijaPojavljivanja, string ikonica, string obnovljivost, string strateskaVaznost, string mogucnostEkspolatacije, string jedinicaMere, string cena, string datum, Etiketa etiketaResursa)
        {
            this.OznakaResursa = oznakaResursa;
            this.ImeResursa = imeResursa;
            this.OpisResursa = opisResursa;
            this.TipResursa = tipResursa;
            this.Frekvencija = frekvencijaPojavljivanja;
            this.IkonicaResursa = ikonica;
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
