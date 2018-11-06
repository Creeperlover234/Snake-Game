namespace snaketest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.directionTimer = new System.Windows.Forms.Timer(this.components);
            this.foodEatTimer = new System.Windows.Forms.Timer(this.components);
            this.pointsLabel = new System.Windows.Forms.Label();
            this.gmovLabel = new System.Windows.Forms.Label();
            this.restartLabel = new System.Windows.Forms.Label();
            this.diffLabel = new System.Windows.Forms.Label();
            this.difEasy = new System.Windows.Forms.Label();
            this.difNorm = new System.Windows.Forms.Label();
            this.difHard = new System.Windows.Forms.Label();
            this.difExpert = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Label();
            this.pauseplayButton = new System.Windows.Forms.Label();
            this.powerupTimer = new System.Windows.Forms.Timer(this.components);
            this.ghostTimer = new System.Windows.Forms.Timer(this.components);
            this.gTimeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.doublepointTimer = new System.Windows.Forms.Timer(this.components);
            this.bonuspointTimer = new System.Windows.Forms.Timer(this.components);
            this.ghostTime = new System.Windows.Forms.Timer(this.components);
            this.dpTime = new System.Windows.Forms.Timer(this.components);
            this.bpTime = new System.Windows.Forms.Timer(this.components);
            this.dpTimeLabel = new System.Windows.Forms.Label();
            this.bpTimeLabel = new System.Windows.Forms.Label();
            this.bonusPow = new System.Windows.Forms.PictureBox();
            this.dpPow = new System.Windows.Forms.PictureBox();
            this.ghostPow = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.createdLabel = new System.Windows.Forms.Label();
            this.helpLabel = new System.Windows.Forms.Label();
            this.disPowerups = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.firstTime = new System.Windows.Forms.Timer(this.components);
            this.boundsLabel = new System.Windows.Forms.Label();
            this.outOfBoundTimer = new System.Windows.Forms.Timer(this.components);
            this.muteButton = new System.Windows.Forms.PictureBox();
            this.aiDirection = new System.Windows.Forms.Timer(this.components);
            this.aiEnabled = new System.Windows.Forms.Label();
            this.evilBallOn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bonusPow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpPow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostPow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muteButton)).BeginInit();
            this.SuspendLayout();
            // 
            // directionTimer
            // 
            this.directionTimer.Tick += new System.EventHandler(this.directionTimer_Tick);
            // 
            // foodEatTimer
            // 
            this.foodEatTimer.Tick += new System.EventHandler(this.foodEatTimer_Tick);
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pointsLabel.Location = new System.Drawing.Point(556, 24);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(136, 37);
            this.pointsLabel.TabIndex = 0;
            this.pointsLabel.Text = "Score: 0";
            // 
            // gmovLabel
            // 
            this.gmovLabel.BackColor = System.Drawing.Color.Black;
            this.gmovLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 69.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmovLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.gmovLabel.Location = new System.Drawing.Point(14, 106);
            this.gmovLabel.Name = "gmovLabel";
            this.gmovLabel.Size = new System.Drawing.Size(540, 110);
            this.gmovLabel.TabIndex = 1;
            this.gmovLabel.Text = "Game Over\r\n";
            this.gmovLabel.Visible = false;
            // 
            // restartLabel
            // 
            this.restartLabel.AutoSize = true;
            this.restartLabel.BackColor = System.Drawing.Color.Black;
            this.restartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.restartLabel.Location = new System.Drawing.Point(149, 216);
            this.restartLabel.Name = "restartLabel";
            this.restartLabel.Size = new System.Drawing.Size(213, 25);
            this.restartLabel.TabIndex = 2;
            this.restartLabel.Text = "Press enter to restart";
            this.restartLabel.Visible = false;
            // 
            // diffLabel
            // 
            this.diffLabel.AutoSize = true;
            this.diffLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diffLabel.Location = new System.Drawing.Point(558, 78);
            this.diffLabel.Name = "diffLabel";
            this.diffLabel.Size = new System.Drawing.Size(100, 25);
            this.diffLabel.TabIndex = 4;
            this.diffLabel.Text = "Difficulty:";
            // 
            // difEasy
            // 
            this.difEasy.AutoSize = true;
            this.difEasy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.difEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difEasy.Location = new System.Drawing.Point(559, 103);
            this.difEasy.Name = "difEasy";
            this.difEasy.Size = new System.Drawing.Size(44, 20);
            this.difEasy.TabIndex = 5;
            this.difEasy.Text = "Easy";
            this.difEasy.Click += new System.EventHandler(this.difEasy_Click);
            // 
            // difNorm
            // 
            this.difNorm.AutoSize = true;
            this.difNorm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.difNorm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difNorm.Location = new System.Drawing.Point(609, 103);
            this.difNorm.Name = "difNorm";
            this.difNorm.Size = new System.Drawing.Size(59, 20);
            this.difNorm.TabIndex = 6;
            this.difNorm.Text = "Normal";
            this.difNorm.Click += new System.EventHandler(this.difNorm_Click);
            // 
            // difHard
            // 
            this.difHard.AutoSize = true;
            this.difHard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.difHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difHard.Location = new System.Drawing.Point(674, 103);
            this.difHard.Name = "difHard";
            this.difHard.Size = new System.Drawing.Size(44, 20);
            this.difHard.TabIndex = 7;
            this.difHard.Text = "Hard";
            this.difHard.Click += new System.EventHandler(this.difHard_Click);
            // 
            // difExpert
            // 
            this.difExpert.AutoSize = true;
            this.difExpert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.difExpert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difExpert.Location = new System.Drawing.Point(724, 103);
            this.difExpert.Name = "difExpert";
            this.difExpert.Size = new System.Drawing.Size(55, 20);
            this.difExpert.TabIndex = 8;
            this.difExpert.Text = "Expert";
            this.difExpert.Click += new System.EventHandler(this.difExpert_Click);
            // 
            // restartButton
            // 
            this.restartButton.AutoSize = true;
            this.restartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.Location = new System.Drawing.Point(556, 305);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(103, 31);
            this.restartButton.TabIndex = 15;
            this.restartButton.Text = "Restart";
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // pauseplayButton
            // 
            this.pauseplayButton.AutoSize = true;
            this.pauseplayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pauseplayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseplayButton.Location = new System.Drawing.Point(679, 305);
            this.pauseplayButton.Name = "pauseplayButton";
            this.pauseplayButton.Size = new System.Drawing.Size(91, 31);
            this.pauseplayButton.TabIndex = 16;
            this.pauseplayButton.Text = "Pause";
            this.pauseplayButton.Click += new System.EventHandler(this.pauseplayButton_Click);
            // 
            // powerupTimer
            // 
            this.powerupTimer.Interval = 20000;
            this.powerupTimer.Tick += new System.EventHandler(this.collisionTimer_Tick);
            // 
            // ghostTimer
            // 
            this.ghostTimer.Interval = 8000;
            this.ghostTimer.Tick += new System.EventHandler(this.testtimer_Tick);
            // 
            // gTimeLabel
            // 
            this.gTimeLabel.AutoSize = true;
            this.gTimeLabel.Location = new System.Drawing.Point(570, 244);
            this.gTimeLabel.Name = "gTimeLabel";
            this.gTimeLabel.Size = new System.Drawing.Size(0, 13);
            this.gTimeLabel.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(562, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Active Powerups:";
            // 
            // doublepointTimer
            // 
            this.doublepointTimer.Interval = 10000;
            this.doublepointTimer.Tick += new System.EventHandler(this.doublepointTimer_Tick);
            // 
            // bonuspointTimer
            // 
            this.bonuspointTimer.Interval = 15000;
            this.bonuspointTimer.Tick += new System.EventHandler(this.bonuspointTimer_Tick);
            // 
            // ghostTime
            // 
            this.ghostTime.Interval = 1000;
            this.ghostTime.Tick += new System.EventHandler(this.ghostTime_Tick);
            // 
            // dpTime
            // 
            this.dpTime.Interval = 1000;
            this.dpTime.Tick += new System.EventHandler(this.dpTime_Tick);
            // 
            // bpTime
            // 
            this.bpTime.Interval = 1000;
            this.bpTime.Tick += new System.EventHandler(this.bpTime_Tick);
            // 
            // dpTimeLabel
            // 
            this.dpTimeLabel.AutoSize = true;
            this.dpTimeLabel.Location = new System.Drawing.Point(641, 244);
            this.dpTimeLabel.Name = "dpTimeLabel";
            this.dpTimeLabel.Size = new System.Drawing.Size(0, 13);
            this.dpTimeLabel.TabIndex = 23;
            // 
            // bpTimeLabel
            // 
            this.bpTimeLabel.AutoSize = true;
            this.bpTimeLabel.Location = new System.Drawing.Point(712, 244);
            this.bpTimeLabel.Name = "bpTimeLabel";
            this.bpTimeLabel.Size = new System.Drawing.Size(0, 13);
            this.bpTimeLabel.TabIndex = 24;
            // 
            // bonusPow
            // 
            this.bonusPow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bonusPow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bonusPow.Location = new System.Drawing.Point(709, 201);
            this.bonusPow.Name = "bonusPow";
            this.bonusPow.Size = new System.Drawing.Size(40, 40);
            this.bonusPow.TabIndex = 22;
            this.bonusPow.TabStop = false;
            this.bonusPow.Paint += new System.Windows.Forms.PaintEventHandler(this.bonusPow_Paint);
            // 
            // dpPow
            // 
            this.dpPow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dpPow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dpPow.Location = new System.Drawing.Point(638, 201);
            this.dpPow.Name = "dpPow";
            this.dpPow.Size = new System.Drawing.Size(40, 40);
            this.dpPow.TabIndex = 21;
            this.dpPow.TabStop = false;
            this.dpPow.Paint += new System.Windows.Forms.PaintEventHandler(this.dpPow_Paint);
            // 
            // ghostPow
            // 
            this.ghostPow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ghostPow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ghostPow.Location = new System.Drawing.Point(567, 201);
            this.ghostPow.Name = "ghostPow";
            this.ghostPow.Size = new System.Drawing.Size(40, 40);
            this.ghostPow.TabIndex = 20;
            this.ghostPow.TabStop = false;
            this.ghostPow.Paint += new System.Windows.Forms.PaintEventHandler(this.ghostPow_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 544);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // createdLabel
            // 
            this.createdLabel.AutoSize = true;
            this.createdLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.createdLabel.Location = new System.Drawing.Point(606, 547);
            this.createdLabel.Name = "createdLabel";
            this.createdLabel.Size = new System.Drawing.Size(125, 13);
            this.createdLabel.TabIndex = 25;
            this.createdLabel.Text = "Created by Carson Kelley";
            this.createdLabel.Click += new System.EventHandler(this.createdLabel_Click);
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpLabel.Location = new System.Drawing.Point(739, 3);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(42, 20);
            this.helpLabel.TabIndex = 26;
            this.helpLabel.Text = "Help";
            this.helpLabel.Click += new System.EventHandler(this.helpLabel_Click);
            // 
            // disPowerups
            // 
            this.disPowerups.AutoSize = true;
            this.disPowerups.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disPowerups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disPowerups.Location = new System.Drawing.Point(559, 368);
            this.disPowerups.Name = "disPowerups";
            this.disPowerups.Size = new System.Drawing.Size(113, 20);
            this.disPowerups.TabIndex = 27;
            this.disPowerups.Text = "Powerups - On";
            this.disPowerups.Click += new System.EventHandler(this.disPowerups_Click);
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthLabel.Location = new System.Drawing.Point(562, 132);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(84, 25);
            this.lengthLabel.TabIndex = 28;
            this.lengthLabel.Text = "Length:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(560, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(560, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(560, 506);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(635, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(635, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(635, 414);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(635, 461);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(635, 483);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(635, 506);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 40;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(560, 527);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 41;
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.AutoSize = true;
            this.highScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreLabel.Location = new System.Drawing.Point(561, 257);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(178, 31);
            this.highScoreLabel.TabIndex = 42;
            this.highScoreLabel.Text = "High Score: 0";
            // 
            // firstTime
            // 
            this.firstTime.Tick += new System.EventHandler(this.firstTime_Tick);
            // 
            // boundsLabel
            // 
            this.boundsLabel.AutoSize = true;
            this.boundsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boundsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boundsLabel.Location = new System.Drawing.Point(681, 368);
            this.boundsLabel.Name = "boundsLabel";
            this.boundsLabel.Size = new System.Drawing.Size(98, 20);
            this.boundsLabel.TabIndex = 43;
            this.boundsLabel.Text = "Bounds - On";
            this.boundsLabel.Click += new System.EventHandler(this.boundsLabel_Click);
            // 
            // outOfBoundTimer
            // 
            this.outOfBoundTimer.Interval = 110;
            this.outOfBoundTimer.Tick += new System.EventHandler(this.outOfBoundTimer_Tick);
            // 
            // muteButton
            // 
            this.muteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.muteButton.Location = new System.Drawing.Point(562, 521);
            this.muteButton.Name = "muteButton";
            this.muteButton.Size = new System.Drawing.Size(32, 32);
            this.muteButton.TabIndex = 44;
            this.muteButton.TabStop = false;
            this.muteButton.Click += new System.EventHandler(this.muteButton_Click);
            // 
            // aiDirection
            // 
            this.aiDirection.Interval = 150;
            this.aiDirection.Tick += new System.EventHandler(this.aiDirection_Tick);
            // 
            // aiEnabled
            // 
            this.aiEnabled.AutoSize = true;
            this.aiEnabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aiEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiEnabled.Location = new System.Drawing.Point(559, 404);
            this.aiEnabled.Name = "aiEnabled";
            this.aiEnabled.Size = new System.Drawing.Size(113, 20);
            this.aiEnabled.TabIndex = 45;
            this.aiEnabled.Text = "AI Enemy - Off";
            this.aiEnabled.Click += new System.EventHandler(this.aiEnabled_Click);
            // 
            // evilBallOn
            // 
            this.evilBallOn.AutoSize = true;
            this.evilBallOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.evilBallOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evilBallOn.Location = new System.Drawing.Point(681, 404);
            this.evilBallOn.Name = "evilBallOn";
            this.evilBallOn.Size = new System.Drawing.Size(98, 20);
            this.evilBallOn.TabIndex = 46;
            this.evilBallOn.Text = "Evil Ball - Off";
            this.evilBallOn.Click += new System.EventHandler(this.evilBallOn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.evilBallOn);
            this.Controls.Add(this.aiEnabled);
            this.Controls.Add(this.muteButton);
            this.Controls.Add(this.boundsLabel);
            this.Controls.Add(this.highScoreLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.disPowerups);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.createdLabel);
            this.Controls.Add(this.bpTimeLabel);
            this.Controls.Add(this.dpTimeLabel);
            this.Controls.Add(this.bonusPow);
            this.Controls.Add(this.dpPow);
            this.Controls.Add(this.ghostPow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gTimeLabel);
            this.Controls.Add(this.pauseplayButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.difExpert);
            this.Controls.Add(this.difHard);
            this.Controls.Add(this.difNorm);
            this.Controls.Add(this.difEasy);
            this.Controls.Add(this.diffLabel);
            this.Controls.Add(this.gmovLabel);
            this.Controls.Add(this.restartLabel);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bonusPow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpPow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostPow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muteButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer directionTimer;
        private System.Windows.Forms.Timer foodEatTimer;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Label gmovLabel;
        private System.Windows.Forms.Label restartLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label diffLabel;
        private System.Windows.Forms.Label difEasy;
        private System.Windows.Forms.Label difNorm;
        private System.Windows.Forms.Label difHard;
        private System.Windows.Forms.Label difExpert;
        private System.Windows.Forms.Label restartButton;
        private System.Windows.Forms.Label pauseplayButton;
        private System.Windows.Forms.Timer powerupTimer;
        private System.Windows.Forms.Timer ghostTimer;
        private System.Windows.Forms.Label gTimeLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox ghostPow;
        private System.Windows.Forms.PictureBox dpPow;
        private System.Windows.Forms.PictureBox bonusPow;
        private System.Windows.Forms.Timer doublepointTimer;
        private System.Windows.Forms.Timer bonuspointTimer;
        private System.Windows.Forms.Timer ghostTime;
        private System.Windows.Forms.Timer dpTime;
        private System.Windows.Forms.Timer bpTime;
        private System.Windows.Forms.Label dpTimeLabel;
        private System.Windows.Forms.Label bpTimeLabel;
        private System.Windows.Forms.Label createdLabel;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.Label disPowerups;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label highScoreLabel;
        private System.Windows.Forms.Timer firstTime;
        private System.Windows.Forms.Label boundsLabel;
        private System.Windows.Forms.Timer outOfBoundTimer;
        private System.Windows.Forms.PictureBox muteButton;
        private System.Windows.Forms.Timer aiDirection;
        private System.Windows.Forms.Label aiEnabled;
        private System.Windows.Forms.Label evilBallOn;
    }
}

