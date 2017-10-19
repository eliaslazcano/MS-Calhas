namespace MS_Calhas.View
{
    partial class ControleFuncionario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControleFuncionario));
            this.listaFuncionarios = new System.Windows.Forms.ListView();
            this.colunaId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.informante = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listaFuncionarios
            // 
            this.listaFuncionarios.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listaFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listaFuncionarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaId,
            this.colunaNome});
            this.listaFuncionarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaFuncionarios.Location = new System.Drawing.Point(3, 56);
            this.listaFuncionarios.Name = "listaFuncionarios";
            this.listaFuncionarios.Size = new System.Drawing.Size(635, 326);
            this.listaFuncionarios.TabIndex = 4;
            this.listaFuncionarios.UseCompatibleStateImageBehavior = false;
            this.listaFuncionarios.View = System.Windows.Forms.View.Details;
            // 
            // colunaId
            // 
            this.colunaId.Text = "ID";
            // 
            // colunaNome
            // 
            this.colunaNome.Text = "Nome";
            this.colunaNome.Width = 300;
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(7, 5);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(0);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(45, 45);
            this.btnNovo.TabIndex = 1;
            this.informante.SetToolTip(this.btnNovo, "Novo funcionário");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(69, 5);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(45, 45);
            this.btnAlterar.TabIndex = 2;
            this.informante.SetToolTip(this.btnAlterar, "Alterar Funcionário");
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(131, 5);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(45, 45);
            this.btnExcluir.TabIndex = 3;
            this.informante.SetToolTip(this.btnExcluir, "Excluir funcionário");
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(383, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 41);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtFiltro
            // 
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(425, 21);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(212, 27);
            this.txtFiltro.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(493, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtrar lista";
            // 
            // informante
            // 
            this.informante.AutomaticDelay = 200;
            // 
            // ControleFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.listaFuncionarios);
            this.Name = "ControleFuncionario";
            this.Size = new System.Drawing.Size(641, 385);
            this.Load += new System.EventHandler(this.ControleFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listaFuncionarios;
        private System.Windows.Forms.ColumnHeader colunaNome;
        private System.Windows.Forms.ColumnHeader colunaId;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip informante;
    }
}
