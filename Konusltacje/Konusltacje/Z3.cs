using System;
using System.Collections.Generic;
using System.Text;

namespace Konusltacje
{
    class Z3
    {
        public Z3(string kod)
        {
            Kod = kod;
        }

        public string Kod { get; set; }

        //public void Deconstruct(out string R,out string G,out string B)
        //{
        //    R = Kod[0].ToString() + Kod[1].ToString();
        //    G = Kod[2].ToString() + Kod[3].ToString();
        //    B = Kod[4].ToString() + Kod[5].ToString();
        //}

        public void Deconstruct(out int R, out int G, out int B)
        {
            R = Convert.ToInt32(Kod.Substring(0, 2), 16);
            G = Convert.ToInt32(Kod.Substring(2, 4), 16);
            B = Convert.ToInt32(Kod.Substring(4, 2), 16);
        }


    }
}
