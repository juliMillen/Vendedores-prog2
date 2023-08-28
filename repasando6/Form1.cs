using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repasando6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Empresa empresa;
        Vendedor nuevoVendedor;
        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombreEmpresa = tBempresa.Text;
            empresa = new Empresa();
            lBlista.Items.Add("Empresa: " + nombreEmpresa);
            empresa.CrearLista();
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            foreach(Vendedor listaV in empresa.vendedores)
            {
                lBlista.Items.Add("--------------------------------------------");
                if(listaV is Mostrador)
                {
                    lBlista.Items.Add(" " + ((Mostrador)listaV).ToString());
                }
                else if(listaV is Online)
                {
                    lBlista.Items.Add(" " + ((Online)listaV).ToString());
                }
            }
           
        }

        private void btnVerV_Click(object sender, EventArgs e)
        {
            lBlista.Items.Clear();
            lBlista.Items.Add(" " + empresa.VerDatoVendedor(1));
        }
    }
}
