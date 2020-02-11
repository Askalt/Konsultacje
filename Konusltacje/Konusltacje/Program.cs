using System;
using System.Collections.Generic;
using System.Linq;

namespace Konusltacje
{
    class Program
    {

        static void Main(string[] args)
        {
            #region z1
            ////Stworz liste produktow
            //List<Produkt> produkts = new List<Produkt>();
            ////Wypełnij losowymi danymi
            //List<Skladnik> skladniks = new List<Skladnik>();
            //skladniks.Add(new Skladnik(100, 22, 123));
            //skladniks.Add(new Skladnik(500, 21, 111));
            //skladniks.Add(new Skladnik(20, 120, 20));
            //produkts.Add(new Produkt(skladniks));

            ////Produkty2
            //List<Skladnik> skladniks2 = new List<Skladnik>();
            //skladniks2.Add(new Skladnik(100, 25, 155));
            //skladniks2.Add(new Skladnik(500, 21, 125));
            //skladniks2.Add(new Skladnik(25, 125, 155));
            //produkts.Add(new Produkt(skladniks2));

            //foreach (Produkt item in produkts)
            //{
            //    Console.WriteLine($"Weglowodany {item.lista.Sum(x=>x.wengle)}");
            //    Console.WriteLine($"Tłuszcze {item.lista.Sum(x=>x.tluszcz)}");
            //}
            #endregion
            #region z3
            //Z3 obiekt = new Z3("FFAAEE");
            ////  (string r1, string g1, string b1) = obiekt;
            //var (r, g, b) = obiekt;
            //Console.WriteLine(r+g+b);
            #endregion
            #region z4
            //Panel panel = new Panel();
            //Robot robot = new Robot();
            ////Dopisz do listy nasłuchujących handlerów funkcje WLewo
            //panel.LEFT += robot.WLewo;//alby przypisac event +=
            //panel.RIGHT += robot.WPrawo;
            //panel.RIGHT += robot.WPrawo;
            //panel.RIGHT += robot.WPrawo;
            ////Wywołajfunkcje , ktora opublikuje event LEFT
            //panel.Left();
            //panel.Right();
            //panel.Up();
            //panel.Down();
            #endregion
            #region z3f
            Postac postac = new Postac();
            postac.Kolejka();
            postac.status = Status.Szal;
            postac.Kolejka();
            postac.Kolejka();
            postac.status = Status.Trucizna;
            postac.Kolejka();
            #endregion
        }

    }
}
 
