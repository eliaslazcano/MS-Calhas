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
        //===========Construtor===========
        public Form1()
        {
            InitializeComponent();
        }
        //========Metodos ajudantes=======
        private void EfetuarLogin() //aqui de fato efetua o login no sistema
        {
            //login do desenvolvedor
            using (var banco = new Banco())
            {
                var users = banco.Usuarios.ToList();
                if (txtNome.Text == "admin" && txtSenha.Text == "admin" && users.Count == 0)
                {
                    Repositorio.usuarioAtivo = new Usuario() { Nome = "Acesso Temporário", Senha = "admin", DataCadastro = Repositorio.DataAtualInt() };
                    var form = new Principal();
                    form.Show();
                    this.Hide();
                    return;
                }
            }


            //login comum
            var usuario = new Usuario() { Nome = txtNome.Text.ToUpper(), Senha = txtSenha.Text };
            List<Usuario> consulta;
            using (var banco = new Banco())
            {
                consulta = banco.Usuarios.Where(x => x.Nome == usuario.Nome).ToList();
            }
            if (consulta.Count == 1)//valida usuario
            {
                if (usuario.Senha == consulta.First().Senha)//valida senha
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
        //=======Acoes da Interface=======
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            EfetuarLogin();
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
        private void Form1_Load(object sender, EventArgs e)//ao carregar o form, valida a licenca de uso
        {
            using (var db = new Banco())
            {
                var consulta = db.Otimizacao.ToList();
                if (consulta.Count == 0)
                {
                    var formAtivador = new Ativacao();
                    formAtivador.ShowDialog();
                }
                else
                {
                    bool ativado = false;
                    foreach(var x in consulta)
                    {
                        if (x.unification == MacAPI.obterMAC())
                            ativado = true;
                    }
                    if (ativado)
                    {
                        //Proseguir com o login normalmente... maquina autorizada
                    }
                    else
                    {
                        var formAtivador = new Ativacao();
                        formAtivador.ShowDialog();
                    }
                }
            }
        }
    }
}
