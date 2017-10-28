using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Calhas.View;
using MS_Calhas.Model;
using MS_Calhas.Controller;

namespace MS_Calhas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EfetuarLogin();
        }

        private void EfetuarLogin() //aqui de fato efetua o login no sistema
        {
            //login do desenvolvedor
            if(txtNome.Text == "admin" && txtSenha.Text == "admin")
            {
                Repositorio.usuarioAtivo = new Usuario() { Nome = "MAIKON", Senha = "admin", DataCadastro = Repositorio.DataAtualInt() };
                var form = new Principal();
                form.Show();
                this.Hide();
                return;
            }

            //login comum
            var usuario = new Usuario() { Nome = txtNome.Text.ToUpper(), Senha = txtSenha.Text};
            List<Usuario> consulta;
            using(var banco = new Banco())
            {
                consulta = banco.Usuarios.Where(x => x.Nome == usuario.Nome).ToList();
            }
            if(consulta.Count == 1)//valida usuario
            {
                if(usuario.Senha == consulta.First().Senha)//valida senha
                {
                    //acesso autorizado:

                    if (consulta.First().Violacao)
                    {
                        //Se a conta foi violada então:
                        MessageBox.Show("Atenção!" +
                            "\nHouve uma tentativa fracassada de tentarem mudar sua senha de acesso no dia " +
                            consulta.First().DataViolacao +
                            " às " +
                            consulta.First().HoraViolacao +
                            "\nFique atento, recomenda-se mudar sua senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        consulta.First().Violacao = false;
                        using (var banco = new Banco())
                        {
                            banco.Usuarios.Update(consulta.First());
                            banco.SaveChanges();
                        }
                    }
                    //

                    Repositorio.usuarioAtivo = consulta.First();
                    var form = new Principal();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Senha inválida", "Senha incorreta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nome de usuário inválido", "Usuário não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            fechar.BorderStyle = BorderStyle.FixedSingle;
        }

        private void fechar_MouseLeave(object sender, EventArgs e)
        {
            fechar.BorderStyle = BorderStyle.None;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                EfetuarLogin();
            }
        }
    }
}
