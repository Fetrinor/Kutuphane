
namespace Kütüphane
{
    partial class ShowRentList
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
            this.btn_ExitFromRentBookList = new System.Windows.Forms.Button();
            this.lv_RentBookList = new System.Windows.Forms.ListView();
            this.btn_RefreshRentList = new System.Windows.Forms.Button();
            this.btn_returnedBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ExitFromRentBookList
            // 
            this.btn_ExitFromRentBookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ExitFromRentBookList.Location = new System.Drawing.Point(424, 166);
            this.btn_ExitFromRentBookList.Name = "btn_ExitFromRentBookList";
            this.btn_ExitFromRentBookList.Size = new System.Drawing.Size(103, 45);
            this.btn_ExitFromRentBookList.TabIndex = 29;
            this.btn_ExitFromRentBookList.Text = "Geri";
            this.btn_ExitFromRentBookList.UseVisualStyleBackColor = true;
            this.btn_ExitFromRentBookList.Click += new System.EventHandler(this.btn_ExitFromRentBookList_Click);
            // 
            // lv_RentBookList
            // 
            this.lv_RentBookList.HideSelection = false;
            this.lv_RentBookList.Location = new System.Drawing.Point(12, 12);
            this.lv_RentBookList.Name = "lv_RentBookList";
            this.lv_RentBookList.Size = new System.Drawing.Size(520, 148);
            this.lv_RentBookList.TabIndex = 26;
            this.lv_RentBookList.UseCompatibleStateImageBehavior = false;
            // 
            // btn_RefreshRentList
            // 
            this.btn_RefreshRentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_RefreshRentList.Location = new System.Drawing.Point(315, 166);
            this.btn_RefreshRentList.Name = "btn_RefreshRentList";
            this.btn_RefreshRentList.Size = new System.Drawing.Size(103, 45);
            this.btn_RefreshRentList.TabIndex = 28;
            this.btn_RefreshRentList.Text = "Listeyi yenile";
            this.btn_RefreshRentList.UseVisualStyleBackColor = true;
            this.btn_RefreshRentList.Click += new System.EventHandler(this.btn_RefreshRentList_Click);
            // 
            // btn_returnedBook
            // 
            this.btn_returnedBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_returnedBook.Location = new System.Drawing.Point(206, 166);
            this.btn_returnedBook.Name = "btn_returnedBook";
            this.btn_returnedBook.Size = new System.Drawing.Size(103, 45);
            this.btn_returnedBook.TabIndex = 27;
            this.btn_returnedBook.Text = "İade edildi";
            this.btn_returnedBook.UseVisualStyleBackColor = true;
            this.btn_returnedBook.Click += new System.EventHandler(this.btn_returnedBook_Click);
            // 
            // ShowRentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 220);
            this.Controls.Add(this.btn_returnedBook);
            this.Controls.Add(this.btn_RefreshRentList);
            this.Controls.Add(this.btn_ExitFromRentBookList);
            this.Controls.Add(this.lv_RentBookList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ShowRentList";
            this.Text = "Kiralatılan Kitaplar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ExitFromRentBookList;
        private System.Windows.Forms.ListView lv_RentBookList;
        private System.Windows.Forms.Button btn_RefreshRentList;
        private System.Windows.Forms.Button btn_returnedBook;
    }
}