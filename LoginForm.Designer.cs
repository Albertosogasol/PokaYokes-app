namespace PokaYokes_app
{
    partial class LoginForm
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
            this.loginFormUserComboBox = new System.Windows.Forms.ComboBox();
            this.loginFormUserLabel = new System.Windows.Forms.Label();
            this.loginFormPasswLabel = new System.Windows.Forms.Label();
            this.loginFormPasswdBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loginFormOkButton = new System.Windows.Forms.Button();
            this.loginFormExitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginFormUserComboBox
            // 
            this.loginFormUserComboBox.FormattingEnabled = true;
            this.loginFormUserComboBox.Location = new System.Drawing.Point(130, 22);
            this.loginFormUserComboBox.Name = "loginFormUserComboBox";
            this.loginFormUserComboBox.Size = new System.Drawing.Size(121, 21);
            this.loginFormUserComboBox.TabIndex = 0;
            // 
            // loginFormUserLabel
            // 
            this.loginFormUserLabel.AutoSize = true;
            this.loginFormUserLabel.Location = new System.Drawing.Point(6, 25);
            this.loginFormUserLabel.Name = "loginFormUserLabel";
            this.loginFormUserLabel.Size = new System.Drawing.Size(43, 13);
            this.loginFormUserLabel.TabIndex = 1;
            this.loginFormUserLabel.Text = "Usuario";
            // 
            // loginFormPasswLabel
            // 
            this.loginFormPasswLabel.AutoSize = true;
            this.loginFormPasswLabel.Location = new System.Drawing.Point(6, 67);
            this.loginFormPasswLabel.Name = "loginFormPasswLabel";
            this.loginFormPasswLabel.Size = new System.Drawing.Size(61, 13);
            this.loginFormPasswLabel.TabIndex = 3;
            this.loginFormPasswLabel.Text = "Contraseña";
            // 
            // loginFormPasswdBox
            // 
            this.loginFormPasswdBox.Location = new System.Drawing.Point(130, 59);
            this.loginFormPasswdBox.Name = "loginFormPasswdBox";
            this.loginFormPasswdBox.Size = new System.Drawing.Size(121, 20);
            this.loginFormPasswdBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginFormExitButton);
            this.groupBox1.Controls.Add(this.loginFormOkButton);
            this.groupBox1.Controls.Add(this.loginFormUserLabel);
            this.groupBox1.Controls.Add(this.loginFormPasswdBox);
            this.groupBox1.Controls.Add(this.loginFormUserComboBox);
            this.groupBox1.Controls.Add(this.loginFormPasswLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 222);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // loginFormOkButton
            // 
            this.loginFormOkButton.Location = new System.Drawing.Point(9, 106);
            this.loginFormOkButton.Name = "loginFormOkButton";
            this.loginFormOkButton.Size = new System.Drawing.Size(75, 23);
            this.loginFormOkButton.TabIndex = 5;
            this.loginFormOkButton.Text = "Loguear";
            this.loginFormOkButton.UseVisualStyleBackColor = true;
            // 
            // loginFormExitButton
            // 
            this.loginFormExitButton.Location = new System.Drawing.Point(130, 106);
            this.loginFormExitButton.Name = "loginFormExitButton";
            this.loginFormExitButton.Size = new System.Drawing.Size(75, 23);
            this.loginFormExitButton.TabIndex = 6;
            this.loginFormExitButton.Text = "Salir";
            this.loginFormExitButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 453);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox loginFormUserComboBox;
        private System.Windows.Forms.Label loginFormUserLabel;
        private System.Windows.Forms.Label loginFormPasswLabel;
        private System.Windows.Forms.TextBox loginFormPasswdBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button loginFormExitButton;
        private System.Windows.Forms.Button loginFormOkButton;
    }
}