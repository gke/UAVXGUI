using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;



namespace UAVXGUI
{

    public partial class PlotForm : Form
    {

        public System.Windows.Forms.DataVisualization.Charting.Chart UAVXChart;

        public void FillChart()
        {

            // clear the chart    
            UAVXChart.Series.Clear();

            // fill the chart
            var series1 = UAVXChart.Series.Add("Acc");
           series1.ChartType = SeriesChartType.Line;
            series1.XValueType = ChartValueType.Double;

           var series2 = UAVXChart.Series.Add("Angle");
           series2.ChartType = SeriesChartType.Line;
            series2.XValueType = ChartValueType.Double; //.Int32;


            for (int i = 0; i < FormMain.valuesArray1.Length; i++)
            { 
               series1.Points.AddXY(i, FormMain.valuesArray1[i]);
               series2.Points.AddXY(i, FormMain.valuesArray2[i]);
            }

            var chartArea = UAVXChart.ChartAreas[series1.ChartArea];

            // set view range to [0,max]
            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Maximum = FormMain.valuesArray1.Length;

            // enable autoscroll
            chartArea.CursorX.AutoScroll = true;

            // let's zoom to [0,blockSize] (e.g. [0,100])
            chartArea.AxisX.ScaleView.Zoomable = true;
            chartArea.AxisX.ScaleView.SizeType = DateTimeIntervalType.Number;
            int position = 0;
            int size = FormMain.blockSize;
            chartArea.AxisX.ScaleView.Zoom(position, size);

            // disable zoom-reset button (only scrollbar's arrows are available)
             chartArea.AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;

            // set scrollbar small change to blockSize (e.g. 100)
             chartArea.AxisX.ScaleView.SmallScrollSize = FormMain.blockSize;
        }

        public PlotForm()
        {
            InitializeComponent();

            FillChart();
        }
     
    }

}
