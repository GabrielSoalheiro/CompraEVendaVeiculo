using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Compra_e_venda_de_veiculos
{
    public class Veículo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Ano { get; set; }
        public string Renavam { get; set; }
        public string Combustível { get; set; }
        public string Placa { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Chassi { get; set; }
        public string Quilometragem { get; set; }
        public string Situação { get; set; }
        public string Observações { get; set; }
        public string IMG { get; set; }
        public string ArCond { get; set; }
        public string Vidro { get; set; }
        public string Trava { get; set; }
        public string Direção { get; set; }
        public string ValorTotal { get; set; }
        public void ledados(CadVeículo o)
        {
            ValorTotal = o.txtBoxValorTotal.Text.ToString();
            Ano = o.txtboxAno.Text.ToString();
            Renavam = o.txtboxRenavam.Text.ToString();
            Quilometragem = o.txtboxKM.Text.ToString();
            Observações = o.txtboxObservações.Text.ToString();
            UF = o.txtboxUF.Text.ToString();
            Modelo = o.txtboxModelo.Text.ToString();
            Marca = o.txtboxMarca.Text.ToString();
            Placa = o.txtboxPLaca.Text.ToString();
            Cor = o.txtboxCor.Text.ToString();
            Chassi = o.txtboxChassi.Text.ToString();
            Cidade = o.txtboxCidade.Text.ToString();
            Combustível = o.ComboboxCombustivel.Text.ToString();

            if (o.radioButton1.Checked==true)
            {
                Situação = "Comprado";
            }
            else if (o.radioButton2.Checked == true)
            {
                Situação = "De Estoque";
            }
            else
            {
                Situação = "";
            }

            if (o.checkBoxArCond.Checked==true)
            {
                ArCond = "Ar Condicionado";
            }

            if (o.checkBoxVidro.Checked==true)
            {
                Vidro = "Vidro elétrico";
            }

            if (o.checkBoxTrava.Checked==true)
            {
                Trava = "Trava elétrica";
            }

            if (o.checkBoxDireção.Checked==true)
            {
                Direção = "Direção";
            }
        }
        public void AddImagem(CadVeículo o)
        {

            string nome;
           

            if (o.pictureBox1.Image!=null)
            {
                try
                {
                    try
                    {
                        nome = Guid.NewGuid().ToString().Substring(0, 7).ToUpper();
                        File.Copy(o.pictureBox1.ImageLocation.ToString(), @"Imagens dos Veículos\" + nome + ".png");
                        IMG = @"Imagens dos Veículos\" + nome + ".png";
                    }
                    catch (Exception)
                    {
                        nome = Guid.NewGuid().ToString().Substring(0, 7).ToUpper();
                        File.Copy(o.pictureBox1.ImageLocation.ToString(), @"Imagens dos Veículos\" + nome + ".png");
                        IMG = @"Imagens dos Veículos\" + nome + ".png";

                    }
                    catch
                    {
                        nome = Guid.NewGuid().ToString().Substring(0, 7).ToUpper();
                        nome += ".1";
                        File.Copy(o.pictureBox1.ImageLocation.ToString(), @"Imagens dos Veículos\" + nome + ".png");
                        IMG = @"Imagens dos Veículos\" + nome + ".png";
                    }
                }
                catch (Exception)
                {

                    
                }
           
            }
            
          

        }

        public void SalvarXML(CadVeículo o)
        {
            if (Placa!="" && Quilometragem!="" && Ano!="" && Combustível!="" && Modelo!="" && Situação!="" && Marca!="" && IMG!="" && ValorTotal!="")
            {
                XElement raiz = XElement.Load(@"C:\Dados.xml");
                XElement NovoAuto = new XElement("Veículo",
                new XElement("Marca", Marca),
                new XElement("Modelo", Modelo),
                new XElement("Cor",Cor),
                new XElement("Ano", Ano),
                new XElement("Combustível", Combustível),
                new XElement("Placa", Placa),
                new XElement("UF", UF),
                new XElement("Cidade", Cidade),
                new XElement("Chassi", Chassi),
                new XElement("Renavam", Renavam),
                new XElement("ValordoVeículo", ValorTotal),
                new XElement("Quilometragem", Quilometragem),
                new XElement("ArCond", ArCond),
                new XElement("Vidro", Vidro),
                new XElement("Trava", Trava),
                new XElement("Direção", Direção),
                new XElement("IMG", IMG),
                new XElement("Observações", Observações),
                new XElement("Situação",Situação));
                raiz.Add(NovoAuto);
                raiz.Save(@"C:\Dados.xml");
               
                CadCliente.ActiveForm.Close();

            }
            else
            {
                MessageBox.Show("\nOs campos: \nPlaca \nModelo \nQuilometragem \nAno \nCombustível \nSituação \nImagem \nSão obrigatórios!");
            }



        }

        public void ConsultarVeiculo(Vender_Veículo x)
        {
            try
            {
                XElement Raiz = XElement.Load(@"C:\Dados.xml");
                var Consulta = from p in Raiz.Elements("Veículo")                     // Faz a consulta - Elemento Raíz Aluno
                               select new                                           // Cria os Objetos
                               {
                                   Modelo = (string)p.Element("Modelo"),
                               };
                foreach (var o in Consulta)
                {


                        x.comboBoxVeículos.Items.Add(o.Modelo);
                                      
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Não existe nenhum veículo cadastrado");
                x.Close();
            }
        }

        public void EscolherVeículo(Vender_Veículo t)
        {
            XElement Raiz = XElement.Load(@"C:\Dados.xml");
            var Consulta = from p in Raiz.Elements("Veículo")                     // Faz a consulta - Elemento Raíz Aluno
                           select new                                           // Cria os Objetos
                           {
                               Modelo = (string)p.Element("Modelo"),
                               IMG = (string)p.Element("IMG"),
                               Observações = (string)p.Element("Observações"),
                               Quilometragem = (string)p.Element("Quilometragem"),
                               Chassi = (string)p.Element("Chassi"),
                               Cidade = (string)p.Element("Cidade"),
                               UF = (string)p.Element("UF"),
                               Placa = (string)p.Element("Placa"),
                               Combustível = (string)p.Element("Combustível"),
                               Renavam = (string)p.Element("Renavam"),
                               Ano = (string)p.Element("Ano"),
                               Cor = (string)p.Element("Cor"),
                               Trava = (string)p.Element("Trava"),
                               Marca = (string)p.Element("Marca"),
                               ArCond = (string)p.Element("ArCond"),
                               Vidro = (string)p.Element("Vidro"),
                               Direção = (string)p.Element("Direção"),
                               Situação = (string)p.Element("Situação")  };
            foreach (var o in Consulta)
            {

                if (t.comboBoxVeículos.Text.ToString() == o.Modelo)
                {
                    t.pictureBoxIMGcar.ImageLocation = o.IMG;
                    t.txtboxCombustível.Text = o.Combustível;
                    t.txtboxAno.Text = o.Ano;
                    t.txtboxChassi.Text = o.Chassi;
                    t.txtboxCidade.Text = o.Cidade;
                    t.txtboxPLaca.Text = o.Placa;
                    t.txtboxRenavam.Text = o.Renavam;
                    t.txtboxUF.Text = o.UF;
                    t.txtboxObservações.Text = o.Observações;
                    t.txtboxCor.Text = o.Cor;
                    t.txtboxKM.Text = o.Quilometragem;
                    t.txtboxMarca.Text = o.Marca;
                    t.txtboxModelo.Text = o.Modelo;

                    if (o.Situação=="De Estoque")
                    {
                        t.radioBTNEstoque.Checked = true;
                       
                    }
                    if (o.Situação=="Comprado")
                    {
                        t.radioBTNComprado.Checked = true;
                    }

                    if (o.ArCond == "Ar Condicionado")
                    {
                        t.checkBoxArCond.Checked = true;
                    }
                    if (o.Trava == "Trava elétrica")
                    {
                        t.checkBoxTrava.Checked = true;
                    }
                    if (o.Vidro == "Vidro elétrico")
                    {
                        t.checkBoxVidro.Checked = true;
                    }
                    if (o.Direção == "Direção")
                    {
                        t.checkBoxDireção.Checked = true;
                    }
                    break;

                }
                else
                {
                    t.pictureBoxIMGcar.Image = null;
                    t.txtboxCombustível.Text = "";
                    t.txtboxAno.Text = "";
                    t.txtboxChassi.Text = "";
                    t.txtboxCidade.Text = "";
                    t.txtboxPLaca.Text = "";
                    t.txtboxRenavam.Text = "";
                    t.txtboxUF.Text = "";
                    t.txtboxObservações.Text = "";
                    t.txtboxCor.Text = "";
                    t.txtboxKM.Text = "";
                    t.checkBoxArCond.Checked = false;
                    t.checkBoxDireção.Checked = false;
                    t.checkBoxVidro.Checked = false;
                    t.checkBoxTrava.Checked = false;
                    t.radioBTNComprado.Checked = false;
                    t.radioBTNEstoque.Checked = false;
                }
            }


        }
        public void AlteraVeic(Vender_Veículo o)
        {
           XElement raiz = XElement.Load(@"C:\Dados.xml");
            var VeículoAltera = from A in raiz.Elements("Veículo")
                               where ((string)A.Element("Modelo")).Equals(o.comboBoxVeículos.Text.ToString())
                              select A;


            foreach (var x in VeículoAltera)
            {
                x.SetElementValue("Marca", o.txtboxModelo.Text.ToString());
                x.SetElementValue("Modelo", o.txtVeic.Text.ToString());
                x.SetElementValue("Cor", o.txtboxCor.Text.ToString());
                x.SetElementValue("Ano", o.txtboxAno.Text.ToString());
                x.SetElementValue("Combustível", o.txtboxCombustível.Text.ToString());
                x.SetElementValue("Placa", o.txtboxPLaca.Text.ToString());
                x.SetElementValue("UF", o.txtboxUF.Text.ToString());
                x.SetElementValue("Cidade", o.txtboxCidade.Text.ToString());
                x.SetElementValue("Chassi", o.txtboxChassi.Text.ToString());
                x.SetElementValue("Quilometragem", o.txtboxKM.Text.ToString());
                x.SetElementValue("Observações", o.txtboxObservações.Text.ToString());

                if (o.checkBoxArCond.Checked==true)
                {
                    x.SetElementValue("ArCond","Ar Condicionado" );
                }
                else
                {
                    x.SetElementValue("ArCond", "");
                }
                if (o.checkBoxDireção.Checked==true)
                {
                    x.SetElementValue("Direção", "Direção");
                }
                else
                {
                    x.SetElementValue("Direção", "");
                }
                if (o.checkBoxTrava.Checked==true)
                {
                    x.SetElementValue("Trava", "Trava elétrica");
                }
                else
                {
                    x.SetElementValue("Trava", "");
                }
                if (o.checkBoxVidro.Checked==true)
                {
                    x.SetElementValue("Vidro", "Vidro elétrico");
                    
                }
                else
                {
                    x.SetElementValue("Vidro", "");
                }
                break;
            }
            raiz.Save(@"C:\Dados.xml");
           
            o.Close();

        }
        public void HabilitaAlteraVeic(Vender_Veículo o)
        {
            o.txtboxAno.ReadOnly = false;
            o.txtboxChassi.ReadOnly = false;
            o.txtboxCidade.ReadOnly = false;
            o.txtboxCombustível.ReadOnly = false;
            o.txtboxCor.ReadOnly = false;
            o.txtboxKM.ReadOnly = false;
            o.txtboxMarca.ReadOnly = false;
            o.txtboxModelo.ReadOnly = false;
            o.txtboxObservações.ReadOnly = false;
            o.txtboxPLaca.ReadOnly = false;
            o.txtboxRenavam.ReadOnly = false;
            o.txtboxUF.ReadOnly = false;
            o.checkBoxArCond.Enabled = true;
            o.checkBoxDireção.Enabled = true;
            o.checkBoxTrava.Enabled = true;
            o.checkBoxVidro.Enabled = true;
            o.btnSalvarAltera.Visible = true;
            o.comboBoxVeículos.Visible = false;
            o.txtVeic.Visible = true;
            o.txtVeic.Text = o.comboBoxVeículos.Text.ToString();
        }
    }
  
}
