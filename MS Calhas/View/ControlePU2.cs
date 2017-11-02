using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Calhas.Model;
using MS_Calhas.Controller;
using Microsoft.EntityFrameworkCore;

namespace MS_Calhas.View
{
    public partial class ControlePU2 : Form
    {
        ControlePU formPai;
        List<RegistroCarga> registros;
        Funcionario funcionario;
        //============Construtor==============
        public ControlePU2(Funcionario funcionario, ControlePU formPai)
        {
            InitializeComponent();
            this.formPai = formPai;
            using (var banco = new Banco())
            {
                registros = banco.Registros.Where(x => x.FuncionarioId == funcionario.FuncionarioId).ToList();
            }
            txtNome.Text = funcionario.Nome;
            this.funcionario = funcionario;
        }
        //==========Métodos ajudantes==========
        private void RecarregarListaSaida()
        {
            listaSaidas.Items.Clear();
            foreach (var y in registros)
            {
                if(y.tipo == RegistroCarga.Tipos.Saida)
                {
                    string[] linhaArray = { Convert.ToString(y.Id), Convert.ToString(y.material), Convert.ToString(y.quantidade), y.data + " " + y.hora };
                    var item = new ListViewItem(linhaArray);
                    listaSaidas.Items.Add(item);
                }                
            }
        }
        //==========Ações da Interface=========
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            formPai.RecarregarLista();
        }
        private void ControlePU2_Load(object sender, EventArgs e)
        {

        }
        private void btnAddSaida_Click(object sender, EventArgs e)
        {
            //adicionar saida
            var form = new AdicionaRegistro(null, true);
            form.ShowDialog();
        }
    }
}
