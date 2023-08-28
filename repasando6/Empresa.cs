using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repasando6
{
    class Empresa
    {
        public Vendedor[] vendedores = new Vendedor[5];
        public double FacturacionTotal { get; set; }
        public int CantVendedores
        {
            get { return vendedores.Length; }
        }

        public Empresa()
        {

        }

        public void CrearLista()
        {
            vendedores[0] = new Mostrador("Juancito",425637482, 15000, 3);
            vendedores[1] = new Mostrador("Pepe",354728161, 16000, 3);
            vendedores[2] = new Mostrador("Carlos",74727191, 18500, 2);
            vendedores[3] = new Online("Cristian",537473821, 12000, "tarde");
            vendedores[4] = new Online("Juan Cruz",37482916 , 13000, "mañana");
        }

        public string VerDatoVendedor(int indice)
        {
            Vendedor v = vendedores[indice];

            if(v is Online)
            {
                Online vOnline = (Online)v;
                return " " + vOnline.ToString();
            }
            else if(v is Mostrador)
            {
                Mostrador vMostrador = (Mostrador)v;
                return " " + vMostrador.ToString();
            }
            return "no exite ese vendedor";
        }

        public void AgregarVenta(int indice, double monto)
        {
            Vendedor vendedor = vendedores[indice];

            if(vendedor != null)
            {
                vendedor.AgregarVenta(monto);
            }
        }
    }
}
