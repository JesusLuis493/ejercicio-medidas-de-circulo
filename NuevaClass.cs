using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplocirculo
{
    internal class NuevaClass
    {
        public double radio { get; set; }
        private const double pi = 3.1416;
        public NuevaClass() { }
        public NuevaClass(double radio) { this.radio = radio; }

        public double perimetro()
        {
            return 2 * pi * radio;
        }

        public double area()
        {
            return pi * radio * radio;
        }
        
        public void cambiarRadio(double radio)
        {
            this.radio = radio;
        }
    }
}