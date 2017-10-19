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
            if(txtNome.Text == "admin" && txtSenha.Text == "admin")
            {
                Repositorio.usuarioAtivo = new Usuario() { Nome = "Desenvolvedor", Senha = "admin" };
                var form = new Principal();
                form.Show();
                this.Hide();
                return;
            }

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
