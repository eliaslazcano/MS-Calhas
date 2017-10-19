namespace MS_Calhas.View
{
    partial class Resumo
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.graficoPU = new LiveCharts.WinForms.CartesianChart();
            this.graficoCheque = new LiveCharts.WinForms.SolidGauge();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // graficoPU
            // 
            this.graficoPU.BackColor = System.Drawing.SystemColors.Window;
            this.graficoPU.ForeColor = System.Drawing.Color.Black;
            this.graficoPU.Location = new System.Drawing.Point(3, 204);
            this.graficoPU.Name = "graficoPU";
            this.graficoPU.Size = new System.Drawing.Size(772, 267);
            this.graficoPU.TabIndex = 1;
            this.graficoPU.Text = "cartesianChart1";
            this.graficoPU.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.graficoPU_ChildChanged);
            // 
            // graficoCheque
            // 
            this.graficoCheque.BackColor = System.Drawing.Color.White;
            this.graficoCheque.Location = new System.Drawing.Point(113, 23);
            this.graficoCheque.Name = "graficoCheque";
            this.graficoCheque.Size = new System.Drawing.Size(200, 152);
            this.graficoCheque.TabIndex = 2;
            this.graficoCheque.Text = "solidGauge1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(107, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Próximo cheque vence em";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(193, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "dias";
            // 
            // Resumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.graficoCheque);
            this.Controls.Add(this.graficoPU);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Resumo";
            this.Size = new System.Drawing.Size(778, 484);
            this.Load += new System.EventHandler(this.Resumo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LiveCharts.WinForms.CartesianChart graficoPU;
        private LiveCharts.WinForms.SolidGauge graficoCheque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}
