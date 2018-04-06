namespace RomanNumeralsToArabicConversion
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
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultOutputLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.enterHereLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(246, 226);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(35, 226);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(15, 133);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(40, 13);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "Result:";
            // 
            // resultOutputLabel
            // 
            this.resultOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultOutputLabel.Location = new System.Drawing.Point(12, 146);
            this.resultOutputLabel.Name = "resultOutputLabel";
            this.resultOutputLabel.Size = new System.Drawing.Size(359, 60);
            this.resultOutputLabel.TabIndex = 3;
            this.resultOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputTextBox
            // 
            this.inputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputTextBox.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.inputTextBox.Location = new System.Drawing.Point(74, 42);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(121, 26);
            this.inputTextBox.TabIndex = 4;
            this.inputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // enterHereLabel
            // 
            this.enterHereLabel.AutoSize = true;
            this.enterHereLabel.Location = new System.Drawing.Point(15, 55);
            this.enterHereLabel.Name = "enterHereLabel";
            this.enterHereLabel.Size = new System.Drawing.Size(59, 13);
            this.enterHereLabel.TabIndex = 5;
            this.enterHereLabel.Text = "Enter here:";
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(267, 67);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(104, 36);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Convert to Roman";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(270, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Convert to Arabic";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.enterHereLabel);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultOutputLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label resultOutputLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label enterHereLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button button1;
    }
}

