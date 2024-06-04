namespace PokaYokes_app
{
    partial class RRDelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RRDelForm));
            this.cancelButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.DataGroupBox = new System.Windows.Forms.GroupBox();
            this.RRIdTextBox = new System.Windows.Forms.TextBox();
            this.RRIdLabel = new System.Windows.Forms.Label();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.CommentsLabel = new System.Windows.Forms.Label();
            this.CommentsTextBox = new System.Windows.Forms.TextBox();
            this.MachineLabel = new System.Windows.Forms.Label();
            this.MachineTextBox = new System.Windows.Forms.TextBox();
            this.CreatedByLabel = new System.Windows.Forms.Label();
            this.CreatedByTextBox = new System.Windows.Forms.TextBox();
            this.DatePickerLabel = new System.Windows.Forms.Label();
            this.ReferenceLabel = new System.Windows.Forms.Label();
            this.RefTextBox = new System.Windows.Forms.TextBox();
            this.TechLabel = new System.Windows.Forms.Label();
            this.TechTextBox = new System.Windows.Forms.TextBox();
            this.ProjectLabel = new System.Windows.Forms.Label();
            this.ProjectTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.NumberIngLabel = new System.Windows.Forms.Label();
            this.NumberIngTextBox = new System.Windows.Forms.TextBox();
            this.NumTextBox = new System.Windows.Forms.TextBox();
            this.NumLabel = new System.Windows.Forms.Label();
            this.DataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(331, 316);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(115, 70);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // delButton
            // 
            this.delButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delButton.Location = new System.Drawing.Point(115, 316);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(115, 70);
            this.delButton.TabIndex = 6;
            this.delButton.Text = "Eliminar";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // DataGroupBox
            // 
            this.DataGroupBox.Controls.Add(this.RRIdTextBox);
            this.DataGroupBox.Controls.Add(this.RRIdLabel);
            this.DataGroupBox.Controls.Add(this.MonthComboBox);
            this.DataGroupBox.Controls.Add(this.MonthLabel);
            this.DataGroupBox.Controls.Add(this.DatePicker);
            this.DataGroupBox.Controls.Add(this.CommentsLabel);
            this.DataGroupBox.Controls.Add(this.CommentsTextBox);
            this.DataGroupBox.Controls.Add(this.MachineLabel);
            this.DataGroupBox.Controls.Add(this.MachineTextBox);
            this.DataGroupBox.Controls.Add(this.CreatedByLabel);
            this.DataGroupBox.Controls.Add(this.CreatedByTextBox);
            this.DataGroupBox.Controls.Add(this.DatePickerLabel);
            this.DataGroupBox.Controls.Add(this.ReferenceLabel);
            this.DataGroupBox.Controls.Add(this.RefTextBox);
            this.DataGroupBox.Controls.Add(this.TechLabel);
            this.DataGroupBox.Controls.Add(this.TechTextBox);
            this.DataGroupBox.Controls.Add(this.ProjectLabel);
            this.DataGroupBox.Controls.Add(this.ProjectTextBox);
            this.DataGroupBox.Controls.Add(this.DescriptionLabel);
            this.DataGroupBox.Controls.Add(this.DescriptionTextBox);
            this.DataGroupBox.Controls.Add(this.NumberIngLabel);
            this.DataGroupBox.Controls.Add(this.NumberIngTextBox);
            this.DataGroupBox.Controls.Add(this.NumTextBox);
            this.DataGroupBox.Controls.Add(this.NumLabel);
            this.DataGroupBox.Location = new System.Drawing.Point(12, 12);
            this.DataGroupBox.Name = "DataGroupBox";
            this.DataGroupBox.Size = new System.Drawing.Size(579, 298);
            this.DataGroupBox.TabIndex = 5;
            this.DataGroupBox.TabStop = false;
            this.DataGroupBox.Text = "Datos";
            // 
            // RRIdTextBox
            // 
            this.RRIdTextBox.Location = new System.Drawing.Point(502, 23);
            this.RRIdTextBox.Name = "RRIdTextBox";
            this.RRIdTextBox.ReadOnly = true;
            this.RRIdTextBox.Size = new System.Drawing.Size(33, 20);
            this.RRIdTextBox.TabIndex = 47;
            // 
            // RRIdLabel
            // 
            this.RRIdLabel.AutoSize = true;
            this.RRIdLabel.Location = new System.Drawing.Point(479, 26);
            this.RRIdLabel.Name = "RRIdLabel";
            this.RRIdLabel.Size = new System.Drawing.Size(18, 13);
            this.RRIdLabel.TabIndex = 46;
            this.RRIdLabel.Text = "ID";
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYOR",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.MonthComboBox.Location = new System.Drawing.Point(406, 162);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(129, 21);
            this.MonthComboBox.TabIndex = 43;
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Location = new System.Drawing.Point(337, 162);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(59, 13);
            this.MonthLabel.TabIndex = 42;
            this.MonthLabel.Text = "Calibración";
            // 
            // DatePicker
            // 
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(406, 58);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(129, 20);
            this.DatePicker.TabIndex = 40;
            // 
            // CommentsLabel
            // 
            this.CommentsLabel.AutoSize = true;
            this.CommentsLabel.Location = new System.Drawing.Point(6, 224);
            this.CommentsLabel.Name = "CommentsLabel";
            this.CommentsLabel.Size = new System.Drawing.Size(65, 13);
            this.CommentsLabel.TabIndex = 39;
            this.CommentsLabel.Text = "Comentarios";
            // 
            // CommentsTextBox
            // 
            this.CommentsTextBox.Location = new System.Drawing.Point(75, 221);
            this.CommentsTextBox.Multiline = true;
            this.CommentsTextBox.Name = "CommentsTextBox";
            this.CommentsTextBox.Size = new System.Drawing.Size(460, 54);
            this.CommentsTextBox.TabIndex = 38;
            // 
            // MachineLabel
            // 
            this.MachineLabel.AutoSize = true;
            this.MachineLabel.Location = new System.Drawing.Point(337, 128);
            this.MachineLabel.Name = "MachineLabel";
            this.MachineLabel.Size = new System.Drawing.Size(48, 13);
            this.MachineLabel.TabIndex = 37;
            this.MachineLabel.Text = "Máquina";
            // 
            // MachineTextBox
            // 
            this.MachineTextBox.Location = new System.Drawing.Point(406, 125);
            this.MachineTextBox.Name = "MachineTextBox";
            this.MachineTextBox.Size = new System.Drawing.Size(129, 20);
            this.MachineTextBox.TabIndex = 36;
            // 
            // CreatedByLabel
            // 
            this.CreatedByLabel.AutoSize = true;
            this.CreatedByLabel.Location = new System.Drawing.Point(337, 93);
            this.CreatedByLabel.Name = "CreatedByLabel";
            this.CreatedByLabel.Size = new System.Drawing.Size(59, 13);
            this.CreatedByLabel.TabIndex = 35;
            this.CreatedByLabel.Text = "Creado por";
            // 
            // CreatedByTextBox
            // 
            this.CreatedByTextBox.Location = new System.Drawing.Point(406, 90);
            this.CreatedByTextBox.Name = "CreatedByTextBox";
            this.CreatedByTextBox.Size = new System.Drawing.Size(129, 20);
            this.CreatedByTextBox.TabIndex = 34;
            // 
            // DatePickerLabel
            // 
            this.DatePickerLabel.AutoSize = true;
            this.DatePickerLabel.Location = new System.Drawing.Point(337, 61);
            this.DatePickerLabel.Name = "DatePickerLabel";
            this.DatePickerLabel.Size = new System.Drawing.Size(57, 13);
            this.DatePickerLabel.TabIndex = 33;
            this.DatePickerLabel.Text = "Fecha alta";
            // 
            // ReferenceLabel
            // 
            this.ReferenceLabel.AutoSize = true;
            this.ReferenceLabel.Location = new System.Drawing.Point(6, 194);
            this.ReferenceLabel.Name = "ReferenceLabel";
            this.ReferenceLabel.Size = new System.Drawing.Size(59, 13);
            this.ReferenceLabel.TabIndex = 32;
            this.ReferenceLabel.Text = "Referencia";
            // 
            // RefTextBox
            // 
            this.RefTextBox.Location = new System.Drawing.Point(75, 191);
            this.RefTextBox.Name = "RefTextBox";
            this.RefTextBox.Size = new System.Drawing.Size(239, 20);
            this.RefTextBox.TabIndex = 31;
            // 
            // TechLabel
            // 
            this.TechLabel.AutoSize = true;
            this.TechLabel.Location = new System.Drawing.Point(6, 162);
            this.TechLabel.Name = "TechLabel";
            this.TechLabel.Size = new System.Drawing.Size(62, 13);
            this.TechLabel.TabIndex = 30;
            this.TechLabel.Text = "Tecnología";
            // 
            // TechTextBox
            // 
            this.TechTextBox.Location = new System.Drawing.Point(75, 159);
            this.TechTextBox.Name = "TechTextBox";
            this.TechTextBox.Size = new System.Drawing.Size(239, 20);
            this.TechTextBox.TabIndex = 29;
            // 
            // ProjectLabel
            // 
            this.ProjectLabel.AutoSize = true;
            this.ProjectLabel.Location = new System.Drawing.Point(6, 128);
            this.ProjectLabel.Name = "ProjectLabel";
            this.ProjectLabel.Size = new System.Drawing.Size(49, 13);
            this.ProjectLabel.TabIndex = 28;
            this.ProjectLabel.Text = "Proyecto";
            // 
            // ProjectTextBox
            // 
            this.ProjectTextBox.Location = new System.Drawing.Point(75, 125);
            this.ProjectTextBox.Name = "ProjectTextBox";
            this.ProjectTextBox.Size = new System.Drawing.Size(239, 20);
            this.ProjectTextBox.TabIndex = 27;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(6, 96);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLabel.TabIndex = 26;
            this.DescriptionLabel.Text = "Descripción";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(75, 93);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(239, 20);
            this.DescriptionTextBox.TabIndex = 25;
            // 
            // NumberIngLabel
            // 
            this.NumberIngLabel.AutoSize = true;
            this.NumberIngLabel.Location = new System.Drawing.Point(6, 61);
            this.NumberIngLabel.Name = "NumberIngLabel";
            this.NumberIngLabel.Size = new System.Drawing.Size(62, 13);
            this.NumberIngLabel.TabIndex = 24;
            this.NumberIngLabel.Text = "Número Ing";
            // 
            // NumberIngTextBox
            // 
            this.NumberIngTextBox.Location = new System.Drawing.Point(75, 58);
            this.NumberIngTextBox.Name = "NumberIngTextBox";
            this.NumberIngTextBox.Size = new System.Drawing.Size(239, 20);
            this.NumberIngTextBox.TabIndex = 23;
            // 
            // NumTextBox
            // 
            this.NumTextBox.Location = new System.Drawing.Point(30, 20);
            this.NumTextBox.Name = "NumTextBox";
            this.NumTextBox.Size = new System.Drawing.Size(33, 20);
            this.NumTextBox.TabIndex = 1;
            // 
            // NumLabel
            // 
            this.NumLabel.AutoSize = true;
            this.NumLabel.Location = new System.Drawing.Point(7, 23);
            this.NumLabel.Name = "NumLabel";
            this.NumLabel.Size = new System.Drawing.Size(26, 13);
            this.NumLabel.TabIndex = 0;
            this.NumLabel.Text = "RR-";
            // 
            // RRDelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 441);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.DataGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(634, 480);
            this.MinimumSize = new System.Drawing.Size(634, 480);
            this.Name = "RRDelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar RedRabbit";
            this.DataGroupBox.ResumeLayout(false);
            this.DataGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.GroupBox DataGroupBox;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label CommentsLabel;
        private System.Windows.Forms.TextBox CommentsTextBox;
        private System.Windows.Forms.Label MachineLabel;
        private System.Windows.Forms.TextBox MachineTextBox;
        private System.Windows.Forms.Label CreatedByLabel;
        private System.Windows.Forms.TextBox CreatedByTextBox;
        private System.Windows.Forms.Label DatePickerLabel;
        private System.Windows.Forms.Label ReferenceLabel;
        private System.Windows.Forms.TextBox RefTextBox;
        private System.Windows.Forms.Label TechLabel;
        private System.Windows.Forms.TextBox TechTextBox;
        private System.Windows.Forms.Label ProjectLabel;
        private System.Windows.Forms.TextBox ProjectTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label NumberIngLabel;
        private System.Windows.Forms.TextBox NumberIngTextBox;
        private System.Windows.Forms.TextBox NumTextBox;
        private System.Windows.Forms.Label NumLabel;
        private System.Windows.Forms.TextBox RRIdTextBox;
        private System.Windows.Forms.Label RRIdLabel;
    }
}