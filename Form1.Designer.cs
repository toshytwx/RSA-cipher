namespace RSAEncryptor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.textArea = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.decryptButton = new System.Windows.Forms.Button();
            this.cryptButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.publicKeyTf = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.aboutButton);
            this.panel1.Controls.Add(this.saveFileButton);
            this.panel1.Controls.Add(this.openFileButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 38);
            this.panel1.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(435, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(138, 32);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(294, 3);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(135, 32);
            this.aboutButton.TabIndex = 1;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(147, 3);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(141, 32);
            this.saveFileButton.TabIndex = 1;
            this.saveFileButton.Text = "Save File";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(3, 3);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(138, 32);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // textArea
            // 
            this.textArea.Location = new System.Drawing.Point(12, 56);
            this.textArea.Multiline = true;
            this.textArea.Name = "textArea";
            this.textArea.Size = new System.Drawing.Size(576, 185);
            this.textArea.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.decryptButton);
            this.panel2.Controls.Add(this.cryptButton);
            this.panel2.Location = new System.Drawing.Point(306, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 52);
            this.panel2.TabIndex = 2;
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(144, 3);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(135, 46);
            this.decryptButton.TabIndex = 4;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // cryptButton
            // 
            this.cryptButton.Location = new System.Drawing.Point(3, 3);
            this.cryptButton.Name = "cryptButton";
            this.cryptButton.Size = new System.Drawing.Size(135, 46);
            this.cryptButton.TabIndex = 3;
            this.cryptButton.Text = "Crypt";
            this.cryptButton.UseVisualStyleBackColor = true;
            this.cryptButton.Click += new System.EventHandler(this.cryptButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.publicKeyTf);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(12, 247);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 52);
            this.panel3.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 0;
            // 
            // publicKeyTf
            // 
            this.publicKeyTf.AutoSize = true;
            this.publicKeyTf.Location = new System.Drawing.Point(3, 20);
            this.publicKeyTf.Name = "publicKeyTf";
            this.publicKeyTf.Size = new System.Drawing.Size(59, 13);
            this.publicKeyTf.TabIndex = 1;
            this.publicKeyTf.Text = "Public key:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 311);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "RSA Encryptor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.TextBox textArea;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button cryptButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label publicKeyTf;
        private System.Windows.Forms.TextBox textBox1;
    }
}

