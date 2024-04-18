namespace PokaYokes_app
{
    partial class MainForm
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
            this.MainFormRRButton = new System.Windows.Forms.Button();
            this.RRFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainFormRRButton
            // 
            this.MainFormRRButton.Location = new System.Drawing.Point(110, 83);
            this.MainFormRRButton.Name = "MainFormRRButton";
            this.MainFormRRButton.Size = new System.Drawing.Size(75, 23);
            this.MainFormRRButton.TabIndex = 0;
            this.MainFormRRButton.Text = "RR";
            this.MainFormRRButton.UseVisualStyleBackColor = true;
            // 
            // RRFormButton
            // 
            this.RRFormButton.Location = new System.Drawing.Point(172, 149);
            this.RRFormButton.Name = "RRFormButton";
            this.RRFormButton.Size = new System.Drawing.Size(75, 23);
            this.RRFormButton.TabIndex = 0;
            this.RRFormButton.Text = "RR";
            this.RRFormButton.UseVisualStyleBackColor = true;
            this.RRFormButton.Click += new System.EventHandler(this.RRFormButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 563);
            this.Controls.Add(this.RRFormButton);
            this.Name = "MainForm";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MainFormRRButton;
        private System.Windows.Forms.Button RRFormButton;
    }
}

