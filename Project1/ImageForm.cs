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
    public partial class ImageForm : Form
    {
        enum ImageType
        {
            Original = 0,
            Grayscale = 1,
            OrderedDithering = 2,
            AutoLevel = 3
        }

        private AudioForm _audioForm;

        private Bitmap _image;

        private Bitmap _oImg;

        private Bitmap _gImg;

        private Bitmap _dImg;

        private Bitmap _aImg;


        private ImageType ImgType
        {
            get => _imgType;
            set
            {
                switch (value)
                {
                    case ImageType.Original:
                        _image = _oImg;
                        break;
                    case ImageType.Grayscale:
                        _image = _gImg;
                        break;
                    case ImageType.OrderedDithering:
                        _image = _dImg;
                        break;
                    case ImageType.AutoLevel:
                        _image = _aImg;
                        break;
                }
                _imgType = value;
                Title.Text = value.ToString();

                ImageBox.Image = _image;
            }
        }

        private ImageType _imgType;

        public ImageForm(AudioForm audioForm)
        {
            _audioForm = audioForm;

            InitializeComponent();

            this.FormClosed += ImageForm_FormClosed;
        }

        private void ImageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void AudioFormBtn_Click(object sender, EventArgs e)
        {
            Hide();
            _audioForm.Show();
        }

        private void ImageForm_Load(object sender, EventArgs e)
        {
            _imgType = ImageType.Original;
        }

        private void OpenBmpBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "bmp File (*.bmp)|*.bmp;"
            };
            if (open.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            _oImg = new Bitmap(open.FileName, true);

            _gImg = _oImg.ToGrayscale();

            _dImg = _gImg.OrderedDithering(4);

            _aImg = _oImg.AutoLevel();

            ImgType = _imgType;
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            ImgType = (ImageType)(((int)ImgType + 3) % 4);
        }


        private void NextBtn_Click(object sender, EventArgs e)
        {
            ImgType = (ImageType)(((int)ImgType + 1) % 4);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(_image != null)
            {
                var path = $"{Environment.CurrentDirectory}/{_imgType.ToString()}.bmp";
                _image.Save(path);
            }
        }
    }
}
