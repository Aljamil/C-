using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoinQueries
{
    public partial class JoiningTableData : Form
    {
        public JoiningTableData()
        {
            InitializeComponent();
        }

        private void JoiningTableData_Load(object sender, EventArgs e)
        {
            BookExamples.BooksEntities dbcontext =
                new BookExamples.BooksEntities();

            var authorsAndISBNs =
                from author in dbcontext.Authors
                from book in author.Titles
                orderby author.LastName, author.FirstName
                select new { author.FirstName, author.LastName, book.ISBN };

            outputTextBox.AppendText("Authors and ISBNs");

            foreach(var element in authorsAndISBNs)
            {
                outputTextBox.AppendText(
                    String.Format("\r\n\t{0,-10}{1,-10}{2,-10}",
                    element.FirstName, element.LastName, element.ISBN));
            }

            var authorAndTitles =
                from book in dbcontext.Titles
                from author in book.Authors
                orderby author.LastName, author.FirstName, book.BookTitle
                select new { author.FirstName, author.LastName, book.BookTitle };

            outputTextBox.AppendText("\r\n\r\nAuthors and Titles:");

            foreach(var element in authorAndTitles)
            {
                outputTextBox.AppendText(String.Format("\r\n\t{0, -10}{1,-10}{2}",
                    element.FirstName, element.LastName, element.BookTitle));
            }

            var titlesByAuthor = from author in dbcontext.Authors
                                 orderby author.LastName, author.FirstName
                                 select new
                                 {
                                     Name = author.FirstName + " " + author.LastName,
                                     Titles = from book in author.Titles
                                              orderby book.BookTitle
                                              select book.BookTitle
                                 };

            outputTextBox.AppendText("\r\n\r\nTitles grouped by author: ");
            foreach(var author in titlesByAuthor)
            {
                outputTextBox.AppendText("\r\n\t" + author.Name + ": ");

                foreach(var title in author.Titles)
                {
                    outputTextBox.AppendText("\r\n\t\t" + title);
                }
            }

        }
    }
}
