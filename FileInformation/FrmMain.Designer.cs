namespace FileInformation
{
    partial class FrmMain
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
            this.openDlg = new System.Windows.Forms.OpenFileDialog();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCriacao = new System.Windows.Forms.TextBox();
            this.txtModificacao = new System.Windows.Forms.TextBox();
            this.txtAcesso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.txtExtensao = new System.Windows.Forms.TextBox();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.cbReadOnly = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAtributos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openDlg
            // 
            this.openDlg.FileName = "openFileDialog1";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(13, 13);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Criação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Acesso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Modificação";
            // 
            // txtCriacao
            // 
            this.txtCriacao.Location = new System.Drawing.Point(87, 50);
            this.txtCriacao.Name = "txtCriacao";
            this.txtCriacao.Size = new System.Drawing.Size(168, 20);
            this.txtCriacao.TabIndex = 4;
            // 
            // txtModificacao
            // 
            this.txtModificacao.Location = new System.Drawing.Point(87, 118);
            this.txtModificacao.Name = "txtModificacao";
            this.txtModificacao.Size = new System.Drawing.Size(168, 20);
            this.txtModificacao.TabIndex = 5;
            // 
            // txtAcesso
            // 
            this.txtAcesso.Location = new System.Drawing.Point(87, 84);
            this.txtAcesso.Name = "txtAcesso";
            this.txtAcesso.Size = new System.Drawing.Size(168, 20);
            this.txtAcesso.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Diretorio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Extensão";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(87, 158);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(168, 20);
            this.txtNome.TabIndex = 10;
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Location = new System.Drawing.Point(87, 194);
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.Size = new System.Drawing.Size(168, 20);
            this.txtDiretorio.TabIndex = 11;
            // 
            // txtExtensao
            // 
            this.txtExtensao.Location = new System.Drawing.Point(87, 231);
            this.txtExtensao.Name = "txtExtensao";
            this.txtExtensao.Size = new System.Drawing.Size(168, 20);
            this.txtExtensao.TabIndex = 12;
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(87, 272);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(168, 20);
            this.txtTamanho.TabIndex = 14;
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Location = new System.Drawing.Point(12, 279);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(52, 13);
            this.lblTamanho.TabIndex = 13;
            this.lblTamanho.Text = "Tamanho";
            // 
            // cbReadOnly
            // 
            this.cbReadOnly.AutoSize = true;
            this.cbReadOnly.Location = new System.Drawing.Point(15, 312);
            this.cbReadOnly.Name = "cbReadOnly";
            this.cbReadOnly.Size = new System.Drawing.Size(103, 17);
            this.cbReadOnly.TabIndex = 15;
            this.cbReadOnly.Text = "Somente Leitura";
            this.cbReadOnly.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Atributos";
            // 
            // txtAtributos
            // 
            this.txtAtributos.Location = new System.Drawing.Point(303, 73);
            this.txtAtributos.Multiline = true;
            this.txtAtributos.Name = "txtAtributos";
            this.txtAtributos.Size = new System.Drawing.Size(217, 219);
            this.txtAtributos.TabIndex = 17;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 365);
            this.Controls.Add(this.txtAtributos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbReadOnly);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.lblTamanho);
            this.Controls.Add(this.txtExtensao);
            this.Controls.Add(this.txtDiretorio);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAcesso);
            this.Controls.Add(this.txtModificacao);
            this.Controls.Add(this.txtCriacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbrir);
            this.Name = "FrmMain";
            this.Text = "File Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openDlg;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCriacao;
        private System.Windows.Forms.TextBox txtModificacao;
        private System.Windows.Forms.TextBox txtAcesso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDiretorio;
        private System.Windows.Forms.TextBox txtExtensao;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.CheckBox cbReadOnly;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAtributos;
    }
}

