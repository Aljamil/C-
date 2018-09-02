using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterDetail
{
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        BookExamples.BooksEntities dbcontext = new BookExamples.BooksEntities();

        private void Details_Load(object sender, EventArgs e)
        {
            dbcontext.Authors
                .OrderBy(author => author.LastName)
                .ThenBy(author => author.FirstName)
                .Load();

            authorBindingSource.DataSource = dbcontext.Authors.Local;
        }
    }
}
