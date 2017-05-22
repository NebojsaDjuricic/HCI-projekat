using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI
{
    public class Etiketa
    {
        public String OznakaEtikete { get; set; }

        public String BojaEtikete { get; set; }

        public String OpisEtikete { get; set; }

        public Etiketa(String o, String b, String op)
        {
            this.OznakaEtikete = o;
            this.BojaEtikete = b;
            this.OpisEtikete = op;
        }

        public override string ToString()
        {
            return OznakaEtikete;
        }
    }
}
