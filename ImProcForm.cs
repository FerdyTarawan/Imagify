using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace CaseMakingComvis
{
    public partial class ImProcForm : Form
    {

        string _fileName = "";

        Image<Bgr, byte> original, edited1, edited2;
        Image<Gray, byte> gray;

        public string FileName
        {
            get
            {
                return this._fileName;
            }
            set
            {
                this._fileName = value;
            }
        }

        public ImProcForm()
        {
            InitializeComponent();
        }

        private void ImProcForm_Load(object sender, EventArgs e)
        {
            original = new Image<Bgr,byte>(new Bitmap(Image.FromFile(this.FileName)));
            gray = new Image<Gray, byte>(original.Width, original.Height);
            edited1 = new Image<Bgr, byte>(original.Width, original.Height);
            edited2 = new Image<Bgr, byte>(original.Width, original.Height);

            CvInvoke.cvCvtColor(original, gray, COLOR_CONVERSION.CV_BGR2GRAY);

            CvInvoke.cvSmooth(original, edited1, SMOOTH_TYPE.CV_BLUR, (Int32)blurLevel.Value, (Int32)blurLevel.Value, 0, 0);
            CvInvoke.cvThreshold(original, edited2,threshold.Value,brightness.Value,THRESH.CV_THRESH_BINARY);

            fillModeBox();
           
            blurType.SelectedIndex = 0;
            threshType.SelectedIndex = 0;

            settingsBox1_1.Visible = false;
            settingsBox1_2.Visible = false;
            saveBtn1.Visible = false;

            pictBox.Image = original.ToBitmap();
        }

        private void fillModeBox()
        {
            imageList1.ImageSize = new Size(64, 64);
            imageList1.Images.Add(original.ToBitmap());
            imageList1.Images.Add(gray.ToBitmap());
            imageList1.Images.Add(edited1.ToBitmap());
            imageList1.Images.Add(edited2.ToBitmap());

            listView1.LargeImageList = imageList1;
            listView1.View = View.LargeIcon;

            string[] effect = new string[] { "Original", "Grayscale", "Blur", "Thresholding" };

            for (int i = 0; i < imageList1.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = effect[i];
                listView1.Items.Add(item);
            }
        }

        private void ImProcForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            var firstSelectedItem = listView1.SelectedIndices[0];

            switch (firstSelectedItem)
            {
                case 0:
                    pictBox.Image = original.ToBitmap();
                    saveBtn1.Visible = false;
                    settingsBox1_1.Visible = false;
                    settingsBox1_2.Visible = false;
                    break;
                case 1:
                    pictBox.Image = gray.ToBitmap();
                    saveBtn1.Visible = true;
                    settingsBox1_1.Visible = false;
                    settingsBox1_2.Visible = false;
                    break;
                case 2:
                    pictBox.Image = edited1.ToBitmap();
                    saveBtn1.Visible = true;
                    settingsBox1_1.Visible = true;
                    settingsBox1_2.Visible = false;
                    break;
                case 3:
                    pictBox.Image = edited2.ToBitmap();
                    saveBtn1.Visible = true;
                    settingsBox1_1.Visible = false;
                    settingsBox1_2.Visible = true;
                    break;

            }
        }

        private void blurLevel_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void threshold_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void brightness_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void blurType_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void threshType_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void threshType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var threshTypeIdx = threshType.SelectedIndex;

            switch (threshTypeIdx)
            {
                case 0:
                    CvInvoke.cvThreshold(original, edited2, threshold.Value, brightness.Value, THRESH.CV_THRESH_BINARY);
                    break;
                case 1:
                    CvInvoke.cvThreshold(original, edited2, threshold.Value, brightness.Value, THRESH.CV_THRESH_BINARY_INV);
                    break;
                case 2:
                    CvInvoke.cvThreshold(original, edited2, threshold.Value, brightness.Value, THRESH.CV_THRESH_TOZERO);
                    break;
                case 3:
                    CvInvoke.cvThreshold(original, edited2, threshold.Value, brightness.Value, THRESH.CV_THRESH_TOZERO_INV);
                    break;
            }

            pictBox.Image = edited2.ToBitmap();
        }

        private void blurType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var blurTypeIdx = blurType.SelectedIndex;

            switch (blurTypeIdx)
            {
                case 0:
                    CvInvoke.cvSmooth(original, edited1, SMOOTH_TYPE.CV_BLUR, (Int32)blurLevel.Value, (Int32)blurLevel.Value, 0, 0);
                    break;
                case 1:
                    if (blurLevel.Value % 2 == 0)
                    {
                        blurLevel.Value += 1;
                    }
                    CvInvoke.cvSmooth(original, edited1, SMOOTH_TYPE.CV_GAUSSIAN, (Int32)blurLevel.Value, (Int32)blurLevel.Value, 0, 0);
                    break;
            }

            pictBox.Image = edited1.ToBitmap();
        }

        private void saveBtn1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Image Files (*.jpg,*.jpeg,*.png)|*.jpg;*.jpeg;*.png";
            saveFileDialog1.DefaultExt = "jpg";

            DialogResult save = saveFileDialog1.ShowDialog();

            if (save == DialogResult.OK && saveFileDialog1.FileName != "")
            {
                pictBox.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void threshold_Scroll(object sender, EventArgs e)
        {
            var threshTypeIdx = threshType.SelectedIndex;

            switch (threshTypeIdx)
            {
                case 0:
                    CvInvoke.cvThreshold(original, edited2, threshold.Value, brightness.Value, THRESH.CV_THRESH_BINARY);
                    break;
                case 1:
                    CvInvoke.cvThreshold(original, edited2, threshold.Value, brightness.Value, THRESH.CV_THRESH_BINARY_INV);
                    break;
                case 2:
                    CvInvoke.cvThreshold(original, edited2, threshold.Value, brightness.Value, THRESH.CV_THRESH_TOZERO);
                    break;
                case 3:
                    CvInvoke.cvThreshold(original, edited2, threshold.Value, brightness.Value, THRESH.CV_THRESH_TOZERO_INV);
                    break;
            }

            pictBox.Image = edited2.ToBitmap();
        }

        private void brightness_Scroll(object sender, EventArgs e)
        {
            var threshTypeIdx = threshType.SelectedIndex;

            switch (threshTypeIdx)
            {
                case 0:
                    CvInvoke.cvThreshold(original, edited2, threshold.Value, brightness.Value, THRESH.CV_THRESH_BINARY);
                    break;
                case 1:
                    CvInvoke.cvThreshold(original, edited2, threshold.Value, brightness.Value, THRESH.CV_THRESH_BINARY_INV);
                    break;
                case 2:
                    CvInvoke.cvThreshold(original, edited2, threshold.Value, brightness.Value, THRESH.CV_THRESH_TOZERO);
                    break;
                case 3:
                    CvInvoke.cvThreshold(original, edited2, threshold.Value, brightness.Value, THRESH.CV_THRESH_TOZERO_INV);
                    break;
            }

            pictBox.Image = edited2.ToBitmap();
        }

        private void blurLevel_Scroll(object sender, EventArgs e)
        {
            var blurTypeIdx = blurType.SelectedIndex;

            switch (blurTypeIdx)
            {
                case 0:
                    CvInvoke.cvSmooth(original, edited1, SMOOTH_TYPE.CV_BLUR, (Int32)blurLevel.Value, (Int32)blurLevel.Value, 0, 0);
                    break;
                case 1:
                    if (blurLevel.Value % 2 == 0)
                    {
                        blurLevel.Value += 1;
                    }
                    CvInvoke.cvSmooth(original, edited1, SMOOTH_TYPE.CV_GAUSSIAN, (Int32)blurLevel.Value, (Int32)blurLevel.Value, 0, 0);
                    break;
            }

            pictBox.Image = edited1.ToBitmap();
        }
    }
}
