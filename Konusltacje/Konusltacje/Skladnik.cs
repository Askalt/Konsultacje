using System;
using System.Collections.Generic;
using System.Text;

namespace Konusltacje
{
   public class Skladnik
    {
        public int wengle { get; set; }
        public int tluszcz { get; set; }
        public int sol { get; set; }

        public Skladnik(int wengle, int tluszcz, int sol)
        {
            this.wengle = wengle;
            this.tluszcz = tluszcz;
            this.sol = sol;
        }
        //  public int MyProperty { get; set; } //poleproperty



    }
}
