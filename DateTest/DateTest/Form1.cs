using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTest
{
    public partial class dateForm : Form
    {
        public dateForm()
        {
            InitializeComponent();
        }

        private void dateTimePickerDropOff_ValueChanged(object sender, EventArgs e)
        {
            DateTime dropOffDate = dateTimePickerDropOff.Value;
            
            // add extra time when items are dropped off around Sunday
            if (dropOffDate.DayOfWeek == DayOfWeek.Friday || dropOffDate.DayOfWeek == DayOfWeek.Saturday ||
                 dropOffDate.DayOfWeek == DayOfWeek.Sunday )

           //estimate three days for delivery
               deliveryDate.Text = dropOffDate.AddDays(3).ToLongDateString();
           else
            // otherwise estimate only two days for delivery
               deliveryDate.Text = dropOffDate.AddDays(2).ToLongDateString();
        }

        private void dateForm_Load(object sender, EventArgs e)
        {
            dateTimePickerDropOff.MinDate = DateTime.Today;
            dateTimePickerDropOff.MaxDate = DateTime.Today.AddYears(1);
        }

        private void CDriveLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CDriveLink.LinkVisited = true;
            System.Diagnostics.Process.Start("D:");
        }

        private void DeitelWebLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeitelWebLink.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.deitel.com");
        }

        private void NotePadLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NotePadLink.LinkVisited = true;
            System.Diagnostics.Process.Start("notepad");
        }
    }
}
