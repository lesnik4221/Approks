namespace Approximation
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.data_in = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clear_button = new System.Windows.Forms.Button();
            this.approximate_button = new System.Windows.Forms.Button();
            this.plot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.data_in)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plot)).BeginInit();
            this.SuspendLayout();
            // 
            // data_in
            // 
            this.data_in.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_in.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_in.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data_in.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_in.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.data_in.Location = new System.Drawing.Point(637, 12);
            this.data_in.Name = "data_in";
            this.data_in.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data_in.Size = new System.Drawing.Size(235, 452);
            this.data_in.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Y";
            this.Column2.Name = "Column2";
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(637, 470);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(100, 45);
            this.clear_button.TabIndex = 0;
            this.clear_button.Text = "Очистить точки";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // approximate_button
            // 
            this.approximate_button.Location = new System.Drawing.Point(772, 470);
            this.approximate_button.Name = "approximate_button";
            this.approximate_button.Size = new System.Drawing.Size(100, 45);
            this.approximate_button.TabIndex = 1;
            this.approximate_button.Text = "Построить график";
            this.approximate_button.UseVisualStyleBackColor = true;
            this.approximate_button.Click += new System.EventHandler(this.approximate_button_Click);
            // 
            // plot
            // 
            this.plot.BackColor = System.Drawing.Color.Transparent;
            this.plot.BorderlineColor = System.Drawing.Color.Maroon;
            chartArea1.Name = "ChartArea1";
            this.plot.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.plot.Legends.Add(legend1);
            this.plot.Location = new System.Drawing.Point(12, 12);
            this.plot.Name = "plot";
            this.plot.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Dots";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "y = ax + b";
            this.plot.Series.Add(series1);
            this.plot.Series.Add(series2);
            this.plot.Size = new System.Drawing.Size(619, 536);
            this.plot.TabIndex = 2;
            this.plot.Text = "chart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.plot);
            this.Controls.Add(this.approximate_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.data_in);
            this.Name = "MainForm";
            this.Text = "Линейная аппроксимация";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_in)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_in;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button approximate_button;
        private System.Windows.Forms.DataVisualization.Charting.Chart plot;
    }
}

