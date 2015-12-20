using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasdastroDePessoas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (textUser.Text == "admin" && textPass.Text == "123")
            {
                panelLogin.Visible = false;
                panelCadastro.Visible = true;

            }
            else
            {
                MessageBox.Show("Usuário ou Senha incorreta!");
            }
            
        }

        private void btnBuscaCEP_Click(object sender, EventArgs e)
        {   
            //url onde será substituido o CEP
            String url = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml";
            DataSet dsRetornaEndereco = new DataSet();
            dsRetornaEndereco.ReadXml(url.Replace("@cep", textCEP.Text));
            //pega primeiro campo e transforma em tabela para saber se a consulta foi bem sucedida.
            String retorno = dsRetornaEndereco.Tables[0].Rows[0]["resultado"].ToString();
            //se o campo resultado for igual a 0, houve um problema na pesquisa
            if (retorno == "0")
            {
                MessageBox.Show("CEP inválido");
            }
            else
            {
                textBairro.Text = dsRetornaEndereco.Tables[0].Rows[0]["bairro"].ToString();
                textEndereço.Text = dsRetornaEndereco.Tables[0].Rows[0]["logradouro"].ToString();
                textEstado.Text = dsRetornaEndereco.Tables[0].Rows[0]["uf"].ToString();
                textCidade.Text = dsRetornaEndereco.Tables[0].Rows[0]["cidade"].ToString();

            }
        }
    }
}
