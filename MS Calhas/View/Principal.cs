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
    public partial class Principal : Form
    {
        //==========Variaveis==========
        Resumo telaResumo = new Resumo();//instancia Tela Resumo
        ControleCheques telaCheques = new ControleCheques();//instancia Tela Cheques
        ControlePU telaPU = new ControlePU();//instancia Tela Controle PU
        bool mover;
        bool maximizado = false;
        private int cX, cY;
        //==========Construtor=========
        public Principal()
        {
            InitializeComponent();
            this.Controls.Add(telaResumo);
            this.Controls.Add(telaCheques);
            this.Controls.Add(telaPU);

            txtUser.Text = Repositorio.usuarioAtivo.Nome;
            labelDataHoje.Text = Repositorio.DataAtualInt().DataParaString();
        }
        //======Métodos ajudantes======
        private void MostrarTela(UserControl tela, Button botao)
        {
            SidePanel.Top = botao.Top;
            tela.BringToFront();
        }
        //=====Ações da interface======
        private void button1_Click(object sender, EventArgs e)//Botão "RESUMO"
        {
            //trexo que tenta re-executar a tela do zero (animações), mas que não deixe acumular memória ram.
            this.Controls.Remove(telaResumo);
            telaResumo.Dispose();//aqui libera memoria
            telaResumo = new Resumo();
            this.Controls.Add(telaResumo);

            MostrarTela(telaResumo, btnResumo);
        }
        private void btnCheques_Click(object sender, EventArgs e)//Botão "CHEQUES"
        {
            MostrarTela(telaCheques, btnCheques);
        }
        private void btnPU_Click(object sender, EventArgs e)//Botão "CONTROLE PU"
        {
            MostrarTela(telaPU, btnPU);
        }
        private void button4_Click(object sender, EventArgs e)//Botão "FECHAR"
        {
            Application.Exit();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnMinimizar_Click(object sender, EventArgs e)//Botão "MINIMIZAR"
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cX = e.X;
                cY = e.Y;
                mover = true;
            }
        }
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mover = false;
        }
        private void btnConfig_Click(object sender, EventArgs e)
        {
            var form = new Configuracoes();
            form.ShowDialog();
            txtUser.Text = Repositorio.usuarioAtivo.Nome;
            telaPU.RecarregarLista();
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            MostrarTela(telaResumo, btnResumo);
        }
        private void propaganda_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMaximizar_Click(object sender, EventArgs e)//Botão "Maximizar"
        {
            if (!maximizado)
            {
                this.WindowState = FormWindowState.Maximized;
                maximizado = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                maximizado = false;
            }            
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            var creditos = new Creditos();
            creditos.Show();
        }

        private void labelDataHoje_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MS_Calhas.Controller.MacAPI.obterMAC() );
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                this.Left += e.X - (cX - panel1.Left);
                this.Top += e.Y - (cY - panel1.Top);
            }
        }
    }
}
