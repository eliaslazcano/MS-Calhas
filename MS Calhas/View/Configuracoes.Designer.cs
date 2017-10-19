namespace MS_Calhas.View
{
    partial class Configuracoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracoes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.indicador = new System.Windows.Forms.Panel();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.indicador);
            this.panel1.Controls.Add(this.btnFuncionarios);
            this.panel1.Controls.Add(this.btnUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 113);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(606, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // indicador
            // 
            this.indicador.BackColor = System.Drawing.Color.Crimson;
            this.indicador.Location = new System.Drawing.Point(12, 2);
            this.indicador.Name = "indicador";
            this.indicador.Size = new System.Drawing.Size(132, 10);
            this.indicador.TabIndex = 1;
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.FlatAppearance.BorderSize = 0;
            this.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.ForeColor = System.Drawing.Color.White;
            this.btnFuncionarios.Image = ((System.Drawing.Image)(resources.GetObject("btnFuncionarios.Image")));
            this.btnFuncionarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFuncionarios.Location = new System.Drawing.Point(150, 14);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(132, 92);
            this.btnFuncionarios.TabIndex = 0;
            this.btnFuncionarios.Text = "Funcionários";
            this.btnFuncionarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFuncionarios.UseVisualStyleBackColor = true;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsuario.Location = new System.Drawing.Point(12, 14);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(132, 92);
            this.btnUsuario.TabIndex = 0;
            this.btnUsuario.Text = "Usuário";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(641, 498);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Configuracoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuracoes";
            this.Load += new System.EventHandler(this.Configuracoes_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Panel indicador;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
    }
}