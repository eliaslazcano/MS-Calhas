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
    public partial class ControlePU : UserControl
    {
        //====Variaveis Local====
        //======Construtor=======
        public ControlePU()
        {
            InitializeComponent();
            this.Top = 55;
            this.Left = 201;
            this.Dock = DockStyle.Fill;
            RecarregarLista();
        }
        //====Métodos ajudantes===
        private Funcionario FuncionarioSelecionado()//retorna instancia Funcionario selecionado, ou null.
        {
            string nome = listaFuncionario.SelectedItems[0].SubItems[0].Text;
            using (var banco = new Banco())
            {
                var consulta = banco.Funcionarios.Where(x => x.Nome == nome).ToList();
                if(consulta.Count == 1)
                {
                    return consulta.First();
                }
                else
                {
                    return null;
                }
            }
        }
        public void RecarregarLista()//falta implementar a coluna Pendencia
        {
            listaFuncionario.Items.Clear();
            using(var banco = new Banco())
            {
                var consulta = banco.Funcionarios.OrderBy(x => x.Nome).ToList();
                foreach(var x in consulta)
                {
                    string[] linhaArray = { x.Nome };
                    var item = new ListViewItem(linhaArray);
                    listaFuncionario.Items.Add(item);
                }
            }
        }
        //===Ações da interface===
        private void listaFuncionario_MouseDoubleClick(object sender, MouseEventArgs e)//ao clicar no funcionario:
        {
            if(FuncionarioSelecionado() != null)
            {
                var form = new ControlePU2(FuncionarioSelecionado(), this);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro, tente novamente clicando duas vezes sobre o funcionário.");
            }            
        }
    }
}
