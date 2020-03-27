namespace IT_2
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GraphChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.EpsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.Freq1 = new System.Windows.Forms.TextBox();
            this.Freq2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Freq3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SizeText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LeftRangeText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RightRangeText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LeftPredictLabel = new System.Windows.Forms.Label();
            this.RightPredictLabel = new System.Windows.Forms.Label();
            this.FilterText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NoiseText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DrawButton = new System.Windows.Forms.Button();
            this.EdgeText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GraphChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // GraphChart
            // 
            chartArea1.Name = "ChartArea1";
            this.GraphChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GraphChart.Legends.Add(legend1);
            this.GraphChart.Location = new System.Drawing.Point(12, 12);
            this.GraphChart.Name = "GraphChart";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.LegendText = "исходный";
            series1.Name = "Series1";
            this.GraphChart.Series.Add(series1);
            this.GraphChart.Size = new System.Drawing.Size(661, 300);
            this.GraphChart.TabIndex = 0;
            this.GraphChart.Text = "chart1";
            // 
            // EpsChart
            // 
            chartArea2.Name = "ChartArea1";
            this.EpsChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.EpsChart.Legends.Add(legend2);
            this.EpsChart.Location = new System.Drawing.Point(679, 12);
            this.EpsChart.Name = "EpsChart";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Gold;
            series2.Legend = "Legend1";
            series2.LegendText = "квадрат";
            series2.Name = "Series1";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Firebrick;
            series3.Legend = "Legend1";
            series3.LegendText = "фильтр";
            series3.Name = "Series2";
            series4.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Black;
            series4.Legend = "Legend1";
            series4.LegendText = "левая";
            series4.Name = "Series3";
            series5.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.Black;
            series5.Legend = "Legend1";
            series5.LegendText = "правая";
            series5.Name = "Series4";
            this.EpsChart.Series.Add(series2);
            this.EpsChart.Series.Add(series3);
            this.EpsChart.Series.Add(series4);
            this.EpsChart.Series.Add(series5);
            this.EpsChart.Size = new System.Drawing.Size(661, 300);
            this.EpsChart.TabIndex = 1;
            this.EpsChart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Частота 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Freq1
            // 
            this.Freq1.Location = new System.Drawing.Point(115, 343);
            this.Freq1.Name = "Freq1";
            this.Freq1.Size = new System.Drawing.Size(61, 22);
            this.Freq1.TabIndex = 3;
            this.Freq1.Text = "0.3";
            // 
            // Freq2
            // 
            this.Freq2.Location = new System.Drawing.Point(115, 371);
            this.Freq2.Name = "Freq2";
            this.Freq2.Size = new System.Drawing.Size(61, 22);
            this.Freq2.TabIndex = 5;
            this.Freq2.Text = "0.1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Частота 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Freq3
            // 
            this.Freq3.Location = new System.Drawing.Point(115, 399);
            this.Freq3.Name = "Freq3";
            this.Freq3.Size = new System.Drawing.Size(61, 22);
            this.Freq3.TabIndex = 7;
            this.Freq3.Text = "0.2";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Частота 2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SizeText
            // 
            this.SizeText.Location = new System.Drawing.Point(308, 343);
            this.SizeText.Name = "SizeText";
            this.SizeText.Size = new System.Drawing.Size(61, 22);
            this.SizeText.TabIndex = 9;
            this.SizeText.Text = "256";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(182, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Отсчеты";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeftRangeText
            // 
            this.LeftRangeText.Location = new System.Drawing.Point(308, 371);
            this.LeftRangeText.Name = "LeftRangeText";
            this.LeftRangeText.Size = new System.Drawing.Size(61, 22);
            this.LeftRangeText.TabIndex = 11;
            this.LeftRangeText.Text = "70";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(182, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Левая граница";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RightRangeText
            // 
            this.RightRangeText.Location = new System.Drawing.Point(308, 399);
            this.RightRangeText.Name = "RightRangeText";
            this.RightRangeText.Size = new System.Drawing.Size(61, 22);
            this.RightRangeText.TabIndex = 13;
            this.RightRangeText.Text = "140";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(182, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Правая граница";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(582, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Правая граница";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(582, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Левая граница";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeftPredictLabel
            // 
            this.LeftPredictLabel.Location = new System.Drawing.Point(708, 343);
            this.LeftPredictLabel.Name = "LeftPredictLabel";
            this.LeftPredictLabel.Size = new System.Drawing.Size(55, 22);
            this.LeftPredictLabel.TabIndex = 16;
            this.LeftPredictLabel.Text = "0";
            this.LeftPredictLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RightPredictLabel
            // 
            this.RightPredictLabel.Location = new System.Drawing.Point(708, 371);
            this.RightPredictLabel.Name = "RightPredictLabel";
            this.RightPredictLabel.Size = new System.Drawing.Size(55, 22);
            this.RightPredictLabel.TabIndex = 17;
            this.RightPredictLabel.Text = "0";
            this.RightPredictLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilterText
            // 
            this.FilterText.Location = new System.Drawing.Point(308, 427);
            this.FilterText.Name = "FilterText";
            this.FilterText.Size = new System.Drawing.Size(61, 22);
            this.FilterText.TabIndex = 19;
            this.FilterText.Text = "20";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(182, 427);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Фильтр";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NoiseText
            // 
            this.NoiseText.Location = new System.Drawing.Point(501, 343);
            this.NoiseText.Name = "NoiseText";
            this.NoiseText.Size = new System.Drawing.Size(61, 22);
            this.NoiseText.TabIndex = 21;
            this.NoiseText.Text = "0";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(375, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 22);
            this.label10.TabIndex = 20;
            this.label10.Text = "Шум";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DrawButton
            // 
            this.DrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DrawButton.Location = new System.Drawing.Point(925, 399);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(413, 95);
            this.DrawButton.TabIndex = 22;
            this.DrawButton.Text = "нарисовать график";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // EdgeText
            // 
            this.EdgeText.Location = new System.Drawing.Point(308, 455);
            this.EdgeText.Name = "EdgeText";
            this.EdgeText.Size = new System.Drawing.Size(61, 22);
            this.EdgeText.TabIndex = 24;
            this.EdgeText.Text = "0.00001";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(182, 455);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 22);
            this.label11.TabIndex = 23;
            this.label11.Text = "Порог";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 506);
            this.Controls.Add(this.EdgeText);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DrawButton);
            this.Controls.Add(this.NoiseText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.FilterText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RightPredictLabel);
            this.Controls.Add(this.LeftPredictLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RightRangeText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LeftRangeText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SizeText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Freq3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Freq2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Freq1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EpsChart);
            this.Controls.Add(this.GraphChart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GraphChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpsChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GraphChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart EpsChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Freq1;
        private System.Windows.Forms.TextBox Freq2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Freq3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SizeText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LeftRangeText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RightRangeText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LeftPredictLabel;
        private System.Windows.Forms.Label RightPredictLabel;
        private System.Windows.Forms.TextBox FilterText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NoiseText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.TextBox EdgeText;
        private System.Windows.Forms.Label label11;
    }
}

