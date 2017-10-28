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
    public partial class ControleCheques : UserControl
    {
        //==========Variaveis==========
        double totalDescontar;
        int atualColunaOrdenada = 7;//indice da coluna que está servindo de ordenação, de 0 á 7.
        //==========Construtor=========
        public ControleCheques()
        {
            InitializeComponent();
            this.Top = 55;
            this.Left = 201;
            this.Dock = DockStyle.Fill;
            AtualizarLista();
        }
        //======Métodos ajudantes======
        private void AtualizarLista()
        {
            totalDescontar = 0;

            listaCheques.Items.Clear();//limpa os itens
            List<Cheque> cheques;
            using (var banco = new Banco())
            {                
                //aqui a consulta é ordenada de acordo com a ultima coluna clicada pelo usuário
                switch (atualColunaOrdenada)
                {
                    case 0:
                        cheques = banco.Cheques.OrderBy(x => x.Cliente).ToList();
                        break;
                    case 1:
                        cheques = banco.Cheques.OrderBy(x => x.CodBanco).ToList();
                        break;
                    case 2:
                        cheques = banco.Cheques.OrderBy(x => x.Banco).ToList();
                        break;
                    case 3:
                        cheques = banco.Cheques.OrderBy(x => x.Conta).ToList();
                        break;
                    case 4:
                        cheques = banco.Cheques.OrderBy(x => x.NumCheque).ToList();
                        break;
                    case 5:
                        cheques = banco.Cheques.OrderBy(x => x.Valor).ToList();
                        break;
                    case 6:
                        cheques = banco.Cheques.OrderBy(x => x.DataCheque.DataParaInt()).ToList();
                        break;
                    case 7:
                        cheques = banco.Cheques.OrderBy(x => x.Compensado).ThenBy(y => y.DataCheque.DataParaInt()).ToList();
                        break;
                    case 10:
                        cheques = banco.Cheques.OrderByDescending(x => x.Cliente).ToList();
                        break;
                    case 11:
                        cheques = banco.Cheques.OrderByDescending(x => x.CodBanco).ToList();
                        break;
                    case 12:
                        cheques = banco.Cheques.OrderByDescending(x => x.Banco).ToList();
                        break;
                    case 13:
                        cheques = banco.Cheques.OrderByDescending(x => x.Conta).ToList();
                        break;
                    case 14:
                        cheques = banco.Cheques.OrderByDescending(x => x.NumCheque).ToList();
                        break;
                    case 15:
                        cheques = banco.Cheques.OrderByDescending(x => x.Valor).ToList();
                        break;
                    case 16:
                        cheques = banco.Cheques.OrderByDescending(x => x.DataCheque.DataParaInt()).ToList();
                        break;
                    case 17:
                        cheques = banco.Cheques.OrderByDescending(x => x.Compensado).ThenBy(y => y.DataCheque.DataParaInt()).ToList();
                        break;
                    default:
                        cheques = banco.Cheques.ToList();
                        break;
                }//fim switch case
            }//fim using banco
            foreach (var x in cheques)
            {


                string[] linhaArray = { x.Cliente, x.CodBanco, x.Banco, x.Conta, x.NumCheque, "R$ " + x.Valor.ToString("N2"), x.DataCheque};
                ListViewItem item = new ListViewItem(linhaArray);
                item.UseItemStyleForSubItems = false;
                
                if (x.Compensado)
                {
                    item.SubItems.Add("Compensado em " + x.DataCompensacao, Color.White, Color.Green, new Font("Century Gothic", 11) );
                }
                else
                {
                    totalDescontar += x.Valor;

                    int diferenca = Repositorio.DataDiferenca(Repositorio.DataAtualInt(), x.DataCheque.DataParaInt());
                    if (diferenca <= 0)
                    {
                        item.SubItems.Add("Descontar cheque", Color.White, Color.Red, new Font("Century Gothic", 11, FontStyle.Italic, GraphicsUnit.Point) );
                    }
                    else if (diferenca == 1)
                    {
                        item.SubItems.Add("Falta " + diferenca + " dia para descontar");
                    }
                    else if (diferenca > 1)
                    {
                        item.SubItems.Add("Faltam " + diferenca + " dias para descontar");
                    }
                }

                listaCheques.Items.Add(item);                
            }
            txtTotalNC.Text = "Total a descontar: R$ " + totalDescontar.ToString("N2");
        }
        private Cheque ChequeSelecionado()
        {
            //etapa 1 = Valida se há um cheque selecionado
            if (listaCheques.SelectedItems.Count == 0)
            {
                MessageBox.Show("Você deve selecionar um cheque da lista primeiro.", "Cheque não especificado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            //etapa 2 = Adquire o cheque no banco de dados
            var codigoBanco = listaCheques.SelectedItems[0].SubItems[1].Text;
            var numCheque = listaCheques.SelectedItems[0].SubItems[4].Text;
            var dataCheque = listaCheques.SelectedItems[0].SubItems[6].Text;
            var conta = listaCheques.SelectedItems[0].SubItems[3].Text;
            Cheque consulta;
            using (var banco = new Banco())
            {
                consulta = banco.Cheques.Where(x => x.CodBanco == codigoBanco && x.NumCheque == numCheque && x.DataCheque == dataCheque && x.Conta == conta).ToList().First();
            }
            return consulta;
        }//da o cheque selecionado da lista, ou então null se não houver seleção e avisa o usuário.
        //=====Ações da interface======
        private void btnNovo_Click(object sender, EventArgs e)
        {
            var form = new AdicionarCheque();
            form.ShowDialog();
            AtualizarLista();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(ChequeSelecionado() == null)
            {                
                return;
            }
            if (ChequeSelecionado().Compensado)
            {
                MessageBox.Show("Alterar um cheque compensado não é possível por razões de segurança.", "Alteração Negada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var codigoBanco = listaCheques.SelectedItems[0].SubItems[1].Text;
            var numCheque = listaCheques.SelectedItems[0].SubItems[4].Text;
            var dataCheque = listaCheques.SelectedItems[0].SubItems[6].Text;
            var conta = listaCheques.SelectedItems[0].SubItems[3].Text;
            Cheque consulta;

            using (var banco = new Banco())
            {
                consulta = banco.Cheques.Where(x => x.CodBanco == codigoBanco && x.NumCheque == numCheque && x.DataCheque == dataCheque && x.Conta == conta).ToList().First();
            }

            var form = new AdicionarCheque(consulta);
            form.ShowDialog();
            AtualizarLista();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ChequeSelecionado() != null)
            {
                var consulta = ChequeSelecionado();
                var resposta = MessageBox.Show("Tem certeza que deseja excluir o cheque nº " + consulta.NumCheque + " de R$ " + consulta.Valor + " ?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (resposta == DialogResult.Yes)
                {
                    using (var banco = new Banco())
                    {
                        banco.Cheques.Remove(consulta);
                        banco.SaveChanges();
                    }
                    AtualizarLista();
                }
            }
        }
        private void btnCompensar_Click(object sender, EventArgs e)
        {
            //etapa 1 = Valida se há um cheque selecionado
            if (ChequeSelecionado() != null)
            {
                if (!ChequeSelecionado().Compensado)//caso o cheque ainda não foi compensado
                {
                    if (Repositorio.DataDiferenca(Repositorio.DataAtualInt(), ChequeSelecionado().DataCheque.DataParaInt()) <= 0)//caso o cheque ja esteja na data elegivel para ser descontado
                    {
                        var consulta = ChequeSelecionado();
                        var resposta = MessageBox.Show("Deseja marcar que o cheque foi 'compensado' na data de hoje?\nClique em 'Não' caso deseje especificar outra data (esqueceu de compensar no dia certo)", "Descontar cheque", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (resposta == DialogResult.Yes)//compensar na data de hoje
                        {
                            using (var banco = new Banco())
                            {
                                consulta.DataCompensacao = Repositorio.DataAtualInt().DataParaString();
                                consulta.Compensado = true;
                                banco.Cheques.Update(consulta);
                                banco.SaveChanges();
                            }
                        }
                        else if (resposta == DialogResult.No)//compensar na data desejada
                        {
                            var compensar = new CompensarCheque(consulta);
                            compensar.ShowDialog();
                        }
                        else//Cancel
                        {

                        }
                        AtualizarLista();
                    }
                    else
                    {
                        MessageBox.Show("Ainda é cedo, este cheque ainda não chegou na data para ser compensado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Este cheque já foi compensado", "Já está compensado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }           
            }
        }
        private void listaCheques_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if(e.Column == atualColunaOrdenada)//se esta clicando na coluna que ja é ordenada então:
            {
                atualColunaOrdenada = e.Column + 10;
            }
            else//senão, prossiga normalmente:
            {
                atualColunaOrdenada = e.Column;
            } 
            AtualizarLista();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void msg_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }
        private void msg_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
