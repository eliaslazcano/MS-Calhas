using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Calhas.Controller;
using MS_Calhas.Model;

namespace MS_Calhas.View
{
    public partial class AdicionarCheque : Form
    {
        //==========Variaveis==========
        bool estouIncluindo;
        Cheque cheque;
        //==========Construtor=========
        public AdicionarCheque()
        {
            InitializeComponent();
            estouIncluindo = true;
        }
        public AdicionarCheque(Cheque chequeAlterar)
        {
            InitializeComponent();
            estouIncluindo = false;
            barraDir.BackColor = Color.FromArgb(250, 213, 92);
            barraEsq.BackColor = Color.FromArgb(250, 213, 92);
            this.cheque = chequeAlterar;
            PreencheCampos(chequeAlterar);
        }
        //======Métodos ajudantes======
        private bool ValidaCampos()
        {
            string mensagem = "Preencha corretamente os campos:";
            string erros =
                ValidaUmCampo(txtbanco, "\nNome do banco") +
                ValidaUmCampo(txtCodBanco, "\nCódigo do banco") +
                ValidaUmCampo(txtConta, "\nConta") +
                ValidaUmCampo(txtCliente, "\nNome do cliente") +
                ValidaUmCampo(txtNumCheque, "\nNº do cheque") +
                ValidaUmCampo(txtValor, "\nValor do cheque") +
                ValidaUmCampoData(txtData, "\nData do cheque");

            if (String.IsNullOrWhiteSpace(erros))
            {
                return true;
            }
            else
            {
                MessageBox.Show(mensagem + erros, "Campos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }//verifica se existem campos em branco e data correta, true caso esteja valido
        private void PreencheCampos(Cheque cheque)
        {
            txtbanco.Text = cheque.Banco;
            txtCliente.Text = cheque.Cliente;
            txtCodBanco.Text = cheque.CodBanco;
            txtConta.Text = cheque.Conta;
            txtData.Text = cheque.DataCheque;
            txtNumCheque.Text = cheque.NumCheque;
            txtValor.Text = Convert.ToString(cheque.Valor);
        }//preenche os campos para uma alteração.
        private string ValidaUmCampo(TextBox textBox, string nomeDoErro)
        {
            if (String.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.BackColor = Color.Red;
                return nomeDoErro;
            }
            else
            {
                textBox.BackColor = Color.White;
                return "";
            }
        }
        private string ValidaUmCampoData(MaskedTextBox textBox, string nomeDoErro)
        {
            if (textBox.DataValidador())
            {
                textBox.BackColor = Color.White;
                return "";
            }
            else
            {
                textBox.BackColor = Color.Red;
                return nomeDoErro;
            }
        }
        private void Salvar()
        {
            if (ValidaCampos())
            {
                if (estouIncluindo)
                {
                    //adiciona
                    try
                    {
                        cheque = new Cheque() { Banco = txtbanco.Text, Cliente = txtCliente.Text, CodBanco = txtCodBanco.Text, Conta = txtConta.Text, NumCheque = txtNumCheque.Text, Valor = Convert.ToDouble(txtValor.Text), DataCheque = txtData.Text };
                        using (var banco = new Banco())
                        {
                            banco.Cheques.Add(cheque);
                            banco.SaveChanges();
                            this.Close();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Houve um problema ao adicionar o cheque, verifique se todos os campos estão corretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else
                {
                    //atualiza
                    try
                    {
                        cheque.Banco = txtbanco.Text; cheque.Cliente = txtCliente.Text; cheque.CodBanco = txtCodBanco.Text; cheque.Conta = txtConta.Text; cheque.NumCheque = txtNumCheque.Text; cheque.Valor = Convert.ToDouble(txtValor.Text); cheque.DataCheque = txtData.Text;
                        using (var banco = new Banco())
                        {
                            banco.Cheques.Update(cheque);
                            banco.SaveChanges();
                            this.Close();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Houve um problema ao alterar o cheque, verifique se todos os campos estão corretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }
        //=====Ações da interface======
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            //se não for número & não for BackSpace & virgula, então:
            {
                e.Handled = true; //isso impede que o caractere presionado seja lido pelo programa.
            }
        }
        private void txtData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Salvar();
            }
        }
    }
}
