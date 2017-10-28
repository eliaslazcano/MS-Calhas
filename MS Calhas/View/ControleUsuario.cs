using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Calhas.Model;
using MS_Calhas.Controller;

namespace MS_Calhas.View
{
    public partial class ControleUsuario : UserControl
    {
        //==========Variaveis==========
        bool estouIncluindo;
        //==========Construtor=========
        public ControleUsuario()
        {
            InitializeComponent();
            txtNome.Text = Repositorio.usuarioAtivo.Nome;
            txtSenha.Text = Repositorio.usuarioAtivo.Senha;
            txtData.Text = "sua conta existe desde " + Repositorio.usuarioAtivo.DataCadastro.DataParaString();
        }
        //======Métodos ajudantes======
        private void HabilitarEdicao()
        {
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            txtNome.Enabled = true;
            txtNome.BorderStyle = BorderStyle.Fixed3D;
            txtSenha.Enabled = true;
            txtSenha.BorderStyle = BorderStyle.Fixed3D;
            btnSalvar.Enabled = true;
            txtNome.Focus();
        }
        private void DesabilitarEdicao()
        {
            txtNome.Enabled = false;
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Enabled = false;
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            btnNovo.Enabled = true;
        }
        private void Salvar()
        {
            if(txtNome.Text.Length >= 4 && txtSenha.Text.Length >= 4 && txtNome.Text.Length <= 12 && txtSenha.Text.Length <=12)
            {
                var usuario = new Usuario() { Nome = txtNome.Text.ToUpper(), Senha = txtSenha.Text };
                using (Banco banco = new Banco())
                {
                    var consulta = banco.Usuarios.Where(x => x.Nome == usuario.Nome).ToList();
                    //valida:
                    if (consulta.Count == 0)
                    {
                        DesabilitarEdicao();
                        if (estouIncluindo)
                        {
                            //adiciona:
                            usuario.DataCadastro = Repositorio.DataAtualInt();
                            banco.Usuarios.Add(usuario);
                            banco.SaveChanges();
                            MessageBox.Show("Usuário cadastrado com sucesso!", "Novo usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNome.Text = Repositorio.usuarioAtivo.Nome; txtSenha.Text = Repositorio.usuarioAtivo.Senha;
                        }
                        else
                        {
                            //atualizar:
                            usuario.UsuarioId = Repositorio.usuarioAtivo.UsuarioId;
                            usuario.DataCadastro = Repositorio.usuarioAtivo.DataCadastro;
                            banco.Usuarios.Update(usuario);
                            banco.SaveChanges();
                            Repositorio.usuarioAtivo = usuario;
                            MessageBox.Show("Alteração efetuada com sucesso!", "Alteração efetuada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("O nome de usuário já existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            else
            {
                MessageBox.Show("O usuário e senha precisam ter no mínimo 4 caracteres e no máximo 12.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //=====Ações da interface======
        private void button3_Click(object sender, EventArgs e)//botao "Criar Novo"
        {
            estouIncluindo = true;
            txtNome.Text = "";
            txtSenha.Text = "";
            HabilitarEdicao();
        }
        private void btnAlterar_Click(object sender, EventArgs e)//botao "Alterar Atual"
        {
            ConfirmaSenha form = new ConfirmaSenha();
            form.ShowDialog();
            if (form.autorizado)
            {
                estouIncluindo = false;
                HabilitarEdicao();
            } 
        }
        private void btnSalvar_Click(object sender, EventArgs e)//botao "Salvar"
        {
            Salvar();
        }
        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Salvar();
            }
        }
    }
}
