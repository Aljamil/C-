namespace GroupPanelExample
{
    partial class GroupPanelExample
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
            this.components = new System.ComponentModel.Container();
            this.TheButtons = new System.Windows.Forms.GroupBox();
            this.ByeButton = new System.Windows.Forms.Button();
            this.HiButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RightButon = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.Bold = new System.Windows.Forms.CheckBox();
            this.Italic = new System.Windows.Forms.CheckBox();
            this.Buttons = new System.Windows.Forms.GroupBox();
            this.RetryCancel = new System.Windows.Forms.RadioButton();
            this.YNButton = new System.Windows.Forms.RadioButton();
            this.YNCButton = new System.Windows.Forms.RadioButton();
            this.ARIButton = new System.Windows.Forms.RadioButton();
            this.OkCancelButton = new System.Windows.Forms.RadioButton();
            this.OkButton = new System.Windows.Forms.RadioButton();
            this.Icons = new System.Windows.Forms.GroupBox();
            this.WarningButton = new System.Windows.Forms.RadioButton();
            this.StopButton = new System.Windows.Forms.RadioButton();
            this.QuestionButton = new System.Windows.Forms.RadioButton();
            this.InformationButton = new System.Windows.Forms.RadioButton();
            this.HandButton = new System.Windows.Forms.RadioButton();
            this.ExclamationButton = new System.Windows.Forms.RadioButton();
            this.ErrorButton = new System.Windows.Forms.RadioButton();
            this.AsteriskRadioButton = new System.Windows.Forms.RadioButton();
            this.displayButton = new System.Windows.Forms.Button();
            this.displayLabel = new System.Windows.Forms.Label();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.Next = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TheButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Buttons.SuspendLayout();
            this.Icons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TheButtons
            // 
            this.TheButtons.Controls.Add(this.ByeButton);
            this.TheButtons.Controls.Add(this.HiButton);
            this.TheButtons.Location = new System.Drawing.Point(484, 12);
            this.TheButtons.Name = "TheButtons";
            this.TheButtons.Size = new System.Drawing.Size(304, 53);
            this.TheButtons.TabIndex = 0;
            this.TheButtons.TabStop = false;
            this.TheButtons.Text = "Main Button";
            // 
            // ByeButton
            // 
            this.ByeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ByeButton.Location = new System.Drawing.Point(159, 19);
            this.ByeButton.Name = "ByeButton";
            this.ByeButton.Size = new System.Drawing.Size(129, 23);
            this.ByeButton.TabIndex = 1;
            this.ByeButton.Text = "Bye";
            this.ByeButton.UseVisualStyleBackColor = true;
            this.ByeButton.Click += new System.EventHandler(this.ByeButton_Click);
            // 
            // HiButton
            // 
            this.HiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HiButton.Location = new System.Drawing.Point(17, 19);
            this.HiButton.Name = "HiButton";
            this.HiButton.Size = new System.Drawing.Size(124, 23);
            this.HiButton.TabIndex = 0;
            this.HiButton.Text = "Hi";
            this.HiButton.UseVisualStyleBackColor = true;
            this.HiButton.Click += new System.EventHandler(this.HiButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.RightButon);
            this.panel1.Controls.Add(this.LeftButton);
            this.panel1.Location = new System.Drawing.Point(484, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 100);
            this.panel1.TabIndex = 1;
            // 
            // RightButon
            // 
            this.RightButon.Location = new System.Drawing.Point(306, 15);
            this.RightButon.Name = "RightButon";
            this.RightButon.Size = new System.Drawing.Size(99, 23);
            this.RightButon.TabIndex = 1;
            this.RightButon.Text = "Far Right";
            this.RightButon.UseVisualStyleBackColor = true;
            this.RightButon.Click += new System.EventHandler(this.RightButon_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(22, 15);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(100, 23);
            this.LeftButton.TabIndex = 0;
            this.LeftButton.Text = "Far Left";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MessageLabel.Location = new System.Drawing.Point(481, 227);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(307, 23);
            this.MessageLabel.TabIndex = 2;
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bold
            // 
            this.Bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bold.Location = new System.Drawing.Point(528, 200);
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(106, 24);
            this.Bold.TabIndex = 3;
            this.Bold.Text = "Bold";
            this.Bold.UseVisualStyleBackColor = true;
            this.Bold.CheckedChanged += new System.EventHandler(this.Bold_CheckedChanged);
            // 
            // Italic
            // 
            this.Italic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Italic.Location = new System.Drawing.Point(683, 200);
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(105, 24);
            this.Italic.TabIndex = 4;
            this.Italic.Text = "Italic";
            this.Italic.UseVisualStyleBackColor = true;
            this.Italic.CheckedChanged += new System.EventHandler(this.Italic_CheckedChanged);
            // 
            // Buttons
            // 
            this.Buttons.Controls.Add(this.RetryCancel);
            this.Buttons.Controls.Add(this.YNButton);
            this.Buttons.Controls.Add(this.YNCButton);
            this.Buttons.Controls.Add(this.ARIButton);
            this.Buttons.Controls.Add(this.OkCancelButton);
            this.Buttons.Controls.Add(this.OkButton);
            this.Buttons.Location = new System.Drawing.Point(26, 26);
            this.Buttons.Name = "Buttons";
            this.Buttons.Size = new System.Drawing.Size(143, 165);
            this.Buttons.TabIndex = 5;
            this.Buttons.TabStop = false;
            this.Buttons.Text = "Button Type";
            this.toolTip1.SetToolTip(this.Buttons, "Buttons");
            // 
            // RetryCancel
            // 
            this.RetryCancel.AutoSize = true;
            this.RetryCancel.Location = new System.Drawing.Point(17, 134);
            this.RetryCancel.Name = "RetryCancel";
            this.RetryCancel.Size = new System.Drawing.Size(83, 17);
            this.RetryCancel.TabIndex = 5;
            this.RetryCancel.TabStop = true;
            this.RetryCancel.Text = "RetryCancel";
            this.RetryCancel.UseVisualStyleBackColor = true;
            // 
            // YNButton
            // 
            this.YNButton.AutoSize = true;
            this.YNButton.Location = new System.Drawing.Point(17, 111);
            this.YNButton.Name = "YNButton";
            this.YNButton.Size = new System.Drawing.Size(57, 17);
            this.YNButton.TabIndex = 4;
            this.YNButton.TabStop = true;
            this.YNButton.Text = "YesNo";
            this.YNButton.UseVisualStyleBackColor = true;
            // 
            // YNCButton
            // 
            this.YNCButton.AutoSize = true;
            this.YNCButton.Location = new System.Drawing.Point(17, 88);
            this.YNCButton.Name = "YNCButton";
            this.YNCButton.Size = new System.Drawing.Size(90, 17);
            this.YNCButton.TabIndex = 3;
            this.YNCButton.TabStop = true;
            this.YNCButton.Text = "YesNoCancel";
            this.YNCButton.UseVisualStyleBackColor = true;
            // 
            // ARIButton
            // 
            this.ARIButton.AutoSize = true;
            this.ARIButton.Location = new System.Drawing.Point(17, 65);
            this.ARIButton.Name = "ARIButton";
            this.ARIButton.Size = new System.Drawing.Size(105, 17);
            this.ARIButton.TabIndex = 2;
            this.ARIButton.TabStop = true;
            this.ARIButton.Text = "AbortRetryIgnore";
            this.ARIButton.UseVisualStyleBackColor = true;
            // 
            // OkCancelButton
            // 
            this.OkCancelButton.AutoSize = true;
            this.OkCancelButton.Location = new System.Drawing.Point(17, 42);
            this.OkCancelButton.Name = "OkCancelButton";
            this.OkCancelButton.Size = new System.Drawing.Size(72, 17);
            this.OkCancelButton.TabIndex = 1;
            this.OkCancelButton.TabStop = true;
            this.OkCancelButton.Text = "OkCancel";
            this.OkCancelButton.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.AutoSize = true;
            this.OkButton.Location = new System.Drawing.Point(17, 19);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(39, 17);
            this.OkButton.TabIndex = 0;
            this.OkButton.TabStop = true;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // Icons
            // 
            this.Icons.Controls.Add(this.WarningButton);
            this.Icons.Controls.Add(this.StopButton);
            this.Icons.Controls.Add(this.QuestionButton);
            this.Icons.Controls.Add(this.InformationButton);
            this.Icons.Controls.Add(this.HandButton);
            this.Icons.Controls.Add(this.ExclamationButton);
            this.Icons.Controls.Add(this.ErrorButton);
            this.Icons.Controls.Add(this.AsteriskRadioButton);
            this.Icons.Location = new System.Drawing.Point(186, 26);
            this.Icons.Name = "Icons";
            this.Icons.Size = new System.Drawing.Size(157, 213);
            this.Icons.TabIndex = 6;
            this.Icons.TabStop = false;
            this.Icons.Text = "Icon";
            this.toolTip1.SetToolTip(this.Icons, "Icons");
            // 
            // WarningButton
            // 
            this.WarningButton.AutoSize = true;
            this.WarningButton.Location = new System.Drawing.Point(6, 183);
            this.WarningButton.Name = "WarningButton";
            this.WarningButton.Size = new System.Drawing.Size(65, 17);
            this.WarningButton.TabIndex = 8;
            this.WarningButton.TabStop = true;
            this.WarningButton.Text = "Warning";
            this.WarningButton.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.AutoSize = true;
            this.StopButton.Location = new System.Drawing.Point(6, 157);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(47, 17);
            this.StopButton.TabIndex = 7;
            this.StopButton.TabStop = true;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // QuestionButton
            // 
            this.QuestionButton.AutoSize = true;
            this.QuestionButton.Location = new System.Drawing.Point(6, 134);
            this.QuestionButton.Name = "QuestionButton";
            this.QuestionButton.Size = new System.Drawing.Size(67, 17);
            this.QuestionButton.TabIndex = 6;
            this.QuestionButton.TabStop = true;
            this.QuestionButton.Text = "Question";
            this.QuestionButton.UseVisualStyleBackColor = true;
            // 
            // InformationButton
            // 
            this.InformationButton.AutoSize = true;
            this.InformationButton.Location = new System.Drawing.Point(6, 112);
            this.InformationButton.Name = "InformationButton";
            this.InformationButton.Size = new System.Drawing.Size(77, 17);
            this.InformationButton.TabIndex = 5;
            this.InformationButton.TabStop = true;
            this.InformationButton.Text = "Information";
            this.InformationButton.UseVisualStyleBackColor = true;
            // 
            // HandButton
            // 
            this.HandButton.AutoSize = true;
            this.HandButton.Location = new System.Drawing.Point(6, 89);
            this.HandButton.Name = "HandButton";
            this.HandButton.Size = new System.Drawing.Size(51, 17);
            this.HandButton.TabIndex = 4;
            this.HandButton.TabStop = true;
            this.HandButton.Text = "Hand";
            this.HandButton.UseVisualStyleBackColor = true;
            // 
            // ExclamationButton
            // 
            this.ExclamationButton.AutoSize = true;
            this.ExclamationButton.Location = new System.Drawing.Point(6, 66);
            this.ExclamationButton.Name = "ExclamationButton";
            this.ExclamationButton.Size = new System.Drawing.Size(82, 17);
            this.ExclamationButton.TabIndex = 3;
            this.ExclamationButton.TabStop = true;
            this.ExclamationButton.Text = "Exclamation";
            this.ExclamationButton.UseVisualStyleBackColor = true;
            // 
            // ErrorButton
            // 
            this.ErrorButton.AutoSize = true;
            this.ErrorButton.Location = new System.Drawing.Point(6, 43);
            this.ErrorButton.Name = "ErrorButton";
            this.ErrorButton.Size = new System.Drawing.Size(47, 17);
            this.ErrorButton.TabIndex = 2;
            this.ErrorButton.TabStop = true;
            this.ErrorButton.Text = "Error";
            this.ErrorButton.UseVisualStyleBackColor = true;
            // 
            // AsteriskRadioButton
            // 
            this.AsteriskRadioButton.AutoSize = true;
            this.AsteriskRadioButton.Location = new System.Drawing.Point(6, 20);
            this.AsteriskRadioButton.Name = "AsteriskRadioButton";
            this.AsteriskRadioButton.Size = new System.Drawing.Size(62, 17);
            this.AsteriskRadioButton.TabIndex = 1;
            this.AsteriskRadioButton.TabStop = true;
            this.AsteriskRadioButton.Text = "Asterisk";
            this.AsteriskRadioButton.UseVisualStyleBackColor = true;
            // 
            // displayButton
            // 
            this.displayButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.displayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayButton.Location = new System.Drawing.Point(43, 245);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(270, 57);
            this.displayButton.TabIndex = 7;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // displayLabel
            // 
            this.displayLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayLabel.Location = new System.Drawing.Point(26, 320);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(320, 31);
            this.displayLabel.TabIndex = 8;
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.InitialImage = null;
            this.imagePictureBox.Location = new System.Drawing.Point(545, 273);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(243, 165);
            this.imagePictureBox.TabIndex = 9;
            this.imagePictureBox.TabStop = false;
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(455, 279);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(84, 23);
            this.Next.TabIndex = 10;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // GroupPanelExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.Icons);
            this.Controls.Add(this.Buttons);
            this.Controls.Add(this.Italic);
            this.Controls.Add(this.Bold);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TheButtons);
            this.Name = "GroupPanelExample";
            this.Text = "Group Panel";
            this.toolTip1.SetToolTip(this, "Group Panel\r\n");
            this.TheButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.Buttons.ResumeLayout(false);
            this.Buttons.PerformLayout();
            this.Icons.ResumeLayout(false);
            this.Icons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TheButtons;
        private System.Windows.Forms.Button ByeButton;
        private System.Windows.Forms.Button HiButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RightButon;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.CheckBox Bold;
        private System.Windows.Forms.CheckBox Italic;
        private System.Windows.Forms.GroupBox Buttons;
        private System.Windows.Forms.RadioButton RetryCancel;
        private System.Windows.Forms.RadioButton YNButton;
        private System.Windows.Forms.RadioButton YNCButton;
        private System.Windows.Forms.RadioButton ARIButton;
        private System.Windows.Forms.RadioButton OkCancelButton;
        private System.Windows.Forms.RadioButton OkButton;
        private System.Windows.Forms.GroupBox Icons;
        private System.Windows.Forms.RadioButton WarningButton;
        private System.Windows.Forms.RadioButton StopButton;
        private System.Windows.Forms.RadioButton QuestionButton;
        private System.Windows.Forms.RadioButton InformationButton;
        private System.Windows.Forms.RadioButton HandButton;
        private System.Windows.Forms.RadioButton ExclamationButton;
        private System.Windows.Forms.RadioButton ErrorButton;
        private System.Windows.Forms.RadioButton AsteriskRadioButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

