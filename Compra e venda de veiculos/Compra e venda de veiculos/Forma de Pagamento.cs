using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Compra_e_venda_de_veiculos
{
    public partial class Forma_de_Pagamento : Form
    {
        Veículo auto = new Veículo();
        Pagamento PGTO = new Pagamento();
        CadastroCliente cliente = new CadastroCliente();
        Vender_Veículo este;
        
        public Forma_de_Pagamento(Vender_Veículo carro)
        {
            este = carro;
            InitializeComponent();
            cliente.ConsultaCliente(this);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            PGTO.FormaPGTO_Entrada(this);

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                auto.ConsultarVeiculo(este);
                PGTO.InformaçõesDeTransação(this, este);
       
           
        
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            PGTO.Financiamento(this);
        }

        private void ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            PGTO.Crédito(this);
        }

        private void ComboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            PGTO.FormaPGTO_Restante(this);
          
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (comboBoxCliente.Text.ToString() != "")
            {
                PGTO.Vender(this,este);
            }
            else
            {
                MessageBox.Show("Cliente não selecionado");
            }
        }

        private void TxtboxEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
