namespace CasdastroDePessoas
{
    partial class Form1
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textPass = new System.Windows.Forms.TextBox();
            this.textUser = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.panelCadastro = new System.Windows.Forms.Panel();
            this.lblContato = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDados = new System.Windows.Forms.Label();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.textEndereço = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.textCEP = new System.Windows.Forms.TextBox();
            this.textBairro = new System.Windows.Forms.TextBox();
            this.textEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.btnBuscaCEP = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelarCadastro = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            this.panelCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.textPass);
            this.panelLogin.Controls.Add(this.textUser);
            this.panelLogin.Controls.Add(this.btnOk);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(903, 565);
            this.panelLogin.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha:";
            //  
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuário:";
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(379, 274);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(112, 20);
            this.textPass.TabIndex = 2;
            this.textPass.Text = "123";
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(379, 235);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(113, 20);
            this.textUser.TabIndex = 1;
            this.textUser.Text = "admin";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(399, 311);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Login";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panelCadastro
            // 
            this.panelCadastro.Controls.Add(this.btnCancelarCadastro);
            this.panelCadastro.Controls.Add(this.btnCadastrar);
            this.panelCadastro.Controls.Add(this.btnBuscaCEP);
            this.panelCadastro.Controls.Add(this.textCidade);
            this.panelCadastro.Controls.Add(this.lblCidade);
            this.panelCadastro.Controls.Add(this.lblEstado);
            this.panelCadastro.Controls.Add(this.textEstado);
            this.panelCadastro.Controls.Add(this.textBairro);
            this.panelCadastro.Controls.Add(this.textCEP);
            this.panelCadastro.Controls.Add(this.lblCEP);
            this.panelCadastro.Controls.Add(this.lblBairro);
            this.panelCadastro.Controls.Add(this.textEndereço);
            this.panelCadastro.Controls.Add(this.lblEndereço);
            this.panelCadastro.Controls.Add(this.lblContato);
            this.panelCadastro.Controls.Add(this.radioButton2);
            this.panelCadastro.Controls.Add(this.radioButton1);
            this.panelCadastro.Controls.Add(this.lblSexo);
            this.panelCadastro.Controls.Add(this.maskedTextBox1);
            this.panelCadastro.Controls.Add(this.lblDataNasc);
            this.panelCadastro.Controls.Add(this.textNome);
            this.panelCadastro.Controls.Add(this.lblNome);
            this.panelCadastro.Controls.Add(this.lblDados);
            this.panelCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCadastro.Location = new System.Drawing.Point(0, 0);
            this.panelCadastro.Name = "panelCadastro";
            this.panelCadastro.Size = new System.Drawing.Size(903, 565);
            this.panelCadastro.TabIndex = 5;
            this.panelCadastro.Visible = false;
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContato.Location = new System.Drawing.Point(281, 278);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(282, 25);
            this.lblContato.TabIndex = 8;
            this.lblContato.Text = "Informações para contato";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(252, 167);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Feminino";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(161, 167);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Masculino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(40, 172);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 5;
            this.lblSexo.Text = "Sexo:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(161, 129);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(66, 20);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(35, 136);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(105, 13);
            this.lblDataNasc.TabIndex = 3;
            this.lblDataNasc.Text = "Data de nascimento:";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(161, 94);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(257, 20);
            this.textNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(35, 98);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDados.Location = new System.Drawing.Point(310, 39);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(172, 25);
            this.lblDados.TabIndex = 0;
            this.lblDados.Text = "Dados Pessoais";
            // 
            // lblEndereço
            // 
            this.lblEndereço.AutoSize = true;
            this.lblEndereço.Location = new System.Drawing.Point(39, 382);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(56, 13);
            this.lblEndereço.TabIndex = 9;
            this.lblEndereço.Text = "Endereço:";
            // 
            // textEndereço
            // 
            this.textEndereço.Location = new System.Drawing.Point(160, 379);
            this.textEndereço.Name = "textEndereço";
            this.textEndereço.Size = new System.Drawing.Size(296, 20);
            this.textEndereço.TabIndex = 10;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(39, 421);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 11;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(39, 344);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 12;
            this.lblCEP.Text = "CEP:";
            // 
            // textCEP
            // 
            this.textCEP.Location = new System.Drawing.Point(160, 341);
            this.textCEP.Name = "textCEP";
            this.textCEP.Size = new System.Drawing.Size(173, 20);
            this.textCEP.TabIndex = 13;
            // 
            // textBairro
            // 
            this.textBairro.Location = new System.Drawing.Point(160, 418);
            this.textBairro.Name = "textBairro";
            this.textBairro.Size = new System.Drawing.Size(297, 20);
            this.textBairro.TabIndex = 14;
            // 
            // textEstado
            // 
            this.textEstado.Location = new System.Drawing.Point(160, 455);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(100, 20);
            this.textEstado.TabIndex = 15;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(39, 458);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(24, 13);
            this.lblEstado.TabIndex = 16;
            this.lblEstado.Text = "UF:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(298, 458);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 17;
            this.lblCidade.Text = "Cidade:";
            // 
            // textCidade
            // 
            this.textCidade.Location = new System.Drawing.Point(393, 455);
            this.textCidade.Name = "textCidade";
            this.textCidade.Size = new System.Drawing.Size(155, 20);
            this.textCidade.TabIndex = 18;
            // 
            // btnBuscaCEP
            // 
            this.btnBuscaCEP.Location = new System.Drawing.Point(355, 338);
            this.btnBuscaCEP.Name = "btnBuscaCEP";
            this.btnBuscaCEP.Size = new System.Drawing.Size(137, 23);
            this.btnBuscaCEP.TabIndex = 19;
            this.btnBuscaCEP.Text = "Buscar pelo CEP";
            this.btnBuscaCEP.UseVisualStyleBackColor = true;
            this.btnBuscaCEP.Click += new System.EventHandler(this.btnBuscaCEP_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(797, 516);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 20;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCadastro
            // 
            this.btnCancelarCadastro.Location = new System.Drawing.Point(716, 516);
            this.btnCancelarCadastro.Name = "btnCancelarCadastro";
            this.btnCancelarCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCadastro.TabIndex = 21;
            this.btnCancelarCadastro.Text = "Cancelar";
            this.btnCancelarCadastro.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 565);
            this.Controls.Add(this.panelCadastro);
            this.Controls.Add(this.panelLogin);
            this.Name = "Form1";
            this.Text = "Cadastro";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelCadastro.ResumeLayout(false);
            this.panelCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCadastro;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.TextBox textCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox textEndereço;
        private System.Windows.Forms.Label lblEndereço;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox textEstado;
        private System.Windows.Forms.TextBox textBairro;
        private System.Windows.Forms.TextBox textCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Button btnBuscaCEP;
        private System.Windows.Forms.Button btnCancelarCadastro;
        private System.Windows.Forms.Button btnCadastrar;
    }
}

