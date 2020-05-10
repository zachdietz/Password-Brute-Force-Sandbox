namespace Passworder
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
            this.button1 = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.attempNum = new System.Windows.Forms.Label();
            this.activityView = new System.Windows.Forms.TextBox();
            this.timerNum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.noOutput = new System.Windows.Forms.CheckBox();
            this.onlyLower = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.resultsButton = new System.Windows.Forms.Button();
            this.resultsBox = new System.Windows.Forms.TextBox();
            this.defineSize = new System.Windows.Forms.CheckBox();
            this.sizeBox = new System.Windows.Forms.ComboBox();
            this.solveRateNum = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.solutionNum = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(150, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(8, 29);
            this.inputBox.MaxLength = 8;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(136, 20);
            this.inputBox.TabIndex = 1;
            this.inputBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Solution:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Attempts:";
            // 
            // attempNum
            // 
            this.attempNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.attempNum.Location = new System.Drawing.Point(122, 145);
            this.attempNum.Name = "attempNum";
            this.attempNum.Size = new System.Drawing.Size(83, 18);
            this.attempNum.TabIndex = 6;
            this.attempNum.Text = "0";
            this.attempNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // activityView
            // 
            this.activityView.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.activityView.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.activityView.Location = new System.Drawing.Point(12, 186);
            this.activityView.Multiline = true;
            this.activityView.Name = "activityView";
            this.activityView.ReadOnly = true;
            this.activityView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.activityView.Size = new System.Drawing.Size(420, 378);
            this.activityView.TabIndex = 7;
            // 
            // timerNum
            // 
            this.timerNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timerNum.Location = new System.Drawing.Point(238, 145);
            this.timerNum.Name = "timerNum";
            this.timerNum.Size = new System.Drawing.Size(83, 18);
            this.timerNum.TabIndex = 9;
            this.timerNum.Text = "0 Second(s)";
            this.timerNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Timer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Output:";
            // 
            // noOutput
            // 
            this.noOutput.AutoSize = true;
            this.noOutput.Location = new System.Drawing.Point(265, 75);
            this.noOutput.Name = "noOutput";
            this.noOutput.Size = new System.Drawing.Size(75, 17);
            this.noOutput.TabIndex = 11;
            this.noOutput.Text = "No Output";
            this.noOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.noOutput.UseVisualStyleBackColor = true;
            // 
            // onlyLower
            // 
            this.onlyLower.AutoSize = true;
            this.onlyLower.Location = new System.Drawing.Point(346, 75);
            this.onlyLower.Name = "onlyLower";
            this.onlyLower.Size = new System.Drawing.Size(79, 17);
            this.onlyLower.TabIndex = 12;
            this.onlyLower.Text = "Only Lower";
            this.onlyLower.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fast Solving Options:";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(-29, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(461, 35);
            this.label7.TabIndex = 14;
            // 
            // resultsButton
            // 
            this.resultsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsButton.Location = new System.Drawing.Point(349, 12);
            this.resultsButton.Name = "resultsButton";
            this.resultsButton.Size = new System.Drawing.Size(83, 49);
            this.resultsButton.TabIndex = 15;
            this.resultsButton.Text = "Show Results History";
            this.resultsButton.UseVisualStyleBackColor = true;
            this.resultsButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // resultsBox
            // 
            this.resultsBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resultsBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.resultsBox.Location = new System.Drawing.Point(448, 13);
            this.resultsBox.Multiline = true;
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.ReadOnly = true;
            this.resultsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultsBox.Size = new System.Drawing.Size(923, 551);
            this.resultsBox.TabIndex = 16;
            // 
            // defineSize
            // 
            this.defineSize.AutoSize = true;
            this.defineSize.Location = new System.Drawing.Point(138, 75);
            this.defineSize.Name = "defineSize";
            this.defineSize.Size = new System.Drawing.Size(80, 17);
            this.defineSize.TabIndex = 17;
            this.defineSize.Text = "Define Size";
            this.defineSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.defineSize.UseVisualStyleBackColor = true;
            this.defineSize.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // sizeBox
            // 
            this.sizeBox.BackColor = System.Drawing.SystemColors.Window;
            this.sizeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeBox.Enabled = false;
            this.sizeBox.FormattingEnabled = true;
            this.sizeBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.sizeBox.Location = new System.Drawing.Point(219, 71);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(31, 21);
            this.sizeBox.TabIndex = 18;
            // 
            // solveRateNum
            // 
            this.solveRateNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.solveRateNum.Location = new System.Drawing.Point(349, 145);
            this.solveRateNum.Name = "solveRateNum";
            this.solveRateNum.Size = new System.Drawing.Size(83, 18);
            this.solveRateNum.TabIndex = 21;
            this.solveRateNum.Text = "0 /sec";
            this.solveRateNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(346, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Solve Rate:";
            // 
            // solutionNum
            // 
            this.solutionNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.solutionNum.Location = new System.Drawing.Point(11, 145);
            this.solutionNum.Name = "solutionNum";
            this.solutionNum.Size = new System.Drawing.Size(83, 18);
            this.solutionNum.TabIndex = 22;
            this.solutionNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 170);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(420, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 23;
            this.progressBar1.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 576);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.solutionNum);
            this.Controls.Add(this.solveRateNum);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.defineSize);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.resultsButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.onlyLower);
            this.Controls.Add(this.noOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timerNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.attempNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.activityView);
            this.MaximumSize = new System.Drawing.Size(460, 615);
            this.MinimumSize = new System.Drawing.Size(460, 615);
            this.Name = "Form1";
            this.Text = "Password Brute Force **EDUCATION ONLY**";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label attempNum;
        private System.Windows.Forms.TextBox activityView;
        private System.Windows.Forms.Label timerNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox noOutput;
        private System.Windows.Forms.CheckBox onlyLower;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button resultsButton;
        private System.Windows.Forms.TextBox resultsBox;
        private System.Windows.Forms.CheckBox defineSize;
        private System.Windows.Forms.ComboBox sizeBox;
        private System.Windows.Forms.Label solveRateNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label solutionNum;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

