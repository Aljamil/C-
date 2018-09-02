using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupPanelExample
{
    public partial class GroupPanelExample : Form
    {
        
        private MessageBoxIcon iconType;
        private MessageBoxButtons buttonType;

        public GroupPanelExample()
        {
            InitializeComponent();
        }

        private void HiButton_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = "Hi User!";
        }

        private void ByeButton_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = "Bye User!";
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = "You pressed Left!";
        }

        private void RightButon_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = "You pressed Right!";
        }

        private void Bold_CheckedChanged(object sender, EventArgs e)
        {
            MessageLabel.Font = new Font(MessageLabel.Font, MessageLabel.Font.Style
                ^ FontStyle.Bold);
        }

        private void Italic_CheckedChanged(object sender, EventArgs e)
        {
            MessageLabel.Font = new Font(MessageLabel.Font, MessageLabel.Font.Style
                ^ FontStyle.Italic);
        }

        private void buttonType_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == OkButton)
            { // display OK Button
                buttonType = MessageBoxButtons.OK;
            }


            else if (sender == OkCancelButton)
            {
                buttonType = MessageBoxButtons.OKCancel;
            }

            // display Abort, Retry and Ignore Buttons
            else if (sender == ARIButton)
            {
                buttonType = MessageBoxButtons.AbortRetryIgnore;
            }

            // display Yes, No and Cancel Buttons
            else if (sender == YNCButton)
            {
                buttonType = MessageBoxButtons.YesNoCancel;
            }

            // display Yes and No Buttons
            else if (sender == YNButton)
            {
                buttonType = MessageBoxButtons.YesNo;
            }

            // only one option left--display Retry and Cancel Buttons
            else
            {
                buttonType = MessageBoxButtons.RetryCancel;
            }

           }

        private void iconType_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == AsteriskRadioButton) // display asterisk Icon
            {
                iconType = MessageBoxIcon.Asterisk;
            }

            // display error Icon
            else if (sender == ErrorButton)
            {
                iconType = MessageBoxIcon.Error;
            }

            // display exclamation point Icon
            else if (sender == ExclamationButton)
            {
                iconType = MessageBoxIcon.Exclamation;
            }

            // display hand Icon
            else if (sender == HandButton)
            {
                iconType = MessageBoxIcon.Hand;
            }

            // display information Icon
            else if (sender == InformationButton)
            {
                iconType = MessageBoxIcon.Information;
            }

            // display question mark Icon
            else if (sender == QuestionButton)
            {
                iconType = MessageBoxIcon.Question;
            }

            // display stop Icon
            else if (sender == StopButton)
            {
                iconType = MessageBoxIcon.Stop;
            }

            // only one option left--display warning Icon
            else
            {
                iconType = MessageBoxIcon.Warning;
            }
         } // end method iconType_CheckedChanged

        private void displayButton_Click(object sender, EventArgs e)
        {

            
            DialogResult result = MessageBox.Show(
                "This is your custom Message Box", "Custom MessageBox", buttonType, iconType);
            
            switch (result)
            {
                case DialogResult.OK:
                   displayLabel.Text = "OK was pressed.";
                    break;
                case DialogResult.Cancel:
                  displayLabel.Text = "Cancel was pressed.";
                    break;
                case DialogResult.Abort:
                  displayLabel.Text = "Abort was pressed.";
                   break;
                case DialogResult.Retry:
                  displayLabel.Text = "Retry was pressed.";
                   break;
                case DialogResult.Ignore:
                  displayLabel.Text = "Ignore was pressed.";
                  break;
                case DialogResult.Yes:
                  displayLabel.Text = "Yes was pressed.";
                  break;
                case DialogResult.No:
                  displayLabel.Text = "No was pressed.";
                  break;
                } // end switch 

            /*
            var result = MessageBox.Show("This is Al", "Sample",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question); */
        }

        private int imageNum = -1;
        private void Next_Click(object sender, EventArgs e)
        {
            imageNum = (imageNum + 1) % 2;

            imagePictureBox.Image = (Image)
                (Properties.Resources.ResourceManager.GetObject(
                    string.Format("image{0}", imageNum)));
        }
    }
}
