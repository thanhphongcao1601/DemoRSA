﻿
namespace DemoPublicKeyRSA
{
    partial class Encode
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLengKey = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.btnOpenFileKeys = new System.Windows.Forms.Button();
            this.tbPathKeys = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Module = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbE = new System.Windows.Forms.TextBox();
            this.tbD = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.selectOutput = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnOpenFolderIn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1f = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpenFileIn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxLengKey);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnGenerateKey);
            this.panel1.Controls.Add(this.btnOpenFileKeys);
            this.panel1.Controls.Add(this.tbPathKeys);
            this.panel1.Location = new System.Drawing.Point(22, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 166);
            this.panel1.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(240, 12);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 28);
            this.label13.TabIndex = 10;
            this.label13.Text = "Tạo Key";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "File Key (Xml):";
            // 
            // comboBoxLengKey
            // 
            this.comboBoxLengKey.FormattingEnabled = true;
            this.comboBoxLengKey.Location = new System.Drawing.Point(160, 59);
            this.comboBoxLengKey.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxLengKey.Name = "comboBoxLengKey";
            this.comboBoxLengKey.Size = new System.Drawing.Size(160, 24);
            this.comboBoxLengKey.TabIndex = 5;
            this.comboBoxLengKey.SelectedIndexChanged += new System.EventHandler(this.comboBoxLengKey_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chọn độ dài Key:";
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.Location = new System.Drawing.Point(350, 58);
            this.btnGenerateKey.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(141, 28);
            this.btnGenerateKey.TabIndex = 3;
            this.btnGenerateKey.Text = "Tạo Key Tự Động";
            this.btnGenerateKey.UseVisualStyleBackColor = true;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // btnOpenFileKeys
            // 
            this.btnOpenFileKeys.Location = new System.Drawing.Point(511, 97);
            this.btnOpenFileKeys.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenFileKeys.Name = "btnOpenFileKeys";
            this.btnOpenFileKeys.Size = new System.Drawing.Size(100, 28);
            this.btnOpenFileKeys.TabIndex = 2;
            this.btnOpenFileKeys.Text = "Open";
            this.btnOpenFileKeys.UseVisualStyleBackColor = true;
            this.btnOpenFileKeys.Click += new System.EventHandler(this.btnOpenFileKeys_Click);
            // 
            // tbPathKeys
            // 
            this.tbPathKeys.Location = new System.Drawing.Point(160, 100);
            this.tbPathKeys.Margin = new System.Windows.Forms.Padding(4);
            this.tbPathKeys.Name = "tbPathKeys";
            this.tbPathKeys.Size = new System.Drawing.Size(341, 22);
            this.tbPathKeys.TabIndex = 1;
            this.tbPathKeys.TextChanged += new System.EventHandler(this.tbPathKeys_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.Module);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.tbN);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tbE);
            this.panel3.Controls.Add(this.tbD);
            this.panel3.Location = new System.Drawing.Point(22, 201);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(624, 174);
            this.panel3.TabIndex = 11;
            // 
            // Module
            // 
            this.Module.AutoSize = true;
            this.Module.Location = new System.Drawing.Point(46, 52);
            this.Module.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Module.Name = "Module";
            this.Module.Size = new System.Drawing.Size(82, 17);
            this.Module.TabIndex = 6;
            this.Module.Text = "Module (N):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mũ Giải Mã (D):";
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(154, 50);
            this.tbN.Margin = new System.Windows.Forms.Padding(4);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(332, 22);
            this.tbN.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mũ Mã Hoá (E):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(221, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Thông tin Key";
            // 
            // tbE
            // 
            this.tbE.Location = new System.Drawing.Point(154, 89);
            this.tbE.Margin = new System.Windows.Forms.Padding(4);
            this.tbE.Name = "tbE";
            this.tbE.Size = new System.Drawing.Size(332, 22);
            this.tbE.TabIndex = 4;
            // 
            // tbD
            // 
            this.tbD.Location = new System.Drawing.Point(154, 134);
            this.tbD.Margin = new System.Windows.Forms.Padding(4);
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(332, 22);
            this.tbD.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.selectOutput);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.btnOpenFolderIn);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.label1f);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnEncrypt);
            this.panel2.Controls.Add(this.tbOutput);
            this.panel2.Controls.Add(this.tbInput);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnOpenFileIn);
            this.panel2.Location = new System.Drawing.Point(21, 383);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 291);
            this.panel2.TabIndex = 12;
            // 
            // selectOutput
            // 
            this.selectOutput.Location = new System.Drawing.Point(501, 145);
            this.selectOutput.Margin = new System.Windows.Forms.Padding(4);
            this.selectOutput.Name = "selectOutput";
            this.selectOutput.Size = new System.Drawing.Size(111, 28);
            this.selectOutput.TabIndex = 15;
            this.selectOutput.Text = "Chọn Nơi Lưu";
            this.selectOutput.UseVisualStyleBackColor = true;
            this.selectOutput.Click += new System.EventHandler(this.selectOutput_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(256, 16);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 28);
            this.label14.TabIndex = 14;
            this.label14.Text = "Mã Hoá";
            // 
            // btnOpenFolderIn
            // 
            this.btnOpenFolderIn.Location = new System.Drawing.Point(501, 65);
            this.btnOpenFolderIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenFolderIn.Name = "btnOpenFolderIn";
            this.btnOpenFolderIn.Size = new System.Drawing.Size(111, 28);
            this.btnOpenFolderIn.TabIndex = 12;
            this.btnOpenFolderIn.Text = "Chọn Folder";
            this.btnOpenFolderIn.UseVisualStyleBackColor = true;
            this.btnOpenFolderIn.Click += new System.EventHandler(this.btnOpenFolderIn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(40, 214);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(528, 28);
            this.progressBar1.TabIndex = 9;
            // 
            // label1f
            // 
            this.label1f.AutoSize = true;
            this.label1f.Location = new System.Drawing.Point(36, 246);
            this.label1f.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1f.Name = "label1f";
            this.label1f.Size = new System.Drawing.Size(0, 17);
            this.label1f.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Output: ";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(250, 178);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(100, 28);
            this.btnEncrypt.TabIndex = 10;
            this.btnEncrypt.Text = "Mã Hoá";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(106, 148);
            this.tbOutput.Margin = new System.Windows.Forms.Padding(4);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(381, 22);
            this.tbOutput.TabIndex = 7;
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(106, 65);
            this.tbInput.Margin = new System.Windows.Forms.Padding(4);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(381, 22);
            this.tbInput.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Input: ";
            // 
            // btnOpenFileIn
            // 
            this.btnOpenFileIn.Location = new System.Drawing.Point(501, 36);
            this.btnOpenFileIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenFileIn.Name = "btnOpenFileIn";
            this.btnOpenFileIn.Size = new System.Drawing.Size(111, 28);
            this.btnOpenFileIn.TabIndex = 0;
            this.btnOpenFileIn.Text = "Chọn File";
            this.btnOpenFileIn.UseVisualStyleBackColor = true;
            this.btnOpenFileIn.Click += new System.EventHandler(this.btnOpenFileIn_Click);
            // 
            // Encode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 698);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Encode";
            this.Text = "Mã Hoá";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLengKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.Button btnOpenFileKeys;
        private System.Windows.Forms.TextBox tbPathKeys;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Module;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbE;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button selectOutput;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnOpenFolderIn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1f;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenFileIn;
    }
}