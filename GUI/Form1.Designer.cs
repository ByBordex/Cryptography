
    namespace App
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
                this.cbMethod = new System.Windows.Forms.ComboBox();
                this.btnEncrypt = new System.Windows.Forms.Button();
                this.btnDecrypt = new System.Windows.Forms.Button();
                this.lblCbMethod = new System.Windows.Forms.Label();
                this.lblKey = new System.Windows.Forms.Label();
                this.txtKey = new System.Windows.Forms.TextBox();
                this.txtInput = new System.Windows.Forms.TextBox();
                this.txtOutput = new System.Windows.Forms.TextBox();
                this.menuStrip1 = new System.Windows.Forms.MenuStrip();
                this.menuStrip2 = new System.Windows.Forms.MenuStrip();
                this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.menuStrip2.SuspendLayout();
                this.SuspendLayout();
                // 
                // cbMethod
                // 
                this.cbMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                this.cbMethod.FormattingEnabled = true;
                this.cbMethod.Location = new System.Drawing.Point(110, 21);
                this.cbMethod.Margin = new System.Windows.Forms.Padding(4);
                this.cbMethod.Name = "cbMethod";
                this.cbMethod.Size = new System.Drawing.Size(274, 26);
                this.cbMethod.TabIndex = 0;
                this.cbMethod.SelectedIndexChanged += new System.EventHandler(this.cbMethod_SelectedIndexChanged);
                // 
                // btnEncrypt
                // 
                this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                this.btnEncrypt.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                this.btnEncrypt.Location = new System.Drawing.Point(311, 63);
                this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4);
                this.btnEncrypt.Name = "btnEncrypt";
                this.btnEncrypt.Size = new System.Drawing.Size(112, 42);
                this.btnEncrypt.TabIndex = 1;
                this.btnEncrypt.Text = "Encrypt";
                this.btnEncrypt.UseVisualStyleBackColor = true;
                this.btnEncrypt.Click += new System.EventHandler(this.EncryptButton_Click);
                // 
                // btnDecrypt
                // 
                this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                this.btnDecrypt.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                this.btnDecrypt.Location = new System.Drawing.Point(431, 63);
                this.btnDecrypt.Margin = new System.Windows.Forms.Padding(4);
                this.btnDecrypt.Name = "btnDecrypt";
                this.btnDecrypt.Size = new System.Drawing.Size(112, 42);
                this.btnDecrypt.TabIndex = 2;
                this.btnDecrypt.Text = "Decrypt";
                this.btnDecrypt.UseVisualStyleBackColor = true;
                this.btnDecrypt.Click += new System.EventHandler(this.DecryptButton_Click);
                // 
                // lblCbMethod
                // 
                this.lblCbMethod.AutoSize = true;
                this.lblCbMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                this.lblCbMethod.Location = new System.Drawing.Point(16, 24);
                this.lblCbMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                this.lblCbMethod.Name = "lblCbMethod";
                this.lblCbMethod.Size = new System.Drawing.Size(86, 18);
                this.lblCbMethod.TabIndex = 3;
                this.lblCbMethod.Text = "Cipher type:";
                // 
                // lblKey
                // 
                this.lblKey.AutoSize = true;
                this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                this.lblKey.Location = new System.Drawing.Point(436, 24);
                this.lblKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                this.lblKey.Name = "lblKey";
                this.lblKey.Size = new System.Drawing.Size(37, 18);
                this.lblKey.TabIndex = 4;
                this.lblKey.Text = "Key:";
                this.lblKey.Click += new System.EventHandler(this.lblKey_Click);
                // 
                // txtKey
                // 
                this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                this.txtKey.Location = new System.Drawing.Point(481, 21);
                this.txtKey.Margin = new System.Windows.Forms.Padding(4);
                this.txtKey.Name = "txtKey";
                this.txtKey.Size = new System.Drawing.Size(319, 24);
                this.txtKey.TabIndex = 5;
                this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
                // 
                // txtInput
                // 
                this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                this.txtInput.Location = new System.Drawing.Point(20, 127);
                this.txtInput.Margin = new System.Windows.Forms.Padding(4);
                this.txtInput.Multiline = true;
                this.txtInput.Name = "txtInput";
                this.txtInput.Size = new System.Drawing.Size(402, 352);
                this.txtInput.TabIndex = 6;
                // 
                // txtOutput
                // 
                this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                this.txtOutput.Location = new System.Drawing.Point(432, 127);
                this.txtOutput.Margin = new System.Windows.Forms.Padding(4);
                this.txtOutput.Multiline = true;
                this.txtOutput.Name = "txtOutput";
                this.txtOutput.Size = new System.Drawing.Size(402, 352);
                this.txtOutput.TabIndex = 7;
                // 
                // menuStrip1
                // 
                this.menuStrip1.Location = new System.Drawing.Point(0, 24);
                this.menuStrip1.Name = "menuStrip1";
                this.menuStrip1.Size = new System.Drawing.Size(859, 24);
                this.menuStrip1.TabIndex = 8;
                this.menuStrip1.Text = "menuStrip1";
                // 
                // menuStrip2
                // 
                this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
                this.menuStrip2.Location = new System.Drawing.Point(0, 0);
                this.menuStrip2.Name = "menuStrip2";
                this.menuStrip2.Size = new System.Drawing.Size(859, 24);
                this.menuStrip2.TabIndex = 9;
                this.menuStrip2.Text = "menuStrip2";
                // 
                // fileToolStripMenuItem
                // 
                this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
                this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
                this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
                this.fileToolStripMenuItem.Text = "File";
                // 
                // openToolStripMenuItem
                // 
                this.openToolStripMenuItem.Name = "openToolStripMenuItem";
                this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
                this.openToolStripMenuItem.Text = "Open";
                this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
                // 
                // saveToolStripMenuItem
                // 
                this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
                this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
                this.saveToolStripMenuItem.Text = "Save";
                this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
                // 
                // Form1
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(859, 506);
                this.Controls.Add(this.txtOutput);
                this.Controls.Add(this.txtInput);
                this.Controls.Add(this.txtKey);
                this.Controls.Add(this.lblKey);
                this.Controls.Add(this.lblCbMethod);
                this.Controls.Add(this.btnDecrypt);
                this.Controls.Add(this.btnEncrypt);
                this.Controls.Add(this.cbMethod);
                this.Controls.Add(this.menuStrip1);
                this.Controls.Add(this.menuStrip2);
                this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
                this.MainMenuStrip = this.menuStrip1;
                this.Margin = new System.Windows.Forms.Padding(4);
                this.Name = "Form1";
                this.Text = "Cryptography";
                this.Load += new System.EventHandler(this.Form1_Load);
                this.menuStrip2.ResumeLayout(false);
                this.menuStrip2.PerformLayout();
                this.ResumeLayout(false);
                this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.ComboBox cbMethod;
            private System.Windows.Forms.Button btnEncrypt;
            private System.Windows.Forms.Button btnDecrypt;
            private System.Windows.Forms.Label lblCbMethod;
            private System.Windows.Forms.Label lblKey;
            private System.Windows.Forms.TextBox txtKey;
            private System.Windows.Forms.TextBox txtInput;
            private System.Windows.Forms.TextBox txtOutput;
            private System.Windows.Forms.MenuStrip menuStrip1;
            private System.Windows.Forms.MenuStrip menuStrip2;
            private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        }
    }

