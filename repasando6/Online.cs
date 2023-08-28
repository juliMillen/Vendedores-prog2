using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repasando6
{
    class Online:Vendedor
    {
        private int totalVentas;
        public string Turno { get; set; }
        public int cantVentas = 0;

        public Online(string nombre,int dni, double sueldo, string turno):base(nombre,dni,sueldo)
        {
            this.Turno = turno;
        }

        public override double Sueldo()
        {
            return sueldoBasico = sueldoBasico + (totalVentas * 0.015);
        }

        public override void AgregarVenta(double monto)
        {
            ventasTotales += monto;
            cantVentas++;
            totalVentas += cantVentas;
        }

        public double Promedio()
        {
            return totalVentas / cantVentas;
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + "\tSueldo: " + sueldoBasico.ToString("00.0") + "\tTurno: " + Turno;
        }
    }
}
