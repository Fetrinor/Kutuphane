
namespace Kütüphane
{
    partial class Library
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lv_books = new System.Windows.Forms.ListView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_Rent = new System.Windows.Forms.Button();
            this.btn_Sell = new System.Windows.Forms.Button();
            this.btn_ListRent = new System.Windows.Forms.Button();
            this.btn_ListSell = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_bookname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_authorname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lv_books
            // 
            this.lv_books.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lv_books.HideSelection = false;
            this.lv_books.Location = new System.Drawing.Point(14, 43);
            this.lv_books.MultiSelect = false;
            this.lv_books.Name = "lv_books";
            this.lv_books.Size = new System.Drawing.Size(404, 363);
            this.lv_books.TabIndex = 0;
            this.lv_books.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Add.Location = new System.Drawing.Point(423, 43);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(132, 35);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Kitap Ekle";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Remove.Location = new System.Drawing.Point(423, 84);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(132, 35);
            this.btn_Remove.TabIndex = 2;
            this.btn_Remove.Text = "Kitap Çıkar";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Change
            // 
            this.btn_Change.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Change.Location = new System.Drawing.Point(423, 125);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(132, 35);
            this.btn_Change.TabIndex = 3;
            this.btn_Change.Text = "Kitap Değiştir";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // btn_Rent
            // 
            this.btn_Rent.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Rent.Location = new System.Drawing.Point(423, 166);
            this.btn_Rent.Name = "btn_Rent";
            this.btn_Rent.Size = new System.Drawing.Size(132, 35);
            this.btn_Rent.TabIndex = 4;
            this.btn_Rent.Text = "Kitap Kiralat";
            this.btn_Rent.UseVisualStyleBackColor = true;
            this.btn_Rent.Click += new System.EventHandler(this.btn_Rent_Click);
            // 
            // btn_Sell
            // 
            this.btn_Sell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sell.Location = new System.Drawing.Point(423, 207);
            this.btn_Sell.Name = "btn_Sell";
            this.btn_Sell.Size = new System.Drawing.Size(132, 35);
            this.btn_Sell.TabIndex = 5;
            this.btn_Sell.Text = "Kitap Sat";
            this.btn_Sell.UseVisualStyleBackColor = true;
            this.btn_Sell.Click += new System.EventHandler(this.btn_Sell_Click);
            // 
            // btn_ListRent
            // 
            this.btn_ListRent.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ListRent.Location = new System.Drawing.Point(423, 248);
            this.btn_ListRent.Name = "btn_ListRent";
            this.btn_ListRent.Size = new System.Drawing.Size(132, 35);
            this.btn_ListRent.TabIndex = 6;
            this.btn_ListRent.Text = "Kiralatılan Kitaplar";
            this.btn_ListRent.UseVisualStyleBackColor = true;
            this.btn_ListRent.Click += new System.EventHandler(this.btn_ListRent_Click);
            // 
            // btn_ListSell
            // 
            this.btn_ListSell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ListSell.Location = new System.Drawing.Point(423, 289);
            this.btn_ListSell.Name = "btn_ListSell";
            this.btn_ListSell.Size = new System.Drawing.Size(132, 35);
            this.btn_ListSell.TabIndex = 7;
            this.btn_ListSell.Text = "Satılan Kitaplar";
            this.btn_ListSell.UseVisualStyleBackColor = true;
            this.btn_ListSell.Click += new System.EventHandler(this.btn_ListSell_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Exit.Location = new System.Drawing.Point(423, 371);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(132, 35);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "Çıkış";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Refresh.Location = new System.Drawing.Point(424, 330);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(132, 35);
            this.btn_Refresh.TabIndex = 9;
            this.btn_Refresh.Text = "Listeyi Yenile";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Search.Location = new System.Drawing.Point(412, 9);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(79, 26);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.Text = "Ara";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_bookname
            // 
            this.tb_bookname.Location = new System.Drawing.Point(76, 11);
            this.tb_bookname.Name = "tb_bookname";
            this.tb_bookname.Size = new System.Drawing.Size(135, 20);
            this.tb_bookname.TabIndex = 11;
            this.tb_bookname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_bookname_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kitap adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(217, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Yazar adı:";
            // 
            // tb_authorname
            // 
            this.tb_authorname.Location = new System.Drawing.Point(281, 11);
            this.tb_authorname.Name = "tb_authorname";
            this.tb_authorname.Size = new System.Drawing.Size(125, 20);
            this.tb_authorname.TabIndex = 13;
            this.tb_authorname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_authorname_KeyPress);
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 418);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_authorname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_bookname);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_ListSell);
            this.Controls.Add(this.btn_ListRent);
            this.Controls.Add(this.btn_Sell);
            this.Controls.Add(this.btn_Rent);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lv_books);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Library";
            this.Text = "Kütüphane";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Library_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_books;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button btn_Rent;
        private System.Windows.Forms.Button btn_Sell;
        private System.Windows.Forms.Button btn_ListRent;
        private System.Windows.Forms.Button btn_ListSell;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_bookname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_authorname;
    }
}

