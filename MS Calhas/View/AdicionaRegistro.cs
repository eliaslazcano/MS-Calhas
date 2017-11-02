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
using MS_Calhas.Model;

namespace MS_Calhas.View
{
    public partial class AdicionaRegistro : Form
    {
        RegistroCarga registro;
        bool ehSaida;
        public AdicionaRegistro(RegistroCarga registro, bool ehSaida)
        {
            InitializeComponent();
            this.registro = registro;
            this.ehSaida = ehSaida;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AdicionaRegistro_Load(object sender, EventArgs e)
        {
            txtData.Text = Repositorio.DataAtualString();
            txtHora.Text = Repositorio.HoraAtualString();
            txtMaterial.Items.Add("Selecione um material");
            txtMaterial.Items.Add("PU");
            txtMaterial.Items.Add("Silicone");
            txtMaterial.SelectedIndex = 0;
            if (ehSaida)
            {
                txtTitulo.Text = "Registro de saída";
            }
            else
            {
                txtTitulo.Text = "Registro de entrada";
            }
        }
        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            //se não for número & não for BackSpace, então:
            {
                e.Handled = true; //isso impede que o caractere presionado seja lido pelo programa.
            }
        }
        private void btnSim_Click(object sender, EventArgs e)
        {
            if(txtMaterial.SelectedIndex != 0)
            {                
                if (txtData.DataValidador())
                {
                    if (txtHora.HoraValidador())
                    {
                        //prossiga
                    }
                    else
                    {
                        //msg de erro, hora inválida
                    }
                }
                else
                {
                    //msg de erro, data inválida
                }
            }
            else
            {
                //msg de erro, selecione o material
            }
        }
    }
}
