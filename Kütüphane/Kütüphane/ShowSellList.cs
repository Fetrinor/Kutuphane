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
    public partial class ShowSellList : Form
    {
        public ShowSellList()
        {
            InitializeComponent();
            RefreshSoldBookListView();
        }

        private void RefreshSoldBookListView()
        {
            lv_SellBookList.Clear();
            lv_SellBookList.View = View.Details;
            lv_SellBookList.GridLines = true;
            lv_SellBookList.FullRowSelect = true;
            lv_SellBookList.Columns.Add("Kiralanan kitap", 104);
            lv_SellBookList.Columns.Add("Adı Soyadı", 104);
            lv_SellBookList.Columns.Add("Telefon numarası", 104);
            lv_SellBookList.Columns.Add("Kiralanma tar", 104);
            lv_SellBookList.Columns.Add("Kiralama süresi", 103);


            if (System.IO.File.Exists(JSONOperationSold.pathSold))
            {
                string json = System.IO.File.ReadAllText(JSONOperationSold.pathSold);
                int countofsold = JArray.Parse(json).Count();
                for (int i = 0; i < countofsold; i++)
                {
                    string[] row = { JArray.Parse(json).Children()["SoldBookName"].ElementAt(i).ToString(),
                                     JArray.Parse(json).Children()["PersonName"].ElementAt(i).ToString(),
                                     JArray.Parse(json).Children()["PersonPhoneNo"].ElementAt(i).ToString(),
                                     JArray.Parse(json).Children()["SaleDate"].ElementAt(i).ToString(),
                                     JArray.Parse(json).Children()["SalePrice"].ElementAt(i).ToString()
                    };
                    var listViewItem = new ListViewItem(row);
                    lv_SellBookList.Items.Add(listViewItem);
                }

            }
        }

        private void btn_ExitFromSellBookList_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_RefreshSoldList_Click(object sender, EventArgs e)
        {
            RefreshSoldBookListView();
        }
    }
}
