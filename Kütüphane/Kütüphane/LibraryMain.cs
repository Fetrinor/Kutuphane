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
    
    public partial class Library : Form
    {
        private AddBook addBookForm;
        private RemoveBook removeBookForm;
        private ChangeBook changeBookForm;
        private RentBook rentBookForm;
        private SellBook sellBookForm;
        private ShowRentList showRentListForm;
        private ShowSellList showSellListForm;

        public Library()
        {
            InitializeComponent();
            JSONOperation.DeserializeJson();
            RefreshBookListView();
        }

        private void RefreshBookListView()
        {
            lv_books.Clear();
            lv_books.View = View.Details;
            lv_books.GridLines = true;
            lv_books.FullRowSelect = true;
            lv_books.Columns.Add("Kitap adı", 202);
            lv_books.Columns.Add("Yazarın adı", 202);
            
            if (System.IO.File.Exists(JSONOperationBook.pathBook))
            {
                string json = System.IO.File.ReadAllText(JSONOperationBook.pathBook);
                int countofbooks = JArray.Parse(json).Count();
                for (int i = 0; i < countofbooks; i++)
                {
                   string[] row = { JArray.Parse(json).Children()["BookName"].ElementAt(i).ToString(),
                                     JArray.Parse(json).Children()["AuthorName"].ElementAt(i).ToString()};
                var listViewItem = new ListViewItem(row);
                lv_books.Items.Add(listViewItem);
                }
                
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            addBookForm = new AddBook();
            addBookForm.Show();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            removeBookForm = new RemoveBook();
            removeBookForm.Show();
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            changeBookForm = new ChangeBook();
            changeBookForm.Show();
        }

        private void btn_Rent_Click(object sender, EventArgs e)
        {
            rentBookForm = new RentBook();
            rentBookForm.Show();
        }

        private void btn_Sell_Click(object sender, EventArgs e)
        {
            sellBookForm = new SellBook();
            sellBookForm.Show();
        }

        private void btn_ListRent_Click(object sender, EventArgs e)
        {
            showRentListForm = new ShowRentList();
            showRentListForm.Show();
        }

        private void btn_ListSell_Click(object sender, EventArgs e)
        {
            showSellListForm = new ShowSellList();
            showSellListForm.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            RefreshBookListView();
        }

        private void Library_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Program kapatılacak emin misiniz?", "Kapatma uyarısı", MessageBoxButtons.YesNo))
                e.Cancel = true;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lv_books.Items)
            {
                if(item.SubItems[0].Text == tb_bookname.Text && item.SubItems[1].Text == tb_authorname.Text)
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
    }
}
