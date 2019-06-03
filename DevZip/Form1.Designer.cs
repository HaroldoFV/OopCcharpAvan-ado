namespace DevZip
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
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.btnCompactar = new System.Windows.Forms.Button();
            this.dlg = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTarget = new System.Windows.Forms.Button();
            this.lstArquivos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnFileName = new System.Windows.Forms.Button();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(43, 45);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(347, 20);
            this.txtSource.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Target";
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(43, 110);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(347, 20);
            this.txtTarget.TabIndex = 2;
            // 
            // btnCompactar
            // 
            this.btnCompactar.Location = new System.Drawing.Point(43, 357);
            this.btnCompactar.Name = "btnCompactar";
            this.btnCompactar.Size = new System.Drawing.Size(75, 23);
            this.btnCompactar.TabIndex = 4;
            this.btnCompactar.Text = "Compactar";
            this.btnCompactar.UseVisualStyleBackColor = true;
            this.btnCompactar.Click += new System.EventHandler(this.btnCompactar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "..";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTarget
            // 
            this.btnTarget.Location = new System.Drawing.Point(396, 107);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(37, 23);
            this.btnTarget.TabIndex = 6;
            this.btnTarget.Text = "..";
            this.btnTarget.UseVisualStyleBackColor = true;
            this.btnTarget.Click += new System.EventHandler(this.button2_Click);
            // 
            // lstArquivos
            // 
            this.lstArquivos.FormattingEnabled = true;
            this.lstArquivos.Location = new System.Drawing.Point(43, 230);
            this.lstArquivos.Name = "lstArquivos";
            this.lstArquivos.Size = new System.Drawing.Size(347, 121);
            this.lstArquivos.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "FileName";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(43, 173);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(347, 20);
            this.txtFileName.TabIndex = 8;
            // 
            // btnFileName
            // 
            this.btnFileName.Location = new System.Drawing.Point(396, 173);
            this.btnFileName.Name = "btnFileName";
            this.btnFileName.Size = new System.Drawing.Size(37, 23);
            this.btnFileName.TabIndex = 10;
            this.btnFileName.Text = "..";
            this.btnFileName.UseVisualStyleBackColor = true;
            this.btnFileName.Click += new System.EventHandler(this.btnFileName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 410);
            this.Controls.Add(this.btnFileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lstArquivos);
            this.Controls.Add(this.btnTarget);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCompactar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSource);
            this.Name = "Form1";
            this.Text = "DevZip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Button btnCompactar;
        private System.Windows.Forms.FolderBrowserDialog dlg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTarget;
        private System.Windows.Forms.ListBox lstArquivos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnFileName;
        private System.Windows.Forms.SaveFileDialog dlgSave;
    }
}

