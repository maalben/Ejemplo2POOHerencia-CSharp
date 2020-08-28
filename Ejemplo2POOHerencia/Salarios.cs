using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo2POOHerencia
{
    public class Salarios : Nomina
    {

        public double calcularSalarioBase() {
            return ( this.getCantidadHoras() * this.getValorHora() );
        }

    }
}
