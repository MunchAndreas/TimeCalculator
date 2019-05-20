namespace TimeCalculator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WeekLabel = new System.Windows.Forms.Label();
            this.SpeakTheResultCheckBox = new System.Windows.Forms.CheckBox();
            this.Time3TextBox = new System.Windows.Forms.TextBox();
            this.Time2TextBox = new System.Windows.Forms.TextBox();
            this.Time1TextBox = new System.Windows.Forms.TextBox();
            this.DigitResultTextBox = new System.Windows.Forms.TextBox();
            this.CopyToClipboardCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeResultTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.SpeakTheResultCheckBox);
            this.groupBox1.Controls.Add(this.Time3TextBox);
            this.groupBox1.Controls.Add(this.Time2TextBox);
            this.groupBox1.Controls.Add(this.Time1TextBox);
            this.groupBox1.Controls.Add(this.DigitResultTextBox);
            this.groupBox1.Controls.Add(this.CopyToClipboardCheckBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TimeResultTextBox);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.WeekLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 225);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adding time...";
            // 
            // WeekLabel
            // 
            this.WeekLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekLabel.Location = new System.Drawing.Point(161, 99);
            this.WeekLabel.Name = "WeekLabel";
            this.WeekLabel.Size = new System.Drawing.Size(103, 54);
            this.WeekLabel.TabIndex = 16;
            this.WeekLabel.Text = "week number";
            this.WeekLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SpeakTheResultCheckBox
            // 
            this.SpeakTheResultCheckBox.AutoSize = true;
            this.SpeakTheResultCheckBox.Location = new System.Drawing.Point(16, 136);
            this.SpeakTheResultCheckBox.Name = "SpeakTheResultCheckBox";
            this.SpeakTheResultCheckBox.Size = new System.Drawing.Size(103, 17);
            this.SpeakTheResultCheckBox.TabIndex = 15;
            this.SpeakTheResultCheckBox.Text = "Speak the result";
            this.SpeakTheResultCheckBox.UseVisualStyleBackColor = true;
            // 
            // Time3TextBox
            // 
            this.Time3TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Time3TextBox.Location = new System.Drawing.Point(16, 72);
            this.Time3TextBox.Name = "Time3TextBox";
            this.Time3TextBox.Size = new System.Drawing.Size(192, 20);
            this.Time3TextBox.TabIndex = 14;
            this.Time3TextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            this.Time3TextBox.Enter += new System.EventHandler(this.InputTextBox_Enter);
            // 
            // Time2TextBox
            // 
            this.Time2TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Time2TextBox.Location = new System.Drawing.Point(16, 48);
            this.Time2TextBox.Name = "Time2TextBox";
            this.Time2TextBox.Size = new System.Drawing.Size(192, 20);
            this.Time2TextBox.TabIndex = 13;
            this.Time2TextBox.Tag = "Time3TextBox";
            this.Time2TextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            this.Time2TextBox.Enter += new System.EventHandler(this.InputTextBox_Enter);
            // 
            // Time1TextBox
            // 
            this.Time1TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Time1TextBox.Location = new System.Drawing.Point(16, 24);
            this.Time1TextBox.Name = "Time1TextBox";
            this.Time1TextBox.Size = new System.Drawing.Size(192, 20);
            this.Time1TextBox.TabIndex = 12;
            this.Time1TextBox.Tag = "Time2TextBox";
            this.Time1TextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            this.Time1TextBox.Enter += new System.EventHandler(this.InputTextBox_EnterFirst);
            // 
            // DigitResultTextBox
            // 
            this.DigitResultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DigitResultTextBox.Location = new System.Drawing.Point(80, 184);
            this.DigitResultTextBox.Name = "DigitResultTextBox";
            this.DigitResultTextBox.ReadOnly = true;
            this.DigitResultTextBox.Size = new System.Drawing.Size(184, 20);
            this.DigitResultTextBox.TabIndex = 11;
            // 
            // CopyToClipboardCheckBox
            // 
            this.CopyToClipboardCheckBox.AutoSize = true;
            this.CopyToClipboardCheckBox.Checked = true;
            this.CopyToClipboardCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CopyToClipboardCheckBox.Location = new System.Drawing.Point(16, 112);
            this.CopyToClipboardCheckBox.Name = "CopyToClipboardCheckBox";
            this.CopyToClipboardCheckBox.Size = new System.Drawing.Size(131, 17);
            this.CopyToClipboardCheckBox.TabIndex = 10;
            this.CopyToClipboardCheckBox.Text = "Copy digit to Clipboard";
            this.CopyToClipboardCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Digit result";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Time result";
            // 
            // TimeResultTextBox
            // 
            this.TimeResultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeResultTextBox.Location = new System.Drawing.Point(80, 158);
            this.TimeResultTextBox.Name = "TimeResultTextBox";
            this.TimeResultTextBox.ReadOnly = true;
            this.TimeResultTextBox.Size = new System.Drawing.Size(184, 20);
            this.TimeResultTextBox.TabIndex = 7;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Location = new System.Drawing.Point(216, 24);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(48, 72);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.AddButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 247);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(320, 285);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Calculator";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TimeResultTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox DigitResultTextBox;
        private System.Windows.Forms.CheckBox CopyToClipboardCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Time3TextBox;
        private System.Windows.Forms.TextBox Time2TextBox;
        private System.Windows.Forms.TextBox Time1TextBox;
        private System.Windows.Forms.CheckBox SpeakTheResultCheckBox;
        private System.Windows.Forms.Label WeekLabel;
    }
}

