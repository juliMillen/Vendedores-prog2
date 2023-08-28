using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repasando6
{
    abstract class Vendedor
    {
        private string nombre;
        public int Dni { get; set; }
        protected double sueldoBasico;
        protected double ventasTotales;

        public string Nombre { get; set; }

        public Vendedor(string nombre,int dni, double sueldo)
        {
            this.nombre = nombre;
            sueldoBasico = sueldo;
            this.Dni = dni;
        }

        public abstract double Sueldo();

        public abstract void AgregarVenta(double monto);

    }
}
