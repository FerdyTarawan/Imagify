using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseMakingComvis
{
    public partial class Form1 : Form
    {

        ImProcForm imform;
        EdgeDetectForm edgeForm;
        ShapeDetectForm shapeForm;
        PatternRecognitionForm patternForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void improcBtn_Click(object sender, EventArgs e)
        {
            imgDialog.Filter = "Image Files (*.jpg,*.jpeg,*.png)|*.jpg;*.jpeg;*.png";
            imgDialog.DefaultExt = "jpg";


            DialogResult rs = imgDialog.ShowDialog();

            if (rs == DialogResult.OK)
            {
                imform = new ImProcForm();
                imform.FileName = imgDialog.FileName;
                imform.Show();
                this.Hide();
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void edgeDetectBtn_Click(object sender, EventArgs e)
        {
            imgDialog.Filter = "Image Files (*.jpg,*.jpeg,*.png)|*.jpg;*.jpeg;*.png";
            imgDialog.DefaultExt = "jpg";


            DialogResult rs = imgDialog.ShowDialog();

            if (rs == DialogResult.OK)
            {
                edgeForm = new EdgeDetectForm();
                edgeForm.FileName = imgDialog.FileName;
                edgeForm.Show();
                this.Hide();
            }
        }

        private void shapeDetectBtn_Click(object sender, EventArgs e)
        {
            imgDialog.Filter = "Image Files (*.jpg,*.jpeg,*.png)|*.jpg;*.jpeg;*.png";
            imgDialog.DefaultExt = "jpg";


            DialogResult rs = imgDialog.ShowDialog();

            if (rs == DialogResult.OK)
            {
                shapeForm = new ShapeDetectForm();
                shapeForm.FileName = imgDialog.FileName;
                shapeForm.Show();
                this.Hide();
            }
        }

        private void prcBtn_Click(object sender, EventArgs e)
        {
            vidDialog.Filter = "Image or Video Files (*.jpg,*.jpeg,*.png,*.mp4)|*.jpg;*.jpeg;*.png;*.mp4" ;
            vidDialog.DefaultExt = "jpg";

            DialogResult rs = vidDialog.ShowDialog();

            if (rs == DialogResult.OK)
            {
                patternForm = new PatternRecognitionForm();
                patternForm.FileName = vidDialog.FileName;
                patternForm.Show();
                this.Hide();
            }
        }
    }
}
