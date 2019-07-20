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
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace CaseMakingComvis
{
    public partial class EdgeDetectForm : Form
    {
        string _fileName = "";

        Image<Bgr, byte> original;
        Image<Gray, byte> gray, edge1;
        Image<Gray, float> grayf,edge2,edge3;

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


        public EdgeDetectForm()
        {
            InitializeComponent();
        }

        private void backLbl2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void EdgeDetectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void EdgeDetectForm_Load(object sender, EventArgs e)
        {
            original = new Image<Bgr, byte>(new Bitmap(Image.FromFile(this.FileName)));
            gray = new Image<Gray, byte>(original.Width, original.Height);
            edge1 = new Image<Gray, byte>(original.Width, original.Height);
            edge2 = new Image<Gray, float>(original.Width, original.Height);
            edge3 = new Image<Gray, float>(original.Width, original.Height);

            CvInvoke.cvCvtColor(original, gray, COLOR_CONVERSION.CV_BGR2GRAY);
            grayf = gray.Convert<Gray, float>();

            //edge detect
            CvInvoke.cvCanny(gray, edge1, 100, 30, (Int32)aperture.Value);
            edge2 = grayf.Laplace((Int32)aperture.Value);
            edge3 = grayf.Sobel(1, 0, (Int32)aperture.Value);


            fillModeBox();

            
            saveBtn2.Visible = false;
            apertureBox.Visible = false;
            pictBox2.Image = original.ToBitmap();
        }

        private void fillModeBox()
        {
            imageList1.ImageSize = new Size(64, 64);
            imageList1.Images.Add(original.ToBitmap());
            imageList1.Images.Add(edge3.ToBitmap());
            imageList1.Images.Add(edge2.ToBitmap());
            imageList1.Images.Add(edge1.ToBitmap());

            listView2.LargeImageList = imageList1;
            listView2.View = View.LargeIcon;

            string[] effect = new string[] { "Original", "Sobel", "Laplace", "Canny" };

            for (int i = 0; i < imageList1.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = effect[i];
                listView2.Items.Add(item);
            }
        }

        private void aperture_ValueChanged(object sender, EventArgs e)
        {
            var selectedMode = listView2.SelectedIndices[0];

            switch(selectedMode)
            {
                case 1:
                    if (aperture.Value > 7)
                    {
                        aperture.Value = 7;
                    }
                    else if (aperture.Value < 3)
                    {
                        aperture.Value = 3;
                    }
                    else if (aperture.Value % 2 == 0)
                    {
                        aperture.Value += 1;
                    }
                    edge3 = grayf.Sobel(1, 0, (Int32)aperture.Value);
                    pictBox2.Image = edge3.ToBitmap();
                    break;
                case 2:
                    if (aperture.Value > 7)
                    {
                        aperture.Value = 7;
                    }
                    else if (aperture.Value < 3)
                    {
                        aperture.Value = 3;
                    }
                    else if (aperture.Value % 2 == 0)
                    {
                        aperture.Value += 1;
                    }
                    edge2 = grayf.Laplace((Int32)aperture.Value);
                    pictBox2.Image = edge2.ToBitmap();
                    break;
                case 3:
                    if (aperture.Value > 7)
                    {
                        aperture.Value = 7;
                    }
                    else if (aperture.Value < 3)
                    {
                        aperture.Value = 3;
                    }
                    else if (aperture.Value % 2 == 0)
                    {
                        aperture.Value += 1;
                    }
                    CvInvoke.cvCanny(gray, edge1, 100, 30, (Int32)aperture.Value);
                    pictBox2.Image = edge1.ToBitmap();
                    break;
            }
        }

        private void listView2_MouseClick(object sender, MouseEventArgs e)
        {
            var selectedMode = listView2.SelectedIndices[0];

            switch (selectedMode)
            {
                case 0:
                    pictBox2.Image = original.ToBitmap();
                    apertureBox.Visible = false;
                    saveBtn2.Visible = false;
                    break;
                case 1:
                    if (aperture.Value > 7)
                    {
                        aperture.Value = 7;
                    }
                    else if (aperture.Value < 3)
                    {
                        aperture.Value = 3;
                    }
                    else if (aperture.Value % 2 == 0)
                    {
                        aperture.Value += 1;
                    }
                    edge3 = grayf.Sobel(1, 0, (Int32)aperture.Value);
                    pictBox2.Image = edge3.ToBitmap();
                    apertureBox.Visible = true;
                    saveBtn2.Visible = true;
                    break;
                case 2:
                    if (aperture.Value > 7)
                    {
                        aperture.Value = 7;
                    }
                    else if (aperture.Value < 3)
                    {
                        aperture.Value = 3;
                    }
                    else if (aperture.Value % 2 == 0)
                    {
                        aperture.Value += 1;
                    }
                    edge2 = grayf.Laplace((Int32)aperture.Value);
                    pictBox2.Image = edge2.ToBitmap();
                    apertureBox.Visible = true;
                    saveBtn2.Visible = true;

                    break;
                case 3:
                    if (aperture.Value > 7)
                    {
                        aperture.Value = 7;
                    }
                    else if (aperture.Value < 3)
                    {
                        aperture.Value = 3;
                    }
                    else if (aperture.Value % 2 == 0)
                    {
                        aperture.Value += 1;
                    }
                    CvInvoke.cvCanny(gray, edge1, 100, 30, (Int32)aperture.Value);
                    pictBox2.Image = edge1.ToBitmap();
                    apertureBox.Visible = true;
                    saveBtn2.Visible = true;

                    break;
            }
        }

        private void saveBtn2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Image Files (*.jpg,*.jpeg,*.png)|*.jpg;*.jpeg;*.png";
            saveFileDialog1.DefaultExt = "jpg";

            DialogResult save = saveFileDialog1.ShowDialog();

            if (save == DialogResult.OK && saveFileDialog1.FileName != "")
            {
                pictBox2.Image.Save(saveFileDialog1.FileName);
            }
        }
    }
}
