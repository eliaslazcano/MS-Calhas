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
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(205, 133);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(322, 190);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ControleCheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.listView1);
            this.Name = "ControleCheques";
            this.Size = new System.Drawing.Size(778, 484);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
    }
}
