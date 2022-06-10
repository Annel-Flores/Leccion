using System;
using System.Collections.Generic;
using System.Text;

namespace Leccion
{
    class Cuadrado : figu
    {
        public int L;
        public Cuadrado(string N, string CO, int L) : base(N, CO) { this.L = L; }
        public override void CA() { int A; A = L * L; Console.WriteLine("Area" + A); }
        public void IMP1() { Console.WriteLine("nombre" + N); Console.WriteLine("color" + CO); }

    }
}
