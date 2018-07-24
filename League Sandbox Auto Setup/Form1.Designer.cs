﻿namespace League_Sandbox_Auto_Setup
{
    partial class leagueSandboxAutoSetupForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.installDirectoryText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cloningProgressLabel = new System.Windows.Forms.Label();
            this.downloadingProgressLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.unzippingProgressLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.launchingProgressLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.finishProgressLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory for League Sandbox Installation:";
            // 
            // installDirectoryText
            // 
            this.installDirectoryText.Location = new System.Drawing.Point(227, 12);
            this.installDirectoryText.Name = "installDirectoryText";
            this.installDirectoryText.Size = new System.Drawing.Size(213, 20);
            this.installDirectoryText.TabIndex = 1;
            this.installDirectoryText.Text = "C:/LeagueSandbox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Note: Please install Visual Studio first for complete setup.";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(197, 69);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cloning Code Repositories";
            // 
            // cloningProgressLabel
            // 
            this.cloningProgressLabel.Location = new System.Drawing.Point(23, 120);
            this.cloningProgressLabel.Name = "cloningProgressLabel";
            this.cloningProgressLabel.Size = new System.Drawing.Size(199, 13);
            this.cloningProgressLabel.TabIndex = 5;
            this.cloningProgressLabel.Text = "❌";
            this.cloningProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // downloadingProgressLabel
            // 
            this.downloadingProgressLabel.Location = new System.Drawing.Point(20, 145);
            this.downloadingProgressLabel.Name = "downloadingProgressLabel";
            this.downloadingProgressLabel.Size = new System.Drawing.Size(202, 13);
            this.downloadingProgressLabel.TabIndex = 7;
            this.downloadingProgressLabel.Text = "❌";
            this.downloadingProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Downloading League of Legends 420 Client";
            // 
            // unzippingProgressLabel
            // 
            this.unzippingProgressLabel.Location = new System.Drawing.Point(20, 170);
            this.unzippingProgressLabel.Name = "unzippingProgressLabel";
            this.unzippingProgressLabel.Size = new System.Drawing.Size(202, 13);
            this.unzippingProgressLabel.TabIndex = 9;
            this.unzippingProgressLabel.Text = "❌";
            this.unzippingProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Unzipping League of Legends 420 Client";
            // 
            // launchingProgressLabel
            // 
            this.launchingProgressLabel.Location = new System.Drawing.Point(20, 194);
            this.launchingProgressLabel.Name = "launchingProgressLabel";
            this.launchingProgressLabel.Size = new System.Drawing.Size(202, 13);
            this.launchingProgressLabel.TabIndex = 11;
            this.launchingProgressLabel.Text = "❌";
            this.launchingProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(228, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Launching Visual Studio for first run";
            // 
            // finishProgressLabel
            // 
            this.finishProgressLabel.Location = new System.Drawing.Point(20, 217);
            this.finishProgressLabel.Name = "finishProgressLabel";
            this.finishProgressLabel.Size = new System.Drawing.Size(202, 13);
            this.finishProgressLabel.TabIndex = 13;
            this.finishProgressLabel.Text = "❌";
            this.finishProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(228, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Finished one time auto setup";
            // 
            // leagueSandboxAutoSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 258);
            this.Controls.Add(this.finishProgressLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.launchingProgressLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.unzippingProgressLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.downloadingProgressLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cloningProgressLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.installDirectoryText);
            this.Controls.Add(this.label1);
            this.Name = "leagueSandboxAutoSetupForm";
            this.Text = "League Sandbox Auto Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox installDirectoryText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cloningProgressLabel;
        private System.Windows.Forms.Label downloadingProgressLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label unzippingProgressLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label launchingProgressLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label finishProgressLabel;
        private System.Windows.Forms.Label label12;
    }
}

