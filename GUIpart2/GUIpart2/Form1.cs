using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIpart2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an example\nof using menus.", "About",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearColor()
        {
            blackToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            displayLabel.ForeColor = Color.Black;
            blackToolStripMenuItem.Checked = true;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            displayLabel.ForeColor = Color.Blue;
            blackToolStripMenuItem.Checked = true;

        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            displayLabel.ForeColor = Color.Red;
            blackToolStripMenuItem.Checked = true;

        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            displayLabel.ForeColor = Color.Green;
            blackToolStripMenuItem.Checked = true;

        }

        private void clearFonts()
        {
            timesNewRomanToolStripMenuItem.Checked = false;
            courierToolStripMenuItem.Checked = false;
            comicsSanToolStripMenuItem.Checked = false;
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearFonts();
            timesNewRomanToolStripMenuItem.Checked = true;
            displayLabel.Font = new Font("Times New Roman", 14, displayLabel.Font.Style);

        }

        private void courierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearFonts();
            courierToolStripMenuItem.Checked = true;
            displayLabel.Font = new Font("Courier", 14, displayLabel.Font.Style);
        }

        private void comicsSanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearFonts();
            comicsSanToolStripMenuItem.Checked = true;
            displayLabel.Font = new Font("Comic Sans MS", 14, displayLabel.Font.Style);
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boldToolStripMenuItem.Checked = !boldToolStripMenuItem.Checked;

            displayLabel.Font = new Font(displayLabel.Font, displayLabel.Font.Style ^ FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            italicToolStripMenuItem.Checked = !italicToolStripMenuItem.Checked;

            displayLabel.Font = new Font(displayLabel.Font, displayLabel.Font.Style ^ FontStyle.Italic);
        }

        private void displayLabel_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "Use the Format to change the appearance of this Text";
        }
    }
}
