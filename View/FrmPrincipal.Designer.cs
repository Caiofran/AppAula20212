
namespace View
{
    partial class FrmPrincipal
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barraStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.itbUsuarioLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.itbHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tHora = new System.Windows.Forms.Timer(this.components);
            this.barraStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraStatus
            // 
            this.barraStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.barraStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.itbUsuarioLogado,
            this.toolStripStatusLabel2,
            this.itbHora});
            this.barraStatus.Location = new System.Drawing.Point(0, 431);
            this.barraStatus.Name = "barraStatus";
            this.barraStatus.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.barraStatus.Size = new System.Drawing.Size(841, 26);
            this.barraStatus.TabIndex = 0;
            this.barraStatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(121, 20);
            this.toolStripStatusLabel1.Text = "Usuário Logado: ";
            // 
            // itbUsuarioLogado
            // 
            this.itbUsuarioLogado.Name = "itbUsuarioLogado";
            this.itbUsuarioLogado.Size = new System.Drawing.Size(108, 20);
            this.itbUsuarioLogado.Text = "usuarioLogado";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(13, 20);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // itbHora
            // 
            this.itbHora.Name = "itbHora";
            this.itbHora.Size = new System.Drawing.Size(63, 20);
            this.itbHora.Text = "00:00:00";
            // 
            // tHora
            // 
            this.tHora.Enabled = true;
            this.tHora.Interval = 1000;
            this.tHora.Tick += new System.EventHandler(this.tHora_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 457);
            this.Controls.Add(this.barraStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Aplicação de Exemplo de Aula";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.barraStatus.ResumeLayout(false);
            this.barraStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip barraStatus;
        private System.Windows.Forms.ToolStripStatusLabel itbUsuarioLogado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel itbHora;
        private System.Windows.Forms.Timer tHora;
    }
}

