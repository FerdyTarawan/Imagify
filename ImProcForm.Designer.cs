namespace CaseMakingComvis
{
    partial class ImProcForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImProcForm));
            this.pictBox = new System.Windows.Forms.PictureBox();
            this.backLbl = new System.Windows.Forms.Label();
            this.saveBtn1 = new System.Windows.Forms.Button();
            this.modeBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.settingsBox1_1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.blurLevel = new System.Windows.Forms.TrackBar();
            this.blurType = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.settingsBox1_2 = new System.Windows.Forms.GroupBox();
            this.brightness = new System.Windows.Forms.TrackBar();
            this.threshold = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.threshType = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).BeginInit();
            this.modeBox1.SuspendLayout();
            this.settingsBox1_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blurLevel)).BeginInit();
            this.settingsBox1_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threshold)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBox
            // 
            this.pictBox.Location = new System.Drawing.Point(155, 40);
            this.pictBox.Name = "pictBox";
            this.pictBox.Size = new System.Drawing.Size(406, 503);
            this.pictBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBox.TabIndex = 0;
            this.pictBox.TabStop = false;
            // 
            // backLbl
            // 
            this.backLbl.AutoSize = true;
            this.backLbl.BackColor = System.Drawing.Color.Transparent;
            this.backLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backLbl.Location = new System.Drawing.Point(12, 9);
            this.backLbl.Name = "backLbl";
            this.backLbl.Size = new System.Drawing.Size(98, 31);
            this.backLbl.TabIndex = 1;
            this.backLbl.Text = "< Back";
            this.backLbl.Click += new System.EventHandler(this.backLbl_Click);
            // 
            // saveBtn1
            // 
            this.saveBtn1.BackColor = System.Drawing.SystemColors.WindowText;
            this.saveBtn1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveBtn1.Location = new System.Drawing.Point(293, 549);
            this.saveBtn1.Name = "saveBtn1";
            this.saveBtn1.Size = new System.Drawing.Size(128, 35);
            this.saveBtn1.TabIndex = 2;
            this.saveBtn1.Text = "Save";
            this.saveBtn1.UseVisualStyleBackColor = false;
            this.saveBtn1.Click += new System.EventHandler(this.saveBtn1_Click);
            // 
            // modeBox1
            // 
            this.modeBox1.BackColor = System.Drawing.Color.Transparent;
            this.modeBox1.Controls.Add(this.listView1);
            this.modeBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.modeBox1.Location = new System.Drawing.Point(638, 40);
            this.modeBox1.Name = "modeBox1";
            this.modeBox1.Size = new System.Drawing.Size(260, 226);
            this.modeBox1.TabIndex = 3;
            this.modeBox1.TabStop = false;
            this.modeBox1.Text = "Mode";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.DimGray;
            this.listView1.Location = new System.Drawing.Point(6, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(248, 201);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // settingsBox1_1
            // 
            this.settingsBox1_1.BackColor = System.Drawing.Color.Transparent;
            this.settingsBox1_1.Controls.Add(this.label1);
            this.settingsBox1_1.Controls.Add(this.blurLevel);
            this.settingsBox1_1.Controls.Add(this.blurType);
            this.settingsBox1_1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.settingsBox1_1.Location = new System.Drawing.Point(601, 291);
            this.settingsBox1_1.Name = "settingsBox1_1";
            this.settingsBox1_1.Size = new System.Drawing.Size(341, 131);
            this.settingsBox1_1.TabIndex = 4;
            this.settingsBox1_1.TabStop = false;
            this.settingsBox1_1.Text = "Adjustments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(6, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Smooth Level";
            // 
            // blurLevel
            // 
            this.blurLevel.BackColor = System.Drawing.Color.DimGray;
            this.blurLevel.Location = new System.Drawing.Point(111, 57);
            this.blurLevel.Maximum = 201;
            this.blurLevel.Minimum = 1;
            this.blurLevel.Name = "blurLevel";
            this.blurLevel.Size = new System.Drawing.Size(224, 45);
            this.blurLevel.TabIndex = 1;
            this.blurLevel.Value = 1;
            this.blurLevel.Scroll += new System.EventHandler(this.blurLevel_Scroll);
            this.blurLevel.ValueChanged += new System.EventHandler(this.blurLevel_ValueChanged);
            // 
            // blurType
            // 
            this.blurType.FormattingEnabled = true;
            this.blurType.Items.AddRange(new object[] {
            "Box Blur",
            "Gaussian Blur"});
            this.blurType.Location = new System.Drawing.Point(6, 19);
            this.blurType.Name = "blurType";
            this.blurType.Size = new System.Drawing.Size(329, 21);
            this.blurType.TabIndex = 0;
            this.blurType.SelectedIndexChanged += new System.EventHandler(this.blurType_SelectedIndexChanged);
            this.blurType.VisibleChanged += new System.EventHandler(this.blurType_VisibleChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // settingsBox1_2
            // 
            this.settingsBox1_2.BackColor = System.Drawing.Color.Transparent;
            this.settingsBox1_2.Controls.Add(this.brightness);
            this.settingsBox1_2.Controls.Add(this.threshold);
            this.settingsBox1_2.Controls.Add(this.label3);
            this.settingsBox1_2.Controls.Add(this.label2);
            this.settingsBox1_2.Controls.Add(this.threshType);
            this.settingsBox1_2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.settingsBox1_2.Location = new System.Drawing.Point(601, 291);
            this.settingsBox1_2.Name = "settingsBox1_2";
            this.settingsBox1_2.Size = new System.Drawing.Size(341, 155);
            this.settingsBox1_2.TabIndex = 1;
            this.settingsBox1_2.TabStop = false;
            this.settingsBox1_2.Text = "Adjustments";
            // 
            // brightness
            // 
            this.brightness.BackColor = System.Drawing.Color.DimGray;
            this.brightness.Location = new System.Drawing.Point(111, 104);
            this.brightness.Maximum = 255;
            this.brightness.Name = "brightness";
            this.brightness.Size = new System.Drawing.Size(224, 45);
            this.brightness.TabIndex = 8;
            this.brightness.Value = 100;
            this.brightness.Scroll += new System.EventHandler(this.brightness_Scroll);
            this.brightness.ValueChanged += new System.EventHandler(this.brightness_ValueChanged);
            // 
            // threshold
            // 
            this.threshold.BackColor = System.Drawing.Color.DimGray;
            this.threshold.Location = new System.Drawing.Point(111, 43);
            this.threshold.Maximum = 255;
            this.threshold.Name = "threshold";
            this.threshold.Size = new System.Drawing.Size(224, 45);
            this.threshold.TabIndex = 5;
            this.threshold.Value = 60;
            this.threshold.Scroll += new System.EventHandler(this.threshold_Scroll);
            this.threshold.ValueChanged += new System.EventHandler(this.threshold_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Brightness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Threshold";
            // 
            // threshType
            // 
            this.threshType.FormattingEnabled = true;
            this.threshType.Items.AddRange(new object[] {
            "Binary",
            "Binary Inverse",
            "To Zero",
            "To Zero Inverse"});
            this.threshType.Location = new System.Drawing.Point(3, 16);
            this.threshType.Name = "threshType";
            this.threshType.Size = new System.Drawing.Size(332, 21);
            this.threshType.TabIndex = 0;
            this.threshType.SelectedIndexChanged += new System.EventHandler(this.threshType_SelectedIndexChanged);
            this.threshType.VisibleChanged += new System.EventHandler(this.threshType_VisibleChanged);
            // 
            // ImProcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(974, 610);
            this.Controls.Add(this.settingsBox1_2);
            this.Controls.Add(this.settingsBox1_1);
            this.Controls.Add(this.modeBox1);
            this.Controls.Add(this.saveBtn1);
            this.Controls.Add(this.backLbl);
            this.Controls.Add(this.pictBox);
            this.Name = "ImProcForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Processing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImProcForm_FormClosing);
            this.Load += new System.EventHandler(this.ImProcForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).EndInit();
            this.modeBox1.ResumeLayout(false);
            this.settingsBox1_1.ResumeLayout(false);
            this.settingsBox1_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blurLevel)).EndInit();
            this.settingsBox1_2.ResumeLayout(false);
            this.settingsBox1_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBox;
        private System.Windows.Forms.Label backLbl;
        private System.Windows.Forms.Button saveBtn1;
        private System.Windows.Forms.GroupBox modeBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox settingsBox1_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar blurLevel;
        private System.Windows.Forms.ComboBox blurType;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox settingsBox1_2;
        private System.Windows.Forms.TrackBar brightness;
        private System.Windows.Forms.TrackBar threshold;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox threshType;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}