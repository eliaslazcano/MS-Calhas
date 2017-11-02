namespace MS_Calhas.View
{
    partial class ControlePU2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlePU2));
            this.btnFechar = new System.Windows.Forms.Button();
            this.listaSaidas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelSaida = new System.Windows.Forms.Button();
            this.btnAltSaida = new System.Windows.Forms.Button();
            this.btnAddSaida = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.Label();
            this.registroCargaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registroCargaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(979, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(33, 33);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // listaSaidas
            // 
            this.listaSaidas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listaSaidas.FullRowSelect = true;
            this.listaSaidas.GridLines = true;
            this.listaSaidas.Location = new System.Drawing.Point(30, 76);
            this.listaSaidas.MultiSelect = false;
            this.listaSaidas.Name = "listaSaidas";
            this.listaSaidas.Size = new System.Drawing.Size(387, 251);
            this.listaSaidas.TabIndex = 1;
            this.listaSaidas.UseCompatibleStateImageBehavior = false;
            this.listaSaidas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cod";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Material";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantidade";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Data";
            this.columnHeader4.Width = 130;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 560);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1014, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 560);
            this.panel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelSaida);
            this.groupBox1.Controls.Add(this.btnAltSaida);
            this.groupBox1.Controls.Add(this.btnAddSaida);
            this.groupBox1.Controls.Add(this.listaSaidas);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(40, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 356);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saídas (fornecido)";
            // 
            // btnDelSaida
            // 
            this.btnDelSaida.FlatAppearance.BorderSize = 0;
            this.btnDelSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelSaida.Image = ((System.Drawing.Image)(resources.GetObject("btnDelSaida.Image")));
            this.btnDelSaida.Location = new System.Drawing.Point(108, 37);
            this.btnDelSaida.Name = "btnDelSaida";
            this.btnDelSaida.Size = new System.Drawing.Size(33, 33);
            this.btnDelSaida.TabIndex = 2;
            this.btnDelSaida.UseVisualStyleBackColor = true;
            // 
            // btnAltSaida
            // 
            this.btnAltSaida.FlatAppearance.BorderSize = 0;
            this.btnAltSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltSaida.Image = ((System.Drawing.Image)(resources.GetObject("btnAltSaida.Image")));
            this.btnAltSaida.Location = new System.Drawing.Point(69, 37);
            this.btnAltSaida.Name = "btnAltSaida";
            this.btnAltSaida.Size = new System.Drawing.Size(33, 33);
            this.btnAltSaida.TabIndex = 2;
            this.btnAltSaida.UseVisualStyleBackColor = true;
            // 
            // btnAddSaida
            // 
            this.btnAddSaida.FlatAppearance.BorderSize = 0;
            this.btnAddSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSaida.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSaida.Image")));
            this.btnAddSaida.Location = new System.Drawing.Point(30, 37);
            this.btnAddSaida.Name = "btnAddSaida";
            this.btnAddSaida.Size = new System.Drawing.Size(33, 33);
            this.btnAddSaida.TabIndex = 2;
            this.btnAddSaida.UseVisualStyleBackColor = true;
            this.btnAddSaida.Click += new System.EventHandler(this.btnAddSaida_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtNome.Location = new System.Drawing.Point(12, 0);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(1000, 28);
            this.txtNome.TabIndex = 4;
            this.txtNome.Text = "Funcionario Nome";
            this.txtNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registroCargaBindingSource
            // 
            this.registroCargaBindingSource.DataSource = typeof(MS_Calhas.Model.RegistroCarga);
            // 
            // ControlePU2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1024, 560);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlePU2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ControlePU2";
            this.Load += new System.EventHandler(this.ControlePU2_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.registroCargaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.BindingSource registroCargaBindingSource;
        private System.Windows.Forms.ListView listaSaidas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelSaida;
        private System.Windows.Forms.Button btnAltSaida;
        private System.Windows.Forms.Button btnAddSaida;
        private System.Windows.Forms.Label txtNome;
    }
}