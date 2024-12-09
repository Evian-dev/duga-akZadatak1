using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dugačakZadatak1
{
    internal class Program
    {
        static void Main(string[] args) 
        {
        }

        
            public class Neboder
        {
            private double visina;
            private int brojKatova;

            public double Visina
            {
                get => visina;
                set => visina = value;
            }

            public int BrojKatova
            {
                get => brojKatova;
                set => brojKatova = value;
            }

            public override string ToString() => $"Visina: {visina} m, Broj katova: {brojKatova}, Prosječna visina kata: {visina / brojKatova} m";

            public Neboder(double visina, int brojKatova)
            {
                this.visina = visina;
                this.brojKatova = brojKatova;
            }
        }

        }
}

