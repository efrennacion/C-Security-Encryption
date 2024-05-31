namespace API_Encyption
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnGenToken = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnEncryptBool = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.encDecResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(7, 12);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(695, 86);
            this.txtInput.TabIndex = 1;
            // 
            // btnGenToken
            // 
            this.btnGenToken.Location = new System.Drawing.Point(7, 104);
            this.btnGenToken.Name = "btnGenToken";
            this.btnGenToken.Size = new System.Drawing.Size(170, 52);
            this.btnGenToken.TabIndex = 2;
            this.btnGenToken.Text = "Generate Token";
            this.btnGenToken.UseVisualStyleBackColor = true;
            this.btnGenToken.Click += new System.EventHandler(this.btnGenToken_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(183, 104);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(169, 52);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Encrypt String";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click_1);
            // 
            // btnEncryptBool
            // 
            this.btnEncryptBool.Location = new System.Drawing.Point(358, 104);
            this.btnEncryptBool.Name = "btnEncryptBool";
            this.btnEncryptBool.Size = new System.Drawing.Size(169, 52);
            this.btnEncryptBool.TabIndex = 4;
            this.btnEncryptBool.Text = "Encrypt Boolean";
            this.btnEncryptBool.UseVisualStyleBackColor = true;
            this.btnEncryptBool.Click += new System.EventHandler(this.btnEncryptBool_Click_1);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(533, 104);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(169, 52);
            this.btnDecrypt.TabIndex = 5;
            this.btnDecrypt.Text = "Decrypt String";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click_1);
            // 
            // encDecResult
            // 
            this.encDecResult.Location = new System.Drawing.Point(7, 162);
            this.encDecResult.Multiline = true;
            this.encDecResult.Name = "encDecResult";
            this.encDecResult.ReadOnly = true;
            this.encDecResult.Size = new System.Drawing.Size(695, 227);
            this.encDecResult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 401);
            this.Controls.Add(this.encDecResult);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncryptBool);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnGenToken);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "API Security";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtInput;
        private Button btnGenToken;
        private Button btnEncrypt;
        private Button btnEncryptBool;
        private Button btnDecrypt;
        private TextBox encDecResult;
    }
}