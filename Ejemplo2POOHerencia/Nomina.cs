using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo2POOHerencia
{
    public class Nomina
    {
        //Atributos por usuario
        private double cantidadHoras;

        //Atributos por constructor
        private double valorHora;

        //Constructor
        public Nomina() {
            double minimo;
            minimo = 900000;
            this.valorHora = minimo / 240;
        }

        //Métodos setter y getter

        public void setCantidadHoras(double valor) {
            this.cantidadHoras = valor;
        }

        public double getCantidadHoras() {
            return this.cantidadHoras;
        }

        public double getValorHora() {
            return this.valorHora;
        }
    }
}
