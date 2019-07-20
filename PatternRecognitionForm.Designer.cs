namespace CaseMakingComvis
{
    partial class PatternRecognitionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatternRecognitionForm));
            this.backLbl4 = new System.Windows.Forms.Label();
            this.pictBox4 = new System.Windows.Forms.PictureBox();
            this.multiBtn = new System.Windows.Forms.Button();
            this.modeBox2 = new System.Windows.Forms.GroupBox();
            this.noseChk = new System.Windows.Forms.CheckBox();
            this.eyeChk = new System.Windows.Forms.CheckBox();
            this.faceChk = new System.Windows.Forms.CheckBox();
            this.conclusionBox = new System.Windows.Forms.GroupBox();
            this.noseConclusion = new System.Windows.Forms.Label();
            this.eyeConclusion = new System.Windows.Forms.Label();
            this.faceConclusion = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictBox4)).BeginInit();
            this.modeBox2.SuspendLayout();
            this.conclusionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // backLbl4
            // 
            this.backLbl4.AutoSize = true;
            this.backLbl4.BackColor = System.Drawing.Color.Transparent;
            this.backLbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLbl4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backLbl4.Location = new System.Drawing.Point(12, 9);
            this.backLbl4.Name = "backLbl4";
            this.backLbl4.Size = new System.Drawing.Size(98, 31);
            this.backLbl4.TabIndex = 3;
            this.backLbl4.Text = "< Back";
            this.backLbl4.Click += new System.EventHandler(this.backLbl4_Click);
            // 
            // pictBox4
            // 
            this.pictBox4.Location = new System.Drawing.Point(108, 67);
            this.pictBox4.Name = "pictBox4";
            this.pictBox4.Size = new System.Drawing.Size(406, 503);
            this.pictBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBox4.TabIndex = 4;
            this.pictBox4.TabStop = false;
            // 
            // multiBtn
            // 
            this.multiBtn.BackColor = System.Drawing.SystemColors.WindowText;
            this.multiBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.multiBtn.Location = new System.Drawing.Point(247, 576);
            this.multiBtn.Name = "multiBtn";
            this.multiBtn.Size = new System.Drawing.Size(128, 35);
            this.multiBtn.TabIndex = 5;
            this.multiBtn.Text = "Save";
            this.multiBtn.UseVisualStyleBackColor = false;
            this.multiBtn.Click += new System.EventHandler(this.multiBtn_Click);
            // 
            // modeBox2
            // 
            this.modeBox2.BackColor = System.Drawing.Color.Transparent;
            this.modeBox2.Controls.Add(this.noseChk);
            this.modeBox2.Controls.Add(this.eyeChk);
            this.modeBox2.Controls.Add(this.faceChk);
            this.modeBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.modeBox2.Location = new System.Drawing.Point(591, 67);
            this.modeBox2.Name = "modeBox2";
            this.modeBox2.Size = new System.Drawing.Size(180, 228);
            this.modeBox2.TabIndex = 6;
            this.modeBox2.TabStop = false;
            this.modeBox2.Text = "Object to Detect";
            // 
            // noseChk
            // 
            this.noseChk.AutoSize = true;
            this.noseChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noseChk.Location = new System.Drawing.Point(58, 151);
            this.noseChk.Name = "noseChk";
            this.noseChk.Size = new System.Drawing.Size(60, 21);
            this.noseChk.TabIndex = 9;
            this.noseChk.Text = "Nose";
            this.noseChk.UseVisualStyleBackColor = true;
            this.noseChk.CheckedChanged += new System.EventHandler(this.noseChk_CheckedChanged);
            // 
            // eyeChk
            // 
            this.eyeChk.AutoSize = true;
            this.eyeChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eyeChk.Location = new System.Drawing.Point(58, 97);
            this.eyeChk.Name = "eyeChk";
            this.eyeChk.Size = new System.Drawing.Size(58, 21);
            this.eyeChk.TabIndex = 8;
            this.eyeChk.Text = "Eyes";
            this.eyeChk.UseVisualStyleBackColor = true;
            this.eyeChk.CheckedChanged += new System.EventHandler(this.eyeChk_CheckedChanged);
            // 
            // faceChk
            // 
            this.faceChk.AutoSize = true;
            this.faceChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faceChk.Location = new System.Drawing.Point(58, 50);
            this.faceChk.Name = "faceChk";
            this.faceChk.Size = new System.Drawing.Size(58, 21);
            this.faceChk.TabIndex = 7;
            this.faceChk.Text = "Face";
            this.faceChk.UseVisualStyleBackColor = true;
            this.faceChk.CheckedChanged += new System.EventHandler(this.faceChk_CheckedChanged);
            // 
            // conclusionBox
            // 
            this.conclusionBox.BackColor = System.Drawing.Color.Transparent;
            this.conclusionBox.Controls.Add(this.noseConclusion);
            this.conclusionBox.Controls.Add(this.eyeConclusion);
            this.conclusionBox.Controls.Add(this.faceConclusion);
            this.conclusionBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.conclusionBox.Location = new System.Drawing.Point(591, 342);
            this.conclusionBox.Name = "conclusionBox";
            this.conclusionBox.Size = new System.Drawing.Size(180, 228);
            this.conclusionBox.TabIndex = 10;
            this.conclusionBox.TabStop = false;
            this.conclusionBox.Text = "Conclusion";
            // 
            // noseConclusion
            // 
            this.noseConclusion.AutoSize = true;
            this.noseConclusion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noseConclusion.Location = new System.Drawing.Point(33, 128);
            this.noseConclusion.Name = "noseConclusion";
            this.noseConclusion.Size = new System.Drawing.Size(114, 17);
            this.noseConclusion.TabIndex = 2;
            this.noseConclusion.Text = "0 Nose Detected";
            // 
            // eyeConclusion
            // 
            this.eyeConclusion.AutoSize = true;
            this.eyeConclusion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eyeConclusion.Location = new System.Drawing.Point(33, 84);
            this.eyeConclusion.Name = "eyeConclusion";
            this.eyeConclusion.Size = new System.Drawing.Size(112, 17);
            this.eyeConclusion.TabIndex = 1;
            this.eyeConclusion.Text = "0 Eyes Detected";
            // 
            // faceConclusion
            // 
            this.faceConclusion.AutoSize = true;
            this.faceConclusion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faceConclusion.Location = new System.Drawing.Point(33, 44);
            this.faceConclusion.Name = "faceConclusion";
            this.faceConclusion.Size = new System.Drawing.Size(112, 17);
            this.faceConclusion.TabIndex = 0;
            this.faceConclusion.Text = "0 Face Detected";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PatternRecognitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(882, 655);
            this.Controls.Add(this.conclusionBox);
            this.Controls.Add(this.modeBox2);
            this.Controls.Add(this.multiBtn);
            this.Controls.Add(this.pictBox4);
            this.Controls.Add(this.backLbl4);
            this.Name = "PatternRecognitionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pattern Recognition and Classification";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ObjectRecogForm_FormClosing);
            this.Load += new System.EventHandler(this.PatternRecogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictBox4)).EndInit();
            this.modeBox2.ResumeLayout(false);
            this.modeBox2.PerformLayout();
            this.conclusionBox.ResumeLayout(false);
            this.conclusionBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label backLbl4;
        private System.Windows.Forms.PictureBox pictBox4;
        private System.Windows.Forms.Button multiBtn;
        private System.Windows.Forms.GroupBox modeBox2;
        private System.Windows.Forms.CheckBox noseChk;
        private System.Windows.Forms.CheckBox eyeChk;
        private System.Windows.Forms.CheckBox faceChk;
        private System.Windows.Forms.GroupBox conclusionBox;
        private System.Windows.Forms.Label noseConclusion;
        private System.Windows.Forms.Label eyeConclusion;
        private System.Windows.Forms.Label faceConclusion;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer1;
    }
}