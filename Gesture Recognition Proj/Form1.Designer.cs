namespace Gesture_Recognition_Proj
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.oneFingerPath = new System.Windows.Forms.TextBox();
            this.fiveFingerIcon = new System.Windows.Forms.PictureBox();
            this.fourFingerIcon = new System.Windows.Forms.PictureBox();
            this.threeFingerIcon = new System.Windows.Forms.PictureBox();
            this.twoFingerIcon = new System.Windows.Forms.PictureBox();
            this.oneFingerIcon = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fiveFingerPath = new System.Windows.Forms.TextBox();
            this.fourFingerPath = new System.Windows.Forms.TextBox();
            this.threeFingerPath = new System.Windows.Forms.TextBox();
            this.twoFingerPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.imageBoxCamera = new Emgu.CV.UI.ImageBox();
            this.imageBoxSkin = new Emgu.CV.UI.ImageBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.debugUnfiltFing = new System.Windows.Forms.Label();
            this.debugFingers = new System.Windows.Forms.Label();
            this.debugAdditional = new System.Windows.Forms.CheckBox();
            this.debugFingerTrack = new System.Windows.Forms.CheckBox();
            this.debugHull = new System.Windows.Forms.CheckBox();
            this.debugContour = new System.Windows.Forms.CheckBox();
            this.additionalNfo = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.notifyIcon3 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiveFingerIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourFingerIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threeFingerIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoFingerIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneFingerIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxSkin)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "One finger";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.oneFingerPath);
            this.groupBox1.Controls.Add(this.fiveFingerIcon);
            this.groupBox1.Controls.Add(this.fourFingerIcon);
            this.groupBox1.Controls.Add(this.threeFingerIcon);
            this.groupBox1.Controls.Add(this.twoFingerIcon);
            this.groupBox1.Controls.Add(this.oneFingerIcon);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.fiveFingerPath);
            this.groupBox1.Controls.Add(this.fourFingerPath);
            this.groupBox1.Controls.Add(this.threeFingerPath);
            this.groupBox1.Controls.Add(this.twoFingerPath);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 511);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 176);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gesture Configuration";
            // 
            // oneFingerPath
            // 
            this.oneFingerPath.Enabled = false;
            this.oneFingerPath.Location = new System.Drawing.Point(209, 26);
            this.oneFingerPath.Name = "oneFingerPath";
            this.oneFingerPath.Size = new System.Drawing.Size(344, 20);
            this.oneFingerPath.TabIndex = 34;
            // 
            // fiveFingerIcon
            // 
            this.fiveFingerIcon.Location = new System.Drawing.Point(109, 141);
            this.fiveFingerIcon.Name = "fiveFingerIcon";
            this.fiveFingerIcon.Size = new System.Drawing.Size(28, 28);
            this.fiveFingerIcon.TabIndex = 33;
            this.fiveFingerIcon.TabStop = false;
            // 
            // fourFingerIcon
            // 
            this.fourFingerIcon.Location = new System.Drawing.Point(109, 111);
            this.fourFingerIcon.Name = "fourFingerIcon";
            this.fourFingerIcon.Size = new System.Drawing.Size(28, 28);
            this.fourFingerIcon.TabIndex = 32;
            this.fourFingerIcon.TabStop = false;
            // 
            // threeFingerIcon
            // 
            this.threeFingerIcon.Location = new System.Drawing.Point(109, 81);
            this.threeFingerIcon.Name = "threeFingerIcon";
            this.threeFingerIcon.Size = new System.Drawing.Size(28, 28);
            this.threeFingerIcon.TabIndex = 31;
            this.threeFingerIcon.TabStop = false;
            // 
            // twoFingerIcon
            // 
            this.twoFingerIcon.Location = new System.Drawing.Point(109, 50);
            this.twoFingerIcon.Name = "twoFingerIcon";
            this.twoFingerIcon.Size = new System.Drawing.Size(28, 28);
            this.twoFingerIcon.TabIndex = 30;
            this.twoFingerIcon.TabStop = false;
            // 
            // oneFingerIcon
            // 
            this.oneFingerIcon.Location = new System.Drawing.Point(109, 19);
            this.oneFingerIcon.Name = "oneFingerIcon";
            this.oneFingerIcon.Size = new System.Drawing.Size(28, 28);
            this.oneFingerIcon.TabIndex = 29;
            this.oneFingerIcon.TabStop = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(559, 115);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 28;
            this.button6.Text = "Select  App";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(559, 145);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 27;
            this.button5.Text = "Select  App";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(559, 85);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Select  App";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(559, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Select  App";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Select  App";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(151, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Exe path:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(151, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Exe path:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(151, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Exe path:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Exe path:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Exe path:";
            // 
            // fiveFingerPath
            // 
            this.fiveFingerPath.Enabled = false;
            this.fiveFingerPath.Location = new System.Drawing.Point(209, 147);
            this.fiveFingerPath.Name = "fiveFingerPath";
            this.fiveFingerPath.Size = new System.Drawing.Size(344, 20);
            this.fiveFingerPath.TabIndex = 16;
            // 
            // fourFingerPath
            // 
            this.fourFingerPath.Enabled = false;
            this.fourFingerPath.Location = new System.Drawing.Point(209, 117);
            this.fourFingerPath.Name = "fourFingerPath";
            this.fourFingerPath.Size = new System.Drawing.Size(344, 20);
            this.fourFingerPath.TabIndex = 15;
            // 
            // threeFingerPath
            // 
            this.threeFingerPath.Enabled = false;
            this.threeFingerPath.Location = new System.Drawing.Point(209, 87);
            this.threeFingerPath.Name = "threeFingerPath";
            this.threeFingerPath.Size = new System.Drawing.Size(344, 20);
            this.threeFingerPath.TabIndex = 14;
            // 
            // twoFingerPath
            // 
            this.twoFingerPath.Enabled = false;
            this.twoFingerPath.Location = new System.Drawing.Point(209, 58);
            this.twoFingerPath.Name = "twoFingerPath";
            this.twoFingerPath.Size = new System.Drawing.Size(344, 20);
            this.twoFingerPath.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Five fingers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Three fingers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Four fingers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Two fingers";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            // 
            // imageBoxCamera
            // 
            this.imageBoxCamera.Cursor = System.Windows.Forms.Cursors.Cross;
            this.imageBoxCamera.Location = new System.Drawing.Point(11, 25);
            this.imageBoxCamera.Name = "imageBoxCamera";
            this.imageBoxCamera.Size = new System.Drawing.Size(640, 480);
            this.imageBoxCamera.TabIndex = 2;
            this.imageBoxCamera.TabStop = false;
            // 
            // imageBoxSkin
            // 
            this.imageBoxSkin.Location = new System.Drawing.Point(657, 25);
            this.imageBoxSkin.Name = "imageBoxSkin";
            this.imageBoxSkin.Size = new System.Drawing.Size(640, 480);
            this.imageBoxSkin.TabIndex = 6;
            this.imageBoxSkin.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.debugUnfiltFing);
            this.groupBox2.Controls.Add(this.debugFingers);
            this.groupBox2.Controls.Add(this.debugAdditional);
            this.groupBox2.Controls.Add(this.debugFingerTrack);
            this.groupBox2.Controls.Add(this.debugHull);
            this.groupBox2.Controls.Add(this.debugContour);
            this.groupBox2.Controls.Add(this.additionalNfo);
            this.groupBox2.Location = new System.Drawing.Point(660, 511);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 176);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Debug";
            // 
            // debugUnfiltFing
            // 
            this.debugUnfiltFing.AutoSize = true;
            this.debugUnfiltFing.Location = new System.Drawing.Point(236, 101);
            this.debugUnfiltFing.Name = "debugUnfiltFing";
            this.debugUnfiltFing.Size = new System.Drawing.Size(30, 13);
            this.debugUnfiltFing.TabIndex = 13;
            this.debugUnfiltFing.Text = "text1";
            this.debugUnfiltFing.Visible = false;
            // 
            // debugFingers
            // 
            this.debugFingers.AutoSize = true;
            this.debugFingers.Location = new System.Drawing.Point(236, 62);
            this.debugFingers.Name = "debugFingers";
            this.debugFingers.Size = new System.Drawing.Size(30, 13);
            this.debugFingers.TabIndex = 11;
            this.debugFingers.Text = "text1";
            this.debugFingers.Visible = false;
            // 
            // debugAdditional
            // 
            this.debugAdditional.AutoSize = true;
            this.debugAdditional.Location = new System.Drawing.Point(45, 100);
            this.debugAdditional.Name = "debugAdditional";
            this.debugAdditional.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.debugAdditional.Size = new System.Drawing.Size(106, 17);
            this.debugAdditional.TabIndex = 10;
            this.debugAdditional.Text = "Show debug info";
            this.debugAdditional.UseVisualStyleBackColor = true;
            this.debugAdditional.CheckedChanged += new System.EventHandler(this.debugAdditional_CheckedChanged);
            // 
            // debugFingerTrack
            // 
            this.debugFingerTrack.AutoSize = true;
            this.debugFingerTrack.Location = new System.Drawing.Point(28, 77);
            this.debugFingerTrack.Name = "debugFingerTrack";
            this.debugFingerTrack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.debugFingerTrack.Size = new System.Drawing.Size(123, 17);
            this.debugFingerTrack.TabIndex = 9;
            this.debugFingerTrack.Text = "Show finger tracking";
            this.debugFingerTrack.UseVisualStyleBackColor = true;
            this.debugFingerTrack.CheckedChanged += new System.EventHandler(this.debugFingerTrack_CheckedChanged);
            // 
            // debugHull
            // 
            this.debugHull.AutoSize = true;
            this.debugHull.Location = new System.Drawing.Point(77, 54);
            this.debugHull.Name = "debugHull";
            this.debugHull.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.debugHull.Size = new System.Drawing.Size(74, 17);
            this.debugHull.TabIndex = 8;
            this.debugHull.Text = "Show Hull";
            this.debugHull.UseVisualStyleBackColor = true;
            this.debugHull.CheckedChanged += new System.EventHandler(this.debugHull_CheckedChanged);
            // 
            // debugContour
            // 
            this.debugContour.AutoSize = true;
            this.debugContour.Location = new System.Drawing.Point(58, 29);
            this.debugContour.Name = "debugContour";
            this.debugContour.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.debugContour.Size = new System.Drawing.Size(93, 17);
            this.debugContour.TabIndex = 7;
            this.debugContour.Text = "Show Contour";
            this.debugContour.UseVisualStyleBackColor = true;
            this.debugContour.CheckedChanged += new System.EventHandler(this.debugContour_CheckedChanged);
            // 
            // additionalNfo
            // 
            this.additionalNfo.AutoSize = true;
            this.additionalNfo.Location = new System.Drawing.Point(236, 30);
            this.additionalNfo.Name = "additionalNfo";
            this.additionalNfo.Size = new System.Drawing.Size(76, 13);
            this.additionalNfo.TabIndex = 4;
            this.additionalNfo.Text = "Additional info:";
            this.additionalNfo.Visible = false;
            // 
            // button12
            // 
            this.button12.Enabled = false;
            this.button12.Location = new System.Drawing.Point(1204, 596);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 45);
            this.button12.TabIndex = 24;
            this.button12.Text = "Stop Capture";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(1204, 543);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 42);
            this.button13.TabIndex = 25;
            this.button13.Text = "Start Capture";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Webcam feed";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(654, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Binary view";
            // 
            // notifyIcon3
            // 
            this.notifyIcon3.Text = "notifyIcon3";
            this.notifyIcon3.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 699);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.imageBoxSkin);
            this.Controls.Add(this.imageBoxCamera);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1328, 737);
            this.MinimumSize = new System.Drawing.Size(1278, 737);
            this.Name = "Form1";
            this.Text = "Gesture App Launcher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiveFingerIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourFingerIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threeFingerIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoFingerIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneFingerIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxSkin)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private Emgu.CV.UI.ImageBox imageBoxCamera;
        private Emgu.CV.UI.ImageBox imageBoxSkin;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox debugAdditional;
        private System.Windows.Forms.CheckBox debugFingerTrack;
        private System.Windows.Forms.CheckBox debugHull;
        private System.Windows.Forms.CheckBox debugContour;
        private System.Windows.Forms.Label additionalNfo;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label debugFingers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label debugUnfiltFing;
        private System.Windows.Forms.PictureBox fiveFingerIcon;
        private System.Windows.Forms.PictureBox fourFingerIcon;
        private System.Windows.Forms.PictureBox threeFingerIcon;
        private System.Windows.Forms.PictureBox twoFingerIcon;
        private System.Windows.Forms.PictureBox oneFingerIcon;
        private System.Windows.Forms.TextBox fiveFingerPath;
        private System.Windows.Forms.TextBox fourFingerPath;
        private System.Windows.Forms.TextBox threeFingerPath;
        private System.Windows.Forms.TextBox twoFingerPath;
        private System.Windows.Forms.TextBox oneFingerPath;
        private System.Windows.Forms.NotifyIcon notifyIcon3;
    }
}

