using System;
using System.Collections;
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
    public partial class Vender_Veículo : Form
    {
        Veículo auto = new Veículo();
        public Vender_Veículo()
        {
            InitializeComponent();
            auto.ConsultarVeiculo(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxVeículos.Text.ToString()!="")
            {
                Forma_de_Pagamento o = new Forma_de_Pagamento(this);
                o.Show();

            }
            else
            {
                MessageBox.Show("Selecione o veículo");
            }

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxVeículos.Text.ToString()!="")
            {
                auto.EscolherVeículo(this);
            }
            else
            {
                MessageBox.Show("Cadastre um Veículo primeiro");
            }
         
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            auto.HabilitaAlteraVeic(this);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            auto.AlteraVeic(this);
            MessageBox.Show("Alteração Concluída!");
            this.Close();
        }
    }
}
