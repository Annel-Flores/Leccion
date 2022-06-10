using System;
using System.Collections.Generic;
using System.Text;

namespace Leccion
{
    class Cir : figu
    {
        public double P, R;

        public Cir(string nombre, string color, double R, double P) : base(nombre, color) { this.R = R; this.P = P; }

        public override void CA() { double A; R = Math.Pow(R, 2); A = R * P; Console.WriteLine("Area" + A); }
        public void IMP3() { Console.WriteLine("nombre" + N); Console.WriteLine("color" + CO); }
    }
}
