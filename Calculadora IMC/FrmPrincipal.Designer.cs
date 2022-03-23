namespace Calculadora_IMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lbPeso = new System.Windows.Forms.Label();
            this.lbAltura = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.lbClassificacao = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPeso
            // 
            this.lbPeso.AutoSize = true;
            this.lbPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPeso.Location = new System.Drawing.Point(45, 72);
            this.lbPeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(160, 20);
            this.lbPeso.TabIndex = 0;
            this.lbPeso.Text = "Informe seu peso:";
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAltura.Location = new System.Drawing.Point(45, 133);
            this.lbAltura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(148, 20);
            this.lbAltura.TabIndex = 1;
            this.lbAltura.Text = "Informe a altura:";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(73, 289);
            this.lbResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(45, 20);
            this.lbResultado.TabIndex = 2;
            this.lbResultado.Text = "------";
            this.lbResultado.Visible = false;
            // 
            // lbClassificacao
            // 
            this.lbClassificacao.AutoSize = true;
            this.lbClassificacao.Location = new System.Drawing.Point(73, 334);
            this.lbClassificacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClassificacao.Name = "lbClassificacao";
            this.lbClassificacao.Size = new System.Drawing.Size(45, 20);
            this.lbClassificacao.TabIndex = 3;
            this.lbClassificacao.Text = "------";
            this.lbClassificacao.Visible = false;
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(213, 68);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(136, 24);
            this.txtPeso.TabIndex = 4;
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(213, 129);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(4);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(136, 24);
            this.txtAltura.TabIndex = 5;
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.SystemColors.Highlight;
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btCalcular.Location = new System.Drawing.Point(61, 185);
            this.btCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(288, 51);
            this.btCalcular.TabIndex = 6;
            this.btCalcular.Text = "Calcular o IMC";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 408);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lbClassificacao);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lbAltura);
            this.Controls.Add(this.lbPeso);
            this.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Calculadora IMC";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPeso;
        private System.Windows.Forms.Label lbAltura;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Label lbClassificacao;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btCalcular;
    }
}

