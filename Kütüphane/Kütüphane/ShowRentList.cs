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
    public partial class ShowRentList : Form
    {
        
        public ShowRentList()
        {
            InitializeComponent();
            RefreshRentedBookListView();
        }

        private void RefreshRentedBookListView()
        {
            lv_RentBookList.Clear();
            lv_RentBookList.View = View.Details;
            lv_RentBookList.GridLines = true;
            lv_RentBookList.FullRowSelect = true;
            lv_RentBookList.Columns.Add("Kiralanan kitap", 104);
            lv_RentBookList.Columns.Add("Adı Soyadı", 104);
            lv_RentBookList.Columns.Add("Telefon numarası", 104);
            lv_RentBookList.Columns.Add("Kiralanma tarihi", 104);
            lv_RentBookList.Columns.Add("Kiralama süresi", 103);
            

            if (System.IO.File.Exists(JSONOperationRent.pathRent))
            {
                string json = System.IO.File.ReadAllText(JSONOperationRent.pathRent);
                int countofrent = JArray.Parse(json).Count();
                for (int i = 0; i < countofrent; i++)
                {
                    string[] row = { JArray.Parse(json).Children()["RentedBookName"].ElementAt(i).ToString(),
                                     JArray.Parse(json).Children()["PersonName"].ElementAt(i).ToString(),
                                     JArray.Parse(json).Children()["PersonPhoneNo"].ElementAt(i).ToString(),
                                     JArray.Parse(json).Children()["RentDate"].ElementAt(i).ToString(),
                                     JArray.Parse(json).Children()["RentalPeriod"].ElementAt(i).ToString()
                    };
                    var listViewItem = new ListViewItem(row);
                    lv_RentBookList.Items.Add(listViewItem);
                }

            }
        }

        private void btn_ExitFromRentBookList_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_RefreshRentList_Click(object sender, EventArgs e)
        {
            RefreshRentedBookListView();
        }

        private void btn_returnedBook_Click(object sender, EventArgs e)
        {
            RentList.ListOfRent.RemoveAt(lv_RentBookList.SelectedItems[0].Index);
            if(RentList.ListOfRent.Count == 0)
            {
                System.IO.File.Delete(JSONOperationRent.pathRent);
            }
            else
            {
                JSONOperationRent.CreateJson();
            }
           
        }
    }
}
