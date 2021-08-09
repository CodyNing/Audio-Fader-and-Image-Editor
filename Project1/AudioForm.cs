using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class AudioForm : Form
    {
        private Wave _wave;

        private ImageForm _imageForm;

        public AudioForm()
        {
            _imageForm = new ImageForm(this);
            InitializeComponent();

            this.FormClosed += AudioForm_FormClosed;
        }

        private void AudioForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void drawWaveform(Wave wave)
        {
            var channel = FadeChkbox.Checked ? wave.LeftChannelFaded : wave.LeftChannel;

            chart1.Series.Clear();

            chart1.Series.Add("wave");
            chart1.Series["wave"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chart1.Series["wave"].ChartArea = "ChartArea1";

            foreach (var val in channel)
            {
                chart1.Series["wave"].Points.Add(val);
            }

            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Sample";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Voltage";
        }

        private void OpenWavBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "wav File (*.wav)|*.wav;"
            };
            if (open.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            _wave = Wave.OpenWav(open.FileName);

            SampleRate.Text = $"Samples per second: {_wave.SampleRate}";

            drawWaveform(_wave);
        }

        private void FadeChkbox_CheckedChanged(object sender, EventArgs e)
        {
            if(_wave != null)
            {
                drawWaveform(_wave);
            }
        }

        private void ImageFormBtn_Click(object sender, EventArgs e)
        {
            Hide();
            _imageForm.Show();
        }

    }
}
