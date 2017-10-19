namespace MS_Calhas.View
{
    partial class ControlePU
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
            this.listaFuncionario = new System.Windows.Forms.ListView();
            this.colunaFuncionario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listaFuncionario
            // 
            this.listaFuncionario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaFuncionario,
            this.columnHeader1});
            this.listaFuncionario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaFuncionario.Location = new System.Drawing.Point(86, 101);
            this.listaFuncionario.Name = "listaFuncionario";
            this.listaFuncionario.Size = new System.Drawing.Size(622, 328);
            this.listaFuncionario.TabIndex = 0;
            this.listaFuncionario.UseCompatibleStateImageBehavior = false;
            this.listaFuncionario.View = System.Windows.Forms.View.Details;
            // 
            // colunaFuncionario
            // 
            this.colunaFuncionario.Text = "Funcionário";
            this.colunaFuncionario.Width = 180;
            // 
            // ControlePU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.listaFuncionario);
            this.Name = "ControlePU";
            this.Size = new System.Drawing.Size(800, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaFuncionario;
        private System.Windows.Forms.ColumnHeader colunaFuncionario;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
