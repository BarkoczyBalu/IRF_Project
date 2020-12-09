namespace CovidCounter
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgwData = new System.Windows.Forms.DataGridView();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tBCountryCode = new System.Windows.Forms.TextBox();
            this.tBCountry = new System.Windows.Forms.TextBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelCountryCode = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTimePickerstart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerend = new System.Windows.Forms.DateTimePicker();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.chartCases = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCases)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwData
            // 
            this.dgwData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwData.Location = new System.Drawing.Point(3, 116);
            this.dgwData.Name = "dgwData";
            this.dgwData.RowHeadersWidth = 51;
            this.dgwData.RowTemplate.Height = 24;
            this.dgwData.Size = new System.Drawing.Size(526, 336);
            this.dgwData.TabIndex = 0;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(618, 61);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(74, 37);
            this.btnRandom.TabIndex = 1;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(543, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(149, 39);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tBCountryCode
            // 
            this.tBCountryCode.Location = new System.Drawing.Point(157, 58);
            this.tBCountryCode.Name = "tBCountryCode";
            this.tBCountryCode.Size = new System.Drawing.Size(73, 22);
            this.tBCountryCode.TabIndex = 3;
            // 
            // tBCountry
            // 
            this.tBCountry.Location = new System.Drawing.Point(78, 24);
            this.tBCountry.Name = "tBCountry";
            this.tBCountry.Size = new System.Drawing.Size(152, 22);
            this.tBCountry.TabIndex = 4;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(12, 27);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(61, 17);
            this.labelCountry.TabIndex = 5;
            this.labelCountry.Text = "Country:";
            // 
            // labelCountryCode
            // 
            this.labelCountryCode.AutoSize = true;
            this.labelCountryCode.Location = new System.Drawing.Point(53, 61);
            this.labelCountryCode.Name = "labelCountryCode";
            this.labelCountryCode.Size = new System.Drawing.Size(98, 17);
            this.labelCountryCode.TabIndex = 6;
            this.labelCountryCode.Text = "Country Code:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(698, 36);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 39);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Results";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateTimePickerstart
            // 
            this.dateTimePickerstart.Location = new System.Drawing.Point(298, 24);
            this.dateTimePickerstart.Name = "dateTimePickerstart";
            this.dateTimePickerstart.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerstart.TabIndex = 8;
            this.dateTimePickerstart.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePickerend
            // 
            this.dateTimePickerend.Location = new System.Drawing.Point(298, 58);
            this.dateTimePickerend.Name = "dateTimePickerend";
            this.dateTimePickerend.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerend.TabIndex = 9;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(248, 27);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(44, 17);
            this.labelFrom.TabIndex = 10;
            this.labelFrom.Text = "From:";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(261, 58);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(29, 17);
            this.labelTo.TabIndex = 11;
            this.labelTo.Text = "To:";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnReset.Location = new System.Drawing.Point(543, 61);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(69, 37);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // chartCases
            // 
            this.chartCases.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartCases.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartCases.Legends.Add(legend2);
            this.chartCases.Location = new System.Drawing.Point(535, 116);
            this.chartCases.Name = "chartCases";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartCases.Series.Add(series2);
            this.chartCases.Size = new System.Drawing.Size(515, 336);
            this.chartCases.TabIndex = 13;
            this.chartCases.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 457);
            this.Controls.Add(this.chartCases);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.dateTimePickerend);
            this.Controls.Add(this.dateTimePickerstart);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelCountryCode);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.tBCountry);
            this.Controls.Add(this.tBCountryCode);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.dgwData);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwData;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tBCountryCode;
        private System.Windows.Forms.TextBox tBCountry;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelCountryCode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dateTimePickerstart;
        private System.Windows.Forms.DateTimePicker dateTimePickerend;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCases;
    }
}

