﻿namespace ConsoleApp1
{
    partial class ScannerUI
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
            this.scanButton = new System.Windows.Forms.Button();
            this.scanPicture = new System.Windows.Forms.PictureBox();
            this.devicesBox = new System.Windows.Forms.ComboBox();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.trackBarHResolution = new System.Windows.Forms.TrackBar();
            this.trackBarVResolution = new System.Windows.Forms.TrackBar();
            this.labelHResolution = new System.Windows.Forms.Label();
            this.labelVResolution = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scanPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVResolution)).BeginInit();
            this.SuspendLayout();
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(252, 21);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(113, 58);
            this.scanButton.TabIndex = 0;
            this.scanButton.Text = "Scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // scanPicture
            // 
            this.scanPicture.Location = new System.Drawing.Point(424, 21);
            this.scanPicture.Name = "scanPicture";
            this.scanPicture.Size = new System.Drawing.Size(364, 417);
            this.scanPicture.TabIndex = 1;
            this.scanPicture.TabStop = false;
            // 
            // devicesBox
            // 
            this.devicesBox.FormattingEnabled = true;
            this.devicesBox.Location = new System.Drawing.Point(22, 21);
            this.devicesBox.Name = "devicesBox";
            this.devicesBox.Size = new System.Drawing.Size(182, 21);
            this.devicesBox.TabIndex = 3;
            this.devicesBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Location = new System.Drawing.Point(252, 106);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(113, 51);
            this.buttonSaveToFile.TabIndex = 4;
            this.buttonSaveToFile.Text = "Save to file";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.ButtonSaveToFile_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(22, 122);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(182, 20);
            this.textBoxPath.TabIndex = 5;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(19, 106);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(98, 13);
            this.labelPath.TabIndex = 6;
            this.labelPath.Text = "Path to save image";
            // 
            // trackBarHResolution
            // 
            this.trackBarHResolution.Location = new System.Drawing.Point(22, 213);
            this.trackBarHResolution.Maximum = 0;
            this.trackBarHResolution.Name = "trackBarHResolution";
            this.trackBarHResolution.Size = new System.Drawing.Size(182, 45);
            this.trackBarHResolution.TabIndex = 7;
            // 
            // trackBarVResolution
            // 
            this.trackBarVResolution.Location = new System.Drawing.Point(22, 295);
            this.trackBarVResolution.Maximum = 0;
            this.trackBarVResolution.Name = "trackBarVResolution";
            this.trackBarVResolution.Size = new System.Drawing.Size(182, 45);
            this.trackBarVResolution.TabIndex = 8;
            // 
            // labelHResolution
            // 
            this.labelHResolution.AutoSize = true;
            this.labelHResolution.Location = new System.Drawing.Point(19, 197);
            this.labelHResolution.Name = "labelHResolution";
            this.labelHResolution.Size = new System.Drawing.Size(102, 13);
            this.labelHResolution.TabIndex = 9;
            this.labelHResolution.Text = "Horizontal resolution";
            // 
            // labelVResolution
            // 
            this.labelVResolution.AutoSize = true;
            this.labelVResolution.Location = new System.Drawing.Point(19, 279);
            this.labelVResolution.Name = "labelVResolution";
            this.labelVResolution.Size = new System.Drawing.Size(90, 13);
            this.labelVResolution.TabIndex = 10;
            this.labelVResolution.Text = "Vertical resolution";
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelVResolution);
            this.Controls.Add(this.labelHResolution);
            this.Controls.Add(this.trackBarVResolution);
            this.Controls.Add(this.trackBarHResolution);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.devicesBox);
            this.Controls.Add(this.scanPicture);
            this.Controls.Add(this.scanButton);
            this.Name = "UI";
            this.Text = "UI";
            ((System.ComponentModel.ISupportInitialize)(this.scanPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVResolution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.PictureBox scanPicture;
        private System.Windows.Forms.ComboBox devicesBox;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.TrackBar trackBarHResolution;
        private System.Windows.Forms.TrackBar trackBarVResolution;
        private System.Windows.Forms.Label labelHResolution;
        private System.Windows.Forms.Label labelVResolution;
    }
}