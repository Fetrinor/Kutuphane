
namespace Kütüphane
{
    partial class SellBook
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
            this.btn_SellBook = new System.Windows.Forms.Button();
            this.btn_ExitFromSellBook = new System.Windows.Forms.Button();
            this.tb_SellPrice = new System.Windows.Forms.TextBox();
            this.lb_SellPrice = new System.Windows.Forms.Label();
            this.lb_PhoneNoSell = new System.Windows.Forms.Label();
            this.tb_NameSell = new System.Windows.Forms.TextBox();
            this.lb_NameSell = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_BookNameSell = new System.Windows.Forms.Label();
            this.mtb_PhoneNoSell = new System.Windows.Forms.MaskedTextBox();
            this.cb_BookNameSell = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_SellBook
            // 
            this.btn_SellBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SellBook.Location = new System.Drawing.Point(35, 184);
            this.btn_SellBook.Name = "btn_SellBook";
            this.btn_SellBook.Size = new System.Drawing.Size(103, 45);
            this.btn_SellBook.TabIndex = 34;
            this.btn_SellBook.Text = "Sat";
            this.btn_SellBook.UseVisualStyleBackColor = true;
            this.btn_SellBook.Click += new System.EventHandler(this.btn_SellBook_Click);
            // 
            // btn_ExitFromSellBook
            // 
            this.btn_ExitFromSellBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ExitFromSellBook.Location = new System.Drawing.Point(162, 184);
            this.btn_ExitFromSellBook.Name = "btn_ExitFromSellBook";
            this.btn_ExitFromSellBook.Size = new System.Drawing.Size(96, 45);
            this.btn_ExitFromSellBook.TabIndex = 35;
            this.btn_ExitFromSellBook.Text = "Geri";
            this.btn_ExitFromSellBook.UseVisualStyleBackColor = true;
            this.btn_ExitFromSellBook.Click += new System.EventHandler(this.btn_ExitFromSellBook_Click);
            // 
            // tb_SellPrice
            // 
            this.tb_SellPrice.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_SellPrice.Location = new System.Drawing.Point(133, 144);
            this.tb_SellPrice.Name = "tb_SellPrice";
            this.tb_SellPrice.Size = new System.Drawing.Size(145, 22);
            this.tb_SellPrice.TabIndex = 33;
            this.tb_SellPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_SellPrice_KeyPress);
            // 
            // lb_SellPrice
            // 
            this.lb_SellPrice.AutoSize = true;
            this.lb_SellPrice.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_SellPrice.Location = new System.Drawing.Point(18, 147);
            this.lb_SellPrice.Name = "lb_SellPrice";
            this.lb_SellPrice.Size = new System.Drawing.Size(38, 15);
            this.lb_SellPrice.TabIndex = 32;
            this.lb_SellPrice.Text = "Fiyat:";
            // 
            // lb_PhoneNoSell
            // 
            this.lb_PhoneNoSell.AutoSize = true;
            this.lb_PhoneNoSell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_PhoneNoSell.Location = new System.Drawing.Point(18, 119);
            this.lb_PhoneNoSell.Name = "lb_PhoneNoSell";
            this.lb_PhoneNoSell.Size = new System.Drawing.Size(108, 15);
            this.lb_PhoneNoSell.TabIndex = 30;
            this.lb_PhoneNoSell.Text = "Telefon Numarası:";
            // 
            // tb_NameSell
            // 
            this.tb_NameSell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_NameSell.Location = new System.Drawing.Point(133, 88);
            this.tb_NameSell.Name = "tb_NameSell";
            this.tb_NameSell.Size = new System.Drawing.Size(145, 22);
            this.tb_NameSell.TabIndex = 29;
            this.tb_NameSell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_NameSell_KeyPress);
            // 
            // lb_NameSell
            // 
            this.lb_NameSell.AutoSize = true;
            this.lb_NameSell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_NameSell.Location = new System.Drawing.Point(18, 91);
            this.lb_NameSell.Name = "lb_NameSell";
            this.lb_NameSell.Size = new System.Drawing.Size(67, 15);
            this.lb_NameSell.TabIndex = 28;
            this.lb_NameSell.Text = "Adı soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Satın alacak kişinin;";
            // 
            // lbl_BookNameSell
            // 
            this.lbl_BookNameSell.AutoSize = true;
            this.lbl_BookNameSell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_BookNameSell.Location = new System.Drawing.Point(18, 15);
            this.lbl_BookNameSell.Name = "lbl_BookNameSell";
            this.lbl_BookNameSell.Size = new System.Drawing.Size(70, 15);
            this.lbl_BookNameSell.TabIndex = 25;
            this.lbl_BookNameSell.Text = "Kitabın adı:";
            // 
            // mtb_PhoneNoSell
            // 
            this.mtb_PhoneNoSell.Location = new System.Drawing.Point(133, 119);
            this.mtb_PhoneNoSell.Mask = "(999) 000-0000";
            this.mtb_PhoneNoSell.Name = "mtb_PhoneNoSell";
            this.mtb_PhoneNoSell.Size = new System.Drawing.Size(145, 20);
            this.mtb_PhoneNoSell.TabIndex = 31;
            this.mtb_PhoneNoSell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtb_PhoneNoSell_KeyPress);
            // 
            // cb_BookNameSell
            // 
            this.cb_BookNameSell.FormattingEnabled = true;
            this.cb_BookNameSell.Location = new System.Drawing.Point(133, 12);
            this.cb_BookNameSell.Name = "cb_BookNameSell";
            this.cb_BookNameSell.Size = new System.Drawing.Size(145, 21);
            this.cb_BookNameSell.TabIndex = 26;
            this.cb_BookNameSell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_BookNameSell_KeyPress);
            // 
            // SellBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 253);
            this.Controls.Add(this.cb_BookNameSell);
            this.Controls.Add(this.mtb_PhoneNoSell);
            this.Controls.Add(this.btn_SellBook);
            this.Controls.Add(this.btn_ExitFromSellBook);
            this.Controls.Add(this.tb_SellPrice);
            this.Controls.Add(this.lb_SellPrice);
            this.Controls.Add(this.lb_PhoneNoSell);
            this.Controls.Add(this.tb_NameSell);
            this.Controls.Add(this.lb_NameSell);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_BookNameSell);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SellBook";
            this.Text = "Kitap Sat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SellBook_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SellBook;
        private System.Windows.Forms.Button btn_ExitFromSellBook;
        private System.Windows.Forms.TextBox tb_SellPrice;
        private System.Windows.Forms.Label lb_SellPrice;
        private System.Windows.Forms.Label lb_PhoneNoSell;
        private System.Windows.Forms.TextBox tb_NameSell;
        private System.Windows.Forms.Label lb_NameSell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_BookNameSell;
        private System.Windows.Forms.MaskedTextBox mtb_PhoneNoSell;
        private System.Windows.Forms.ComboBox cb_BookNameSell;
    }
}