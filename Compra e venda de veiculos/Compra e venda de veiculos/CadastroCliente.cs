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
    public class CadastroCliente
    {


        public string NomeRS { get; set; }
        public string CPFouCNPJ { get; set; }
        public string RG { get; set; }
        public string NomeMãe { get; set; }
        public string Empresa { get; set; }
        public string Setor { get; set; }
        public string Profissão { get; set; }
        public string Salário { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Número { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string UF { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string IE { get; set; }

        public void Ledados(CadCliente c)
        {
            NomeRS = c.txtboxNomeOuRS.Text.ToString();
            CPFouCNPJ = c.txtboxCPFOuCNPJ.Text.ToString();
            CEP = c.txtboxCEP.Text.ToString();
            Logradouro = c.txtboxLogradouro.Text.ToString();
            Número = c.txtboxNº.Text.ToString();
            Complemento = c.txtboxComplemento.Text.ToString();
            UF = c.txtboxUF.Text.ToString();
            Cidade = c.txtboxCidade.Text.ToString();
            Bairro = c.txtboxBairro.Text.ToString();
            Telefone = c.txtboxTelefone.Text.ToString();
            Celular = c.txtboxCelular.Text.ToString();
            Email = c.txtboxEmail.Text.ToString();
            

            if (c.radioButtonPFisica.Checked == true)
            {

                RG = c.txtboxRG.Text.ToString();
                NomeMãe = c.txtboxNomeMãe.Text.ToString();
                Empresa = c.txtboxEmpresa.Text.ToString();
                Setor = c.txtboxSetor.Text.ToString();
                Profissão = c.txtboxProfissão.Text.ToString();
                Salário = c.txtboxSalário.Text.ToString();
               
            }
            if (c.radioButtonPJ.Checked==true)
            {
                
                IE = c.txtboxIE.Text.ToString();
            }
           
        }

        public void PreencheDadosCliente(ConsultaCliente l)
        {
            XElement Raiz = XElement.Load(@"C:\Dados.xml");
            var Consulta = from p in Raiz.Elements("Cliente")                     // Faz a consulta - Elemento Raíz Aluno
                           select new                                           // Cria os Objetos
                           {
                               NomeouRazãoSOCIAL = (string)p.Element("NomeouRazãoSocial"),
                               CPFouCNPJ= (string)p.Element("CPFouCNPJ"),
                               RG = (string)p.Element("RG"),
                               IE = (string)p.Element("IE"),
                               NomeMãe = (string)p.Element("NomeMãe"),
                               Empresa = (string)p.Element("Empresa"),
                               Setor = (string)p.Element("Setor"),
                               Profissão = (string)p.Element("Profissão"),
                               Salário = (string)p.Element("Salário"),
                               CEP = (string)p.Element("CEP"),
                               Logradouro = (string)p.Element("Logradouro"),
                               N = (string)p.Element("N"),
                               Complemento = (string)p.Element("Complemento"),
                               UF = (string)p.Element("UF"),
                               Cidade = (string)p.Element("Cidade"),
                               Bairro = (string)p.Element("Bairro"),
                               Telefone = (string)p.Element("Telefone"),
                               Celular = (string)p.Element("Celular"),
                               Email = (string)p.Element("Email"),
                           };
            foreach (var o in Consulta)
            {
                if (l.comboBoxNome.Text.ToString()== o.NomeouRazãoSOCIAL)
                {

                    l.txtboxCPFOuCNPJ.Text = "";
                    l.txtboxRG.Text = "";
                    l.txtboxIE.Text = "";
                    l.txtboxNomeMãe.Text = "";
                    l.txtboxEmpresa.Text = "";
                    l.txtboxSetor.Text = "";
                    l.txtboxProfissão.Text = "";
                    l.txtboxSalário.Text = "";
                    l.txtboxCEP.Text = "";
                    l.txtboxLogradouro.Text = "";
                    l.txtboxNº.Text = "";
                    l.txtboxComplemento.Text = "";
                    l.txtboxUF.Text = "";
                    l.txtboxCidade.Text = "";
                    l.txtboxBairro.Text = "";
                    l.txtboxTelefone.Text = "";
                    l.txtboxCelular.Text = "";
                    l.txtboxEmail.Text = "";
                    l.radioButtonPFisica.Checked = false;
                    l.radioButtonPJ.Checked = false;
                    l.txtboxCPFOuCNPJ.Text = o.CPFouCNPJ;
                    l.txtboxRG.Text = o.RG;
                    l.txtboxIE.Text = o.IE;
                    l.txtboxNomeMãe.Text = o.NomeMãe;
                    l.txtboxEmpresa.Text = o.Empresa;
                    l.txtboxSetor.Text = o.Setor;
                    l.txtboxProfissão.Text = o.Profissão;
                    l.txtboxSalário.Text = o.Salário;
                    l.txtboxCEP.Text = o.CEP;
                    l.txtboxLogradouro.Text = o.Logradouro;
                    l.txtboxNº.Text = o.N;
                    l.txtboxComplemento.Text = o.Complemento;
                    l.txtboxUF.Text = o.UF;
                    l.txtboxCidade.Text = o.Cidade;
                    l.txtboxBairro.Text = o.Bairro;
                    l.txtboxTelefone.Text = o.Telefone;
                    l.txtboxCelular.Text = o.Celular;
                    l.txtboxEmail.Text = o.Email;
                    if (l.txtboxIE.Text != "")
                    {
                        l.radioButtonPJ.Checked = true;
                    }
                    else
                    {
                        l.radioButtonPFisica.Checked = true;
                    }
                    break;
                }
               
             
            }

        }

        public void Juridica(CadCliente c)
        {
            c.txtboxNomeMãe.ReadOnly = true;
            c.txtboxProfissão.ReadOnly = true;
            c.txtboxSalário.ReadOnly = true;
            c.txtboxSetor.ReadOnly = true;
            c.txtboxEmpresa.ReadOnly = true;
            c.txtboxRG.ReadOnly = true;
            c.txtboxIE.ReadOnly = false;
        }

        public void PessoaF(CadCliente c)
        {
            c.txtboxNomeMãe.ReadOnly = false;
            c.txtboxProfissão.ReadOnly = false;
            c.txtboxSalário.ReadOnly = false;
            c.txtboxSetor.ReadOnly = false;
            c.txtboxEmpresa.ReadOnly = false;
            c.txtboxRG.ReadOnly = false;
            c.txtboxIE.ReadOnly = true;
        }

      
        public void SalvarXML(CadCliente c)
        {
            if (NomeRS != "" && CPFouCNPJ != "" && RG != "" || NomeRS != "" && IE != "" && CPFouCNPJ != "")
            {
                try
                {
                    XElement raiz = XElement.Load(@"C:\Dados.xml");
                    XElement NovoCad = new XElement("Cliente",
                   new XElement("NomeouRazãoSocial", NomeRS),
                   new XElement("CPFouCNPJ", CPFouCNPJ),
                   new XElement("RG", RG),
                   new XElement("IE",IE),
                   new XElement("NomeMãe", NomeMãe),
                   new XElement("Empresa", Empresa),
                   new XElement("Setor", Setor),
                   new XElement("Profissão",Profissão),
                   new XElement("Salário", Salário),
                   new XElement("CEP", CEP),
                   new XElement("Logradouro", Logradouro),
                   new XElement("N", Número),
                   new XElement("Complemento", Complemento),
                   new XElement("UF", UF),
                   new XElement("Cidade", Cidade),
                   new XElement("Bairro", Bairro),
                   new XElement("Telefone", Telefone),
                   new XElement("Celular", Celular),
                   new XElement("Email", Email));
                    raiz.Add(NovoCad);
                    raiz.Save(@"C:\Dados.xml");
                }
                catch (Exception)
                {

                    MessageBox.Show("Algum caractere inválido foi digitado, por favor não digite caractere invalidos!");
                }
       

                CadCliente.ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("Os campos: \nNome/Razão social \nCPF/CNPJ \nIE ou RG \nnão podem ficar vazios");
            }

        }

        public void ConsultaCliente(Forma_de_Pagamento u)
        {
            XElement Raiz = XElement.Load(@"C:\Dados.xml");
            var Consulta = from p in Raiz.Elements("Cliente")                     // Faz a consulta - Elemento Raíz Aluno
                           select new                                           // Cria os Objetos
                           {
                               NomeRS = (string)p.Element("NomeouRazãoSocial"),
                           };
            foreach (var o in Consulta)
            {

                u.comboBoxCliente.Items.Add(o.NomeRS);
            }


        }

   
        public void PlotarComboxNome(ConsultaCliente j)
        {
            try
            {
                XElement Raiz = XElement.Load(@"C:\Dados.xml");
                var Consulta = from p in Raiz.Elements("Cliente")                     // Faz a consulta - Elemento Raíz Aluno
                               select new                                           // Cria os Objetos
                               {
                                   NomeouRazãoSocial = (string)p.Element("NomeouRazãoSocial"),
                               };
                foreach (var o in Consulta)
                {


                    j.comboBoxNome.Items.Add(o.NomeouRazãoSocial);

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Não existe nenhum cliente cadastrado");
                j.Close();
            }
        }

        public void ExcluiCliente(ConsultaCliente yo)
        {

            XElement Raiz = XElement.Load(@"C:\Dados.xml");
            var ola = from A in Raiz.Elements("Cliente")
                            where ((string)A.Element("NomeouRazãoSocial")).Equals(yo.comboBoxNome.Text.ToString())
                            select A;
            foreach (var x in ola)
            {
                x.Element("NomeouRazãoSocial").Parent.Remove();
            }

            Raiz.Save(@"C:\Dados.xml");
        }
        public void AlterarCliente(ConsultaCliente o)
        {
            XElement raiz = XElement.Load(@"C:\Dados.xml");
            var ClienteAlterar = from A in raiz.Elements("Cliente")
                               where ((string)A.Element("NomeouRazãoSocial")).Equals(o.comboBoxNome.Text.ToString())
                               select A;


            if (o.radioButtonPFisica.Checked != true)
            {
                foreach (var x in ClienteAlterar)
                {
                    x.SetElementValue("NomeouRazãoSocial", o.txtBoxNovoNome.Text.ToString());
                    x.SetElementValue("CPFouCNPJ", o.txtboxCPFOuCNPJ.Text.ToString());
                    x.SetElementValue("RG", o.txtboxRG.Text.ToString());
                    x.SetElementValue("IE",o.txtboxIE.Text.ToString());
                    x.SetElementValue("NomeMãe", o.txtboxNomeMãe.Text.ToString());
                    x.SetElementValue("Empresa",o.txtboxEmpresa.Text.ToString());
                    x.SetElementValue("Setor", o.txtboxSetor.Text.ToString());
                    x.SetElementValue("Profissão", o.txtboxProfissão.Text.ToString());
                    x.SetElementValue("Salário", o.txtboxSalário.Text.ToString());
                    x.SetElementValue("CEP", o.txtboxCEP.Text.ToString());
                    x.SetElementValue("Logradouro", o.txtboxLogradouro.Text.ToString());
                    x.SetElementValue("N", o.txtboxNº.Text.ToString());
                    x.SetElementValue("Complemento", o.txtboxComplemento.Text.ToString());
                    x.SetElementValue("UF", o.txtboxUF.Text.ToString());
                    x.SetElementValue("Cidade", o.txtboxCidade.Text.ToString());
                    x.SetElementValue("Bairro", o.txtboxBairro.Text.ToString());
                    x.SetElementValue("Telefone", o.txtboxTelefone.Text.ToString());
                    x.SetElementValue("Celular", o.txtboxCelular.Text.ToString());
                    x.SetElementValue("Email", o.txtboxEmail.Text.ToString());
                   
                }
            }
            else
            {
                foreach (var x in ClienteAlterar)
                {
                    x.SetElementValue("NomeouRazãoSocial", o.txtBoxNovoNome.Text.ToString());
                    x.SetElementValue("CPFouCNPJ", o.txtboxCPFOuCNPJ.Text.ToString());
                    x.SetElementValue("RG", o.txtboxRG.Text.ToString());
                    x.SetElementValue("NomeMãe", o.txtboxNomeMãe.Text.ToString());
                    x.SetElementValue("Empresa", o.txtboxEmpresa.Text.ToString());
                    x.SetElementValue("Setor", o.txtboxSetor.Text.ToString());
                    x.SetElementValue("Profissão", o.txtboxProfissão.Text.ToString());
                    x.SetElementValue("Salário", o.txtboxSalário.Text.ToString());
                    x.SetElementValue("CEP", o.txtboxCEP.Text.ToString());
                    x.SetElementValue("Logradouro", o.txtboxLogradouro.Text.ToString());
                    x.SetElementValue("N", o.txtboxNº.Text.ToString());
                    x.SetElementValue("Complemento", o.txtboxComplemento.Text.ToString());
                    x.SetElementValue("UF", o.txtboxUF.Text.ToString());
                    x.SetElementValue("Cidade", o.txtboxCidade.Text.ToString());
                    x.SetElementValue("Bairro", o.txtboxBairro.Text.ToString());
                    x.SetElementValue("Telefone", o.txtboxTelefone.Text.ToString());
                    x.SetElementValue("Celular", o.txtboxCelular.Text.ToString());
                    x.SetElementValue("Email", o.txtboxEmail.Text.ToString());
                }
            }


            raiz.Save(@"C:\Dados.xml");
            MessageBox.Show("Alteração concluída!");
            o.Close();
        }
        public void HabilitaAlteração(ConsultaCliente o)
        {
            if (o.radioButtonPFisica.Checked == true)
            {
                o.txtboxBairro.ReadOnly = false;
                o.txtboxCelular.ReadOnly = false;
                o.txtboxCEP.ReadOnly = false;
                o.txtboxCidade.ReadOnly = false;
                o.txtboxCPFOuCNPJ.ReadOnly = false;
                o.txtboxComplemento.ReadOnly = false;

                o.txtboxNº.ReadOnly = false;
                o.txtboxSalário.ReadOnly = false;
                o.txtboxUF.ReadOnly = false;
                o.txtboxLogradouro.ReadOnly = false;
                o.txtboxEmail.ReadOnly = false;
                o.txtboxSetor.ReadOnly = false;
                o.txtboxProfissão.ReadOnly = false;
                o.txtboxTelefone.ReadOnly = false;
                o.txtboxRG.ReadOnly = false;
                o.txtboxNomeMãe.ReadOnly = false;
                o.txtboxCelular.ReadOnly = false;
                o.txtboxEmpresa.ReadOnly = false;

            }
            else
            {
                o.txtboxBairro.ReadOnly = false;
                o.txtboxCelular.ReadOnly = false;
                o.txtboxCEP.ReadOnly = false;
                o.txtboxCidade.ReadOnly = false;
                o.txtboxCPFOuCNPJ.ReadOnly = false;
                o.txtboxComplemento.ReadOnly = false;
                o.txtboxIE.ReadOnly = false;
                o.txtboxNº.ReadOnly = false;

                o.txtboxUF.ReadOnly = false;
                o.txtboxLogradouro.ReadOnly = false;
                o.txtboxEmail.ReadOnly = false;


                o.txtboxTelefone.ReadOnly = false;


            }
            o.txtBoxNovoNome.Text = o.comboBoxNome.Text.ToString();
            o.comboBoxNome.Visible = false;
            o.txtBoxNovoNome.Visible = true;
            o.btnSalvaAltera.Visible = true;

        }
    }
}
