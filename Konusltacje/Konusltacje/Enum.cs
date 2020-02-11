using System;
using System.Collections.Generic;
using System.Text;

namespace Konusltacje
{
    [Flags]
    enum Status
    {
        Normalny =0,    //00000
        Trucizna=1,     //00010
        Szal=2,         //00100
        Uciszony=4,     //01000
        Spowolnienie=8, //10000
        Ogluszony=16    //10000
    }
}
