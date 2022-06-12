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

namespace Compra_e_venda_de_veiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!(File.Exists(@"C:\Dados.xml")))
            {
                XmlTextWriter meuwriter = new XmlTextWriter(@"C:\Dados.xml", null);
                
                meuwriter.WriteStartDocument();
                meuwriter.WriteStartElement("Dados");
                meuwriter.WriteEndElement();
                meuwriter.Close();
                MessageBox.Show("O Banco de dados XML foi criado !");
             
            }
            
        }

           private void button2_Click(object sender, EventArgs e)
        {
            CadVeículo o = new CadVeículo();
            o.Show();
        }

        private void buttonCadCliente_Click(object sender, EventArgs e)
        {
            CadCliente o = new CadCliente();
            o.Show();
        }

        private void buttonVendVeic_Click(object sender, EventArgs e)
        {
            try
            {
                Vender_Veículo o = new Vender_Veículo();
                o.Show();
            }
            catch (Exception)
            {

            }
           
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Relatório o = new Relatório();
            o.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                ConsultaCliente o = new ConsultaCliente();
                o.Show();
            }
            catch (Exception)
            {

                throw;
            }
         
        }

     
    }
}
