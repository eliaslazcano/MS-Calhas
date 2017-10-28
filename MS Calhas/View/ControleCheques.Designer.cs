namespace MS_Calhas.View
{
    partial class ControleCheques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControleCheques));
            this.listaCheques = new System.Windows.Forms.ListView();
            this.colunaCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaCodBanco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaNomeBanco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaConta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaChequeNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.msg = new System.Windows.Forms.ToolTip(this.components);
            this.btnCompensar = new System.Windows.Forms.Button();
            this.txtTotalNC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listaCheques
            // 
            this.listaCheques.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaCheques.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaCheques.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaCliente,
            this.colunaCodBanco,
            this.colunaNomeBanco,
            this.colunaConta,
            this.colunaChequeNum,
            this.colunaValor,
            this.colunaData,
            this.colunaStatus});
            this.listaCheques.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaCheques.FullRowSelect = true;
            this.listaCheques.GridLines = true;
            this.listaCheques.Location = new System.Drawing.Point(0, 109);
            this.listaCheques.MultiSelect = false;
            this.listaCheques.Name = "listaCheques";
            this.listaCheques.Size = new System.Drawing.Size(835, 388);
            this.listaCheques.TabIndex = 0;
            this.listaCheques.UseCompatibleStateImageBehavior = false;
            this.listaCheques.View = System.Windows.Forms.View.Details;
            this.listaCheques.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listaCheques_ColumnClick);
            // 
            // colunaCliente
            // 
            this.colunaCliente.Text = "Cliente";
            this.colunaCliente.Width = 100;
            // 
            // colunaCodBanco
            // 
            this.colunaCodBanco.Text = "Cód Banco";
            this.colunaCodBanco.Width = 80;
            // 
            // colunaNomeBanco
            // 
            this.colunaNomeBanco.Text = "Nome do banco";
            this.colunaNomeBanco.Width = 110;
            // 
            // colunaConta
            // 
            this.colunaConta.Text = "Conta";
            this.colunaConta.Width = 68;
            // 
            // colunaChequeNum
            // 
            this.colunaChequeNum.Text = "Nº Cheque";
            this.colunaChequeNum.Width = 80;
            // 
            // colunaValor
            // 
            this.colunaValor.Text = "Valor cheque";
            this.colunaValor.Width = 94;
            // 
            // colunaData
            // 
            this.colunaData.Text = "Data";
            this.colunaData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colunaData.Width = 80;
            // 
            // colunaStatus
            // 
            this.colunaStatus.Text = "Status";
            this.colunaStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colunaStatus.Width = 222;
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(4, 58);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(45, 45);
            this.btnNovo.TabIndex = 1;
            this.msg.SetToolTip(this.btnNovo, "Adicionar");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(59, 58);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(45, 45);
            this.btnAlterar.TabIndex = 1;
            this.msg.SetToolTip(this.btnAlterar, "Alterar");
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(114, 58);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(45, 45);
            this.btnExcluir.TabIndex = 1;
            this.msg.SetToolTip(this.btnExcluir, "Excluir");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // msg
            // 
            this.msg.AutomaticDelay = 100;
            this.msg.AutoPopDelay = 5000;
            this.msg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(155)))), ((int)(((byte)(247)))));
            this.msg.ForeColor = System.Drawing.Color.White;
            this.msg.InitialDelay = 100;
            this.msg.IsBalloon = true;
            this.msg.ReshowDelay = 20;
            this.msg.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.msg_Draw);
            this.msg.Popup += new System.Windows.Forms.PopupEventHandler(this.msg_Popup);
            // 
            // btnCompensar
            // 
            this.btnCompensar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCompensar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnCompensar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnCompensar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompensar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompensar.Image = ((System.Drawing.Image)(resources.GetObject("btnCompensar.Image")));
            this.btnCompensar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompensar.Location = new System.Drawing.Point(565, 57);
            this.btnCompensar.Name = "btnCompensar";
            this.btnCompensar.Size = new System.Drawing.Size(267, 45);
            this.btnCompensar.TabIndex = 1;
            this.btnCompensar.Text = "Marcar como Compensado";
            this.btnCompensar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompensar.UseVisualStyleBackColor = true;
            this.btnCompensar.Click += new System.EventHandler(this.btnCompensar_Click);
            // 
            // txtTotalNC
            // 
            this.txtTotalNC.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTotalNC.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNC.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtTotalNC.Location = new System.Drawing.Point(0, 0);
            this.txtTotalNC.Name = "txtTotalNC";
            this.txtTotalNC.Size = new System.Drawing.Size(835, 21);
            this.txtTotalNC.TabIndex = 2;
            this.txtTotalNC.Text = "Total a descontar: x";
            this.txtTotalNC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ControleCheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtTotalNC);
            this.Controls.Add(this.btnCompensar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.listaCheques);
            this.Name = "ControleCheques";
            this.Size = new System.Drawing.Size(835, 497);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaCheques;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ColumnHeader colunaCliente;
        private System.Windows.Forms.ColumnHeader colunaCodBanco;
        private System.Windows.Forms.ColumnHeader colunaNomeBanco;
        private System.Windows.Forms.ColumnHeader colunaChequeNum;
        private System.Windows.Forms.ColumnHeader colunaConta;
        private System.Windows.Forms.ColumnHeader colunaValor;
        private System.Windows.Forms.ColumnHeader colunaData;
        private System.Windows.Forms.ColumnHeader colunaStatus;
        private System.Windows.Forms.Button btnCompensar;
        private System.Windows.Forms.Label txtTotalNC;
        public System.Windows.Forms.ToolTip msg;
    }
}
