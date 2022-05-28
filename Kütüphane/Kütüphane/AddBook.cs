using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane
{
    public partial class AddBook : Form
    {
        private bool addedBookFlag = false;
        private Book book;
        public static bool trueorfalse;
        public AddBook()
        {
            InitializeComponent();
        }

        private void btn_ExitFromAddBook_Click(object sender, EventArgs e)
        {
            JSONOperationBook.CreateJson();
            this.Close();
        }

        private void btn_AddBook_Click(object sender, EventArgs e)
        {
            addedBookFlag = false;
            if(tb_BookNameAdd.Text == "" || tb_TypeOfBookAdd.Text == "")
            {
                MessageBox.Show("Kitabın adı ve türü olmak zorundadır.");
            }
            else if(tb_AuthorAdd.Text == "" && tb_YearOfPublicationAdd.Text != "") {
                book = new Book(tb_BookNameAdd.Text, tb_TypeOfBookAdd.Text, Convert.ToInt32(tb_YearOfPublicationAdd.Text));
                addedBookFlag = true;
            }
            else if(tb_YearOfPublicationAdd.Text == "")
            {
                book = new Book(tb_BookNameAdd.Text, tb_TypeOfBookAdd.Text, tb_AuthorAdd.Text);
                addedBookFlag = true;
            }
            else
            {
                book = new Book(tb_BookNameAdd.Text, tb_TypeOfBookAdd.Text, tb_AuthorAdd.Text, Convert.ToInt32(tb_YearOfPublicationAdd.Text));
                addedBookFlag = true;
            }
            if (addedBookFlag)
            {
                MessageBox.Show(tb_BookNameAdd.Text + " kitabı eklendi.");
                BookList.AddToBookList(book);
            }
            
            
        }

        private void AddBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            JSONOperationBook.CreateJson();
        }

        private void tb_AuthorAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void tb_BookNameAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void tb_YearOfPublicationAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_TypeOfBookAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
    }
}
