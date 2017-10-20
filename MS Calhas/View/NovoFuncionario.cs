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
        bool estouInserindo;
        Funcionario funcionario;
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
            }            
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            GravarFuncionario();
        }

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
                    if (consulta.Count == 0)//valida se ja existe este nome
                    {
                        if (estouInserindo)
                        {
                            //adiciona:
                            banco.Funcionarios.Add(new Funcionario() { Nome = txtNome.Text });
                            banco.SaveChanges();
                            this.Close();
                        }
                        else
                        {
                            //altera:
                            this.funcionario.Nome = txtNome.Text;
                            banco.Funcionarios.Update(this.funcionario);
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

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                GravarFuncionario();
            }
        }
    }
}
