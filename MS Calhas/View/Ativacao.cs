using MS_Calhas.Model;
using MS_Calhas.Controller;
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
    public partial class Ativacao : Form
    {
        public Ativacao()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            var form = new Creditos();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validar();
        }

        private void Validar()
        {
            string chave = txtSerial.Text;
            if (chave == "VnWRpWIfqJ")
            {
                using (var banco = new Banco())
                {
                    banco.Otimizacao.Add(new Section() { unification = MacAPI.obterMAC(), inauguracao = Repositorio.DataAtualInt().DataParaString() });
                    banco.SaveChanges();
                }
                MessageBox.Show("Acesso Autorizado! Tente executar o programa novamente.", "Acesso Autorizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Chave de acesso inválida", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtSerial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                Validar();
            }
        }
    }
}
