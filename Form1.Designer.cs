namespace CaseMakingComvis
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.title = new System.Windows.Forms.Label();
            this.improcBtn = new System.Windows.Forms.Button();
            this.edgeDetectBtn = new System.Windows.Forms.Button();
            this.shapeDetectBtn = new System.Windows.Forms.Button();
            this.prcBtn = new System.Windows.Forms.Button();
            this.imgDialog = new System.Windows.Forms.OpenFileDialog();
            this.vidDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.title.Location = new System.Drawing.Point(85, 40);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(147, 46);
            this.title.TabIndex = 0;
            this.title.Text = "Imagify";
            // 
            // improcBtn
            // 
            this.improcBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.improcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.improcBtn.ForeColor = System.Drawing.Color.Snow;
            this.improcBtn.Location = new System.Drawing.Point(67, 133);
            this.improcBtn.Name = "improcBtn";
            this.improcBtn.Size = new System.Drawing.Size(191, 37);
            this.improcBtn.TabIndex = 1;
            this.improcBtn.Text = "Image Processing";
            this.improcBtn.UseVisualStyleBackColor = false;
            this.improcBtn.Click += new System.EventHandler(this.improcBtn_Click);
            // 
            // edgeDetectBtn
            // 
            this.edgeDetectBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.edgeDetectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgeDetectBtn.ForeColor = System.Drawing.Color.Snow;
            this.edgeDetectBtn.Location = new System.Drawing.Point(67, 199);
            this.edgeDetectBtn.Name = "edgeDetectBtn";
            this.edgeDetectBtn.Size = new System.Drawing.Size(191, 37);
            this.edgeDetectBtn.TabIndex = 2;
            this.edgeDetectBtn.Text = "Edge Detection";
            this.edgeDetectBtn.UseVisualStyleBackColor = false;
            this.edgeDetectBtn.Click += new System.EventHandler(this.edgeDetectBtn_Click);
            // 
            // shapeDetectBtn
            // 
            this.shapeDetectBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.shapeDetectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapeDetectBtn.ForeColor = System.Drawing.Color.Snow;
            this.shapeDetectBtn.Location = new System.Drawing.Point(67, 266);
            this.shapeDetectBtn.Name = "shapeDetectBtn";
            this.shapeDetectBtn.Size = new System.Drawing.Size(191, 37);
            this.shapeDetectBtn.TabIndex = 3;
            this.shapeDetectBtn.Text = "Shape Detection";
            this.shapeDetectBtn.UseVisualStyleBackColor = false;
            this.shapeDetectBtn.Click += new System.EventHandler(this.shapeDetectBtn_Click);
            // 
            // prcBtn
            // 
            this.prcBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.prcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prcBtn.ForeColor = System.Drawing.Color.Snow;
            this.prcBtn.Location = new System.Drawing.Point(67, 334);
            this.prcBtn.Name = "prcBtn";
            this.prcBtn.Size = new System.Drawing.Size(191, 37);
            this.prcBtn.TabIndex = 4;
            this.prcBtn.Text = "Pattern Recognition and Classification";
            this.prcBtn.UseVisualStyleBackColor = false;
            this.prcBtn.Click += new System.EventHandler(this.prcBtn_Click);
            // 
            // imgDialog
            // 
            this.imgDialog.FileName = "openFileDialog1";
            // 
            // vidDialog
            // 
            this.vidDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(322, 448);
            this.Controls.Add(this.prcBtn);
            this.Controls.Add(this.shapeDetectBtn);
            this.Controls.Add(this.edgeDetectBtn);
            this.Controls.Add(this.improcBtn);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button improcBtn;
        private System.Windows.Forms.Button edgeDetectBtn;
        private System.Windows.Forms.Button shapeDetectBtn;
        private System.Windows.Forms.Button prcBtn;
        private System.Windows.Forms.OpenFileDialog imgDialog;
        private System.Windows.Forms.OpenFileDialog vidDialog;
    }
}

