﻿namespace FightMe
{
    partial class FightingGameMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            startbutt = new Button();
            optionsbutt = new Button();
            exitbutt = new Button();
            volumebutt = new Button();
            videobutt = new Button();
            controlsbutt = new Button();
            backbutt = new Button();
            Cool_image = new PictureBox();
            punchbox = new PictureBox();
            botbox = new PictureBox();
            botPbox = new PictureBox();
            contbutt = new Button();
            winTBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Cool_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)punchbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)botbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)botPbox).BeginInit();
            SuspendLayout();
            // 
            // startbutt
            // 
            startbutt.AllowDrop = true;
            startbutt.Location = new Point(734, 300);
            startbutt.Name = "startbutt";
            startbutt.Size = new Size(267, 79);
            startbutt.TabIndex = 0;
            startbutt.Text = "START";
            startbutt.UseVisualStyleBackColor = true;
            startbutt.Click += startbutt_Click;
            // 
            // optionsbutt
            // 
            optionsbutt.Location = new Point(734, 385);
            optionsbutt.Name = "optionsbutt";
            optionsbutt.Size = new Size(267, 76);
            optionsbutt.TabIndex = 1;
            optionsbutt.Text = "OPTIONS";
            optionsbutt.UseVisualStyleBackColor = true;
            optionsbutt.Click += optionsbutt_Click;
            // 
            // exitbutt
            // 
            exitbutt.Location = new Point(736, 215);
            exitbutt.Name = "exitbutt";
            exitbutt.Size = new Size(265, 79);
            exitbutt.TabIndex = 2;
            exitbutt.Text = "exit";
            exitbutt.UseVisualStyleBackColor = true;
            exitbutt.Click += exitbutt_Click;
            // 
            // volumebutt
            // 
            volumebutt.Location = new Point(734, 467);
            volumebutt.Name = "volumebutt";
            volumebutt.Size = new Size(267, 78);
            volumebutt.TabIndex = 3;
            volumebutt.Text = "volume";
            volumebutt.UseVisualStyleBackColor = true;
            volumebutt.Click += volumebutt_Click;
            // 
            // videobutt
            // 
            videobutt.Location = new Point(736, 551);
            videobutt.Name = "videobutt";
            videobutt.Size = new Size(265, 73);
            videobutt.TabIndex = 4;
            videobutt.Text = "video";
            videobutt.UseVisualStyleBackColor = true;
            videobutt.Click += videobutt_Click;
            // 
            // controlsbutt
            // 
            controlsbutt.Location = new Point(736, 630);
            controlsbutt.Name = "controlsbutt";
            controlsbutt.Size = new Size(265, 79);
            controlsbutt.TabIndex = 5;
            controlsbutt.Text = "controls";
            controlsbutt.UseVisualStyleBackColor = true;
            // 
            // backbutt
            // 
            backbutt.Location = new Point(737, 714);
            backbutt.Name = "backbutt";
            backbutt.Size = new Size(264, 82);
            backbutt.TabIndex = 6;
            backbutt.Text = "back";
            backbutt.UseVisualStyleBackColor = true;
            backbutt.Click += backbutt_Click;
            // 
            // Cool_image
            // 
            Cool_image.BackColor = Color.White;
            Cool_image.ImageLocation = "";
            Cool_image.Location = new Point(446, 203);
            Cool_image.Name = "Cool_image";
            Cool_image.Size = new Size(200, 400);
            Cool_image.TabIndex = 7;
            Cool_image.TabStop = false;
            // 
            // punchbox
            // 
            punchbox.BackColor = Color.Red;
            punchbox.Location = new Point(466, 112);
            punchbox.Name = "punchbox";
            punchbox.Size = new Size(150, 48);
            punchbox.TabIndex = 8;
            punchbox.TabStop = false;
            // 
            // botbox
            // 
            botbox.BackColor = Color.White;
            botbox.ImageLocation = "";
            botbox.Location = new Point(1160, 203);
            botbox.Name = "botbox";
            botbox.Size = new Size(200, 400);
            botbox.TabIndex = 9;
            botbox.TabStop = false;
            // 
            // botPbox
            // 
            botPbox.BackColor = Color.Lime;
            botPbox.Location = new Point(1187, 112);
            botPbox.Name = "botPbox";
            botPbox.Size = new Size(150, 48);
            botPbox.TabIndex = 10;
            botPbox.TabStop = false;
            // 
            // contbutt
            // 
            contbutt.Location = new Point(736, 300);
            contbutt.Name = "contbutt";
            contbutt.Size = new Size(265, 79);
            contbutt.TabIndex = 11;
            contbutt.Text = "continue";
            contbutt.UseVisualStyleBackColor = true;
            contbutt.Click += contbutt_Click;
            // 
            // winTBox
            // 
            winTBox.Location = new Point(745, 56);
            winTBox.Name = "winTBox";
            winTBox.ReadOnly = true;
            winTBox.Size = new Size(252, 23);
            winTBox.TabIndex = 12;
            // 
            // FightingGameMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2153, 1147);
            Controls.Add(winTBox);
            Controls.Add(contbutt);
            Controls.Add(botPbox);
            Controls.Add(botbox);
            Controls.Add(punchbox);
            Controls.Add(Cool_image);
            Controls.Add(backbutt);
            Controls.Add(controlsbutt);
            Controls.Add(videobutt);
            Controls.Add(volumebutt);
            Controls.Add(exitbutt);
            Controls.Add(optionsbutt);
            Controls.Add(startbutt);
            Name = "FightingGameMainForm";
            Text = "Fight Me";
            KeyDown += keydown;
            KeyPress += keypress;
            KeyUp += keyup;
            ((System.ComponentModel.ISupportInitialize)Cool_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)punchbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)botbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)botPbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startbutt;
        private Button optionsbutt;
        private Button exitbutt;
        private Button volumebutt;
        private Button videobutt;
        private Button controlsbutt;
        private Button backbutt;
        private PictureBox Cool_image;
        private PictureBox punchbox;
        private PictureBox botbox;
        private PictureBox botPbox;
        private Button contbutt;
        private TextBox winTBox;
    }
}