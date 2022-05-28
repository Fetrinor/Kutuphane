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
    public partial class SellBook : Form
    {
        private SellPerson person;

        public SellBook()
        {
            InitializeComponent();
            FillComboBox();
        }

        private void FillComboBox()
        {
            if (System.IO.File.Exists(JSONOperationBook.pathBook))
            {
                string json = System.IO.File.ReadAllText(JSONOperationBook.pathBook);
                int countofbooks = JArray.Parse(json).Count();
                for (int i = 0; i < countofbooks; i++)
                {
                    string bookname = JArray.Parse(json).Children()["BookName"].ElementAt(i).ToString();
                    cb_BookNameSell.Items.Add(bookname);
                }

            }
        }

        private void btn_ExitFromSellBook_Click(object sender, EventArgs e)
        {
            JSONOperationSold.CreateJson();
            this.Close();
        }

        private void btn_SellBook_Click(object sender, EventArgs e)
        {
            if (mtb_PhoneNoSell.MaskCompleted && cb_BookNameSell.Text != "" && tb_NameSell.Text != "" && tb_SellPrice.Text != "")
            {
                person = new SellPerson(cb_BookNameSell.Text, tb_NameSell.Text, mtb_PhoneNoSell.Text, tb_SellPrice.Text);
                SellList.AddToSoldList(person);
                for (int i = 0; i < BookList.ListOfBooks.Count; i++)
                {
                    if (BookList.ListOfBooks[i].BookName == cb_BookNameSell.Text)
                    {
                        MessageBox.Show(BookList.ListOfBooks[i].BookName + " kitabı satıldı.");
                        BookList.ListOfBooks.RemoveAt(i);
                        JSONOperationBook.CreateJson();
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Bilgileri eksik girdiniz.");
            }
            
        }

        private void SellBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            JSONOperationSold.CreateJson();
        }

        private void mtb_PhoneNoSell_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_NameSell_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void tb_SellPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cb_BookNameSell_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
