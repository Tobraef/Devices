namespace ConsoleApp1
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
            this.labelHResolution = new System.Windows.Forms.Label();
            this.labelVResolution = new System.Windows.Forms.Label();
            this.checkBoxColor = new System.Windows.Forms.CheckBox();
            this.comboBoxHRes = new System.Windows.Forms.ComboBox();
            this.comboBoxVRes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scanPicture)).BeginInit();
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
            this.devicesBox.Location = new System.Drawing.Point(22, 31);
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
            // checkBoxColor
            // 
            this.checkBoxColor.AutoSize = true;
            this.checkBoxColor.Location = new System.Drawing.Point(22, 346);
            this.checkBoxColor.Name = "checkBoxColor";
            this.checkBoxColor.Size = new System.Drawing.Size(50, 17);
            this.checkBoxColor.TabIndex = 11;
            this.checkBoxColor.Text = "Color";
            this.checkBoxColor.UseVisualStyleBackColor = true;
            // 
            // comboBoxHRes
            // 
            this.comboBoxHRes.FormattingEnabled = true;
            this.comboBoxHRes.Location = new System.Drawing.Point(22, 213);
            this.comboBoxHRes.Name = "comboBoxHRes";
            this.comboBoxHRes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHRes.TabIndex = 12;
            // 
            // comboBoxVRes
            // 
            this.comboBoxVRes.FormattingEnabled = true;
            this.comboBoxVRes.Location = new System.Drawing.Point(22, 295);
            this.comboBoxVRes.Name = "comboBoxVRes";
            this.comboBoxVRes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVRes.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Choose scanner by ID";
            // 
            // ScannerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxVRes);
            this.Controls.Add(this.comboBoxHRes);
            this.Controls.Add(this.checkBoxColor);
            this.Controls.Add(this.labelVResolution);
            this.Controls.Add(this.labelHResolution);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.devicesBox);
            this.Controls.Add(this.scanPicture);
            this.Controls.Add(this.scanButton);
            this.Name = "ScannerUI";
            this.Text = "UI";
            this.Load += new System.EventHandler(this.ScannerUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scanPicture)).EndInit();
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
        private System.Windows.Forms.Label labelHResolution;
        private System.Windows.Forms.Label labelVResolution;
        private System.Windows.Forms.CheckBox checkBoxColor;
        private System.Windows.Forms.ComboBox comboBoxHRes;
        private System.Windows.Forms.ComboBox comboBoxVRes;
        private System.Windows.Forms.Label label1;
    }
}