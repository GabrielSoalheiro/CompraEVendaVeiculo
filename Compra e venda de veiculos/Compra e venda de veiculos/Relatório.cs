using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Compra_e_venda_de_veiculos
{
    public partial class Relatório : Form
    {
        public Relatório()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PreencherRelatório();
           
        }

        public void PreencherRelatório()
        {
            XElement Raiz = XElement.Load(@"C:\Dados.xml");
            var Consulta = from p in Raiz.Elements("Relatório")                     // Faz a consulta - Elemento Raíz Aluno
                           select new                                           // Cria os Objetos
                           {
                               Comprador = (string)p.Element("Comprador"),
                               Veículo = (string)p.Element("Veículo"),
                               ValorDeEntrada = (string)p.Element("ValorDeEntrada"),
                               QTDParcelasF = (string)p.Element("QTDParcelasF"),
                               QTDCréd = (string)p.Element("QTDCréd"),
                               FormadePGTO = (string)p.Element("FormadePGTO"),
                               Placa = (string)p.Element("Placa"),
                               ValorParcela = (string)p.Element("ValorParcela"),
                               FormaPGTOeNtrada = (string)p.Element("FormaPGTOeNtrada"),
                           

                           };
            foreach (var o in Consulta)
            {


                ListBoxComprador.Items.Add(o.Comprador);
                ListBoxModelo.Items.Add(o.Veículo);
                listBoxEntrada.Items.Add(o.ValorDeEntrada);
                if (o.QTDCréd == "")
                {
                    listBoxParcelas.Items.Add(o.QTDParcelasF);
                }
                else
                {
                    listBoxParcelas.Items.Add(o.QTDCréd);
                }
                listBoxValorParcela.Items.Add(o.ValorParcela);
                listBoxRestante.Items.Add(o.FormadePGTO);
                listBoxPlaca.Items.Add(o.Placa);
                listBoxPGTO.Items.Add("R$ "+o.FormaPGTOeNtrada);

            }
        }

      
    }
}
