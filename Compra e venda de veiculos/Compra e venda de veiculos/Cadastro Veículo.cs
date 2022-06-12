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

namespace Compra_e_venda_de_veiculos
{
    public partial class CadVeículo : Form
    {
        public CadVeículo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();      
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Veículo o = new Veículo();

            o.ledados(this);
            o.AddImagem(this);
            o.SalvarXML(this);


        }

        private void txtBoxValorTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar)&&(e.KeyChar!=','))
            {
                e.Handled=true;
            }
        }

        private void txtboxKM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
