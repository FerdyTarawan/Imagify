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
    public partial class ShapeDetectForm : Form
    {
        string _fileName = "";
        Image<Bgr, byte> original, edited;
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

        public ShapeDetectForm()
        {
            InitializeComponent();
        }

        private void ShapeDetectForm_Load(object sender, EventArgs e)
        {
            original = new Image<Bgr, byte>(new Bitmap(Image.FromFile(this.FileName)));
            gray = new Image<Gray, byte>(original.Width, original.Height);
            CvInvoke.cvCvtColor(original, gray, COLOR_CONVERSION.CV_BGR2GRAY);

            pictBox3.Image = original.ToBitmap();

            saveBtn3.Visible = false;
        }

        private void ShapeDetectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backLbl2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void lineChk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void circleChk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void triangleChk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void squareChk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void shapeDetectBtn_Click(object sender, EventArgs e)
        {
            edited = original.Copy();

            if (lineChk.Checked)
            {
                LineSegment2D[] lines = gray.HoughLines(new Gray(127), new Gray(127), 5, Math.PI / 45, 10, 20, 5)[0];
                foreach (var line in lines)
                {
                    edited.Draw(line, new Bgr(Color.Red), 5);
                }

                pictBox3.Image = edited.ToBitmap();
                saveBtn3.Visible = true;
            }
           
            if (circleChk.Checked)
            {
                

                CircleF[] circles = gray.HoughCircles(new Gray(100), new Gray(80), 2, 400, 50, 0)[0];
                foreach (var circle in circles)
                {
                    edited.Draw(circle, new Bgr(Color.Red), 5);
                }
                pictBox3.Image = edited.ToBitmap();
                saveBtn3.Visible = true;

            }
            
            if(triangleChk.Checked)
            {
                Contour<Point> contours = gray.FindContours();
                while (contours != null)
                {
                    Contour<Point> contour = contours.ApproxPoly(contours.Perimeter * 0.1);
                    
                    if (contour.Total == 3)
                    {
                        Point[] points = contour.ToArray();
                        edited.Draw(new Triangle2DF(points[0], points[1], points[2]), new Bgr(Color.Red), 5);
                    }
                    contours = contours.HNext;
                }
                
            }
           
            if (squareChk.Checked)
            {
                Contour<Point> contours = gray.FindContours();
                while (contours != null)
                {
                    Contour<Point> contour = contours.ApproxPoly(contours.Perimeter * 0.1);
                    if (contour.Total == 4)
                    {
                        Point[] points = contour.ToArray();

                        LineSegment2D[] lines = PointCollection.PolyLine(points, true);
                        for (int i = 0; i < lines.Length; i++)
                        {
                            double angle = lines[i].GetExteriorAngleDegree(lines[(i + 1) % lines.Length]);
                            
                            if (angle > 80 && angle < 100)
                            {
                                edited.Draw(lines[i], new Bgr(Color.Red), 5);
                            }
                        }
                    }
                    contours = contours.HNext;
                }
            }


            if (!lineChk.Checked && !circleChk.Checked && !triangleChk.Checked && !squareChk.Checked)
            {
                MessageBox.Show("Please select shape to detect!");
                resetBtn.PerformClick();
            }
            else
            {
                pictBox3.Image = edited.ToBitmap();
                saveBtn3.Visible = true;
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            lineChk.Checked = false;
            circleChk.Checked = false;
            triangleChk.Checked = false;
            squareChk.Checked = false;

            saveBtn3.Visible = false;
            pictBox3.Image = original.ToBitmap();
        }

        private void saveBtn3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Image Files (*.jpg,*.jpeg,*.png)|*.jpg;*.jpeg;*.png";
            saveFileDialog1.DefaultExt = "jpg";

            DialogResult save = saveFileDialog1.ShowDialog();

            if (save == DialogResult.OK && saveFileDialog1.FileName != "")
            {
                pictBox3.Image.Save(saveFileDialog1.FileName);
            }
        }
    }
}
