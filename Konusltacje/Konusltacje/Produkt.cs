using System;
using System.Collections.Generic;
using System.Text;

namespace Konusltacje
{
    public class Produkt
    {
        public List<Skladnik> lista = new List<Skladnik>();
        public Produkt(List<Skladnik> lista)
        {
            this.lista = lista;
        }

    }
}
