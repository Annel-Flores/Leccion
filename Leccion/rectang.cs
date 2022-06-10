using System;
using System.Collections.Generic;
using System.Text;

namespace Leccion
{
    class rectang : figu
    {
        public int AL, B;
        public rectang(string N, string CO, int AL, int B) : base(N, CO) { this.AL = AL; this.B = B; }
        public override void CA() { int A; A = B * AL; Console.WriteLine("Area" + A); }
        public void IMP2() { Console.WriteLine("nombre" + N); Console.WriteLine("color" + CO); }
    }
}
