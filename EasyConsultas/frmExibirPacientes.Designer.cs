
namespace EasyConsultas
{
    partial class frmExibirPacientes
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
            this.textBoxPacientes = new System.Windows.Forms.TextBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.listViewPacientes = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // textBoxPacientes
            // 
            this.textBoxPacientes.Location = new System.Drawing.Point(12, 13);
            this.textBoxPacientes.Name = "textBoxPacientes";
            this.textBoxPacientes.Size = new System.Drawing.Size(445, 23);
            this.textBoxPacientes.TabIndex = 1;
            this.textBoxPacientes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPacientes_KeyDown);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(463, 13);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(93, 23);
            this.buttonPesquisar.TabIndex = 2;
            this.buttonPesquisar.Text = "PESQUISAR";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // listViewPacientes
            // 
            this.listViewPacientes.HideSelection = false;
            this.listViewPacientes.Location = new System.Drawing.Point(13, 43);
            this.listViewPacientes.Name = "listViewPacientes";
            this.listViewPacientes.Size = new System.Drawing.Size(543, 284);
            this.listViewPacientes.TabIndex = 3;
            this.listViewPacientes.UseCompatibleStateImageBehavior = false;
            // 
            // frmExibirPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 339);
            this.Controls.Add(this.listViewPacientes);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.textBoxPacientes);
            this.Name = "frmExibirPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExibirPacientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPacientes;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.ListView listViewPacientes;
    }
}