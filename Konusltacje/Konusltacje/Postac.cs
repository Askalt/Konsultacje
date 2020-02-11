using System;
using System.Collections.Generic;
using System.Text;

namespace Konusltacje
{
    class Postac
    {
        private bool spowolniony = true;
        public int HP;
        public Status status;

        public Postac()
        {
            HP = 10;
            status = Status.Trucizna;
        }

    public void Kolejka()
        {
            switch (status)
            {
                case Status.Normalny:
                    break;
                case Status.Trucizna:
                    break;
                case Status.Szal:
                    break;
                case Status.Uciszony:
                    break;
                case Status.Spowolnienie:
                    break;
                case Status.Ogluszony:
                    break;
                default:
                    break;
            }

            if (Status.Normalny==status)
            {
                Console.WriteLine("Co zrobisz ?");
                Console.ReadLine();
            }
           else if (Status.Trucizna==status)
            {
                HP -= 2;
                Console.WriteLine($"Otruty {HP}");
            }
            else if (Status.Ogluszony==status)
            {
                Console.WriteLine("Tracisz kolejke");
                status &= status & ~Status.Ogluszony;
            }
            else if(Status.Spowolnienie==status)
            {
                if (spowolniony)
                {
                    Console.WriteLine("Tracisz kolejek");
                    spowolniony = false;
                }
                else
                {
                    Console.WriteLine("Co robisz ?");
                    Console.ReadLine();
                    spowolniony = true;
                }
            }
            else if (Status.Szal==status)
            {
                Console.WriteLine("Postac ruszyła do ataku");
            }
        }
    }
}
