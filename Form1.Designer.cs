namespace PassGenerator
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
            this.passLengthText = new System.Windows.Forms.Label();
            this.sliderPassLength = new System.Windows.Forms.TrackBar();
            this.lowercaseLabel = new System.Windows.Forms.Label();
            this.uppercaseLabel = new System.Windows.Forms.Label();
            this.numbersLabel = new System.Windows.Forms.Label();
            this.symbolsLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.copyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sliderPassLength)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password Generator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passLengthText
            // 
            this.passLengthText.BackColor = System.Drawing.Color.Transparent;
            this.passLengthText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLengthText.ForeColor = System.Drawing.Color.Blue;
            this.passLengthText.Location = new System.Drawing.Point(0, 49);
            this.passLengthText.Name = "passLengthText";
            this.passLengthText.Size = new System.Drawing.Size(419, 37);
            this.passLengthText.TabIndex = 2;
            this.passLengthText.Text = "Current Password Length: 4";
            this.passLengthText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passLengthText.Click += new System.EventHandler(this.passLengthText_Click);
            // 
            // sliderPassLength
            // 
            this.sliderPassLength.BackColor = System.Drawing.Color.Blue;
            this.sliderPassLength.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sliderPassLength.Location = new System.Drawing.Point(96, 89);
            this.sliderPassLength.Maximum = 40;
            this.sliderPassLength.Minimum = 4;
            this.sliderPassLength.Name = "sliderPassLength";
            this.sliderPassLength.Size = new System.Drawing.Size(231, 45);
            this.sliderPassLength.TabIndex = 3;
            this.sliderPassLength.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.sliderPassLength.Value = 4;
            this.sliderPassLength.Scroll += new System.EventHandler(this.sliderPassLength_Scroll);
            // 
            // lowercaseLabel
            // 
            this.lowercaseLabel.BackColor = System.Drawing.Color.MidnightBlue;
            this.lowercaseLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lowercaseLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowercaseLabel.ForeColor = System.Drawing.Color.Lavender;
            this.lowercaseLabel.Location = new System.Drawing.Point(107, 137);
            this.lowercaseLabel.Name = "lowercaseLabel";
            this.lowercaseLabel.Size = new System.Drawing.Size(210, 37);
            this.lowercaseLabel.TabIndex = 4;
            this.lowercaseLabel.Text = "LowerCase";
            this.lowercaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lowercaseLabel.Click += new System.EventHandler(this.lowercaseLabel_Click);
            // 
            // uppercaseLabel
            // 
            this.uppercaseLabel.BackColor = System.Drawing.Color.MidnightBlue;
            this.uppercaseLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uppercaseLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uppercaseLabel.ForeColor = System.Drawing.Color.Lavender;
            this.uppercaseLabel.Location = new System.Drawing.Point(107, 174);
            this.uppercaseLabel.Name = "uppercaseLabel";
            this.uppercaseLabel.Size = new System.Drawing.Size(210, 37);
            this.uppercaseLabel.TabIndex = 5;
            this.uppercaseLabel.Text = "UpperCase";
            this.uppercaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uppercaseLabel.Click += new System.EventHandler(this.uppercaseLabel_Click);
            // 
            // numbersLabel
            // 
            this.numbersLabel.BackColor = System.Drawing.Color.MidnightBlue;
            this.numbersLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.numbersLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbersLabel.ForeColor = System.Drawing.Color.Lavender;
            this.numbersLabel.Location = new System.Drawing.Point(107, 211);
            this.numbersLabel.Name = "numbersLabel";
            this.numbersLabel.Size = new System.Drawing.Size(210, 37);
            this.numbersLabel.TabIndex = 6;
            this.numbersLabel.Text = "Numbers";
            this.numbersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.numbersLabel.Click += new System.EventHandler(this.numbersLabel_Click);
            // 
            // symbolsLabel
            // 
            this.symbolsLabel.BackColor = System.Drawing.Color.MidnightBlue;
            this.symbolsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.symbolsLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbolsLabel.ForeColor = System.Drawing.Color.Lavender;
            this.symbolsLabel.Location = new System.Drawing.Point(107, 248);
            this.symbolsLabel.Name = "symbolsLabel";
            this.symbolsLabel.Size = new System.Drawing.Size(210, 37);
            this.symbolsLabel.TabIndex = 7;
            this.symbolsLabel.Text = "Symbols";
            this.symbolsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.symbolsLabel.Click += new System.EventHandler(this.symbolsLabel_Click);
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.generateButton.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.generateButton.Location = new System.Drawing.Point(154, 297);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(118, 39);
            this.generateButton.TabIndex = 8;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(96, 342);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(231, 92);
            this.textBoxResult.TabIndex = 9;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // copyButton
            // 
            this.copyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.copyButton.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.copyButton.Location = new System.Drawing.Point(154, 440);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(118, 39);
            this.copyButton.TabIndex = 10;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = false;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PassGenerator.Properties.Resources.Gradient_background;
            this.ClientSize = new System.Drawing.Size(419, 482);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.symbolsLabel);
            this.Controls.Add(this.numbersLabel);
            this.Controls.Add(this.uppercaseLabel);
            this.Controls.Add(this.lowercaseLabel);
            this.Controls.Add(this.sliderPassLength);
            this.Controls.Add(this.passLengthText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sliderPassLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label passLengthText;
        private System.Windows.Forms.TrackBar sliderPassLength;
        private System.Windows.Forms.Label lowercaseLabel;
        private System.Windows.Forms.Label uppercaseLabel;
        private System.Windows.Forms.Label numbersLabel;
        private System.Windows.Forms.Label symbolsLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button copyButton;
    }
}

