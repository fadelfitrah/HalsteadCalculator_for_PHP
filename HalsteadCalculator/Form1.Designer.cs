using System.Drawing;
using System.IO;

namespace HalsteadCalculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.srcBtn = new System.Windows.Forms.Button();
            this.operatorsPath = new System.Windows.Forms.RichTextBox();
            this.analyzeResult = new System.Windows.Forms.RichTextBox();
            this.operandsPath = new System.Windows.Forms.RichTextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.TextBox();
            this.showCode = new System.Windows.Forms.Button();
            this.userGuide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Halstead Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input file:";
            // 
            // srcBtn
            // 
            this.srcBtn.BackColor = System.Drawing.Color.Gray;
            this.srcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.srcBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.srcBtn.Location = new System.Drawing.Point(476, 119);
            this.srcBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.srcBtn.Name = "srcBtn";
            this.srcBtn.Size = new System.Drawing.Size(62, 24);
            this.srcBtn.TabIndex = 4;
            this.srcBtn.Text = "Browse..";
            this.srcBtn.UseVisualStyleBackColor = false;
            this.srcBtn.Click += new System.EventHandler(this.srcBtn_Click);
            // 
            // operatorsPath
            // 
            this.operatorsPath.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.operatorsPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.operatorsPath.Location = new System.Drawing.Point(23, 225);
            this.operatorsPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.operatorsPath.Name = "operatorsPath";
            this.operatorsPath.Size = new System.Drawing.Size(245, 112);
            this.operatorsPath.TabIndex = 6;
            this.operatorsPath.Text = "";
            // 
            // analyzeResult
            // 
            this.analyzeResult.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.analyzeResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.analyzeResult.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analyzeResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.analyzeResult.Location = new System.Drawing.Point(299, 225);
            this.analyzeResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.analyzeResult.Name = "analyzeResult";
            this.analyzeResult.Size = new System.Drawing.Size(245, 252);
            this.analyzeResult.TabIndex = 7;
            this.analyzeResult.Text = "";
            // 
            // operandsPath
            // 
            this.operandsPath.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.operandsPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.operandsPath.Location = new System.Drawing.Point(23, 355);
            this.operandsPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.operandsPath.Name = "operandsPath";
            this.operandsPath.Size = new System.Drawing.Size(245, 122);
            this.operandsPath.TabIndex = 8;
            this.operandsPath.Text = "";
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Chartreuse;
            this.startBtn.Location = new System.Drawing.Point(23, 184);
            this.startBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(92, 33);
            this.startBtn.TabIndex = 10;
            this.startBtn.Text = "Start Analyze";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // filePath
            // 
            this.filePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filePath.Location = new System.Drawing.Point(100, 114);
            this.filePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filePath.Multiline = true;
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(444, 34);
            this.filePath.TabIndex = 0;
            this.filePath.TextChanged += new System.EventHandler(this.filePath_TextChanged);
            // 
            // showCode
            // 
            this.showCode.BackColor = System.Drawing.Color.Chartreuse;
            this.showCode.Location = new System.Drawing.Point(442, 184);
            this.showCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showCode.Name = "showCode";
            this.showCode.Size = new System.Drawing.Size(96, 32);
            this.showCode.TabIndex = 11;
            this.showCode.Text = "Show Code";
            this.showCode.UseVisualStyleBackColor = false;
            this.showCode.Click += new System.EventHandler(this.showCode_Click);
            // 
            // userGuide
            // 
            this.userGuide.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userGuide.Cursor = System.Windows.Forms.Cursors.Help;
            this.userGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userGuide.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userGuide.Location = new System.Drawing.Point(501, 22);
            this.userGuide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userGuide.Name = "userGuide";
            this.userGuide.Size = new System.Drawing.Size(38, 41);
            this.userGuide.TabIndex = 12;
            this.userGuide.Text = "?";
            this.userGuide.UseVisualStyleBackColor = false;
            this.userGuide.Click += new System.EventHandler(this.userGuide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 531);
            this.Controls.Add(this.userGuide);
            this.Controls.Add(this.showCode);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.operandsPath);
            this.Controls.Add(this.analyzeResult);
            this.Controls.Add(this.operatorsPath);
            this.Controls.Add(this.srcBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filePath);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button srcBtn;
        private System.Windows.Forms.RichTextBox operatorsPath;
        private System.Windows.Forms.RichTextBox analyzeResult;
        private System.Windows.Forms.RichTextBox operandsPath;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button showCode;
        private System.Windows.Forms.Button userGuide;
    }
}

