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
using MS_Calhas.Controller;

namespace MS_Calhas.View
{
    public partial class CompensarCheque : Form
    {
        Cheque cheque;
        public CompensarCheque(Cheque cheque)
        {
            InitializeComponent();
            this.cheque = cheque;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(txtData.DataValidador())
            {
                if(Repositorio.DataDiferenca(cheque.DataCheque.DataParaInt(), txtData.Text.DataParaInt()) < 0)
                {
                    MessageBox.Show("Você não pode compensar o cheque antes da data prevista para descontar, apenas no dia previsto ou após (atrasado).", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }else if (txtData.Text.DataParaInt() > Repositorio.DataAtualInt())
                {
                    MessageBox.Show("Impossível o cheque ter sido compensado nesta data, pois ela nem chegou ainda.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    cheque.DataCompensacao = txtData.Text;
                    cheque.Compensado = true;
                    using (var banco = new Banco())
                    {
                        banco.Cheques.Update(cheque);
                        banco.SaveChanges();
                    }
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Data inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
