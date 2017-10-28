using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_Calhas.View
{
    public partial class ControlePU : UserControl
    {
        public ControlePU()
        {
            InitializeComponent();
            this.Top = 55;
            this.Left = 201;
            this.Dock = DockStyle.Fill;
            //this.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right);
        }
    }
}
