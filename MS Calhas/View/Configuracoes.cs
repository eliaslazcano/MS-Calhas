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
    public partial class Configuracoes : Form
    {
        UserControl subTela = new UserControl();
        public Configuracoes()
        {
            InitializeComponent();
            this.Controls.Add(subTela);//evita bugs com o método MostrarTela
        }
        private void MostrarTela(UserControl tela, Button botao)
        {
            this.Controls.Remove(subTela);
            indicador.Left = botao.Left;
            subTela = tela;
            subTela.Left = 0;
            subTela.Top = 113;
            this.Controls.Add(subTela);
        }
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            MostrarTela(new ControleUsuario(), btnUsuario);
        }
        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            MostrarTela(new ControleFuncionario(), btnFuncionarios);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }      
        private void Configuracoes_Load(object sender, EventArgs e)
        {
            MostrarTela(new ControleUsuario(), btnUsuario);
        }
    }
}
