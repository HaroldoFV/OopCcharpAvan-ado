namespace EventosRunTime
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
            this.btnCriarButtonEmRunTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCriarButtonEmRunTime
            // 
            this.btnCriarButtonEmRunTime.Location = new System.Drawing.Point(96, 48);
            this.btnCriarButtonEmRunTime.Name = "btnCriarButtonEmRunTime";
            this.btnCriarButtonEmRunTime.Size = new System.Drawing.Size(75, 23);
            this.btnCriarButtonEmRunTime.TabIndex = 0;
            this.btnCriarButtonEmRunTime.Text = "Criar Button";
            this.btnCriarButtonEmRunTime.UseVisualStyleBackColor = true;
            this.btnCriarButtonEmRunTime.Click += new System.EventHandler(this.btnCriarButtonEmRunTime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 191);
            this.Controls.Add(this.btnCriarButtonEmRunTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCriarButtonEmRunTime;
    }
}

