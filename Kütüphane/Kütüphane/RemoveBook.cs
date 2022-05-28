using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Kütüphane
{
    public partial class RemoveBook : Form
    {
        private bool deletedBookflag = false;
        public RemoveBook()
        {
            InitializeComponent();
        }

        private void btn_ExitFromRemoveBook_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_RemoveBook_Click(object sender, EventArgs e)
        {
            deletedBookflag = false;
            for(int i = 0; i < BookList.ListOfBooks.Count; i++)
            {
                if(BookList.ListOfBooks[i].BookName == tb_BookNameRemove.Text && BookList.ListOfBooks[i].AuthorName == tb_AuthorNameRemove.Text)
                {
                    BookList.ListOfBooks.Remove(BookList.ListOfBooks[i]);
                    deletedBookflag = true;
                }
            }
            if (BookList.ListOfBooks.Count == 0)
            {
                System.IO.File.Delete(JSONOperationBook.pathBook);
            }
            else
            {
                JSONOperationBook.CreateJson();
            }
            if (deletedBookflag)
            {
                MessageBox.Show(tb_BookNameRemove.Text + " kitabı çıkartıldı.");
            }
            else
            {
                MessageBox.Show("Kitap bulunamadı. Girilen bilgileri kontrol ediniz.");
            }

            
        }

        private void tb_BookNameRemove_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

        private void tb_AuthorNameRemove_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }
    }
}
