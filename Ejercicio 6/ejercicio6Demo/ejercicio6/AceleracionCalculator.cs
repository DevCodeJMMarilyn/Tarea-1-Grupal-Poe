using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    internal class AceleracionCalculator
    {
        private double velocidadInicial;
        private double velocidadFinal;
        private double tiempo;

        public AceleracionCalculator(double velocidadInicial, double velocidadFinal, double tiempo)
        {
            this.velocidadInicial = velocidadInicial;
            this.velocidadFinal = velocidadFinal;
            this.tiempo = tiempo;
        }

        public double CalcularAceleracion()
        {
            return (velocidadFinal - velocidadInicial) / tiempo;
        }
    }
}
