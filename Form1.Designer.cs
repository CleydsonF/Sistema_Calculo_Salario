namespace Aula_5_WindowsFormExercico_02_05
{
    partial class Form1
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
            this.txtColaborador = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtValorProjeto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdClt = new System.Windows.Forms.RadioButton();
            this.rdPj = new System.Windows.Forms.RadioButton();
            this.rdFreelancer = new System.Windows.Forms.RadioButton();
            this.apagar = new System.Windows.Forms.Button();
            this.calcular = new System.Windows.Forms.Button();
            this.calculo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtColaborador
            // 
            this.txtColaborador.Location = new System.Drawing.Point(136, 68);
            this.txtColaborador.Name = "txtColaborador";
            this.txtColaborador.Size = new System.Drawing.Size(156, 20);
            this.txtColaborador.TabIndex = 4;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(136, 116);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(156, 20);
            this.txtSalario.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtValorProjeto
            // 
            this.txtValorProjeto.Location = new System.Drawing.Point(136, 161);
            this.txtValorProjeto.Name = "txtValorProjeto";
            this.txtValorProjeto.Size = new System.Drawing.Size(156, 20);
            this.txtValorProjeto.TabIndex = 6;
            this.txtValorProjeto.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome do Colaborador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Salário Bruto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor do Projeto";
            this.label3.Visible = false;
            // 
            // rdClt
            // 
            this.rdClt.AutoSize = true;
            this.rdClt.Location = new System.Drawing.Point(23, 22);
            this.rdClt.Name = "rdClt";
            this.rdClt.Size = new System.Drawing.Size(88, 17);
            this.rdClt.TabIndex = 1;
            this.rdClt.TabStop = true;
            this.rdClt.Text = "Contrato CLT";
            this.rdClt.UseVisualStyleBackColor = true;
            // 
            // rdPj
            // 
            this.rdPj.AutoSize = true;
            this.rdPj.Location = new System.Drawing.Point(136, 22);
            this.rdPj.Name = "rdPj";
            this.rdPj.Size = new System.Drawing.Size(80, 17);
            this.rdPj.TabIndex = 2;
            this.rdPj.TabStop = true;
            this.rdPj.Text = "Contrato PJ";
            this.rdPj.UseVisualStyleBackColor = true;
            // 
            // rdFreelancer
            // 
            this.rdFreelancer.AutoSize = true;
            this.rdFreelancer.Location = new System.Drawing.Point(244, 22);
            this.rdFreelancer.Name = "rdFreelancer";
            this.rdFreelancer.Size = new System.Drawing.Size(75, 17);
            this.rdFreelancer.TabIndex = 3;
            this.rdFreelancer.TabStop = true;
            this.rdFreelancer.Text = "Freelancer";
            this.rdFreelancer.UseVisualStyleBackColor = true;
            this.rdFreelancer.CheckedChanged += new System.EventHandler(this.rdFreelancer_CheckedChanged);
            // 
            // apagar
            // 
            this.apagar.Location = new System.Drawing.Point(174, 210);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(75, 23);
            this.apagar.TabIndex = 0;
            this.apagar.Text = "Apagar";
            this.apagar.UseVisualStyleBackColor = true;
            this.apagar.Click += new System.EventHandler(this.apagar_Click);
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(69, 210);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 7;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // calculo
            // 
            this.calculo.AutoSize = true;
            this.calculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculo.Location = new System.Drawing.Point(12, 256);
            this.calculo.Name = "calculo";
            this.calculo.Size = new System.Drawing.Size(41, 13);
            this.calculo.TabIndex = 8;
            this.calculo.Text = "label4";
            this.calculo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 298);
            this.Controls.Add(this.calculo);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.rdFreelancer);
            this.Controls.Add(this.rdPj);
            this.Controls.Add(this.rdClt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorProjeto);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtColaborador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtColaborador;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtValorProjeto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdClt;
        private System.Windows.Forms.RadioButton rdPj;
        private System.Windows.Forms.RadioButton rdFreelancer;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label calculo;
    }
}

