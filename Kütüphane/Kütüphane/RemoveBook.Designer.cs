
namespace Kütüphane
{
    partial class RemoveBook
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
            this.lbl_RemoveBookName = new System.Windows.Forms.Label();
            this.tb_BookNameRemove = new System.Windows.Forms.TextBox();
            this.btn_ExitFromRemoveBook = new System.Windows.Forms.Button();
            this.btn_RemoveBook = new System.Windows.Forms.Button();
            this.tb_AuthorNameRemove = new System.Windows.Forms.TextBox();
            this.lbl_RemoveAuthorName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_RemoveBookName
            // 
            this.lbl_RemoveBookName.AutoSize = true;
            this.lbl_RemoveBookName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_RemoveBookName.Location = new System.Drawing.Point(22, 26);
            this.lbl_RemoveBookName.Name = "lbl_RemoveBookName";
            this.lbl_RemoveBookName.Size = new System.Drawing.Size(59, 15);
            this.lbl_RemoveBookName.TabIndex = 0;
            this.lbl_RemoveBookName.Text = "Kitap adı:";
            // 
            // tb_BookNameRemove
            // 
            this.tb_BookNameRemove.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_BookNameRemove.Location = new System.Drawing.Point(100, 19);
            this.tb_BookNameRemove.Name = "tb_BookNameRemove";
            this.tb_BookNameRemove.Size = new System.Drawing.Size(173, 22);
            this.tb_BookNameRemove.TabIndex = 4;
            this.tb_BookNameRemove.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_BookNameRemove_KeyPress);
            // 
            // btn_ExitFromRemoveBook
            // 
            this.btn_ExitFromRemoveBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ExitFromRemoveBook.Location = new System.Drawing.Point(158, 75);
            this.btn_ExitFromRemoveBook.Name = "btn_ExitFromRemoveBook";
            this.btn_ExitFromRemoveBook.Size = new System.Drawing.Size(85, 35);
            this.btn_ExitFromRemoveBook.TabIndex = 10;
            this.btn_ExitFromRemoveBook.Text = "Geri";
            this.btn_ExitFromRemoveBook.UseVisualStyleBackColor = true;
            this.btn_ExitFromRemoveBook.Click += new System.EventHandler(this.btn_ExitFromRemoveBook_Click);
            // 
            // btn_RemoveBook
            // 
            this.btn_RemoveBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_RemoveBook.Location = new System.Drawing.Point(53, 75);
            this.btn_RemoveBook.Name = "btn_RemoveBook";
            this.btn_RemoveBook.Size = new System.Drawing.Size(85, 35);
            this.btn_RemoveBook.TabIndex = 11;
            this.btn_RemoveBook.Text = "Çıkar";
            this.btn_RemoveBook.UseVisualStyleBackColor = true;
            this.btn_RemoveBook.Click += new System.EventHandler(this.btn_RemoveBook_Click);
            // 
            // tb_AuthorNameRemove
            // 
            this.tb_AuthorNameRemove.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_AuthorNameRemove.Location = new System.Drawing.Point(100, 47);
            this.tb_AuthorNameRemove.Name = "tb_AuthorNameRemove";
            this.tb_AuthorNameRemove.Size = new System.Drawing.Size(173, 22);
            this.tb_AuthorNameRemove.TabIndex = 13;
            this.tb_AuthorNameRemove.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_AuthorNameRemove_KeyPress);
            // 
            // lbl_RemoveAuthorName
            // 
            this.lbl_RemoveAuthorName.AutoSize = true;
            this.lbl_RemoveAuthorName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_RemoveAuthorName.Location = new System.Drawing.Point(22, 54);
            this.lbl_RemoveAuthorName.Name = "lbl_RemoveAuthorName";
            this.lbl_RemoveAuthorName.Size = new System.Drawing.Size(72, 15);
            this.lbl_RemoveAuthorName.TabIndex = 12;
            this.lbl_RemoveAuthorName.Text = "Yazarın adı:";
            // 
            // RemoveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 122);
            this.Controls.Add(this.tb_AuthorNameRemove);
            this.Controls.Add(this.lbl_RemoveAuthorName);
            this.Controls.Add(this.btn_RemoveBook);
            this.Controls.Add(this.btn_ExitFromRemoveBook);
            this.Controls.Add(this.tb_BookNameRemove);
            this.Controls.Add(this.lbl_RemoveBookName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RemoveBook";
            this.Text = "Kitap Çıkar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_RemoveBookName;
        private System.Windows.Forms.TextBox tb_BookNameRemove;
        private System.Windows.Forms.Button btn_ExitFromRemoveBook;
        private System.Windows.Forms.Button btn_RemoveBook;
        private System.Windows.Forms.TextBox tb_AuthorNameRemove;
        private System.Windows.Forms.Label lbl_RemoveAuthorName;
    }
}