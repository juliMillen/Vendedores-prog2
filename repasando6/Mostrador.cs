using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repasando6
{
    class Mostrador:Vendedor
    {
        private int nroSucursal;

        public Mostrador(string nombre, int dni, double sueldo, int nroSucursal) : base(nombre,dni, sueldo)
        {
            this.nroSucursal = nroSucursal;
        }

        public override void AgregarVenta(double monto)
        {
            ventasTotales += monto;
        }

        public override double Sueldo()
        {
            if (ventasTotales <= 10000)
            {
                sueldoBasico *= 0.02;
            }
            else if(ventasTotales>10000 && ventasTotales <= 20000)
            {
                sueldoBasico *= 0.03;
            }
            else
            {
                sueldoBasico *= 0.05;
            }
            return sueldoBasico;
        }

        public override string ToString()
        {
            return "Numero de sucursal:  " + nroSucursal + "\tDni: " + Dni + "\tNombre: " + Nombre + "\nSueldo: " + sueldoBasico.ToString("00.0");
        }
    }
}
