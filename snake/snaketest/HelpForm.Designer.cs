namespace snaketest
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.applInf = new System.Windows.Forms.PictureBox();
            this.bonuspointInf = new System.Windows.Forms.PictureBox();
            this.ghostInf = new System.Windows.Forms.PictureBox();
            this.doublePointInfo = new System.Windows.Forms.PictureBox();
            this.applLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.applInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonuspointInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doublePointInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // applInf
            // 
            this.applInf.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.applInf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.applInf.Location = new System.Drawing.Point(12, 12);
            this.applInf.Name = "applInf";
            this.applInf.Size = new System.Drawing.Size(40, 40);
            this.applInf.TabIndex = 21;
            this.applInf.TabStop = false;
            this.applInf.Paint += new System.Windows.Forms.PaintEventHandler(this.ghostPow_Paint);
            // 
            // bonuspointInf
            // 
            this.bonuspointInf.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bonuspointInf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bonuspointInf.Location = new System.Drawing.Point(277, 176);
            this.bonuspointInf.Name = "bonuspointInf";
            this.bonuspointInf.Size = new System.Drawing.Size(40, 40);
            this.bonuspointInf.TabIndex = 22;
            this.bonuspointInf.TabStop = false;
            this.bonuspointInf.Paint += new System.Windows.Forms.PaintEventHandler(this.bonuspointInf_Paint);
            // 
            // ghostInf
            // 
            this.ghostInf.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ghostInf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ghostInf.Location = new System.Drawing.Point(277, 12);
            this.ghostInf.Name = "ghostInf";
            this.ghostInf.Size = new System.Drawing.Size(40, 40);
            this.ghostInf.TabIndex = 23;
            this.ghostInf.TabStop = false;
            this.ghostInf.Paint += new System.Windows.Forms.PaintEventHandler(this.ghostInf_Paint);
            // 
            // doublePointInfo
            // 
            this.doublePointInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.doublePointInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.doublePointInfo.Location = new System.Drawing.Point(12, 176);
            this.doublePointInfo.Name = "doublePointInfo";
            this.doublePointInfo.Size = new System.Drawing.Size(40, 40);
            this.doublePointInfo.TabIndex = 24;
            this.doublePointInfo.TabStop = false;
            this.doublePointInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.doublePointInfo_Paint);
            // 
            // applLabel
            // 
            this.applLabel.AutoSize = true;
            this.applLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.applLabel.Location = new System.Drawing.Point(12, 55);
            this.applLabel.Name = "applLabel";
            this.applLabel.Size = new System.Drawing.Size(257, 78);
            this.applLabel.TabIndex = 25;
            this.applLabel.Text = resources.GetString("applLabel.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 65);
            this.label1.TabIndex = 26;
            this.label1.Text = "This is the ghost powerup. When eaten, \r\nyour snake becomes a ghost. This \r\nallow" +
    "s your snake to go right through \r\nyour body without dying. But, watch\r\nout. Thi" +
    "s powerup only lasts 8 seconds!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(271, 170);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox4.Location = new System.Drawing.Point(272, 170);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(208, 187);
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 78);
            this.label2.TabIndex = 29;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(277, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 104);
            this.label3.TabIndex = 30;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 357);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.applLabel);
            this.Controls.Add(this.doublePointInfo);
            this.Controls.Add(this.ghostInf);
            this.Controls.Add(this.bonuspointInf);
            this.Controls.Add(this.applInf);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpForm";
            this.ShowInTaskbar = false;
            this.Text = "Help";
            ((System.ComponentModel.ISupportInitialize)(this.applInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonuspointInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doublePointInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox applInf;
        private System.Windows.Forms.PictureBox bonuspointInf;
        private System.Windows.Forms.PictureBox ghostInf;
        private System.Windows.Forms.PictureBox doublePointInfo;
        private System.Windows.Forms.Label applLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}