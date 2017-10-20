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

namespace MS_Calhas.View
{
    public partial class ControleFuncionario : UserControl
    {
        //==========Variaveis==========
        //==========Construtor=========
        public ControleFuncionario()
        {
            InitializeComponent();
            AtualizaLista();
        }
        //======Métodos ajudantes======
        private void AtualizaLista()//atualiza a lista de funcionarios em ordem de Nome Acrescente
        {
            listaFuncionarios.Items.Clear();
            List<Funcionario> funcionarios;
            using(var banco = new Banco())
            {
                funcionarios = banco.Funcionarios.OrderBy(x => x.Nome).ToList();
            }
            foreach(var funcionario in funcionarios)
            {
                string[] linhaArray = { Convert.ToString(funcionario.FuncionarioId), funcionario.Nome };
                var item = new ListViewItem(linhaArray);
                listaFuncionarios.Items.Add(item);
            }
        }
        private Funcionario ItemSelecionado()//retorna o funcionario selecionado, Null caso não haja um selecionado.
        {
            try
            {
                var id = listaFuncionarios.SelectedItems[0].SubItems[0].Text;
                Funcionario consulta;
                using (var banco = new Banco())
                {
                    consulta = banco.Funcionarios.Find(Convert.ToInt32(id));
                }
                return consulta;
            }
            catch (Exception erro)
            {
                return null;
            }            
        }
        //=====Ações da interface======
        private void btnNovo_Click(object sender, EventArgs e)
        {
            var form = new NovoFuncionario(null);
            form.ShowDialog();
            AtualizaLista();
        }
        private void ControleFuncionario_Load(object sender, EventArgs e)
        {

        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(ItemSelecionado() != null)
            {
                using (var dao = new Banco())
                {
                    dao.Funcionarios.Remove(ItemSelecionado());
                    dao.SaveChanges();
                }
                AtualizaLista();
            }
            else
            {
                MessageBox.Show("Selecione um funcionário da lista primeiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ItemSelecionado() != null)
            {
                var form = new NovoFuncionario(ItemSelecionado());
                form.ShowDialog();
                AtualizaLista();
            }
            else
            {
                MessageBox.Show("Selecione um funcionário da lista primeiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
