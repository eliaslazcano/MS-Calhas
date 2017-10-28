using MS_Calhas.Controller;
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
    public partial class ConfirmaSenha : Form
    {
        public bool autorizado = false;
        public ConfirmaSenha()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Checar();
        }

        private void Checar()
        {
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Digite a senha");
            }
            else
            {
                if (txtSenha.Text == Repositorio.usuarioAtivo.Senha)//valida a senha
                {
                    autorizado = true;
                    this.Close();
                }
                else
                {
                    autorizado = false;
                    //acionar um modo do dono da conta saber disso.
                    using (var banco = new Banco())
                    {
                        var consulta = banco.Usuarios.Find(Repositorio.usuarioAtivo.UsuarioId);
                        consulta.Violacao = true;
                        consulta.DataViolacao = Repositorio.DataAtualInt().DataParaString();
                        consulta.HoraViolacao = DateTime.Now.Hour + "h" + DateTime.Now.Minute + "m";
                        banco.Usuarios.Update(consulta);
                        banco.SaveChanges();
                    }
                    MessageBox.Show("Senha incorreta, acesso negado!\nEntrando com medidas de segurança.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Checar();
            }
        }
    }
}
