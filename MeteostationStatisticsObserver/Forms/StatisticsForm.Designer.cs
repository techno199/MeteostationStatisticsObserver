namespace MeteostationStatisticsObserver
{
    partial class StatisticsForm
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.dateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.labelInfo = new System.Windows.Forms.Label();
            this.numericUpDownSampleSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSampleSize)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(502, 491);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(520, 13);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(247, 21);
            this.comboBoxUsers.TabIndex = 1;
            this.comboBoxUsers.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsers_SelectedIndexChanged);
            // 
            // dateTimePickerStartTime
            // 
            this.dateTimePickerStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerStartTime.Location = new System.Drawing.Point(608, 40);
            this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            this.dateTimePickerStartTime.Size = new System.Drawing.Size(159, 20);
            this.dateTimePickerStartTime.TabIndex = 2;
            this.dateTimePickerStartTime.ValueChanged += new System.EventHandler(this.dateTimePickerStartTime_ValueChanged);
            // 
            // labelStartTime
            // 
            this.labelStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Location = new System.Drawing.Point(520, 40);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(51, 13);
            this.labelStartTime.TabIndex = 3;
            this.labelStartTime.Text = "Start time";
            // 
            // labelEndTime
            // 
            this.labelEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEndTime.AutoSize = true;
            this.labelEndTime.Location = new System.Drawing.Point(520, 73);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(48, 13);
            this.labelEndTime.TabIndex = 4;
            this.labelEndTime.Text = "End time";
            // 
            // dateTimePickerEndTime
            // 
            this.dateTimePickerEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerEndTime.Location = new System.Drawing.Point(608, 73);
            this.dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            this.dateTimePickerEndTime.Size = new System.Drawing.Size(159, 20);
            this.dateTimePickerEndTime.TabIndex = 5;
            this.dateTimePickerEndTime.ValueChanged += new System.EventHandler(this.dateTimePickerEndTime_ValueChanged);
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(521, 144);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(50, 13);
            this.labelInfo.TabIndex = 6;
            this.labelInfo.Text = "Info label";
            // 
            // numericUpDownSampleSize
            // 
            this.numericUpDownSampleSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownSampleSize.DecimalPlaces = 2;
            this.numericUpDownSampleSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownSampleSize.Location = new System.Drawing.Point(608, 104);
            this.numericUpDownSampleSize.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSampleSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownSampleSize.Name = "numericUpDownSampleSize";
            this.numericUpDownSampleSize.Size = new System.Drawing.Size(159, 20);
            this.numericUpDownSampleSize.TabIndex = 7;
            this.numericUpDownSampleSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownSampleSize.ValueChanged += new System.EventHandler(this.numericUpDownSampleSize_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sample size";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 515);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownSampleSize);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.dateTimePickerEndTime);
            this.Controls.Add(this.labelEndTime);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.dateTimePickerStartTime);
            this.Controls.Add(this.comboBoxUsers);
            this.Controls.Add(this.chart1);
            this.Name = "StatisticsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSampleSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTime;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label labelEndTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndTime;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.NumericUpDown numericUpDownSampleSize;
        private System.Windows.Forms.Label label1;
    }
}

