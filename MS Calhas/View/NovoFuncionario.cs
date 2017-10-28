using MS_Calhas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_Calhas.View
{
    public partial class NovoFuncionario : Form
    {
        //==========Variaveis==========        
        bool estouInserindo;
        Funcionario funcionario;
        //==========Construtor=========
        public NovoFuncionario(Funcionario funcionario)
        {
            InitializeComponent();
            if(funcionario == null)
            {
                estouInserindo = true;
            }
            else
            {
                estouInserindo = false;
                this.funcionario = funcionario;
                txtNome.Text = this.funcionario.Nome;
                txtCargo.Text = this.funcionario.Cargo;
                panel1.BackColor = Color.FromArgb(250, 213, 92);
                panel2.BackColor = Color.FromArgb(250, 213, 92);
            }            
        }
        //======Métodos ajudantes======
        private void GravarFuncionario()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))//validamos se o campo não está vazio ou em branco
            {
                MessageBox.Show("Preencha um nome", "Nome vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (var banco = new Banco())
                {
                    var consulta = banco.Funcionarios.Where(x => x.Nome.ToUpper() == txtNome.Text.ToUpper()).ToList();
                    if (consulta.Count == 0 || !estouInserindo)//valida se ja existe este nome
                    {
                        if (estouInserindo)
                        {
                            //adiciona:
                            banco.Funcionarios.Add(new Funcionario() { Nome = txtNome.Text, Cargo = txtCargo.Text });
                            banco.SaveChanges();
                            this.Close();
                        }
                        else
                        {
                            //altera:
                            var fulano = banco.Funcionarios.Find(funcionario.FuncionarioId);
                            fulano.Nome = txtNome.Text;
                            fulano.Cargo = txtCargo.Text;

                            banco.Funcionarios.Update(fulano);
                            banco.SaveChanges();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("O nome ja está em uso", "Nome inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        //=====Ações da interface======
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            GravarFuncionario();
        }       
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                GravarFuncionario();
            }
        }
    }
}
