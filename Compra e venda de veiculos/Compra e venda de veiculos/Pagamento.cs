using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Compra_e_venda_de_veiculos
{
    class Pagamento
    {
        public double parcela { get; set; }
        public double restante { get; set; }
        public void FormaPGTO_Restante(Forma_de_Pagamento o)
        {
            if (o.comboBoxFormaRestante.Text.ToString() == "Financiamento")
            {
                o.comboBoxFinanciamento.Visible = true;
                o.txtBoxValorParcela.Visible = true;
                o.label12.Visible = true;
                o.label7.Visible = true;
            }
            else
            {
                o.comboBoxFinanciamento.Visible = false;
                o.txtBoxValorParcela.Visible = false;
                o.label12.Visible = false;
                o.label7.Visible = false;
            }

            if (o.comboBoxFormaRestante.Text.ToString() == "Crédito")
            {
                o.comboBoxCrédito.Visible = true;
                o.txtBoxValorParcela.Visible = true;
                o.label12.Visible = true;
                o.label7.Visible = true;

            }
            else
            {
                o.comboBoxCrédito.Visible = false;

            }
        }

        public void Crédito(Forma_de_Pagamento o)
        {
            if (o.comboBoxFormaRestante.Text.ToString() == "Crédito")
            {
               parcela = Math.Round(restante / double.Parse(o.comboBoxCrédito.Text.ToString()));
                o.txtBoxValorParcela.Text = "R$ " + parcela.ToString();
            }
        }

        public void Financiamento(Forma_de_Pagamento o)
        {
            if (o.comboBoxFormaRestante.Text.ToString() == "Financiamento")
            {
                parcela= Math.Round( restante / double.Parse(o.comboBoxFinanciamento.Text.ToString()));
                o.txtBoxValorParcela.Text = "R$ " + parcela.ToString();
            }
        }

        public void FormaPGTO_Entrada(Forma_de_Pagamento o)
        {
            restante = double.Parse(o.txtBoxValorVeiculo.Text) - double.Parse(o.txtboxEntrada.Text);
            o.txtBoxRestante.Text = "R$ " + restante.ToString();
          
        }

        public void InformaçõesDeTransação(Forma_de_Pagamento x,Vender_Veículo r)
        {
            XElement Raiz = XElement.Load(@"C:\Dados.xml");
            var Consulta = from p in Raiz.Elements("Cliente")                     
                           select new                                           
                           {
                               NomeRS = (string)p.Element("NomeouRazãoSocial"),
                               CPFouCNPJ = (string)p.Element("CPFouCNPJ"),
                           };
            var car = from o in Raiz.Elements("Veículo")
                      select new
                      {
                          Modelo = (string)o.Element("Modelo"),
                          IMG = (string)o.Element("IMG"),
                          ValordoVeículo = (string)o.Element("ValordoVeículo")
                      };

            foreach (var o in Consulta)
            {
                if (o.NomeRS == x.comboBoxCliente.Text.ToString())
                {
                    x.txtBoxCPFouCNPJ.Text = o.CPFouCNPJ;
                    foreach (var j in car)
                    {
                        if (r.comboBoxVeículos.Text == j.Modelo)
                        {
                 
                            x.txtBoxValorVeiculo.Text =j.ValordoVeículo;

                            x.pictureBoxIMGVEIC.ImageLocation = j.IMG;
                        }
                    }
                }
            }
        }

        public void Vender(Forma_de_Pagamento o,Vender_Veículo y)
        {

            XElement Raiz = XElement.Load(@"C:\Dados.xml");
            var VenderCar = from A in Raiz.Elements("Veículo")
                            where ((string)A.Element("Modelo")).Equals(y.comboBoxVeículos.Text.ToString())
                            select A;
            foreach (var x in VenderCar)
            {
                x.Element("Modelo").Parent.Remove();
            }

            Raiz.Save(@"C:\Dados.xml");



            XElement raiz = XElement.Load(@"C:\Dados.xml");
            XElement Relat = new XElement("Relatório",
            new XElement("Comprador", o.comboBoxCliente.Text.ToString()),
            new XElement("Veículo", y.comboBoxVeículos.Text.ToString()),
            new XElement("ValorDeEntrada", "R$ " +o.txtboxEntrada.Text.ToString()),
            new XElement("QTDParcelasF", o.comboBoxFinanciamento.Text.ToString()),
            new XElement("QTDCréd", o.comboBoxCrédito.Text.ToString()),
            new XElement("ValorParcela", o.txtBoxValorParcela.Text.ToString()),
            new XElement("FormadePGTO", o.comboBoxFormaRestante.Text.ToString()),
            new XElement("Placa", y.txtboxPLaca.Text.ToString()),
            new XElement("FormaPGTOeNtrada",o.ComboBoxFormaEntrada.Text.ToString()));

                
            raiz.Add(Relat);
            raiz.Save(@"C:\Dados.xml");



            y.Close();
            o.Close();

            MessageBox.Show("Transação realizada com sucesso !");
        }
    }
}
