namespace DateTest
{
    partial class dateForm
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
            this.dateTimePickerDropOff = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deliveryDate = new System.Windows.Forms.Label();
            this.CDriveLink = new System.Windows.Forms.LinkLabel();
            this.DeitelWebLink = new System.Windows.Forms.LinkLabel();
            this.NotePadLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // dateTimePickerDropOff
            // 
            this.dateTimePickerDropOff.Location = new System.Drawing.Point(44, 45);
            this.dateTimePickerDropOff.Name = "dateTimePickerDropOff";
            this.dateTimePickerDropOff.Size = new System.Drawing.Size(220, 20);
            this.dateTimePickerDropOff.TabIndex = 0;
            this.dateTimePickerDropOff.Value = new System.DateTime(2018, 8, 5, 0, 0, 0, 0);
            this.dateTimePickerDropOff.ValueChanged += new System.EventHandler(this.dateTimePickerDropOff_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drop Off Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estimated Delivery Date:";
            // 
            // deliveryDate
            // 
            this.deliveryDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.deliveryDate.Location = new System.Drawing.Point(44, 116);
            this.deliveryDate.Name = "deliveryDate";
            this.deliveryDate.Size = new System.Drawing.Size(220, 22);
            this.deliveryDate.TabIndex = 3;
            this.deliveryDate.UseMnemonic = false;
            // 
            // CDriveLink
            // 
            this.CDriveLink.AutoSize = true;
            this.CDriveLink.Location = new System.Drawing.Point(54, 182);
            this.CDriveLink.Name = "CDriveLink";
            this.CDriveLink.Size = new System.Drawing.Size(102, 13);
            this.CDriveLink.TabIndex = 4;
            this.CDriveLink.TabStop = true;
            this.CDriveLink.Text = "Click to browse C://";
            this.CDriveLink.VisitedLinkColor = System.Drawing.Color.Red;
            this.CDriveLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CDriveLink_LinkClicked);
            // 
            // DeitelWebLink
            // 
            this.DeitelWebLink.AutoSize = true;
            this.DeitelWebLink.Location = new System.Drawing.Point(54, 222);
            this.DeitelWebLink.Name = "DeitelWebLink";
            this.DeitelWebLink.Size = new System.Drawing.Size(141, 13);
            this.DeitelWebLink.TabIndex = 5;
            this.DeitelWebLink.TabStop = true;
            this.DeitelWebLink.Text = "Click to visit www.deitel.com";
            this.DeitelWebLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeitelWebLink_LinkClicked);
            // 
            // NotePadLink
            // 
            this.NotePadLink.AutoSize = true;
            this.NotePadLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.NotePadLink.Location = new System.Drawing.Point(54, 262);
            this.NotePadLink.Name = "NotePadLink";
            this.NotePadLink.Size = new System.Drawing.Size(104, 13);
            this.NotePadLink.TabIndex = 6;
            this.NotePadLink.TabStop = true;
            this.NotePadLink.Text = "Click to run Notepad";
            this.NotePadLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NotePadLink_LinkClicked);
            // 
            // dateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 345);
            this.Controls.Add(this.NotePadLink);
            this.Controls.Add(this.DeitelWebLink);
            this.Controls.Add(this.CDriveLink);
            this.Controls.Add(this.deliveryDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDropOff);
            this.Name = "dateForm";
            this.Text = "Date Test";
            this.Load += new System.EventHandler(this.dateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDropOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label deliveryDate;
        private System.Windows.Forms.LinkLabel CDriveLink;
        private System.Windows.Forms.LinkLabel DeitelWebLink;
        private System.Windows.Forms.LinkLabel NotePadLink;
    }
}

