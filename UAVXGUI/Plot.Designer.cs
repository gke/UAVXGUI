﻿namespace UAVXGUI
{


    partial class PlotForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.UAVXChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.UAVXChart)).BeginInit();
            this.SuspendLayout();
            // 
            // UAVXChart
            // 
            chartArea1.Name = "ChartArea1";
            this.UAVXChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.UAVXChart.Legends.Add(legend1);
            this.UAVXChart.Location = new System.Drawing.Point(2, 6);
            this.UAVXChart.Name = "UAVXChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Acc";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Angle";
            this.UAVXChart.Series.Add(series1);
            this.UAVXChart.Series.Add(series2);
            this.UAVXChart.Size = new System.Drawing.Size(989, 397);
            this.UAVXChart.TabIndex = 0;
            this.UAVXChart.Text = "chart1";
            // 
            // PlotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 443);
            this.Controls.Add(this.UAVXChart);
            this.Name = "PlotForm";
            this.Text = "Plot";
            ((System.ComponentModel.ISupportInitialize)(this.UAVXChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

      // private System.Windows.Forms.DataVisualization.Charting.Chart UAVXChart;

    }
}