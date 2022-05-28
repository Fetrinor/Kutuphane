
namespace Kütüphane
{
    partial class ChangeBook
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
            this.lv_BooksChange = new System.Windows.Forms.ListView();
            this.tb_TypeOfBookChange = new System.Windows.Forms.TextBox();
            this.lbl_TypeOfBookChange = new System.Windows.Forms.Label();
            this.tb_YearOfPublicationChange = new System.Windows.Forms.TextBox();
            this.lbl_YearOfPublicationChange = new System.Windows.Forms.Label();
            this.tb_BookNameChange = new System.Windows.Forms.TextBox();
            this.lbl_BookNameChange = new System.Windows.Forms.Label();
            this.tb_AuthorChange = new System.Windows.Forms.TextBox();
            this.lbl_AuthorChange = new System.Windows.Forms.Label();
            this.btn_ChangeBook = new System.Windows.Forms.Button();
            this.btn_ExitFromChangeBook = new System.Windows.Forms.Button();
            this.btn_CancelChange = new System.Windows.Forms.Button();
            this.btn_RefreshChange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_authorname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_bookname = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_BooksChange
            // 
            this.lv_BooksChange.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lv_BooksChange.HideSelection = false;
            this.lv_BooksChange.Location = new System.Drawing.Point(12, 12);
            this.lv_BooksChange.MultiSelect = false;
            this.lv_BooksChange.Name = "lv_BooksChange";
            this.lv_BooksChange.Size = new System.Drawing.Size(488, 358);
            this.lv_BooksChange.TabIndex = 1;
            this.lv_BooksChange.UseCompatibleStateImageBehavior = false;
            this.lv_BooksChange.SelectedIndexChanged += new System.EventHandler(this.lv_BooksChange_SelectedIndexChanged);
            // 
            // tb_TypeOfBookChange
            // 
            this.tb_TypeOfBookChange.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_TypeOfBookChange.Location = new System.Drawing.Point(638, 190);
            this.tb_TypeOfBookChange.Name = "tb_TypeOfBookChange";
            this.tb_TypeOfBookChange.Size = new System.Drawing.Size(145, 22);
            this.tb_TypeOfBookChange.TabIndex = 15;
            this.tb_TypeOfBookChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_TypeOfBookChange_KeyPress);
            // 
            // lbl_TypeOfBookChange
            // 
            this.lbl_TypeOfBookChange.AutoSize = true;
            this.lbl_TypeOfBookChange.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_TypeOfBookChange.Location = new System.Drawing.Point(523, 193);
            this.lbl_TypeOfBookChange.Name = "lbl_TypeOfBookChange";
            this.lbl_TypeOfBookChange.Size = new System.Drawing.Size(39, 15);
            this.lbl_TypeOfBookChange.TabIndex = 14;
            this.lbl_TypeOfBookChange.Text = "Türü:";
            // 
            // tb_YearOfPublicationChange
            // 
            this.tb_YearOfPublicationChange.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_YearOfPublicationChange.Location = new System.Drawing.Point(638, 162);
            this.tb_YearOfPublicationChange.Name = "tb_YearOfPublicationChange";
            this.tb_YearOfPublicationChange.Size = new System.Drawing.Size(145, 22);
            this.tb_YearOfPublicationChange.TabIndex = 13;
            this.tb_YearOfPublicationChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_YearOfPublicationChange_KeyPress);
            // 
            // lbl_YearOfPublicationChange
            // 
            this.lbl_YearOfPublicationChange.AutoSize = true;
            this.lbl_YearOfPublicationChange.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_YearOfPublicationChange.Location = new System.Drawing.Point(523, 165);
            this.lbl_YearOfPublicationChange.Name = "lbl_YearOfPublicationChange";
            this.lbl_YearOfPublicationChange.Size = new System.Drawing.Size(67, 15);
            this.lbl_YearOfPublicationChange.TabIndex = 12;
            this.lbl_YearOfPublicationChange.Text = "Basım yılı:";
            // 
            // tb_BookNameChange
            // 
            this.tb_BookNameChange.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_BookNameChange.Location = new System.Drawing.Point(638, 106);
            this.tb_BookNameChange.Name = "tb_BookNameChange";
            this.tb_BookNameChange.Size = new System.Drawing.Size(145, 22);
            this.tb_BookNameChange.TabIndex = 9;
            this.tb_BookNameChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_BookNameChange_KeyPress);
            // 
            // lbl_BookNameChange
            // 
            this.lbl_BookNameChange.AutoSize = true;
            this.lbl_BookNameChange.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_BookNameChange.Location = new System.Drawing.Point(523, 109);
            this.lbl_BookNameChange.Name = "lbl_BookNameChange";
            this.lbl_BookNameChange.Size = new System.Drawing.Size(70, 15);
            this.lbl_BookNameChange.TabIndex = 10;
            this.lbl_BookNameChange.Text = "Kitabın adı:";
            // 
            // tb_AuthorChange
            // 
            this.tb_AuthorChange.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_AuthorChange.Location = new System.Drawing.Point(638, 134);
            this.tb_AuthorChange.Name = "tb_AuthorChange";
            this.tb_AuthorChange.Size = new System.Drawing.Size(145, 22);
            this.tb_AuthorChange.TabIndex = 11;
            this.tb_AuthorChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_AuthorChange_KeyPress);
            // 
            // lbl_AuthorChange
            // 
            this.lbl_AuthorChange.AutoSize = true;
            this.lbl_AuthorChange.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_AuthorChange.Location = new System.Drawing.Point(523, 137);
            this.lbl_AuthorChange.Name = "lbl_AuthorChange";
            this.lbl_AuthorChange.Size = new System.Drawing.Size(109, 15);
            this.lbl_AuthorChange.TabIndex = 8;
            this.lbl_AuthorChange.Text = "Yazarın adı soyadı:";
            // 
            // btn_ChangeBook
            // 
            this.btn_ChangeBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ChangeBook.Location = new System.Drawing.Point(536, 237);
            this.btn_ChangeBook.Name = "btn_ChangeBook";
            this.btn_ChangeBook.Size = new System.Drawing.Size(103, 45);
            this.btn_ChangeBook.TabIndex = 16;
            this.btn_ChangeBook.Text = "Degistir";
            this.btn_ChangeBook.UseVisualStyleBackColor = true;
            this.btn_ChangeBook.Click += new System.EventHandler(this.btn_ChangeBook_Click);
            // 
            // btn_ExitFromChangeBook
            // 
            this.btn_ExitFromChangeBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ExitFromChangeBook.Location = new System.Drawing.Point(687, 312);
            this.btn_ExitFromChangeBook.Name = "btn_ExitFromChangeBook";
            this.btn_ExitFromChangeBook.Size = new System.Drawing.Size(96, 45);
            this.btn_ExitFromChangeBook.TabIndex = 19;
            this.btn_ExitFromChangeBook.Text = "Geri";
            this.btn_ExitFromChangeBook.UseVisualStyleBackColor = true;
            this.btn_ExitFromChangeBook.Click += new System.EventHandler(this.btn_ExitFromChangeBook_Click);
            // 
            // btn_CancelChange
            // 
            this.btn_CancelChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_CancelChange.Location = new System.Drawing.Point(536, 312);
            this.btn_CancelChange.Name = "btn_CancelChange";
            this.btn_CancelChange.Size = new System.Drawing.Size(103, 45);
            this.btn_CancelChange.TabIndex = 18;
            this.btn_CancelChange.Text = "Geri Al";
            this.btn_CancelChange.UseVisualStyleBackColor = true;
            this.btn_CancelChange.Click += new System.EventHandler(this.btn_CancelChange_Click);
            // 
            // btn_RefreshChange
            // 
            this.btn_RefreshChange.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_RefreshChange.Location = new System.Drawing.Point(687, 237);
            this.btn_RefreshChange.Name = "btn_RefreshChange";
            this.btn_RefreshChange.Size = new System.Drawing.Size(96, 45);
            this.btn_RefreshChange.TabIndex = 17;
            this.btn_RefreshChange.Text = "Listeyi Yenile";
            this.btn_RefreshChange.UseVisualStyleBackColor = true;
            this.btn_RefreshChange.Click += new System.EventHandler(this.btn_RefreshChange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(523, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Yazar adı:";
            // 
            // tb_authorname
            // 
            this.tb_authorname.Location = new System.Drawing.Point(586, 46);
            this.tb_authorname.Name = "tb_authorname";
            this.tb_authorname.Size = new System.Drawing.Size(197, 20);
            this.tb_authorname.TabIndex = 23;
            this.tb_authorname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_authorname_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(522, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Kitap adı:";
            // 
            // tb_bookname
            // 
            this.tb_bookname.Location = new System.Drawing.Point(586, 20);
            this.tb_bookname.Name = "tb_bookname";
            this.tb_bookname.Size = new System.Drawing.Size(197, 20);
            this.tb_bookname.TabIndex = 21;
            this.tb_bookname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_bookname_KeyPress);
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Search.Location = new System.Drawing.Point(622, 74);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(79, 26);
            this.btn_Search.TabIndex = 20;
            this.btn_Search.Text = "Ara";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // ChangeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 382);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_authorname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_bookname);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_RefreshChange);
            this.Controls.Add(this.btn_CancelChange);
            this.Controls.Add(this.btn_ChangeBook);
            this.Controls.Add(this.btn_ExitFromChangeBook);
            this.Controls.Add(this.tb_TypeOfBookChange);
            this.Controls.Add(this.lbl_TypeOfBookChange);
            this.Controls.Add(this.tb_YearOfPublicationChange);
            this.Controls.Add(this.lbl_YearOfPublicationChange);
            this.Controls.Add(this.tb_BookNameChange);
            this.Controls.Add(this.lbl_BookNameChange);
            this.Controls.Add(this.tb_AuthorChange);
            this.Controls.Add(this.lbl_AuthorChange);
            this.Controls.Add(this.lv_BooksChange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChangeBook";
            this.Text = "Kitap Değiştir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_BooksChange;
        private System.Windows.Forms.TextBox tb_TypeOfBookChange;
        private System.Windows.Forms.Label lbl_TypeOfBookChange;
        private System.Windows.Forms.TextBox tb_YearOfPublicationChange;
        private System.Windows.Forms.Label lbl_YearOfPublicationChange;
        private System.Windows.Forms.TextBox tb_BookNameChange;
        private System.Windows.Forms.Label lbl_BookNameChange;
        private System.Windows.Forms.TextBox tb_AuthorChange;
        private System.Windows.Forms.Label lbl_AuthorChange;
        private System.Windows.Forms.Button btn_ChangeBook;
        private System.Windows.Forms.Button btn_ExitFromChangeBook;
        private System.Windows.Forms.Button btn_CancelChange;
        private System.Windows.Forms.Button btn_RefreshChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_authorname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_bookname;
        private System.Windows.Forms.Button btn_Search;
    }
}