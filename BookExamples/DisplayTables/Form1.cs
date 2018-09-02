using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayTables
{
    public partial class DisplayAuthorsTable : Form
    {
        public DisplayAuthorsTable()
        {
            InitializeComponent();
        }

        private BookExamples.BooksEntities dbcontext = new BookExamples.BooksEntities();

        private void DisplayAuthorsTable_Load(object sender, EventArgs e)
        {
            dbcontext.Authors
                     .OrderBy(author => author.LastName)
                     .ThenBy(author => author.FirstName)
                     .Load();

            authorBindingSource.DataSource = dbcontext.Authors.Local;
        }

        private void authorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            authorBindingSource.EndEdit();

            try
            {
                dbcontext.SaveChanges();
            }
            catch (DbEntityValidationException)
            {
                MessageBox.Show("FirstName and LastName must contain values", "Entity Validation Exception");
            }
        }
    }
}
