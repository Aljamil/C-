namespace SimpleEventExample
{
    partial class SimpleEvent
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
            this.clickButton = new System.Windows.Forms.Button();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.displayPasswordLabel = new System.Windows.Forms.Label();
            this.displayPasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clickButton
            // 
            this.clickButton.Location = new System.Drawing.Point(284, 292);
            this.clickButton.Name = "clickButton";
            this.clickButton.Size = new System.Drawing.Size(362, 48);
            this.clickButton.TabIndex = 0;
            this.clickButton.Text = "Click Button";
            this.clickButton.UseVisualStyleBackColor = true;
            this.clickButton.Click += new System.EventHandler(this.clickButton_Click);
            // 
            // inputPassword
            // 
            this.inputPassword.AcceptsReturn = true;
            this.inputPassword.AcceptsTab = true;
            this.inputPassword.Location = new System.Drawing.Point(284, 111);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(362, 23);
            this.inputPassword.TabIndex = 2;
            this.inputPassword.UseSystemPasswordChar = true;
            // 
            // displayPasswordLabel
            // 
            this.displayPasswordLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.displayPasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayPasswordLabel.Location = new System.Drawing.Point(284, 149);
            this.displayPasswordLabel.Name = "displayPasswordLabel";
            this.displayPasswordLabel.Size = new System.Drawing.Size(362, 30);
            this.displayPasswordLabel.TabIndex = 3;
            // 
            // displayPasswordButton
            // 
            this.displayPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayPasswordButton.Location = new System.Drawing.Point(368, 193);
            this.displayPasswordButton.Name = "displayPasswordButton";
            this.displayPasswordButton.Size = new System.Drawing.Size(200, 23);
            this.displayPasswordButton.TabIndex = 4;
            this.displayPasswordButton.Text = "Show Text";
            this.displayPasswordButton.UseVisualStyleBackColor = true;
            this.displayPasswordButton.Click += new System.EventHandler(this.displayPasswordButton_Click);
            // 
            // SimpleEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 500);
            this.Controls.Add(this.displayPasswordButton);
            this.Controls.Add(this.displayPasswordLabel);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.clickButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SimpleEvent";
            this.Text = "Simple Event Example";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clickButton;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.Label displayPasswordLabel;
        private System.Windows.Forms.Button displayPasswordButton;
    }
}

