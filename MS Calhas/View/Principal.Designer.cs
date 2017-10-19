namespace MS_Calhas.View
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.propaganda = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnPU = new System.Windows.Forms.Button();
            this.btnCheques = new System.Windows.Forms.Button();
            this.btnResumo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.Label();
            this.btnConfig = new System.Windows.Forms.Button();
            this.mensagem = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.propaganda);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btnPU);
            this.panel1.Controls.Add(this.btnCheques);
            this.panel1.Controls.Add(this.btnResumo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 560);
            this.panel1.TabIndex = 0;
            // 
            // propaganda
            // 
            this.propaganda.AutoSize = true;
            this.propaganda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propaganda.ForeColor = System.Drawing.Color.White;
            this.propaganda.Location = new System.Drawing.Point(6, 535);
            this.propaganda.Name = "propaganda";
            this.propaganda.Size = new System.Drawing.Size(189, 17);
            this.propaganda.TabIndex = 5;
            this.propaganda.Text = "Desenvolvido por Elias Neto";
            this.propaganda.Click += new System.EventHandler(this.propaganda_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 91);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 54);
            this.SidePanel.TabIndex = 2;
            // 
            // btnPU
            // 
            this.btnPU.FlatAppearance.BorderSize = 0;
            this.btnPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPU.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPU.ForeColor = System.Drawing.Color.White;
            this.btnPU.Image = ((System.Drawing.Image)(resources.GetObject("btnPU.Image")));
            this.btnPU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPU.Location = new System.Drawing.Point(12, 211);
            this.btnPU.Name = "btnPU";
            this.btnPU.Size = new System.Drawing.Size(188, 54);
            this.btnPU.TabIndex = 4;
            this.btnPU.Text = "    Controle PU";
            this.btnPU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPU.UseVisualStyleBackColor = true;
            this.btnPU.Click += new System.EventHandler(this.btnPU_Click);
            // 
            // btnCheques
            // 
            this.btnCheques.FlatAppearance.BorderSize = 0;
            this.btnCheques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheques.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheques.ForeColor = System.Drawing.Color.White;
            this.btnCheques.Image = ((System.Drawing.Image)(resources.GetObject("btnCheques.Image")));
            this.btnCheques.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheques.Location = new System.Drawing.Point(12, 151);
            this.btnCheques.Name = "btnCheques";
            this.btnCheques.Size = new System.Drawing.Size(188, 54);
            this.btnCheques.TabIndex = 4;
            this.btnCheques.Text = "    Cheques";
            this.btnCheques.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheques.UseVisualStyleBackColor = true;
            this.btnCheques.Click += new System.EventHandler(this.btnCheques_Click);
            // 
            // btnResumo
            // 
            this.btnResumo.FlatAppearance.BorderSize = 0;
            this.btnResumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResumo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResumo.ForeColor = System.Drawing.Color.White;
            this.btnResumo.Image = ((System.Drawing.Image)(resources.GetObject("btnResumo.Image")));
            this.btnResumo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResumo.Location = new System.Drawing.Point(12, 91);
            this.btnResumo.Name = "btnResumo";
            this.btnResumo.Size = new System.Drawing.Size(188, 54);
            this.btnResumo.TabIndex = 2;
            this.btnResumo.Text = "    Resumo";
            this.btnResumo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResumo.UseVisualStyleBackColor = true;
            this.btnResumo.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 10);
            this.panel2.TabIndex = 1;
            this.mensagem.SetToolTip(this.panel2, "Arrastar");
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(721, 6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(28, 28);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mensagem.SetToolTip(this.btnMinimizar, "Minimizar");
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(755, 6);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(28, 28);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mensagem.SetToolTip(this.btnFechar, "Fechar");
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 41);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Window;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtUser);
            this.panel5.Controls.Add(this.btnConfig);
            this.panel5.Controls.Add(this.btnMinimizar);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.btnFechar);
            this.panel5.Location = new System.Drawing.Point(201, 11);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(788, 43);
            this.panel5.TabIndex = 6;
            // 
            // txtUser
            // 
            this.txtUser.AutoSize = true;
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtUser.Location = new System.Drawing.Point(44, 9);
            this.txtUser.Margin = new System.Windows.Forms.Padding(0);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(56, 23);
            this.txtUser.TabIndex = 7;
            this.txtUser.Text = "João";
            this.txtUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
            this.btnConfig.Location = new System.Drawing.Point(687, 6);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(28, 28);
            this.btnConfig.TabIndex = 4;
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mensagem.SetToolTip(this.btnConfig, "Configurações");
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // mensagem
            // 
            this.mensagem.AutomaticDelay = 200;
            this.mensagem.BackColor = System.Drawing.SystemColors.Menu;
            this.mensagem.IsBalloon = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(990, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 550);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(200, 550);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(790, 10);
            this.panel4.TabIndex = 7;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1000, 560);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MS Calhas";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnResumo;
        private System.Windows.Forms.Button btnCheques;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label txtUser;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.ToolTip mensagem;
        private System.Windows.Forms.Button btnPU;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label propaganda;
    }
}