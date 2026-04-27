namespace PojetoKamiTestes
{
    partial class GerenciamentoFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciamentoFuncionarios));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.msk_dtnasc = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.msk_cadcpf = new System.Windows.Forms.MaskedTextBox();
            this.msk_cadsenha = new System.Windows.Forms.MaskedTextBox();
            this.msk_confsenha = new System.Windows.Forms.MaskedTextBox();
            this.msk_login = new System.Windows.Forms.MaskedTextBox();
            this.txt_cadnome = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.msk_tel = new System.Windows.Forms.MaskedTextBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_funcionarios = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lOJAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_criarPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_pedidoAndto = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_financeiro = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_estoque = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUÁRIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_resetSenha = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DATA NASCIMENTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TELEFONE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-MAIL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "LOGIN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "SENHA";
            // 
            // msk_dtnasc
            // 
            this.msk_dtnasc.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msk_dtnasc.Location = new System.Drawing.Point(167, 89);
            this.msk_dtnasc.Mask = "00/00/0000";
            this.msk_dtnasc.Name = "msk_dtnasc";
            this.msk_dtnasc.Size = new System.Drawing.Size(100, 20);
            this.msk_dtnasc.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "CONFIRMAR SENHA";
            // 
            // msk_cadcpf
            // 
            this.msk_cadcpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msk_cadcpf.Location = new System.Drawing.Point(167, 132);
            this.msk_cadcpf.Mask = "000,000,000-00";
            this.msk_cadcpf.Name = "msk_cadcpf";
            this.msk_cadcpf.Size = new System.Drawing.Size(100, 20);
            this.msk_cadcpf.TabIndex = 9;
            // 
            // msk_cadsenha
            // 
            this.msk_cadsenha.Location = new System.Drawing.Point(167, 280);
            this.msk_cadsenha.Name = "msk_cadsenha";
            this.msk_cadsenha.Size = new System.Drawing.Size(100, 20);
            this.msk_cadsenha.TabIndex = 10;
            // 
            // msk_confsenha
            // 
            this.msk_confsenha.Location = new System.Drawing.Point(167, 311);
            this.msk_confsenha.Name = "msk_confsenha";
            this.msk_confsenha.Size = new System.Drawing.Size(100, 20);
            this.msk_confsenha.TabIndex = 11;
            // 
            // msk_login
            // 
            this.msk_login.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msk_login.Location = new System.Drawing.Point(167, 246);
            this.msk_login.Mask = "000,000,000-00";
            this.msk_login.Name = "msk_login";
            this.msk_login.Size = new System.Drawing.Size(100, 20);
            this.msk_login.TabIndex = 12;
            // 
            // txt_cadnome
            // 
            this.txt_cadnome.Location = new System.Drawing.Point(167, 45);
            this.txt_cadnome.Name = "txt_cadnome";
            this.txt_cadnome.Size = new System.Drawing.Size(350, 20);
            this.txt_cadnome.TabIndex = 13;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(167, 205);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(350, 20);
            this.txt_email.TabIndex = 14;
            // 
            // msk_tel
            // 
            this.msk_tel.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msk_tel.Location = new System.Drawing.Point(167, 170);
            this.msk_tel.Mask = "(00) 00000-0000";
            this.msk_tel.Name = "msk_tel";
            this.msk_tel.Size = new System.Drawing.Size(100, 20);
            this.msk_tel.TabIndex = 15;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(161, 361);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(106, 23);
            this.btn_cadastrar.TabIndex = 16;
            this.btn_cadastrar.Text = "CADASTRAR";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_funcionarios
            // 
            this.btn_funcionarios.Location = new System.Drawing.Point(293, 361);
            this.btn_funcionarios.Name = "btn_funcionarios";
            this.btn_funcionarios.Size = new System.Drawing.Size(106, 23);
            this.btn_funcionarios.TabIndex = 17;
            this.btn_funcionarios.Text = "FUNCIONÁRIOS";
            this.btn_funcionarios.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlText;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOJAToolStripMenuItem,
            this.uSUÁRIOToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lOJAToolStripMenuItem
            // 
            this.lOJAToolStripMenuItem.BackColor = System.Drawing.SystemColors.Desktop;
            this.lOJAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_criarPedido,
            this.btn_pedidoAndto,
            this.btn_financeiro,
            this.btn_estoque});
            this.lOJAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOJAToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lOJAToolStripMenuItem.Name = "lOJAToolStripMenuItem";
            this.lOJAToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.lOJAToolStripMenuItem.Text = "LOJA";
            // 
            // btn_criarPedido
            // 
            this.btn_criarPedido.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_criarPedido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_criarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btn_criarPedido.Image")));
            this.btn_criarPedido.Name = "btn_criarPedido";
            this.btn_criarPedido.Size = new System.Drawing.Size(201, 22);
            this.btn_criarPedido.Text = "Criar Pedido";
            // 
            // btn_pedidoAndto
            // 
            this.btn_pedidoAndto.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_pedidoAndto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_pedidoAndto.Image = ((System.Drawing.Image)(resources.GetObject("btn_pedidoAndto.Image")));
            this.btn_pedidoAndto.Name = "btn_pedidoAndto";
            this.btn_pedidoAndto.Size = new System.Drawing.Size(201, 22);
            this.btn_pedidoAndto.Text = "Pedido em Andamento";
            // 
            // btn_financeiro
            // 
            this.btn_financeiro.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_financeiro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_financeiro.Image = ((System.Drawing.Image)(resources.GetObject("btn_financeiro.Image")));
            this.btn_financeiro.Name = "btn_financeiro";
            this.btn_financeiro.Size = new System.Drawing.Size(201, 22);
            this.btn_financeiro.Text = "Financeiro";
            // 
            // btn_estoque
            // 
            this.btn_estoque.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_estoque.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_estoque.Image = ((System.Drawing.Image)(resources.GetObject("btn_estoque.Image")));
            this.btn_estoque.Name = "btn_estoque";
            this.btn_estoque.Size = new System.Drawing.Size(201, 22);
            this.btn_estoque.Text = "Estoque";
            // 
            // uSUÁRIOToolStripMenuItem
            // 
            this.uSUÁRIOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.btn_resetSenha});
            this.uSUÁRIOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uSUÁRIOToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uSUÁRIOToolStripMenuItem.Name = "uSUÁRIOToolStripMenuItem";
            this.uSUÁRIOToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.uSUÁRIOToolStripMenuItem.Text = "USUÁRIO";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(250, 22);
            this.toolStripMenuItem1.Text = "Gerenciamento de Funcionários";
            // 
            // btn_resetSenha
            // 
            this.btn_resetSenha.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_resetSenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_resetSenha.Image = ((System.Drawing.Image)(resources.GetObject("btn_resetSenha.Image")));
            this.btn_resetSenha.Name = "btn_resetSenha";
            this.btn_resetSenha.Size = new System.Drawing.Size(250, 22);
            this.btn_resetSenha.Text = "Reset de Senha";
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sAIRToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sAIRToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            // 
            // GerenciamentoFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_funcionarios);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.msk_tel);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_cadnome);
            this.Controls.Add(this.msk_login);
            this.Controls.Add(this.msk_confsenha);
            this.Controls.Add(this.msk_cadsenha);
            this.Controls.Add(this.msk_cadcpf);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.msk_dtnasc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "GerenciamentoFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerenciamentoFuncionarios";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox msk_dtnasc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox msk_cadcpf;
        private System.Windows.Forms.MaskedTextBox msk_cadsenha;
        private System.Windows.Forms.MaskedTextBox msk_confsenha;
        private System.Windows.Forms.MaskedTextBox msk_login;
        private System.Windows.Forms.TextBox txt_cadnome;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.MaskedTextBox msk_tel;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_funcionarios;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lOJAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_criarPedido;
        private System.Windows.Forms.ToolStripMenuItem btn_pedidoAndto;
        private System.Windows.Forms.ToolStripMenuItem btn_financeiro;
        private System.Windows.Forms.ToolStripMenuItem btn_estoque;
        private System.Windows.Forms.ToolStripMenuItem uSUÁRIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btn_resetSenha;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
    }
}