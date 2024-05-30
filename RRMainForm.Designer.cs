namespace PokaYokes_app
{
    partial class RRMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RRMainForm));
            this.RRDataGridGroupBox = new System.Windows.Forms.GroupBox();
            this.RRDataGrid = new System.Windows.Forms.DataGridView();
            this.rRNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rRNumberIngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rRDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rRDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rRProjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rRTechDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rRReferenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rRCreatedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rRCommentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rRMachineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rRCalibrationMonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rRCalibrationChkDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.t10RedRabbitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokaYokesDataSet = new PokaYokes_app.PokaYokesDataSet();
            this.t10RedRabbitsTableAdapter = new PokaYokes_app.PokaYokesDataSetTableAdapters.T10RedRabbitsTableAdapter();
            this.RRDataGroupBox = new System.Windows.Forms.GroupBox();
            this.RRDatePicker = new System.Windows.Forms.DateTimePicker();
            this.RRCommentsLabel = new System.Windows.Forms.Label();
            this.RRCommentsTextBox = new System.Windows.Forms.TextBox();
            this.RRMachineLabel = new System.Windows.Forms.Label();
            this.RRMachineTextBox = new System.Windows.Forms.TextBox();
            this.RRCreatedByLabel = new System.Windows.Forms.Label();
            this.RRCreatedByTextBox = new System.Windows.Forms.TextBox();
            this.RRDatePickerLabel = new System.Windows.Forms.Label();
            this.RRReferenceLabel = new System.Windows.Forms.Label();
            this.RRRefTextBox = new System.Windows.Forms.TextBox();
            this.RRTechLabel = new System.Windows.Forms.Label();
            this.RRTechTextBox = new System.Windows.Forms.TextBox();
            this.RRProjectLabel = new System.Windows.Forms.Label();
            this.RRProjectTextBox = new System.Windows.Forms.TextBox();
            this.RRDescriptionLabel = new System.Windows.Forms.Label();
            this.RRDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.RRNumberIngLabel = new System.Windows.Forms.Label();
            this.RRNumberIngTextBox = new System.Windows.Forms.TextBox();
            this.RRNumberLabel = new System.Windows.Forms.Label();
            this.RRNumberTextBox = new System.Windows.Forms.TextBox();
            this.RRModButton = new System.Windows.Forms.Button();
            this.RRToolsGroupBox = new System.Windows.Forms.GroupBox();
            this.RRAddButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.RRDataGridGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RRDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t10RedRabbitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokaYokesDataSet)).BeginInit();
            this.RRDataGroupBox.SuspendLayout();
            this.RRToolsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RRDataGridGroupBox
            // 
            this.RRDataGridGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RRDataGridGroupBox.Controls.Add(this.RRDataGrid);
            this.RRDataGridGroupBox.Location = new System.Drawing.Point(12, 345);
            this.RRDataGridGroupBox.Name = "RRDataGridGroupBox";
            this.RRDataGridGroupBox.Size = new System.Drawing.Size(1285, 306);
            this.RRDataGridGroupBox.TabIndex = 0;
            this.RRDataGridGroupBox.TabStop = false;
            this.RRDataGridGroupBox.Text = "Red Rabbits";
            // 
            // RRDataGrid
            // 
            this.RRDataGrid.AllowUserToAddRows = false;
            this.RRDataGrid.AllowUserToDeleteRows = false;
            this.RRDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RRDataGrid.AutoGenerateColumns = false;
            this.RRDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RRDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rRNumberDataGridViewTextBoxColumn,
            this.rRNumberIngDataGridViewTextBoxColumn,
            this.rRDescriptionDataGridViewTextBoxColumn,
            this.rRDateDataGridViewTextBoxColumn,
            this.rRProjectDataGridViewTextBoxColumn,
            this.rRTechDataGridViewTextBoxColumn,
            this.rRReferenceDataGridViewTextBoxColumn,
            this.rRCreatedByDataGridViewTextBoxColumn,
            this.rRCommentsDataGridViewTextBoxColumn,
            this.rRMachineDataGridViewTextBoxColumn,
            this.rRCalibrationMonthDataGridViewTextBoxColumn,
            this.rRCalibrationChkDataGridViewCheckBoxColumn});
            this.RRDataGrid.DataSource = this.t10RedRabbitsBindingSource;
            this.RRDataGrid.Location = new System.Drawing.Point(7, 20);
            this.RRDataGrid.Name = "RRDataGrid";
            this.RRDataGrid.ReadOnly = true;
            this.RRDataGrid.Size = new System.Drawing.Size(1253, 280);
            this.RRDataGrid.TabIndex = 0;
            this.RRDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RRDataGrid_CellDoubleClick);
            // 
            // rRNumberDataGridViewTextBoxColumn
            // 
            this.rRNumberDataGridViewTextBoxColumn.DataPropertyName = "RR_Number";
            this.rRNumberDataGridViewTextBoxColumn.HeaderText = "RR_Number";
            this.rRNumberDataGridViewTextBoxColumn.Name = "rRNumberDataGridViewTextBoxColumn";
            this.rRNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rRNumberIngDataGridViewTextBoxColumn
            // 
            this.rRNumberIngDataGridViewTextBoxColumn.DataPropertyName = "RR_Number_Ing";
            this.rRNumberIngDataGridViewTextBoxColumn.HeaderText = "RR_Number_Ing";
            this.rRNumberIngDataGridViewTextBoxColumn.Name = "rRNumberIngDataGridViewTextBoxColumn";
            this.rRNumberIngDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rRDescriptionDataGridViewTextBoxColumn
            // 
            this.rRDescriptionDataGridViewTextBoxColumn.DataPropertyName = "RR_Description";
            this.rRDescriptionDataGridViewTextBoxColumn.HeaderText = "RR_Description";
            this.rRDescriptionDataGridViewTextBoxColumn.Name = "rRDescriptionDataGridViewTextBoxColumn";
            this.rRDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rRDateDataGridViewTextBoxColumn
            // 
            this.rRDateDataGridViewTextBoxColumn.DataPropertyName = "RR_Date";
            this.rRDateDataGridViewTextBoxColumn.HeaderText = "RR_Date";
            this.rRDateDataGridViewTextBoxColumn.Name = "rRDateDataGridViewTextBoxColumn";
            this.rRDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rRProjectDataGridViewTextBoxColumn
            // 
            this.rRProjectDataGridViewTextBoxColumn.DataPropertyName = "RR_Project";
            this.rRProjectDataGridViewTextBoxColumn.HeaderText = "RR_Project";
            this.rRProjectDataGridViewTextBoxColumn.Name = "rRProjectDataGridViewTextBoxColumn";
            this.rRProjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rRTechDataGridViewTextBoxColumn
            // 
            this.rRTechDataGridViewTextBoxColumn.DataPropertyName = "RR_Tech";
            this.rRTechDataGridViewTextBoxColumn.HeaderText = "RR_Tech";
            this.rRTechDataGridViewTextBoxColumn.Name = "rRTechDataGridViewTextBoxColumn";
            this.rRTechDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rRReferenceDataGridViewTextBoxColumn
            // 
            this.rRReferenceDataGridViewTextBoxColumn.DataPropertyName = "RR_Reference";
            this.rRReferenceDataGridViewTextBoxColumn.HeaderText = "RR_Reference";
            this.rRReferenceDataGridViewTextBoxColumn.Name = "rRReferenceDataGridViewTextBoxColumn";
            this.rRReferenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rRCreatedByDataGridViewTextBoxColumn
            // 
            this.rRCreatedByDataGridViewTextBoxColumn.DataPropertyName = "RR_CreatedBy";
            this.rRCreatedByDataGridViewTextBoxColumn.HeaderText = "RR_CreatedBy";
            this.rRCreatedByDataGridViewTextBoxColumn.Name = "rRCreatedByDataGridViewTextBoxColumn";
            this.rRCreatedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rRCommentsDataGridViewTextBoxColumn
            // 
            this.rRCommentsDataGridViewTextBoxColumn.DataPropertyName = "RR_Comments";
            this.rRCommentsDataGridViewTextBoxColumn.HeaderText = "RR_Comments";
            this.rRCommentsDataGridViewTextBoxColumn.Name = "rRCommentsDataGridViewTextBoxColumn";
            this.rRCommentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rRMachineDataGridViewTextBoxColumn
            // 
            this.rRMachineDataGridViewTextBoxColumn.DataPropertyName = "RR_Machine";
            this.rRMachineDataGridViewTextBoxColumn.HeaderText = "RR_Machine";
            this.rRMachineDataGridViewTextBoxColumn.Name = "rRMachineDataGridViewTextBoxColumn";
            this.rRMachineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rRCalibrationMonthDataGridViewTextBoxColumn
            // 
            this.rRCalibrationMonthDataGridViewTextBoxColumn.DataPropertyName = "RR_Calibration_Month";
            this.rRCalibrationMonthDataGridViewTextBoxColumn.HeaderText = "RR_Calibration_Month";
            this.rRCalibrationMonthDataGridViewTextBoxColumn.Name = "rRCalibrationMonthDataGridViewTextBoxColumn";
            this.rRCalibrationMonthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rRCalibrationChkDataGridViewCheckBoxColumn
            // 
            this.rRCalibrationChkDataGridViewCheckBoxColumn.DataPropertyName = "RR_Calibration_Chk";
            this.rRCalibrationChkDataGridViewCheckBoxColumn.HeaderText = "RR_Calibration_Chk";
            this.rRCalibrationChkDataGridViewCheckBoxColumn.Name = "rRCalibrationChkDataGridViewCheckBoxColumn";
            this.rRCalibrationChkDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // t10RedRabbitsBindingSource
            // 
            this.t10RedRabbitsBindingSource.DataMember = "T10RedRabbits";
            this.t10RedRabbitsBindingSource.DataSource = this.pokaYokesDataSet;
            // 
            // pokaYokesDataSet
            // 
            this.pokaYokesDataSet.DataSetName = "PokaYokesDataSet";
            this.pokaYokesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t10RedRabbitsTableAdapter
            // 
            this.t10RedRabbitsTableAdapter.ClearBeforeFill = true;
            // 
            // RRDataGroupBox
            // 
            this.RRDataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RRDataGroupBox.Controls.Add(this.RRDatePicker);
            this.RRDataGroupBox.Controls.Add(this.RRCommentsLabel);
            this.RRDataGroupBox.Controls.Add(this.RRCommentsTextBox);
            this.RRDataGroupBox.Controls.Add(this.RRMachineLabel);
            this.RRDataGroupBox.Controls.Add(this.RRMachineTextBox);
            this.RRDataGroupBox.Controls.Add(this.RRCreatedByLabel);
            this.RRDataGroupBox.Controls.Add(this.RRCreatedByTextBox);
            this.RRDataGroupBox.Controls.Add(this.RRDatePickerLabel);
            this.RRDataGroupBox.Controls.Add(this.RRReferenceLabel);
            this.RRDataGroupBox.Controls.Add(this.RRRefTextBox);
            this.RRDataGroupBox.Controls.Add(this.RRTechLabel);
            this.RRDataGroupBox.Controls.Add(this.RRTechTextBox);
            this.RRDataGroupBox.Controls.Add(this.RRProjectLabel);
            this.RRDataGroupBox.Controls.Add(this.RRProjectTextBox);
            this.RRDataGroupBox.Controls.Add(this.RRDescriptionLabel);
            this.RRDataGroupBox.Controls.Add(this.RRDescriptionTextBox);
            this.RRDataGroupBox.Controls.Add(this.RRNumberIngLabel);
            this.RRDataGroupBox.Controls.Add(this.RRNumberIngTextBox);
            this.RRDataGroupBox.Controls.Add(this.RRNumberLabel);
            this.RRDataGroupBox.Controls.Add(this.RRNumberTextBox);
            this.RRDataGroupBox.Location = new System.Drawing.Point(12, 12);
            this.RRDataGroupBox.Name = "RRDataGroupBox";
            this.RRDataGroupBox.Size = new System.Drawing.Size(615, 327);
            this.RRDataGroupBox.TabIndex = 1;
            this.RRDataGroupBox.TabStop = false;
            this.RRDataGroupBox.Text = "Datos";
            // 
            // RRDatePicker
            // 
            this.RRDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RRDatePicker.Location = new System.Drawing.Point(429, 28);
            this.RRDatePicker.Name = "RRDatePicker";
            this.RRDatePicker.Size = new System.Drawing.Size(129, 20);
            this.RRDatePicker.TabIndex = 20;
            // 
            // RRCommentsLabel
            // 
            this.RRCommentsLabel.AutoSize = true;
            this.RRCommentsLabel.Location = new System.Drawing.Point(360, 130);
            this.RRCommentsLabel.Name = "RRCommentsLabel";
            this.RRCommentsLabel.Size = new System.Drawing.Size(65, 13);
            this.RRCommentsLabel.TabIndex = 19;
            this.RRCommentsLabel.Text = "Comentarios";
            // 
            // RRCommentsTextBox
            // 
            this.RRCommentsTextBox.Location = new System.Drawing.Point(363, 146);
            this.RRCommentsTextBox.Multiline = true;
            this.RRCommentsTextBox.Name = "RRCommentsTextBox";
            this.RRCommentsTextBox.Size = new System.Drawing.Size(195, 67);
            this.RRCommentsTextBox.TabIndex = 18;
            // 
            // RRMachineLabel
            // 
            this.RRMachineLabel.AutoSize = true;
            this.RRMachineLabel.Location = new System.Drawing.Point(360, 98);
            this.RRMachineLabel.Name = "RRMachineLabel";
            this.RRMachineLabel.Size = new System.Drawing.Size(48, 13);
            this.RRMachineLabel.TabIndex = 17;
            this.RRMachineLabel.Text = "Máquina";
            // 
            // RRMachineTextBox
            // 
            this.RRMachineTextBox.Location = new System.Drawing.Point(429, 95);
            this.RRMachineTextBox.Name = "RRMachineTextBox";
            this.RRMachineTextBox.Size = new System.Drawing.Size(129, 20);
            this.RRMachineTextBox.TabIndex = 16;
            // 
            // RRCreatedByLabel
            // 
            this.RRCreatedByLabel.AutoSize = true;
            this.RRCreatedByLabel.Location = new System.Drawing.Point(360, 63);
            this.RRCreatedByLabel.Name = "RRCreatedByLabel";
            this.RRCreatedByLabel.Size = new System.Drawing.Size(59, 13);
            this.RRCreatedByLabel.TabIndex = 15;
            this.RRCreatedByLabel.Text = "Creado por";
            // 
            // RRCreatedByTextBox
            // 
            this.RRCreatedByTextBox.Location = new System.Drawing.Point(429, 60);
            this.RRCreatedByTextBox.Name = "RRCreatedByTextBox";
            this.RRCreatedByTextBox.Size = new System.Drawing.Size(129, 20);
            this.RRCreatedByTextBox.TabIndex = 14;
            // 
            // RRDatePickerLabel
            // 
            this.RRDatePickerLabel.AutoSize = true;
            this.RRDatePickerLabel.Location = new System.Drawing.Point(360, 31);
            this.RRDatePickerLabel.Name = "RRDatePickerLabel";
            this.RRDatePickerLabel.Size = new System.Drawing.Size(57, 13);
            this.RRDatePickerLabel.TabIndex = 13;
            this.RRDatePickerLabel.Text = "Fecha alta";
            // 
            // RRReferenceLabel
            // 
            this.RRReferenceLabel.AutoSize = true;
            this.RRReferenceLabel.Location = new System.Drawing.Point(17, 196);
            this.RRReferenceLabel.Name = "RRReferenceLabel";
            this.RRReferenceLabel.Size = new System.Drawing.Size(59, 13);
            this.RRReferenceLabel.TabIndex = 11;
            this.RRReferenceLabel.Text = "Referencia";
            // 
            // RRRefTextBox
            // 
            this.RRRefTextBox.Location = new System.Drawing.Point(86, 193);
            this.RRRefTextBox.Name = "RRRefTextBox";
            this.RRRefTextBox.Size = new System.Drawing.Size(239, 20);
            this.RRRefTextBox.TabIndex = 10;
            // 
            // RRTechLabel
            // 
            this.RRTechLabel.AutoSize = true;
            this.RRTechLabel.Location = new System.Drawing.Point(17, 164);
            this.RRTechLabel.Name = "RRTechLabel";
            this.RRTechLabel.Size = new System.Drawing.Size(62, 13);
            this.RRTechLabel.TabIndex = 9;
            this.RRTechLabel.Text = "Tecnología";
            // 
            // RRTechTextBox
            // 
            this.RRTechTextBox.Location = new System.Drawing.Point(86, 161);
            this.RRTechTextBox.Name = "RRTechTextBox";
            this.RRTechTextBox.Size = new System.Drawing.Size(239, 20);
            this.RRTechTextBox.TabIndex = 8;
            // 
            // RRProjectLabel
            // 
            this.RRProjectLabel.AutoSize = true;
            this.RRProjectLabel.Location = new System.Drawing.Point(17, 130);
            this.RRProjectLabel.Name = "RRProjectLabel";
            this.RRProjectLabel.Size = new System.Drawing.Size(49, 13);
            this.RRProjectLabel.TabIndex = 7;
            this.RRProjectLabel.Text = "Proyecto";
            // 
            // RRProjectTextBox
            // 
            this.RRProjectTextBox.Location = new System.Drawing.Point(86, 127);
            this.RRProjectTextBox.Name = "RRProjectTextBox";
            this.RRProjectTextBox.Size = new System.Drawing.Size(239, 20);
            this.RRProjectTextBox.TabIndex = 6;
            // 
            // RRDescriptionLabel
            // 
            this.RRDescriptionLabel.AutoSize = true;
            this.RRDescriptionLabel.Location = new System.Drawing.Point(17, 98);
            this.RRDescriptionLabel.Name = "RRDescriptionLabel";
            this.RRDescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.RRDescriptionLabel.TabIndex = 5;
            this.RRDescriptionLabel.Text = "Descripción";
            // 
            // RRDescriptionTextBox
            // 
            this.RRDescriptionTextBox.Location = new System.Drawing.Point(86, 95);
            this.RRDescriptionTextBox.Name = "RRDescriptionTextBox";
            this.RRDescriptionTextBox.Size = new System.Drawing.Size(239, 20);
            this.RRDescriptionTextBox.TabIndex = 4;
            // 
            // RRNumberIngLabel
            // 
            this.RRNumberIngLabel.AutoSize = true;
            this.RRNumberIngLabel.Location = new System.Drawing.Point(17, 63);
            this.RRNumberIngLabel.Name = "RRNumberIngLabel";
            this.RRNumberIngLabel.Size = new System.Drawing.Size(62, 13);
            this.RRNumberIngLabel.TabIndex = 3;
            this.RRNumberIngLabel.Text = "Número Ing";
            // 
            // RRNumberIngTextBox
            // 
            this.RRNumberIngTextBox.Location = new System.Drawing.Point(86, 60);
            this.RRNumberIngTextBox.Name = "RRNumberIngTextBox";
            this.RRNumberIngTextBox.Size = new System.Drawing.Size(239, 20);
            this.RRNumberIngTextBox.TabIndex = 2;
            // 
            // RRNumberLabel
            // 
            this.RRNumberLabel.AutoSize = true;
            this.RRNumberLabel.Location = new System.Drawing.Point(17, 31);
            this.RRNumberLabel.Name = "RRNumberLabel";
            this.RRNumberLabel.Size = new System.Drawing.Size(63, 13);
            this.RRNumberLabel.TabIndex = 1;
            this.RRNumberLabel.Text = "Número RR";
            // 
            // RRNumberTextBox
            // 
            this.RRNumberTextBox.Location = new System.Drawing.Point(86, 28);
            this.RRNumberTextBox.Name = "RRNumberTextBox";
            this.RRNumberTextBox.Size = new System.Drawing.Size(239, 20);
            this.RRNumberTextBox.TabIndex = 0;
            // 
            // RRModButton
            // 
            this.RRModButton.Location = new System.Drawing.Point(18, 98);
            this.RRModButton.Name = "RRModButton";
            this.RRModButton.Size = new System.Drawing.Size(114, 52);
            this.RRModButton.TabIndex = 21;
            this.RRModButton.Text = "Modificar RedRabbit";
            this.RRModButton.UseVisualStyleBackColor = true;
            this.RRModButton.Click += new System.EventHandler(this.RRModButton_Click);
            // 
            // RRToolsGroupBox
            // 
            this.RRToolsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RRToolsGroupBox.Controls.Add(this.RRAddButton);
            this.RRToolsGroupBox.Controls.Add(this.closeButton);
            this.RRToolsGroupBox.Controls.Add(this.RRModButton);
            this.RRToolsGroupBox.Location = new System.Drawing.Point(633, 12);
            this.RRToolsGroupBox.Name = "RRToolsGroupBox";
            this.RRToolsGroupBox.Size = new System.Drawing.Size(664, 327);
            this.RRToolsGroupBox.TabIndex = 2;
            this.RRToolsGroupBox.TabStop = false;
            this.RRToolsGroupBox.Text = "Herramientas";
            // 
            // RRAddButton
            // 
            this.RRAddButton.Location = new System.Drawing.Point(18, 28);
            this.RRAddButton.Name = "RRAddButton";
            this.RRAddButton.Size = new System.Drawing.Size(114, 52);
            this.RRAddButton.TabIndex = 23;
            this.RRAddButton.Text = "Añadir RedRabbit";
            this.RRAddButton.UseVisualStyleBackColor = true;
            this.RRAddButton.Click += new System.EventHandler(this.RRAddButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(18, 255);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(114, 52);
            this.closeButton.TabIndex = 22;
            this.closeButton.Text = "Cerrar";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // RRMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 663);
            this.Controls.Add(this.RRToolsGroupBox);
            this.Controls.Add(this.RRDataGroupBox);
            this.Controls.Add(this.RRDataGridGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(50, 50);
            this.Name = "RRMainForm";
            this.Text = "RRMainForm";
            this.Load += new System.EventHandler(this.RRMainForm_Load);
            this.RRDataGridGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RRDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t10RedRabbitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokaYokesDataSet)).EndInit();
            this.RRDataGroupBox.ResumeLayout(false);
            this.RRDataGroupBox.PerformLayout();
            this.RRToolsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RRDataGridGroupBox;
        private System.Windows.Forms.DataGridView RRDataGrid;
        private PokaYokesDataSet pokaYokesDataSet;
        private System.Windows.Forms.BindingSource t10RedRabbitsBindingSource;
        private PokaYokesDataSetTableAdapters.T10RedRabbitsTableAdapter t10RedRabbitsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rRNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rRNumberIngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rRDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rRDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rRProjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rRTechDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rRReferenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rRCreatedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rRCommentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rRMachineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rRCalibrationMonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rRCalibrationChkDataGridViewCheckBoxColumn;
        private System.Windows.Forms.GroupBox RRDataGroupBox;
        private System.Windows.Forms.GroupBox RRToolsGroupBox;
        private System.Windows.Forms.Label RRNumberIngLabel;
        private System.Windows.Forms.TextBox RRNumberIngTextBox;
        private System.Windows.Forms.Label RRNumberLabel;
        private System.Windows.Forms.TextBox RRNumberTextBox;
        private System.Windows.Forms.Label RRReferenceLabel;
        private System.Windows.Forms.TextBox RRRefTextBox;
        private System.Windows.Forms.Label RRTechLabel;
        private System.Windows.Forms.TextBox RRTechTextBox;
        private System.Windows.Forms.Label RRProjectLabel;
        private System.Windows.Forms.TextBox RRProjectTextBox;
        private System.Windows.Forms.Label RRDescriptionLabel;
        private System.Windows.Forms.TextBox RRDescriptionTextBox;
        private System.Windows.Forms.DateTimePicker RRDatePicker;
        private System.Windows.Forms.Label RRCommentsLabel;
        private System.Windows.Forms.TextBox RRCommentsTextBox;
        private System.Windows.Forms.Label RRMachineLabel;
        private System.Windows.Forms.TextBox RRMachineTextBox;
        private System.Windows.Forms.Label RRCreatedByLabel;
        private System.Windows.Forms.TextBox RRCreatedByTextBox;
        private System.Windows.Forms.Label RRDatePickerLabel;
        private System.Windows.Forms.Button RRModButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button RRAddButton;
    }
}