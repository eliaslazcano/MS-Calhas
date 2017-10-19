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
        private void AtualizaLista()
        {
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
        //=====Ações da interface======
        private void btnNovo_Click(object sender, EventArgs e)
        {
            var form = new NovoFuncionario(this);
            form.ShowDialog();
        }
        private void ControleFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
