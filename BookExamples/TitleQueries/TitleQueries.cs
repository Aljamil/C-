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

namespace TitleQueries
{
    public partial class TitleQueries : Form
    {
        public TitleQueries()
        {
            InitializeComponent();
        }

        private BookExamples.BooksEntities dbcontext =
            new BookExamples.BooksEntities();

        private void TitleQueries_Load(object sender, EventArgs e)
        {
            dbcontext.Titles.Load();

            queriesComboBox.SelectedIndex = 0;
        }

        private void queriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(queriesComboBox.SelectedIndex)
            {
                case 0:
                    titleBindingSource.DataSource =
                        dbcontext.Titles.Local.OrderBy(book => book.BookTitle);
                    break;
                case 1:
                    titleBindingSource.DataSource = dbcontext.Titles.Local
                        .Where(book => book.Copyright == "2008")
                        .OrderBy(book => book.BookTitle);
                    break;
                case 2:
                    titleBindingSource.DataSource = dbcontext.Titles.Local
                        .Where(book => book.BookTitle.EndsWith("How to Program"))
                        .OrderBy(book => book.BookTitle);
                    break;
            }
            titleBindingSource.MoveFirst();
        }
    }
}
