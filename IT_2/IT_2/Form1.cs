using System;
using System.Linq;
using System.Windows.Forms;

namespace IT_2
{
    public partial class Form1 : Form
    {
        private double[] freqArray, signal, error, filter;
        private int[] info;
        private int size, leftrange, rightrange, noise, filterLength;
        private double edge;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            freqArray = new double[3];            
        }

        void Initialize()
        {
            freqArray[0] = Convert.ToDouble(Freq1.Text);
            freqArray[1] = Convert.ToDouble(Freq2.Text);
            freqArray[2] = Convert.ToDouble(Freq3.Text);
            size = Convert.ToInt32(SizeText.Text);
            leftrange = Convert.ToInt32(LeftRangeText.Text);
            rightrange = Convert.ToInt32(RightRangeText.Text);
            noise = Convert.ToInt32(NoiseText.Text);
            filterLength = Convert.ToInt32(FilterText.Text);
            edge = Convert.ToDouble(EdgeText.Text);
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            Initialize();
            Predict predict = new Predict(size, leftrange, rightrange, noise, filterLength, edge, freqArray);

            signal = predict.Draw();
            error = predict.DrawError();
            filter = predict.DrawFilter();
            info = predict.GetPredicted();

            GraphChart.Series[0].Points.Clear();
            EpsChart.Series[0].Points.Clear();
            EpsChart.Series[1].Points.Clear();
            EpsChart.Series[2].Points.Clear();
            EpsChart.Series[3].Points.Clear();

            for (int i = 1; i < size; i++)
            {
                GraphChart.Series[0].Points.AddXY(i, signal[i]);
                EpsChart.Series[0].Points.AddXY(i, error[i]);
                EpsChart.Series[1].Points.AddXY(i, filter[i]);
            }

            EpsChart.Series[2].Points.AddXY(info[0], 0);
            EpsChart.Series[2].Points.AddXY(info[0], error.Max());
            EpsChart.Series[3].Points.AddXY(info[1], 0);
            EpsChart.Series[3].Points.AddXY(info[1], error.Max());

            LeftPredictLabel.Text = info[0].ToString();
            RightPredictLabel.Text = info[1].ToString();
        }
    }
}
