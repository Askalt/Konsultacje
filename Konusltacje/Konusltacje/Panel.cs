using System;
using System.Collections.Generic;
using System.Text;


namespace Konusltacje
{
    public class Panel
    {
        public event EventHandler UP;
        public event EventHandler DOWN;
        public event EventHandler LEFT;
        public event EventHandler RIGHT;

        public void Up()
        {
            //UP(this, EventArgs.Empty);
            UP?.Invoke(this, EventArgs.Empty);
        }
        public void Down()
        {
            //UP(this, EventArgs.Empty);
            DOWN?.Invoke(this, EventArgs.Empty);
        }
        public void Left()
        {
            //UP(this, EventArgs.Empty);
            LEFT?.Invoke(this, EventArgs.Empty);
        }
        public void Right()
        {
            //UP(this, EventArgs.Empty);
            RIGHT?.Invoke(this, EventArgs.Empty);// ?. jesli cos za pytajniekime jest null nie wykonaj 
        }
    }
}