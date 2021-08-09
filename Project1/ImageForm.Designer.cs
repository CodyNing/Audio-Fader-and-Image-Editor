namespace Project1
{
    partial class ImageForm
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
            this.AudioFormBtn = new System.Windows.Forms.Button();
            this.OpenBmpBtn = new System.Windows.Forms.Button();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.PrevBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AudioFormBtn
            // 
            this.AudioFormBtn.Location = new System.Drawing.Point(647, 12);
            this.AudioFormBtn.Name = "AudioFormBtn";
            this.AudioFormBtn.Size = new System.Drawing.Size(131, 43);
            this.AudioFormBtn.TabIndex = 0;
            this.AudioFormBtn.Text = "To AudioForm";
            this.AudioFormBtn.UseVisualStyleBackColor = true;
            this.AudioFormBtn.Click += new System.EventHandler(this.AudioFormBtn_Click);
            // 
            // OpenBmpBtn
            // 
            this.OpenBmpBtn.Location = new System.Drawing.Point(12, 12);
            this.OpenBmpBtn.Name = "OpenBmpBtn";
            this.OpenBmpBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenBmpBtn.TabIndex = 1;
            this.OpenBmpBtn.Text = "Open Bmp";
            this.OpenBmpBtn.UseVisualStyleBackColor = true;
            this.OpenBmpBtn.Click += new System.EventHandler(this.OpenBmpBtn_Click);
            // 
            // ImageBox
            // 
            this.ImageBox.Location = new System.Drawing.Point(80, 93);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(632, 486);
            this.ImageBox.TabIndex = 2;
            this.ImageBox.TabStop = false;
            // 
            // PrevBtn
            // 
            this.PrevBtn.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.PrevBtn.Location = new System.Drawing.Point(12, 295);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(62, 64);
            this.PrevBtn.TabIndex = 3;
            this.PrevBtn.Text = "<";
            this.PrevBtn.UseVisualStyleBackColor = true;
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBtn.Location = new System.Drawing.Point(720, 295);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(62, 64);
            this.NextBtn.TabIndex = 4;
            this.NextBtn.Text = ">";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(294, 48);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(214, 42);
            this.Title.TabIndex = 5;
            this.Title.Text = "Image Type";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(12, 48);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Save Bmp";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 642);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.PrevBtn);
            this.Controls.Add(this.ImageBox);
            this.Controls.Add(this.OpenBmpBtn);
            this.Controls.Add(this.AudioFormBtn);
            this.Name = "ImageForm";
            this.Text = "ImageForm";
            this.Load += new System.EventHandler(this.ImageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AudioFormBtn;
        private System.Windows.Forms.Button OpenBmpBtn;
        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Button PrevBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button SaveBtn;
    }
}