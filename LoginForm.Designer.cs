﻿namespace PokaYokes_app
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginFormUserComboBox = new System.Windows.Forms.ComboBox();
            this.t0ActiveUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokaYokesDataSet = new PokaYokes_app.PokaYokesDataSet();
            this.t0UsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginFormUserLabel = new System.Windows.Forms.Label();
            this.loginFormPasswLabel = new System.Windows.Forms.Label();
            this.loginFormPasswdBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loginFormExitButton = new System.Windows.Forms.Button();
            this.loginFormOkButton = new System.Windows.Forms.Button();
            this.t0UsersTableAdapter = new PokaYokes_app.PokaYokesDataSetTableAdapters.T0UsersTableAdapter();
            this.t0ActiveUsersTableAdapter = new PokaYokes_app.PokaYokesDataSetTableAdapters.T0ActiveUsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.t0ActiveUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokaYokesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t0UsersBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginFormUserComboBox
            // 
            this.loginFormUserComboBox.DataSource = this.t0ActiveUsersBindingSource;
            this.loginFormUserComboBox.DisplayMember = "type_User";
            this.loginFormUserComboBox.FormattingEnabled = true;
            this.loginFormUserComboBox.Location = new System.Drawing.Point(162, 41);
            this.loginFormUserComboBox.Name = "loginFormUserComboBox";
            this.loginFormUserComboBox.Size = new System.Drawing.Size(121, 21);
            this.loginFormUserComboBox.TabIndex = 0;
            // 
            // t0ActiveUsersBindingSource
            // 
            this.t0ActiveUsersBindingSource.DataMember = "T0ActiveUsers";
            this.t0ActiveUsersBindingSource.DataSource = this.pokaYokesDataSet;
            // 
            // pokaYokesDataSet
            // 
            this.pokaYokesDataSet.DataSetName = "PokaYokesDataSet";
            this.pokaYokesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t0UsersBindingSource
            // 
            this.t0UsersBindingSource.DataMember = "T0Users";
            this.t0UsersBindingSource.DataSource = this.pokaYokesDataSet;
            // 
            // loginFormUserLabel
            // 
            this.loginFormUserLabel.AutoSize = true;
            this.loginFormUserLabel.Location = new System.Drawing.Point(38, 44);
            this.loginFormUserLabel.Name = "loginFormUserLabel";
            this.loginFormUserLabel.Size = new System.Drawing.Size(43, 13);
            this.loginFormUserLabel.TabIndex = 1;
            this.loginFormUserLabel.Text = "Usuario";
            // 
            // loginFormPasswLabel
            // 
            this.loginFormPasswLabel.AutoSize = true;
            this.loginFormPasswLabel.Location = new System.Drawing.Point(38, 86);
            this.loginFormPasswLabel.Name = "loginFormPasswLabel";
            this.loginFormPasswLabel.Size = new System.Drawing.Size(61, 13);
            this.loginFormPasswLabel.TabIndex = 3;
            this.loginFormPasswLabel.Text = "Contraseña";
            // 
            // loginFormPasswdBox
            // 
            this.loginFormPasswdBox.Location = new System.Drawing.Point(162, 78);
            this.loginFormPasswdBox.Name = "loginFormPasswdBox";
            this.loginFormPasswdBox.PasswordChar = '*';
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
            this.groupBox1.Size = new System.Drawing.Size(317, 222);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // loginFormExitButton
            // 
            this.loginFormExitButton.Location = new System.Drawing.Point(179, 128);
            this.loginFormExitButton.Name = "loginFormExitButton";
            this.loginFormExitButton.Size = new System.Drawing.Size(75, 23);
            this.loginFormExitButton.TabIndex = 6;
            this.loginFormExitButton.Text = "Salir";
            this.loginFormExitButton.UseVisualStyleBackColor = true;
            this.loginFormExitButton.Click += new System.EventHandler(this.loginFormExitButton_Click);
            // 
            // loginFormOkButton
            // 
            this.loginFormOkButton.Location = new System.Drawing.Point(58, 128);
            this.loginFormOkButton.Name = "loginFormOkButton";
            this.loginFormOkButton.Size = new System.Drawing.Size(75, 23);
            this.loginFormOkButton.TabIndex = 5;
            this.loginFormOkButton.Text = "Login";
            this.loginFormOkButton.UseVisualStyleBackColor = true;
            this.loginFormOkButton.Click += new System.EventHandler(this.LoginFormOkButton_Click);
            // 
            // t0UsersTableAdapter
            // 
            this.t0UsersTableAdapter.ClearBeforeFill = true;
            // 
            // t0ActiveUsersTableAdapter
            // 
            this.t0ActiveUsersTableAdapter.ClearBeforeFill = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 252);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t0ActiveUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokaYokesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t0UsersBindingSource)).EndInit();
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
        private PokaYokesDataSet pokaYokesDataSet;
        private System.Windows.Forms.BindingSource t0UsersBindingSource;
        private PokaYokesDataSetTableAdapters.T0UsersTableAdapter t0UsersTableAdapter;
        private System.Windows.Forms.BindingSource t0ActiveUsersBindingSource;
        private PokaYokesDataSetTableAdapters.T0ActiveUsersTableAdapter t0ActiveUsersTableAdapter;
    }
}