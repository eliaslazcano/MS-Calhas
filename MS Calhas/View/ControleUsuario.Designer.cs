namespace MS_Calhas.View
{
    partial class ControleUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControleUsuario));
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.balao = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(290, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.Black;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Enabled = false;
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.White;
            this.txtSenha.Location = new System.Drawing.Point(232, 270);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(174, 27);
            this.txtSenha.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(249, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome de usuário";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Black;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(232, 197);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(174, 27);
            this.txtNome.TabIndex = 3;
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(51, 112);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(99, 65);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Criar novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.balao.SetToolTip(this.btnNovo, "Crie um novo usuário para outra pessoa");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.Location = new System.Drawing.Point(51, 202);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(99, 65);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar atual";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.balao.SetToolTip(this.btnAlterar, "Altere seu nome ou senha");
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnSalvar.FlatAppearance.BorderSize = 2;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(260, 322);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 40);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // balao
            // 
            this.balao.AutoPopDelay = 5000;
            this.balao.BackColor = System.Drawing.Color.Black;
            this.balao.ForeColor = System.Drawing.Color.White;
            this.balao.InitialDelay = 250;
            this.balao.ReshowDelay = 100;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(255, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ControleUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnAlterar);
            this.Name = "ControleUsuario";
            this.Size = new System.Drawing.Size(641, 385);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ToolTip balao;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
