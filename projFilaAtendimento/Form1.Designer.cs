namespace ProjFilaAtendimento
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
            this.btnGerar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblQtdeGuiches = new System.Windows.Forms.Label();
            this.lblNumeroGuiches = new System.Windows.Forms.Label();
            this.btnAdicionarGuiche = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxGuiche = new System.Windows.Forms.TextBox();
            this.btnChamarSenha = new System.Windows.Forms.Button();
            this.btnListarAtendimentos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(71, 53);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(108, 31);
            this.btnGerar.TabIndex = 0;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(24, 135);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 224);
            this.listBox1.TabIndex = 1;
            // 
            // lblQtdeGuiches
            // 
            this.lblQtdeGuiches.AutoSize = true;
            this.lblQtdeGuiches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeGuiches.Location = new System.Drawing.Point(263, 168);
            this.lblQtdeGuiches.Name = "lblQtdeGuiches";
            this.lblQtdeGuiches.Size = new System.Drawing.Size(173, 20);
            this.lblQtdeGuiches.TabIndex = 3;
            this.lblQtdeGuiches.Text = "Quantidade de guichês";
            this.lblQtdeGuiches.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNumeroGuiches
            // 
            this.lblNumeroGuiches.AutoSize = true;
            this.lblNumeroGuiches.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroGuiches.Location = new System.Drawing.Point(322, 200);
            this.lblNumeroGuiches.Name = "lblNumeroGuiches";
            this.lblNumeroGuiches.Size = new System.Drawing.Size(51, 55);
            this.lblNumeroGuiches.TabIndex = 4;
            this.lblNumeroGuiches.Text = "0";
            // 
            // btnAdicionarGuiche
            // 
            this.btnAdicionarGuiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarGuiche.Location = new System.Drawing.Point(295, 281);
            this.btnAdicionarGuiche.Name = "btnAdicionarGuiche";
            this.btnAdicionarGuiche.Size = new System.Drawing.Size(108, 31);
            this.btnAdicionarGuiche.TabIndex = 5;
            this.btnAdicionarGuiche.Text = "Adicionar";
            this.btnAdicionarGuiche.UseVisualStyleBackColor = true;
            this.btnAdicionarGuiche.Click += new System.EventHandler(this.btnAdicionarGuiche_Click);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(452, 135);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(336, 224);
            this.listBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Guichê";
            // 
            // txtBoxGuiche
            // 
            this.txtBoxGuiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxGuiche.Location = new System.Drawing.Point(504, 55);
            this.txtBoxGuiche.Name = "txtBoxGuiche";
            this.txtBoxGuiche.Size = new System.Drawing.Size(70, 26);
            this.txtBoxGuiche.TabIndex = 8;
            this.txtBoxGuiche.TextChanged += new System.EventHandler(this.txtBoxGuiche_TextChanged);
            // 
            // btnChamarSenha
            // 
            this.btnChamarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamarSenha.Location = new System.Drawing.Point(644, 50);
            this.btnChamarSenha.Name = "btnChamarSenha";
            this.btnChamarSenha.Size = new System.Drawing.Size(108, 31);
            this.btnChamarSenha.TabIndex = 9;
            this.btnChamarSenha.Text = "Chamar";
            this.btnChamarSenha.UseVisualStyleBackColor = true;
            this.btnChamarSenha.Click += new System.EventHandler(this.btnChamarSenha_Click);
            // 
            // btnListarAtendimentos
            // 
            this.btnListarAtendimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarAtendimentos.Location = new System.Drawing.Point(504, 365);
            this.btnListarAtendimentos.Name = "btnListarAtendimentos";
            this.btnListarAtendimentos.Size = new System.Drawing.Size(228, 31);
            this.btnListarAtendimentos.TabIndex = 11;
            this.btnListarAtendimentos.Text = "Listar Atendimentos";
            this.btnListarAtendimentos.UseVisualStyleBackColor = true;
            this.btnListarAtendimentos.Click += new System.EventHandler(this.btnListarAtendimentos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListarAtendimentos);
            this.Controls.Add(this.btnChamarSenha);
            this.Controls.Add(this.txtBoxGuiche);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnAdicionarGuiche);
            this.Controls.Add(this.lblNumeroGuiches);
            this.Controls.Add(this.lblQtdeGuiches);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnGerar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblQtdeGuiches;
        private System.Windows.Forms.Label lblNumeroGuiches;
        private System.Windows.Forms.Button btnAdicionarGuiche;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxGuiche;
        private System.Windows.Forms.Button btnChamarSenha;
        private System.Windows.Forms.Button btnListarAtendimentos;
    }
}

