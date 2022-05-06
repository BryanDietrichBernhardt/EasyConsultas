
namespace EasyConsultas
{
    partial class frmCadastrarPaciente
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelCpf = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCpf = new System.Windows.Forms.TextBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(40, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nome";
            this.labelName.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Location = new System.Drawing.Point(12, 44);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(28, 15);
            this.labelCpf.TabIndex = 1;
            this.labelCpf.Text = "CPF";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(58, 12);
            this.textBoxName.MaxLength = 150;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PlaceholderText = "Digite o nome...";
            this.textBoxName.Size = new System.Drawing.Size(356, 23);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxCpf
            // 
            this.textBoxCpf.Location = new System.Drawing.Point(46, 41);
            this.textBoxCpf.MaxLength = 11;
            this.textBoxCpf.Name = "textBoxCpf";
            this.textBoxCpf.PlaceholderText = "Digite o CPF (apenas números)...";
            this.textBoxCpf.Size = new System.Drawing.Size(368, 23);
            this.textBoxCpf.TabIndex = 3;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(12, 73);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(41, 15);
            this.labelEndereco.TabIndex = 4;
            this.labelEndereco.Text = "E-mail";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(59, 70);
            this.textBoxEmail.MaxLength = 150;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PlaceholderText = "Digite o e-mail...";
            this.textBoxEmail.Size = new System.Drawing.Size(355, 23);
            this.textBoxEmail.TabIndex = 5;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(150, 102);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(102, 44);
            this.buttonAdicionar.TabIndex = 6;
            this.buttonAdicionar.Text = "ADICIONAR";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCadastrarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 158);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.textBoxCpf);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelCpf);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadastrarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Paciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCpf;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonAdicionar;
    }
}