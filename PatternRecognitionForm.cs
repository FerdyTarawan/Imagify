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
    public partial class PatternRecognitionForm : Form
    {
        string _fileName = "";
        Image<Bgr, byte> original, edited;
        Image<Bgr, byte> frame;
        Image<Gray, byte> gray,grayFrame;

        HaarCascade face, nose, eye;
        Capture cap;

        int faceCounter,eyeCounter,noseCounter;
        int mode = 0;
        bool isPlaying;

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

        private void clearCounter()
        {
            faceCounter = 0;
            eyeCounter = 0;
            noseCounter = 0;
        }

        public PatternRecognitionForm()
        {
            InitializeComponent();
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            eye = new HaarCascade("haarcascade_eye.xml");
            nose = new HaarCascade("haarcascade_mcs_nose.xml");
            timer1.Interval = 16;
            isPlaying = false;
            noseChk.Visible = false;
        }

        private void ObjectRecogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PatternRecogForm_Load(object sender, EventArgs e)
        {
            if (_fileName.EndsWith(".mp4"))
            {
                mode = 1;
                timer1.Start();
                cap = new Capture(this.FileName);
                isPlaying = true;
                multiBtn.Visible = true;

            }
            else
            {
                mode = 2;

                original = new Image<Bgr, byte>(new Bitmap(Image.FromFile(this.FileName)));
                gray = new Image<Gray, byte>(original.Width, original.Height);
                CvInvoke.cvCvtColor(original, gray, COLOR_CONVERSION.CV_BGR2GRAY);

                edited = original.Copy();
                multiBtn.Visible = false;
                pictBox4.Image = original.ToBitmap();
            }

            
            conclusionBox.Visible = false;
            dynamicText();
        }

        private void dynamicText()
        {
            switch (mode)
            {
                case -1:
                    multiBtn.Text = "Play Video";
                    break;
                case 1:
                    multiBtn.Text = "Stop Video";
                    break;
                case 2:
                    multiBtn.Text = "Save";
                    break;
            }
        }

        private void backLbl4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void multiBtn_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case -1:
                    mode *= -1;
                    isPlaying = true;
                    dynamicText();
                    break;
                case 1:
                    mode *= -1;
                    isPlaying = false;
                    dynamicText();
                    break;
                case 2:
                    saveFileDialog1.Filter = "Image Files (*.jpg,*.jpeg,*.png)|*.jpg;*.jpeg;*.png";
                    saveFileDialog1.DefaultExt = "jpg";

                    DialogResult save = saveFileDialog1.ShowDialog();

                    if (save == DialogResult.OK && saveFileDialog1.FileName != "")
                    {
                        pictBox4.Image.Save(saveFileDialog1.FileName);
                    }
                    
                    break;
            }
        }

        private void detect()
        {
            
            if (mode == 2 || mode == -1)
            {
                if (mode == -1) 
                {
                    edited = frame.Copy(); 
                    grayFrame = new Image<Gray,byte>(frame.Width,frame.Height);
                    CvInvoke.cvCvtColor(frame,grayFrame,COLOR_CONVERSION.CV_BGR2GRAY);
                }
                else{
                    edited = original.Copy();
                }

                clearCounter();
                if (faceChk.Checked)
                {
                   

                    if (mode == -1)
                    {
                        var faces = face.Detect(grayFrame);
                        foreach (var f in faces)
                        {
                            edited.Draw(f.rect, new Bgr(Color.White), 5);
                            faceCounter++;
                        }

                    }
                    else
                    {
                        var faces = face.Detect(gray);
                        foreach (var f in faces)
                        {
                            edited.Draw(f.rect, new Bgr(Color.White), 5);
                            faceCounter++;
                        }
                    }

                    
                }

                if (eyeChk.Checked)
                {
                    if (mode == -1)
                    {
                        var eyes = eye.Detect(grayFrame);
                        foreach (var e in eyes)
                        {
                            edited.Draw(e.rect, new Bgr(Color.White), 5);
                            eyeCounter++;
                        }
                    }
                    else
                    {
                        var eyes = eye.Detect(gray);
                        foreach (var e in eyes)
                        {
                            edited.Draw(e.rect, new Bgr(Color.White), 5);
                            eyeCounter++;
                        }
                    }

                    
                }

                if (noseChk.Checked)
                {
                    if (mode == -1)
                    {
                        var noses = nose.Detect(grayFrame);
                        foreach (var n in noses)
                        {
                            edited.Draw(n.rect, new Bgr(Color.White), 5);
                            noseCounter++;
                        }
                    }
                    else
                    {
                        var noses = nose.Detect(gray);
                        foreach (var n in noses)
                        {
                            edited.Draw(n.rect, new Bgr(Color.White), 5);
                            noseCounter++;
                        }
                    }

                    
                }

                if (!faceChk.Checked && !eyeChk.Checked && !noseChk.Checked)
                {
                    if (mode == -1)
                    {
                        conclusionBox.Visible = false;
                        pictBox4.Image = frame.ToBitmap();
                    }
                    else
                    {
                        multiBtn.Visible = false;
                        conclusionBox.Visible = false;
                        pictBox4.Image = original.ToBitmap();
                    }
                    
                }
                else
                {
                    multiBtn.Visible = true;
                    conclusionBox.Visible = true;

                    if (faceChk.Checked)
                    {
                        faceConclusion.Text = faceCounter.ToString() + " Face Detected";
                        faceConclusion.Visible = true;
                    }
                    else
                    {
                        faceConclusion.Visible = false;
                    }


                    if (eyeChk.Checked)
                    {
                        eyeConclusion.Text = eyeCounter.ToString() + " Eyes Detected";
                        eyeConclusion.Visible = true;
                    }
                    else {
                        eyeConclusion.Visible = false;
                    }

                    if (noseChk.Checked)
                    {
                        noseConclusion.Text = noseCounter.ToString() + " Nose Detected";
                        noseConclusion.Visible = true;
                    }
                    else
                    {
                        noseConclusion.Visible = false;
                    }
                    

                    pictBox4.Image = edited.ToBitmap();
                }
               
            }
           
        }

        private void faceChk_CheckedChanged(object sender, EventArgs e)
        {
            detect();
        }

        private void eyeChk_CheckedChanged(object sender, EventArgs e)
        {
            detect();
        }

        private void noseChk_CheckedChanged(object sender, EventArgs e)
        {
            detect();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                clearCounter();
                frame = cap.QueryFrame();
                grayFrame = new Image<Gray, byte>(frame.Width, frame.Height);
                CvInvoke.cvCvtColor(frame, grayFrame, COLOR_CONVERSION.CV_BGR2GRAY);

                clearCounter();
                if (faceChk.Checked)
                {
                    var faces = face.Detect(grayFrame);
                    foreach (var f in faces)
                    {
                        frame.Draw(f.rect, new Bgr(Color.White), 5);
                        faceCounter++;
                    }
                }

                if (eyeChk.Checked)
                {
                    var eyes = eye.Detect(grayFrame);
                    foreach (var ey in eyes)
                    {
                        frame.Draw(ey.rect, new Bgr(Color.White), 5);
                        eyeCounter++;
                    }
                }

                if (noseChk.Checked)
                {
                    var noses = nose.Detect(grayFrame);
                    foreach (var n in noses)
                    {
                        frame.Draw(n.rect, new Bgr(Color.White), 5);
                        noseCounter++;
                    }
                }

                if (!faceChk.Checked && !eyeChk.Checked && !noseChk.Checked)
                {
                    conclusionBox.Visible = false;
                    pictBox4.Image = frame.ToBitmap();
                }
                else
                {
                    
                    conclusionBox.Visible = true;

                    if (faceChk.Checked)
                    {
                        faceConclusion.Text = faceCounter.ToString() + " Face Detected";
                        faceConclusion.Visible = true;
                    }
                    else
                    {
                        faceConclusion.Visible = false;
                    }


                    if (eyeChk.Checked)
                    {
                        eyeConclusion.Text = eyeCounter.ToString() + " Eyes Detected";
                        eyeConclusion.Visible = true;
                    }
                    else {
                        eyeConclusion.Visible = false;
                    }

                    if (noseChk.Checked)
                    {
                        noseConclusion.Text = noseCounter.ToString() + " Nose Detected";
                        noseConclusion.Visible = true;
                    }
                    else
                    {
                        noseConclusion.Visible = false;
                    }
                    

                    pictBox4.Image = frame.ToBitmap();
                }
               
            
            }
        }
    }
}
