using System;
using System.Collections.Generic;

namespace Leccion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<figu> LY = new List<figu>();
            Cuadrado CUA1 = new Cuadrado("#1,Cuadrado: ", " AZUL ELECTRICO", 52);
            CUA1.IMP1();
            rectang REC = new rectang(" #2,Rectangulo:", " VIOLETA", 33, 44);
            REC.IMP2();
            Cir CIR = new Cir("Circulo","#3, VERDE MENTA", 3.5, 3.14);
            CIR.IMP3();
            LY.Add(CIR);
            LY.Add(REC);
            LY.Add(CUA1);

            foreach (figu item in LY)
            {
                item.CA();
            }
        }
    }
}
