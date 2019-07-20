namespace CaseMakingComvis
{
    partial class EdgeDetectForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdgeDetectForm));
            this.backLbl2 = new System.Windows.Forms.Label();
            this.pictBox2 = new System.Windows.Forms.PictureBox();
            this.saveBtn2 = new System.Windows.Forms.Button();
            this.modeBox2 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.apertureBox = new System.Windows.Forms.GroupBox();
            this.aperture = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox2)).BeginInit();
            this.modeBox2.SuspendLayout();
            this.apertureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aperture)).BeginInit();
            this.SuspendLayout();
            // 
            // backLbl2
            // 
            this.backLbl2.AutoSize = true;
            this.backLbl2.BackColor = System.Drawing.Color.Transparent;
            this.backLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLbl2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backLbl2.Location = new System.Drawing.Point(12, 9);
            this.backLbl2.Name = "backLbl2";
            this.backLbl2.Size = new System.Drawing.Size(98, 31);
            this.backLbl2.TabIndex = 2;
            this.backLbl2.Text = "< Back";
            this.backLbl2.Click += new System.EventHandler(this.backLbl2_Click);
            // 
            // pictBox2
            // 
            this.pictBox2.Location = new System.Drawing.Point(112, 49);
            this.pictBox2.Name = "pictBox2";
            this.pictBox2.Size = new System.Drawing.Size(406, 503);
            this.pictBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBox2.TabIndex = 3;
            this.pictBox2.TabStop = false;
            // 
            // saveBtn2
            // 
            this.saveBtn2.BackColor = System.Drawing.SystemColors.WindowText;
            this.saveBtn2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveBtn2.Location = new System.Drawing.Point(249, 558);
            this.saveBtn2.Name = "saveBtn2";
            this.saveBtn2.Size = new System.Drawing.Size(128, 35);
            this.saveBtn2.TabIndex = 4;
            this.saveBtn2.Text = "Save";
            this.saveBtn2.UseVisualStyleBackColor = false;
            this.saveBtn2.Click += new System.EventHandler(this.saveBtn2_Click);
            // 
            // modeBox2
            // 
            this.modeBox2.BackColor = System.Drawing.Color.Transparent;
            this.modeBox2.Controls.Add(this.listView2);
            this.modeBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.modeBox2.Location = new System.Drawing.Point(578, 49);
            this.modeBox2.Name = "modeBox2";
            this.modeBox2.Size = new System.Drawing.Size(260, 226);
            this.modeBox2.TabIndex = 5;
            this.modeBox2.TabStop = false;
            this.modeBox2.Text = "Mode";
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.DimGray;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(6, 19);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(248, 201);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // apertureBox
            // 
            this.apertureBox.BackColor = System.Drawing.Color.Transparent;
            this.apertureBox.Controls.Add(this.aperture);
            this.apertureBox.Controls.Add(this.label2);
            this.apertureBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.apertureBox.Location = new System.Drawing.Point(578, 307);
            this.apertureBox.Name = "apertureBox";
            this.apertureBox.Size = new System.Drawing.Size(260, 75);
            this.apertureBox.TabIndex = 6;
            this.apertureBox.TabStop = false;
            this.apertureBox.Text = "Adjustments";
            // 
            // aperture
            // 
            this.aperture.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.aperture.Location = new System.Drawing.Point(89, 30);
            this.aperture.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.aperture.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.aperture.Name = "aperture";
            this.aperture.Size = new System.Drawing.Size(165, 20);
            this.aperture.TabIndex = 7;
            this.aperture.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.aperture.ValueChanged += new System.EventHandler(this.aperture_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Aperture";
            // 
            // EdgeDetectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(904, 643);
            this.Controls.Add(this.apertureBox);
            this.Controls.Add(this.modeBox2);
            this.Controls.Add(this.saveBtn2);
            this.Controls.Add(this.pictBox2);
            this.Controls.Add(this.backLbl2);
            this.Name = "EdgeDetectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edge Detection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EdgeDetectForm_FormClosing);
            this.Load += new System.EventHandler(this.EdgeDetectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictBox2)).EndInit();
            this.modeBox2.ResumeLayout(false);
            this.apertureBox.ResumeLayout(false);
            this.apertureBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aperture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label backLbl2;
        private System.Windows.Forms.PictureBox pictBox2;
        private System.Windows.Forms.Button saveBtn2;
        private System.Windows.Forms.GroupBox modeBox2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox apertureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown aperture;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}