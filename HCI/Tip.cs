using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI
{
    public class Tip
    {
        public String OznakaTipa { get; set; }
        public String ImeTipa { get; set; }
        public String OpisTipa { get; set; }
        public String IkonicaTipa { get; set; }


        public Tip(String oz, String im, String op, String ik)
        {
            this.OznakaTipa = oz;
            this.ImeTipa = im;
            this.OpisTipa = op;
            this.IkonicaTipa = ik;
        }

        public override string ToString()
        {
            return OznakaTipa + "-" + ImeTipa;
        }

        public String getIkonicaTipa()
        {
            return IkonicaTipa;
        }
        public void setIkonicaTipa(String s)
        {
            this.IkonicaTipa = s;
        }

        public String getOznakaTipa()
        {
            return OznakaTipa;
        }

        public String getImeTipa()
        {
            return ImeTipa;
        }

        public String getOpisTipa()
        {
            return OpisTipa;
        }
    }
}
