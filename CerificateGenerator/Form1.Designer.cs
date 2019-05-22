namespace CerificateGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTemplateUrl = new System.Windows.Forms.TextBox();
            this.btnBrowseTemplate = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFintName = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnBrowseFont = new System.Windows.Forms.Button();
            this.txtFontSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.txtOutputFolderUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnBroseExcelList = new System.Windows.Forms.Button();
            this.txtExcelListNamesUrl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.txtXPosition = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYPosition = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDateYPosition = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDateXPostion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFontSizeDate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFontSizeNumbers = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtYPositionSace = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtXPositionSace = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtYPosHPCSA = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtXPosHPCSA = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select PDF Template";
            // 
            // txtTemplateUrl
            // 
            this.txtTemplateUrl.Location = new System.Drawing.Point(191, 12);
            this.txtTemplateUrl.Name = "txtTemplateUrl";
            this.txtTemplateUrl.Size = new System.Drawing.Size(410, 20);
            this.txtTemplateUrl.TabIndex = 1;
            // 
            // btnBrowseTemplate
            // 
            this.btnBrowseTemplate.Location = new System.Drawing.Point(607, 10);
            this.btnBrowseTemplate.Name = "btnBrowseTemplate";
            this.btnBrowseTemplate.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseTemplate.TabIndex = 2;
            this.btnBrowseTemplate.Text = "Browse";
            this.btnBrowseTemplate.UseVisualStyleBackColor = true;
            this.btnBrowseTemplate.Click += new System.EventHandler(this.BtnBrowseTemplate_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Font Name";
            // 
            // txtFintName
            // 
            this.txtFintName.Location = new System.Drawing.Point(191, 64);
            this.txtFintName.Name = "txtFintName";
            this.txtFintName.Size = new System.Drawing.Size(410, 20);
            this.txtFintName.TabIndex = 4;
            this.txtFintName.Text = "Arial";
            // 
            // btnBrowseFont
            // 
            this.btnBrowseFont.Location = new System.Drawing.Point(607, 64);
            this.btnBrowseFont.Name = "btnBrowseFont";
            this.btnBrowseFont.Size = new System.Drawing.Size(75, 46);
            this.btnBrowseFont.TabIndex = 5;
            this.btnBrowseFont.Text = "Browse";
            this.btnBrowseFont.UseVisualStyleBackColor = true;
            this.btnBrowseFont.Click += new System.EventHandler(this.BtnBrowseFont_Click);
            // 
            // txtFontSize
            // 
            this.txtFontSize.Location = new System.Drawing.Point(191, 90);
            this.txtFontSize.Name = "txtFontSize";
            this.txtFontSize.Size = new System.Drawing.Size(67, 20);
            this.txtFontSize.TabIndex = 7;
            this.txtFontSize.Text = "18";
            this.txtFontSize.TextChanged += new System.EventHandler(this.TxtFontSize_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Font Size Name";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Location = new System.Drawing.Point(607, 114);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseFolder.TabIndex = 10;
            this.btnBrowseFolder.Text = "Browse";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.BtnBrowseFolder_Click);
            // 
            // txtOutputFolderUrl
            // 
            this.txtOutputFolderUrl.Location = new System.Drawing.Point(191, 116);
            this.txtOutputFolderUrl.Name = "txtOutputFolderUrl";
            this.txtOutputFolderUrl.Size = new System.Drawing.Size(410, 20);
            this.txtOutputFolderUrl.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Output Folder";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(222, 279);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(326, 44);
            this.btnGenerate.TabIndex = 11;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // btnBroseExcelList
            // 
            this.btnBroseExcelList.Location = new System.Drawing.Point(607, 36);
            this.btnBroseExcelList.Name = "btnBroseExcelList";
            this.btnBroseExcelList.Size = new System.Drawing.Size(75, 23);
            this.btnBroseExcelList.TabIndex = 14;
            this.btnBroseExcelList.Text = "Browse";
            this.btnBroseExcelList.UseVisualStyleBackColor = true;
            this.btnBroseExcelList.Click += new System.EventHandler(this.BtnBroseExcelList_Click);
            // 
            // txtExcelListNamesUrl
            // 
            this.txtExcelListNamesUrl.Location = new System.Drawing.Point(191, 38);
            this.txtExcelListNamesUrl.Name = "txtExcelListNamesUrl";
            this.txtExcelListNamesUrl.Size = new System.Drawing.Size(410, 20);
            this.txtExcelListNamesUrl.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Excel List of Names";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(25, 329);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(670, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(25, 368);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(24, 13);
            this.lblProgress.TabIndex = 16;
            this.lblProgress.Text = "0/0";
            // 
            // txtXPosition
            // 
            this.txtXPosition.Location = new System.Drawing.Point(191, 142);
            this.txtXPosition.Name = "txtXPosition";
            this.txtXPosition.Size = new System.Drawing.Size(98, 20);
            this.txtXPosition.TabIndex = 18;
            this.txtXPosition.Text = "305";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "X Position Name";
            // 
            // txtYPosition
            // 
            this.txtYPosition.Location = new System.Drawing.Point(191, 168);
            this.txtYPosition.Name = "txtYPosition";
            this.txtYPosition.Size = new System.Drawing.Size(98, 20);
            this.txtYPosition.TabIndex = 20;
            this.txtYPosition.Text = "400";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Y Position Name";
            // 
            // txtDateYPosition
            // 
            this.txtDateYPosition.Location = new System.Drawing.Point(397, 168);
            this.txtDateYPosition.Name = "txtDateYPosition";
            this.txtDateYPosition.Size = new System.Drawing.Size(88, 20);
            this.txtDateYPosition.TabIndex = 24;
            this.txtDateYPosition.Text = "625";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(298, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Y Position Date";
            // 
            // txtDateXPostion
            // 
            this.txtDateXPostion.Location = new System.Drawing.Point(397, 142);
            this.txtDateXPostion.Name = "txtDateXPostion";
            this.txtDateXPostion.Size = new System.Drawing.Size(88, 20);
            this.txtDateXPostion.TabIndex = 22;
            this.txtDateXPostion.Text = "150";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(298, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "X Position Date";
            // 
            // txtFontSizeDate
            // 
            this.txtFontSizeDate.Location = new System.Drawing.Point(352, 90);
            this.txtFontSizeDate.Name = "txtFontSizeDate";
            this.txtFontSizeDate.Size = new System.Drawing.Size(67, 20);
            this.txtFontSizeDate.TabIndex = 26;
            this.txtFontSizeDate.Text = "18";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Font Size Date";
            // 
            // txtFontSizeNumbers
            // 
            this.txtFontSizeNumbers.Location = new System.Drawing.Point(533, 90);
            this.txtFontSizeNumbers.Name = "txtFontSizeNumbers";
            this.txtFontSizeNumbers.Size = new System.Drawing.Size(67, 20);
            this.txtFontSizeNumbers.TabIndex = 28;
            this.txtFontSizeNumbers.Text = "10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(431, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Font Size Numbers";
            // 
            // txtYPositionSace
            // 
            this.txtYPositionSace.Location = new System.Drawing.Point(191, 220);
            this.txtYPositionSace.Name = "txtYPositionSace";
            this.txtYPositionSace.Size = new System.Drawing.Size(98, 20);
            this.txtYPositionSace.TabIndex = 32;
            this.txtYPositionSace.Text = "700";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Y Position Sace";
            // 
            // txtXPositionSace
            // 
            this.txtXPositionSace.Location = new System.Drawing.Point(191, 194);
            this.txtXPositionSace.Name = "txtXPositionSace";
            this.txtXPositionSace.Size = new System.Drawing.Size(98, 20);
            this.txtXPositionSace.TabIndex = 30;
            this.txtXPositionSace.Text = "85";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "X Position Sace";
            // 
            // txtYPosHPCSA
            // 
            this.txtYPosHPCSA.Location = new System.Drawing.Point(397, 220);
            this.txtYPosHPCSA.Name = "txtYPosHPCSA";
            this.txtYPosHPCSA.Size = new System.Drawing.Size(88, 20);
            this.txtYPosHPCSA.TabIndex = 36;
            this.txtYPosHPCSA.Text = "720";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(298, 223);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Y Position HPCSA";
            // 
            // txtXPosHPCSA
            // 
            this.txtXPosHPCSA.Location = new System.Drawing.Point(397, 194);
            this.txtXPosHPCSA.Name = "txtXPosHPCSA";
            this.txtXPosHPCSA.Size = new System.Drawing.Size(88, 20);
            this.txtXPosHPCSA.TabIndex = 34;
            this.txtXPosHPCSA.Text = "85";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(298, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "X Position HPCSA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 554);
            this.Controls.Add(this.txtYPosHPCSA);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtXPosHPCSA);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtYPositionSace);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtXPositionSace);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtFontSizeNumbers);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtFontSizeDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDateYPosition);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDateXPostion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtYPosition);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtXPosition);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnBroseExcelList);
            this.Controls.Add(this.txtExcelListNamesUrl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnBrowseFolder);
            this.Controls.Add(this.txtOutputFolderUrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFontSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowseFont);
            this.Controls.Add(this.txtFintName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowseTemplate);
            this.Controls.Add(this.txtTemplateUrl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Certificate Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTemplateUrl;
        private System.Windows.Forms.Button btnBrowseTemplate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFintName;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnBrowseFont;
        private System.Windows.Forms.TextBox txtFontSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.TextBox txtOutputFolderUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnBroseExcelList;
        private System.Windows.Forms.TextBox txtExcelListNamesUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.TextBox txtXPosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYPosition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDateYPosition;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDateXPostion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFontSizeDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFontSizeNumbers;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtYPositionSace;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtXPositionSace;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtYPosHPCSA;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtXPosHPCSA;
        private System.Windows.Forms.Label label15;
    }
}

