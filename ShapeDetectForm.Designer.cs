namespace CaseMakingComvis
{
    partial class ShapeDetectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShapeDetectForm));
            this.backLbl2 = new System.Windows.Forms.Label();
            this.pictBox3 = new System.Windows.Forms.PictureBox();
            this.saveBtn3 = new System.Windows.Forms.Button();
            this.modeBox3 = new System.Windows.Forms.GroupBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.squareChk = new System.Windows.Forms.CheckBox();
            this.triangleChk = new System.Windows.Forms.CheckBox();
            this.circleChk = new System.Windows.Forms.CheckBox();
            this.shapeDetectBtn = new System.Windows.Forms.Button();
            this.lineChk = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox3)).BeginInit();
            this.modeBox3.SuspendLayout();
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
            this.backLbl2.TabIndex = 3;
            this.backLbl2.Text = "< Back";
            this.backLbl2.Click += new System.EventHandler(this.backLbl2_Click);
            // 
            // pictBox3
            // 
            this.pictBox3.Location = new System.Drawing.Point(114, 53);
            this.pictBox3.Name = "pictBox3";
            this.pictBox3.Size = new System.Drawing.Size(540, 380);
            this.pictBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBox3.TabIndex = 4;
            this.pictBox3.TabStop = false;
            // 
            // saveBtn3
            // 
            this.saveBtn3.BackColor = System.Drawing.SystemColors.WindowText;
            this.saveBtn3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveBtn3.Location = new System.Drawing.Point(322, 439);
            this.saveBtn3.Name = "saveBtn3";
            this.saveBtn3.Size = new System.Drawing.Size(128, 35);
            this.saveBtn3.TabIndex = 5;
            this.saveBtn3.Text = "Save";
            this.saveBtn3.UseVisualStyleBackColor = false;
            this.saveBtn3.Click += new System.EventHandler(this.saveBtn3_Click);
            // 
            // modeBox3
            // 
            this.modeBox3.BackColor = System.Drawing.Color.Transparent;
            this.modeBox3.Controls.Add(this.resetBtn);
            this.modeBox3.Controls.Add(this.squareChk);
            this.modeBox3.Controls.Add(this.triangleChk);
            this.modeBox3.Controls.Add(this.circleChk);
            this.modeBox3.Controls.Add(this.shapeDetectBtn);
            this.modeBox3.Controls.Add(this.lineChk);
            this.modeBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.modeBox3.Location = new System.Drawing.Point(114, 494);
            this.modeBox3.Name = "modeBox3";
            this.modeBox3.Size = new System.Drawing.Size(540, 140);
            this.modeBox3.TabIndex = 6;
            this.modeBox3.TabStop = false;
            this.modeBox3.Text = "Shape to Detect";
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.SystemColors.WindowText;
            this.resetBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resetBtn.Location = new System.Drawing.Point(148, 83);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(118, 35);
            this.resetBtn.TabIndex = 12;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // squareChk
            // 
            this.squareChk.AutoSize = true;
            this.squareChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squareChk.Location = new System.Drawing.Point(394, 35);
            this.squareChk.Name = "squareChk";
            this.squareChk.Size = new System.Drawing.Size(91, 21);
            this.squareChk.TabIndex = 11;
            this.squareChk.Text = "Rectangle";
            this.squareChk.UseVisualStyleBackColor = true;
            this.squareChk.CheckedChanged += new System.EventHandler(this.squareChk_CheckedChanged);
            // 
            // triangleChk
            // 
            this.triangleChk.AutoSize = true;
            this.triangleChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triangleChk.Location = new System.Drawing.Point(283, 35);
            this.triangleChk.Name = "triangleChk";
            this.triangleChk.Size = new System.Drawing.Size(79, 21);
            this.triangleChk.TabIndex = 10;
            this.triangleChk.Text = "Triangle";
            this.triangleChk.UseVisualStyleBackColor = true;
            this.triangleChk.CheckedChanged += new System.EventHandler(this.triangleChk_CheckedChanged);
            // 
            // circleChk
            // 
            this.circleChk.AutoSize = true;
            this.circleChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleChk.Location = new System.Drawing.Point(173, 35);
            this.circleChk.Name = "circleChk";
            this.circleChk.Size = new System.Drawing.Size(62, 21);
            this.circleChk.TabIndex = 9;
            this.circleChk.Text = "Circle";
            this.circleChk.UseVisualStyleBackColor = true;
            this.circleChk.CheckedChanged += new System.EventHandler(this.circleChk_CheckedChanged);
            // 
            // shapeDetectBtn
            // 
            this.shapeDetectBtn.BackColor = System.Drawing.SystemColors.WindowText;
            this.shapeDetectBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.shapeDetectBtn.Location = new System.Drawing.Point(283, 83);
            this.shapeDetectBtn.Name = "shapeDetectBtn";
            this.shapeDetectBtn.Size = new System.Drawing.Size(118, 35);
            this.shapeDetectBtn.TabIndex = 7;
            this.shapeDetectBtn.Text = "Process";
            this.shapeDetectBtn.UseVisualStyleBackColor = false;
            this.shapeDetectBtn.Click += new System.EventHandler(this.shapeDetectBtn_Click);
            // 
            // lineChk
            // 
            this.lineChk.AutoSize = true;
            this.lineChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineChk.Location = new System.Drawing.Point(61, 35);
            this.lineChk.Name = "lineChk";
            this.lineChk.Size = new System.Drawing.Size(54, 21);
            this.lineChk.TabIndex = 8;
            this.lineChk.Text = "Line";
            this.lineChk.UseVisualStyleBackColor = true;
            this.lineChk.CheckedChanged += new System.EventHandler(this.lineChk_CheckedChanged);
            // 
            // ShapeDetectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(764, 657);
            this.Controls.Add(this.modeBox3);
            this.Controls.Add(this.saveBtn3);
            this.Controls.Add(this.pictBox3);
            this.Controls.Add(this.backLbl2);
            this.Name = "ShapeDetectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shape Detection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShapeDetectForm_FormClosing);
            this.Load += new System.EventHandler(this.ShapeDetectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictBox3)).EndInit();
            this.modeBox3.ResumeLayout(false);
            this.modeBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label backLbl2;
        private System.Windows.Forms.PictureBox pictBox3;
        private System.Windows.Forms.Button saveBtn3;
        private System.Windows.Forms.GroupBox modeBox3;
        private System.Windows.Forms.Button shapeDetectBtn;
        private System.Windows.Forms.CheckBox squareChk;
        private System.Windows.Forms.CheckBox triangleChk;
        private System.Windows.Forms.CheckBox circleChk;
        private System.Windows.Forms.CheckBox lineChk;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}