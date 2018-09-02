using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace OtherGUI
{
    public partial class SampleTreeView : Form
    {
        public SampleTreeView()
        {
            InitializeComponent();
        }

        public void populateTreeView(string directoryValue, TreeNode parentNode)
        {
            string substringDirectory;
            string[] directoryArray = Directory.GetDirectories(directoryValue);

            try
            {
                if (directoryArray.Length != 0)
                {
                    foreach (string directory in directoryArray)
                    {
                        substringDirectory = Path.GetFileNameWithoutExtension(directory);

                        TreeNode myNode = new TreeNode(substringDirectory);

                        parentNode.Nodes.Add(myNode);

                        populateTreeView(directory, myNode);
                    }
                }
            }

            catch(UnauthorizedAccessException)
            {
                parentNode.Nodes.Add("Access Denied");
            }  
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();

            if(Directory.Exists(inputTextBox.Text))
            {
                treeView.Nodes.Add(inputTextBox.Text);

                populateTreeView(inputTextBox.Text, treeView.Nodes[0]);

            }

            else
            {
                MessageBox.Show(inputTextBox.Text + " could not be found.",
                                "Directory Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ChildTree childForm = new ChildTree();
            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}
