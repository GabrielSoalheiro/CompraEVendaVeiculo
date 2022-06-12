using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compra_e_venda_de_veiculos
{
    public partial class ConfirmaExclusão : Form
    {
        ConsultaCliente cliente;
        public ConfirmaExclusão(ConsultaCliente o)
        {
            InitializeComponent();
            cliente = o;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CadastroCliente o = new CadastroCliente();
            o.ExcluiCliente(cliente);
            this.Close();
            cliente.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
