﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Triangulo : IFiguras
    {
        public int Base { get; set; }
        public int Altura { get; set; } 

        public double CalcularArea()
        {
            return Base * Altura / 2;
        }

        public void DatosTriangulo()
        {
            Console.WriteLine("Base: {0}, Altura: {1}", Base, Altura);
        }




    }
}
