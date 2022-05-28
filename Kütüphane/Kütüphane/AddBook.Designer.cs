
namespace Kütüphane
{
    partial class AddBook
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
            this.lbl_Author = new System.Windows.Forms.Label();
            this.tb_AuthorAdd = new System.Windows.Forms.TextBox();
            this.tb_BookNameAdd = new System.Windows.Forms.TextBox();
            this.lbl_BookName = new System.Windows.Forms.Label();
            this.lbl_YearOfPublication = new System.Windows.Forms.Label();
            this.tb_TypeOfBookAdd = new System.Windows.Forms.TextBox();
            this.lbl_TypeOfBook = new System.Windows.Forms.Label();
            this.btn_AddBook = new System.Windows.Forms.Button();
            this.btn_ExitFromAddBook = new System.Windows.Forms.Button();
            this.tb_YearOfPublicationAdd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Author
            // 
            this.lbl_Author.AutoSize = true;
            this.lbl_Author.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Author.Location = new System.Drawing.Point(12, 31);
            this.lbl_Author.Name = "lbl_Author";
            this.lbl_Author.Size = new System.Drawing.Size(109, 15);
            this.lbl_Author.TabIndex = 0;
            this.lbl_Author.Text = "Yazarın adı soyadı:";
            // 
            // tb_AuthorAdd
            // 
            this.tb_AuthorAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_AuthorAdd.Location = new System.Drawing.Point(127, 28);
            this.tb_AuthorAdd.Name = "tb_AuthorAdd";
            this.tb_AuthorAdd.Size = new System.Drawing.Size(145, 22);
            this.tb_AuthorAdd.TabIndex = 1;
            this.tb_AuthorAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_AuthorAdd_KeyPress);
            // 
            // tb_BookNameAdd
            // 
            this.tb_BookNameAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_BookNameAdd.Location = new System.Drawing.Point(127, 56);
            this.tb_BookNameAdd.Name = "tb_BookNameAdd";
            this.tb_BookNameAdd.Size = new System.Drawing.Size(145, 22);
            this.tb_BookNameAdd.TabIndex = 3;
            this.tb_BookNameAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_BookNameAdd_KeyPress);
            // 
            // lbl_BookName
            // 
            this.lbl_BookName.AutoSize = true;
            this.lbl_BookName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_BookName.Location = new System.Drawing.Point(12, 59);
            this.lbl_BookName.Name = "lbl_BookName";
            this.lbl_BookName.Size = new System.Drawing.Size(70, 15);
            this.lbl_BookName.TabIndex = 2;
            this.lbl_BookName.Text = "Kitabın adı:";
            // 
            // lbl_YearOfPublication
            // 
            this.lbl_YearOfPublication.AutoSize = true;
            this.lbl_YearOfPublication.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_YearOfPublication.Location = new System.Drawing.Point(12, 87);
            this.lbl_YearOfPublication.Name = "lbl_YearOfPublication";
            this.lbl_YearOfPublication.Size = new System.Drawing.Size(67, 15);
            this.lbl_YearOfPublication.TabIndex = 4;
            this.lbl_YearOfPublication.Text = "Basım yılı:";
            // 
            // tb_TypeOfBookAdd
            // 
            this.tb_TypeOfBookAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_TypeOfBookAdd.Location = new System.Drawing.Point(127, 112);
            this.tb_TypeOfBookAdd.Name = "tb_TypeOfBookAdd";
            this.tb_TypeOfBookAdd.Size = new System.Drawing.Size(145, 22);
            this.tb_TypeOfBookAdd.TabIndex = 7;
            this.tb_TypeOfBookAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_TypeOfBookAdd_KeyPress);
            // 
            // lbl_TypeOfBook
            // 
            this.lbl_TypeOfBook.AutoSize = true;
            this.lbl_TypeOfBook.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_TypeOfBook.Location = new System.Drawing.Point(12, 115);
            this.lbl_TypeOfBook.Name = "lbl_TypeOfBook";
            this.lbl_TypeOfBook.Size = new System.Drawing.Size(39, 15);
            this.lbl_TypeOfBook.TabIndex = 6;
            this.lbl_TypeOfBook.Text = "Türü:";
            // 
            // btn_AddBook
            // 
            this.btn_AddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AddBook.Location = new System.Drawing.Point(56, 144);
            this.btn_AddBook.Name = "btn_AddBook";
            this.btn_AddBook.Size = new System.Drawing.Size(85, 35);
            this.btn_AddBook.TabIndex = 8;
            this.btn_AddBook.Text = "Ekle";
            this.btn_AddBook.UseVisualStyleBackColor = true;
            this.btn_AddBook.Click += new System.EventHandler(this.btn_AddBook_Click);
            // 
            // btn_ExitFromAddBook
            // 
            this.btn_ExitFromAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ExitFromAddBook.Location = new System.Drawing.Point(147, 144);
            this.btn_ExitFromAddBook.Name = "btn_ExitFromAddBook";
            this.btn_ExitFromAddBook.Size = new System.Drawing.Size(85, 35);
            this.btn_ExitFromAddBook.TabIndex = 9;
            this.btn_ExitFromAddBook.Text = "Geri";
            this.btn_ExitFromAddBook.UseVisualStyleBackColor = true;
            this.btn_ExitFromAddBook.Click += new System.EventHandler(this.btn_ExitFromAddBook_Click);
            // 
            // tb_YearOfPublicationAdd
            // 
            this.tb_YearOfPublicationAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_YearOfPublicationAdd.Location = new System.Drawing.Point(127, 84);
            this.tb_YearOfPublicationAdd.Name = "tb_YearOfPublicationAdd";
            this.tb_YearOfPublicationAdd.Size = new System.Drawing.Size(145, 22);
            this.tb_YearOfPublicationAdd.TabIndex = 5;
            this.tb_YearOfPublicationAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_YearOfPublicationAdd_KeyPress);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 196);
            this.Controls.Add(this.btn_ExitFromAddBook);
            this.Controls.Add(this.btn_AddBook);
            this.Controls.Add(this.tb_TypeOfBookAdd);
            this.Controls.Add(this.lbl_TypeOfBook);
            this.Controls.Add(this.tb_YearOfPublicationAdd);
            this.Controls.Add(this.lbl_YearOfPublication);
            this.Controls.Add(this.tb_BookNameAdd);
            this.Controls.Add(this.lbl_BookName);
            this.Controls.Add(this.tb_AuthorAdd);
            this.Controls.Add(this.lbl_Author);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddBook";
            this.Text = "Kitap Ekle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddBook_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Author;
        private System.Windows.Forms.TextBox tb_AuthorAdd;
        private System.Windows.Forms.TextBox tb_BookNameAdd;
        private System.Windows.Forms.Label lbl_BookName;
        private System.Windows.Forms.Label lbl_YearOfPublication;
        private System.Windows.Forms.TextBox tb_TypeOfBookAdd;
        private System.Windows.Forms.Label lbl_TypeOfBook;
        private System.Windows.Forms.Button btn_AddBook;
        private System.Windows.Forms.Button btn_ExitFromAddBook;
        private System.Windows.Forms.TextBox tb_YearOfPublicationAdd;
    }
}