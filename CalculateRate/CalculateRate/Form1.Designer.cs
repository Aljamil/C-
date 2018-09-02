namespace CalculateRate
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
            this.yearsTextBox = new System.Windows.Forms.NumericUpDown();
            this.InterestRateTextbox = new System.Windows.Forms.TextBox();
            this.principalTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.displayTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.yearsTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // yearsTextBox
            // 
            this.yearsTextBox.Location = new System.Drawing.Point(120, 56);
            this.yearsTextBox.Name = "yearsTextBox";
            this.yearsTextBox.Size = new System.Drawing.Size(120, 20);
            this.yearsTextBox.TabIndex = 0;
            // 
            // InterestRateTextbox
            // 
            this.InterestRateTextbox.Location = new System.Drawing.Point(120, 30);
            this.InterestRateTextbox.Name = "InterestRateTextbox";
            this.InterestRateTextbox.Size = new System.Drawing.Size(120, 20);
            this.InterestRateTextbox.TabIndex = 1;
            // 
            // principalTextbox
            // 
            this.principalTextbox.Location = new System.Drawing.Point(120, 4);
            this.principalTextbox.Name = "principalTextbox";
            this.principalTextbox.Size = new System.Drawing.Size(120, 20);
            this.principalTextbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Principal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Interest Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Years:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yearly Account Balance:";
            // 
            // displayTextbox
            // 
            this.displayTextbox.Location = new System.Drawing.Point(12, 129);
            this.displayTextbox.Multiline = true;
            this.displayTextbox.Name = "displayTextbox";
            this.displayTextbox.ReadOnly = true;
            this.displayTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displayTextbox.Size = new System.Drawing.Size(345, 142);
            this.displayTextbox.TabIndex = 8;
    
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 283);
            this.Controls.Add(this.displayTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.principalTextbox);
            this.Controls.Add(this.InterestRateTextbox);
            this.Controls.Add(this.yearsTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.yearsTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown yearsTextBox;
        private System.Windows.Forms.TextBox InterestRateTextbox;
        private System.Windows.Forms.TextBox principalTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox displayTextbox;
    }
}

