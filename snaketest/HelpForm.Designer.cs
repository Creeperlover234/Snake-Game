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
            this.slowdownTimeBox = new System.Windows.Forms.PictureBox();
            this.itemButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.controlsButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.infoBox1 = new MaterialSkin.Controls.MaterialLabel();
            this.infoBox2 = new MaterialSkin.Controls.MaterialLabel();
            this.page1button = new MaterialSkin.Controls.MaterialFlatButton();
            this.page2button = new MaterialSkin.Controls.MaterialFlatButton();
            this.page3button = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.controlLabel = new MaterialSkin.Controls.MaterialLabel();
            this.buttonWimage = new System.Windows.Forms.PictureBox();
            this.buttonAimage = new System.Windows.Forms.PictureBox();
            this.buttonSimage = new System.Windows.Forms.PictureBox();
            this.buttonDimage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.applInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonuspointInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doublePointInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slowdownTimeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonWimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDimage)).BeginInit();
            this.SuspendLayout();
            // 
            // applInf
            // 
            this.applInf.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.applInf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.applInf.Location = new System.Drawing.Point(145, 75);
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
            this.bonuspointInf.Location = new System.Drawing.Point(472, 110);
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
            this.ghostInf.Location = new System.Drawing.Point(145, 242);
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
            this.doublePointInfo.Location = new System.Drawing.Point(472, 156);
            this.doublePointInfo.Name = "doublePointInfo";
            this.doublePointInfo.Size = new System.Drawing.Size(40, 40);
            this.doublePointInfo.TabIndex = 24;
            this.doublePointInfo.TabStop = false;
            this.doublePointInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.doublePointInfo_Paint);
            // 
            // slowdownTimeBox
            // 
            this.slowdownTimeBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.slowdownTimeBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.slowdownTimeBox.Location = new System.Drawing.Point(472, 64);
            this.slowdownTimeBox.Name = "slowdownTimeBox";
            this.slowdownTimeBox.Size = new System.Drawing.Size(40, 40);
            this.slowdownTimeBox.TabIndex = 32;
            this.slowdownTimeBox.TabStop = false;
            this.slowdownTimeBox.Paint += new System.Windows.Forms.PaintEventHandler(this.slowdownTimeBox_Paint);
            // 
            // itemButton
            // 
            this.itemButton.AutoSize = true;
            this.itemButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.itemButton.Depth = 0;
            this.itemButton.Icon = null;
            this.itemButton.Location = new System.Drawing.Point(9, 81);
            this.itemButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.itemButton.Name = "itemButton";
            this.itemButton.Primary = true;
            this.itemButton.Size = new System.Drawing.Size(61, 36);
            this.itemButton.TabIndex = 35;
            this.itemButton.Text = "Items";
            this.itemButton.UseVisualStyleBackColor = true;
            this.itemButton.Click += new System.EventHandler(this.itemButton_Click);
            // 
            // controlsButton
            // 
            this.controlsButton.AutoSize = true;
            this.controlsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.controlsButton.Depth = 0;
            this.controlsButton.Icon = null;
            this.controlsButton.Location = new System.Drawing.Point(9, 123);
            this.controlsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.controlsButton.Name = "controlsButton";
            this.controlsButton.Primary = true;
            this.controlsButton.Size = new System.Drawing.Size(91, 36);
            this.controlsButton.TabIndex = 36;
            this.controlsButton.Text = "Controls";
            this.controlsButton.UseVisualStyleBackColor = true;
            this.controlsButton.Click += new System.EventHandler(this.controlsButton_Click);
            // 
            // infoBox1
            // 
            this.infoBox1.AutoSize = true;
            this.infoBox1.Depth = 0;
            this.infoBox1.Font = new System.Drawing.Font("Roboto", 11F);
            this.infoBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.infoBox1.Location = new System.Drawing.Point(140, 118);
            this.infoBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.infoBox1.Name = "infoBox1";
            this.infoBox1.Size = new System.Drawing.Size(372, 114);
            this.infoBox1.TabIndex = 37;
            this.infoBox1.Text = resources.GetString("infoBox1.Text");
            // 
            // infoBox2
            // 
            this.infoBox2.AutoSize = true;
            this.infoBox2.Depth = 0;
            this.infoBox2.Font = new System.Drawing.Font("Roboto", 11F);
            this.infoBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.infoBox2.Location = new System.Drawing.Point(140, 285);
            this.infoBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.infoBox2.Name = "infoBox2";
            this.infoBox2.Size = new System.Drawing.Size(352, 95);
            this.infoBox2.TabIndex = 38;
            this.infoBox2.Text = resources.GetString("infoBox2.Text");
            // 
            // page1button
            // 
            this.page1button.AutoSize = true;
            this.page1button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.page1button.Depth = 0;
            this.page1button.Icon = null;
            this.page1button.Location = new System.Drawing.Point(409, 64);
            this.page1button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.page1button.MouseState = MaterialSkin.MouseState.HOVER;
            this.page1button.Name = "page1button";
            this.page1button.Primary = false;
            this.page1button.Size = new System.Drawing.Size(29, 36);
            this.page1button.TabIndex = 39;
            this.page1button.Text = "1";
            this.page1button.UseVisualStyleBackColor = true;
            this.page1button.Click += new System.EventHandler(this.page1button_Click);
            // 
            // page2button
            // 
            this.page2button.AutoSize = true;
            this.page2button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.page2button.Depth = 0;
            this.page2button.Icon = null;
            this.page2button.Location = new System.Drawing.Point(446, 64);
            this.page2button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.page2button.MouseState = MaterialSkin.MouseState.HOVER;
            this.page2button.Name = "page2button";
            this.page2button.Primary = false;
            this.page2button.Size = new System.Drawing.Size(29, 36);
            this.page2button.TabIndex = 40;
            this.page2button.Text = "2";
            this.page2button.UseVisualStyleBackColor = true;
            this.page2button.Click += new System.EventHandler(this.page2button_Click);
            // 
            // page3button
            // 
            this.page3button.AutoSize = true;
            this.page3button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.page3button.Depth = 0;
            this.page3button.Icon = null;
            this.page3button.Location = new System.Drawing.Point(483, 64);
            this.page3button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.page3button.MouseState = MaterialSkin.MouseState.HOVER;
            this.page3button.Name = "page3button";
            this.page3button.Primary = false;
            this.page3button.Size = new System.Drawing.Size(29, 36);
            this.page3button.TabIndex = 41;
            this.page3button.Text = "3";
            this.page3button.UseVisualStyleBackColor = true;
            this.page3button.Click += new System.EventHandler(this.page3Button_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(109, 64);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(24, 345);
            this.materialDivider1.TabIndex = 42;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // controlLabel
            // 
            this.controlLabel.AutoSize = true;
            this.controlLabel.Depth = 0;
            this.controlLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.controlLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.controlLabel.Location = new System.Drawing.Point(-144, 358);
            this.controlLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.controlLabel.Name = "controlLabel";
            this.controlLabel.Size = new System.Drawing.Size(247, 171);
            this.controlLabel.TabIndex = 43;
            this.controlLabel.Text = resources.GetString("controlLabel.Text");
            // 
            // buttonWimage
            // 
            this.buttonWimage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonWimage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.buttonWimage.Location = new System.Drawing.Point(310, 72);
            this.buttonWimage.Name = "buttonWimage";
            this.buttonWimage.Size = new System.Drawing.Size(40, 40);
            this.buttonWimage.TabIndex = 44;
            this.buttonWimage.TabStop = false;
            this.buttonWimage.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonWimage_Paint);
            // 
            // buttonAimage
            // 
            this.buttonAimage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAimage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.buttonAimage.Location = new System.Drawing.Point(264, 118);
            this.buttonAimage.Name = "buttonAimage";
            this.buttonAimage.Size = new System.Drawing.Size(40, 40);
            this.buttonAimage.TabIndex = 45;
            this.buttonAimage.TabStop = false;
            this.buttonAimage.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonAimage_Paint);
            // 
            // buttonSimage
            // 
            this.buttonSimage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSimage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.buttonSimage.Location = new System.Drawing.Point(310, 118);
            this.buttonSimage.Name = "buttonSimage";
            this.buttonSimage.Size = new System.Drawing.Size(40, 40);
            this.buttonSimage.TabIndex = 46;
            this.buttonSimage.TabStop = false;
            this.buttonSimage.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonSimage_Paint);
            // 
            // buttonDimage
            // 
            this.buttonDimage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDimage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.buttonDimage.Location = new System.Drawing.Point(357, 118);
            this.buttonDimage.Name = "buttonDimage";
            this.buttonDimage.Size = new System.Drawing.Size(40, 40);
            this.buttonDimage.TabIndex = 47;
            this.buttonDimage.TabStop = false;
            this.buttonDimage.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonDimage_Paint);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 405);
            this.Controls.Add(this.buttonDimage);
            this.Controls.Add(this.buttonSimage);
            this.Controls.Add(this.buttonAimage);
            this.Controls.Add(this.buttonWimage);
            this.Controls.Add(this.controlLabel);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.page3button);
            this.Controls.Add(this.page2button);
            this.Controls.Add(this.page1button);
            this.Controls.Add(this.infoBox2);
            this.Controls.Add(this.infoBox1);
            this.Controls.Add(this.controlsButton);
            this.Controls.Add(this.itemButton);
            this.Controls.Add(this.slowdownTimeBox);
            this.Controls.Add(this.doublePointInfo);
            this.Controls.Add(this.ghostInf);
            this.Controls.Add(this.bonuspointInf);
            this.Controls.Add(this.applInf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpForm";
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.Text = "Help";
            ((System.ComponentModel.ISupportInitialize)(this.applInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonuspointInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doublePointInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slowdownTimeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonWimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox applInf;
        private System.Windows.Forms.PictureBox bonuspointInf;
        private System.Windows.Forms.PictureBox ghostInf;
        private System.Windows.Forms.PictureBox doublePointInfo;
        private System.Windows.Forms.PictureBox slowdownTimeBox;
        private MaterialSkin.Controls.MaterialRaisedButton itemButton;
        private MaterialSkin.Controls.MaterialRaisedButton controlsButton;
        private MaterialSkin.Controls.MaterialLabel infoBox1;
        private MaterialSkin.Controls.MaterialLabel infoBox2;
        private MaterialSkin.Controls.MaterialFlatButton page1button;
        private MaterialSkin.Controls.MaterialFlatButton page2button;
        private MaterialSkin.Controls.MaterialFlatButton page3button;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel controlLabel;
        private System.Windows.Forms.PictureBox buttonWimage;
        private System.Windows.Forms.PictureBox buttonAimage;
        private System.Windows.Forms.PictureBox buttonSimage;
        private System.Windows.Forms.PictureBox buttonDimage;
    }
}