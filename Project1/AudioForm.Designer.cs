namespace Project1
{
    partial class AudioForm
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
            this.OpenWavBtn = new System.Windows.Forms.Button();
            this.FadeChkbox = new System.Windows.Forms.CheckBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SampleRate = new System.Windows.Forms.TextBox();
            this.ImageFormBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenWavBtn
            // 
            this.OpenWavBtn.Location = new System.Drawing.Point(12, 12);
            this.OpenWavBtn.Name = "OpenWavBtn";
            this.OpenWavBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenWavBtn.TabIndex = 0;
            this.OpenWavBtn.Text = "Open Wav";
            this.OpenWavBtn.UseVisualStyleBackColor = true;
            this.OpenWavBtn.Click += new System.EventHandler(this.OpenWavBtn_Click);
            // 
            // FadeChkbox
            // 
            this.FadeChkbox.AutoSize = true;
            this.FadeChkbox.Location = new System.Drawing.Point(110, 17);
            this.FadeChkbox.Name = "FadeChkbox";
            this.FadeChkbox.Size = new System.Drawing.Size(84, 17);
            this.FadeChkbox.TabIndex = 1;
            this.FadeChkbox.Text = "Fade In/Out";
            this.FadeChkbox.UseVisualStyleBackColor = true;
            this.FadeChkbox.CheckedChanged += new System.EventHandler(this.FadeChkbox_CheckedChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chart1.Location = new System.Drawing.Point(0, 76);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(924, 366);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // SampleRate
            // 
            this.SampleRate.Enabled = false;
            this.SampleRate.Location = new System.Drawing.Point(12, 41);
            this.SampleRate.Name = "SampleRate";
            this.SampleRate.Size = new System.Drawing.Size(182, 20);
            this.SampleRate.TabIndex = 4;
            // 
            // ImageFormBtn
            // 
            this.ImageFormBtn.Location = new System.Drawing.Point(787, 12);
            this.ImageFormBtn.Name = "ImageFormBtn";
            this.ImageFormBtn.Size = new System.Drawing.Size(125, 39);
            this.ImageFormBtn.TabIndex = 5;
            this.ImageFormBtn.Text = "To Image Form";
            this.ImageFormBtn.UseVisualStyleBackColor = true;
            this.ImageFormBtn.Click += new System.EventHandler(this.ImageFormBtn_Click);
            // 
            // AudioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 442);
            this.Controls.Add(this.ImageFormBtn);
            this.Controls.Add(this.SampleRate);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.FadeChkbox);
            this.Controls.Add(this.OpenWavBtn);
            this.Name = "AudioForm";
            this.Text = "AudioForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenWavBtn;
        private System.Windows.Forms.CheckBox FadeChkbox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox SampleRate;
        private System.Windows.Forms.Button ImageFormBtn;
    }
}

