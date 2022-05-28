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

namespace Kütüphane
{
    public partial class ChangeBook : Form
    {
        private string BookName;
        private string AuthorName;
        private string YearOfPublication;
        private string TypeOfBook;

        public ChangeBook()
        {
            InitializeComponent();
            RefreshBookListView();
        }

        private void FillTextFromChosen()
        {
            if (lv_BooksChange.SelectedItems.Count > 0)
            {
                BookName = lv_BooksChange.SelectedItems[0].SubItems[0].Text;
                AuthorName = lv_BooksChange.SelectedItems[0].SubItems[1].Text;
                YearOfPublication = lv_BooksChange.SelectedItems[0].SubItems[2].Text;
                TypeOfBook = lv_BooksChange.SelectedItems[0].SubItems[3].Text;

                tb_AuthorChange.Text = AuthorName;
                tb_BookNameChange.Text = BookName;
                tb_YearOfPublicationChange.Text = YearOfPublication;
                tb_TypeOfBookChange.Text = TypeOfBook;
            }
        }

        private void Clear()
        {
            tb_AuthorChange.Text = "";
            tb_BookNameChange.Text = "";
            tb_TypeOfBookChange.Text = "";
            tb_YearOfPublicationChange.Text = "";
        }

        private void RefreshBookListView()
        {
            lv_BooksChange.Clear();
            lv_BooksChange.View = View.Details;
            lv_BooksChange.GridLines = true;
            lv_BooksChange.FullRowSelect = true;
            lv_BooksChange.Columns.Add("Kitap adı", 122);
            lv_BooksChange.Columns.Add("Yazarın adı", 122);
            lv_BooksChange.Columns.Add("Basım yılı", 122);
            lv_BooksChange.Columns.Add("Türü", 122);

            if (System.IO.File.Exists(JSONOperationBook.pathBook))
            {
                string json = System.IO.File.ReadAllText(JSONOperationBook.pathBook);
                int countofbooks = JArray.Parse(json).Count();
                for (int i = 0; i < countofbooks; i++)
                {
                    string[] row = { JArray.Parse(json).Children()["BookName"].ElementAt(i).ToString(),
                                     JArray.Parse(json).Children()["AuthorName"].ElementAt(i).ToString(),
                                     JArray.Parse(json).Children()["YearOfPublication"].ElementAt(i).ToString(),
                                     JArray.Parse(json).Children()["TypeOfBook"].ElementAt(i).ToString()
                    };
                    var listViewItem = new ListViewItem(row);
                    lv_BooksChange.Items.Add(listViewItem);
                }

            }
        }

        private void btn_ExitFromChangeBook_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ChangeBook_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < BookList.ListOfBooks.Count; i++)
            {
                if (BookList.ListOfBooks[i].AuthorName == AuthorName &&
                    BookList.ListOfBooks[i].BookName == BookName &&
                    BookList.ListOfBooks[i].YearOfPublication == YearOfPublication &&
                    BookList.ListOfBooks[i].TypeOfBook == TypeOfBook)
                {

                    BookList.ListOfBooks[i].AuthorName = tb_AuthorChange.Text;
                    BookList.ListOfBooks[i].BookName = tb_BookNameChange.Text;
                    BookList.ListOfBooks[i].YearOfPublication = tb_YearOfPublicationChange.Text;
                    BookList.ListOfBooks[i].TypeOfBook = tb_TypeOfBookChange.Text;
                    JSONOperationBook.CreateJson();
                    MessageBox.Show("Seçilen kitap değiştirildi. Görebilmek için listeyi yenileyiniz.");
                    Clear();
                    break;
                }
            }

        }

        private void lv_BooksChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTextFromChosen();
        }

        private void btn_CancelChange_Click(object sender, EventArgs e)
        {
            FillTextFromChosen();
        }

        private void btn_RefreshChange_Click(object sender, EventArgs e)
        {
            RefreshBookListView();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lv_BooksChange.Items)
            {
                if (item.SubItems[0].Text == tb_bookname.Text && item.SubItems[1].Text == tb_authorname.Text)
                {
                    item.Selected = true;
                    break;
                }
            }
        }

        private void tb_bookname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void tb_authorname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void tb_BookNameChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void tb_AuthorChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void tb_TypeOfBookChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void tb_YearOfPublicationChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
