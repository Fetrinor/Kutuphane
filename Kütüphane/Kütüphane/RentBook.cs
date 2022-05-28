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
    public partial class RentBook : Form
    {
        private RentPerson person;
        public RentBook()
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
                    cb_BookNameRent.Items.Add(bookname);
                }

            }
        }

        private void btn_ExitFromRentBook_Click(object sender, EventArgs e)
        {
            JSONOperationRent.CreateJson();
            this.Close();
        }

        private void btn_RentBook_Click(object sender, EventArgs e)
        {
            if (mtb_PhoneNoRent.MaskCompleted && tb_NameRent.Text != "" && cb_BookNameRent.Text != "" && tb_RentalPeriod.Text != "")
            {
                person = new RentPerson(cb_BookNameRent.Text, tb_NameRent.Text, mtb_PhoneNoRent.Text, tb_RentalPeriod.Text);
                RentList.AddToRentList(person);
                for (int i = 0; i < BookList.ListOfBooks.Count; i++)
                {
                    if (BookList.ListOfBooks[i].BookName == cb_BookNameRent.Text)
                    {
                        MessageBox.Show(BookList.ListOfBooks[i].BookName + " kitabı kiralandı.");
                        BookList.ListOfBooks.RemoveAt(i);
                        if(BookList.ListOfBooks.Count == 0)
                        {
                            System.IO.File.Delete(JSONOperationBook.pathBook);
                        }
                        else
                        {
                            JSONOperationBook.CreateJson();
                        }
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Bilgileri eksik girdiniz.");
            }
           
        }

        private void RentBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            JSONOperationRent.CreateJson();
        }

        private void tb_NameRent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

        private void tb_RentalPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void mtb_PhoneNoRent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cb_BookNameRent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
