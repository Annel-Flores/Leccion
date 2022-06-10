using System;
using System.Collections.Generic;
using System.Text;

namespace Leccion
{
    abstract class figu
    {
        public string N, CO;
        public figu(string N, string CO) { this.N = N; this.CO = CO; }
        public abstract void CA();
    }
}
