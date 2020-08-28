using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo2POOHerencia
{
    public class Descuentos : Salarios
    {

        public double calcularSalud() {
            if (this.calcularSalarioBase() >= 2000000) {
                return (this.calcularSalarioBase() * 0.04);
            } else {
                return (this.calcularSalarioBase() * 0.02);
            }
        }

        public double calcularPension() {
            if (this.calcularSalarioBase() >= 2000000){
                return (this.calcularSalarioBase() * 0.04);
            }else{
                return (this.calcularSalarioBase() * 0.02);
            }
        }

        public double calcularCcf() {
            if (this.calcularSalarioBase() >= 2000000){
                return (this.calcularSalarioBase() * 0.02);
            }else{
                return (this.calcularSalarioBase() * 0.01);
            }
        }

        public double calcularSalarioConDescuento() {
            return (this.calcularSalarioBase() - (this.calcularSalud() + this.calcularPension() + this.calcularCcf()));
        }

    }
}
