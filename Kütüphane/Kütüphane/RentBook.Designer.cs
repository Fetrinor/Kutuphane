
namespace Kütüphane
{
    partial class RentBook
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
            this.lbl_BookNameRent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_NameRent = new System.Windows.Forms.TextBox();
            this.lb_NameRent = new System.Windows.Forms.Label();
            this.lb_PhoneNoRent = new System.Windows.Forms.Label();
            this.tb_RentalPeriod = new System.Windows.Forms.TextBox();
            this.lb_RentalPeriod = new System.Windows.Forms.Label();
            this.btn_RentBook = new System.Windows.Forms.Button();
            this.btn_ExitFromRentBook = new System.Windows.Forms.Button();
            this.mtb_PhoneNoRent = new System.Windows.Forms.MaskedTextBox();
            this.cb_BookNameRent = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_BookNameRent
            // 
            this.lbl_BookNameRent.AutoSize = true;
            this.lbl_BookNameRent.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_BookNameRent.Location = new System.Drawing.Point(14, 15);
            this.lbl_BookNameRent.Name = "lbl_BookNameRent";
            this.lbl_BookNameRent.Size = new System.Drawing.Size(70, 15);
            this.lbl_BookNameRent.TabIndex = 12;
            this.lbl_BookNameRent.Text = "Kitabın adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kiralayacak kişinin;";
            // 
            // tb_NameRent
            // 
            this.tb_NameRent.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_NameRent.Location = new System.Drawing.Point(148, 88);
            this.tb_NameRent.Name = "tb_NameRent";
            this.tb_NameRent.Size = new System.Drawing.Size(145, 22);
            this.tb_NameRent.TabIndex = 16;
            this.tb_NameRent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_NameRent_KeyPress);
            // 
            // lb_NameRent
            // 
            this.lb_NameRent.AutoSize = true;
            this.lb_NameRent.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_NameRent.Location = new System.Drawing.Point(14, 91);
            this.lb_NameRent.Name = "lb_NameRent";
            this.lb_NameRent.Size = new System.Drawing.Size(67, 15);
            this.lb_NameRent.TabIndex = 15;
            this.lb_NameRent.Text = "Adı soyadı:";
            // 
            // lb_PhoneNoRent
            // 
            this.lb_PhoneNoRent.AutoSize = true;
            this.lb_PhoneNoRent.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_PhoneNoRent.Location = new System.Drawing.Point(14, 119);
            this.lb_PhoneNoRent.Name = "lb_PhoneNoRent";
            this.lb_PhoneNoRent.Size = new System.Drawing.Size(108, 15);
            this.lb_PhoneNoRent.TabIndex = 17;
            this.lb_PhoneNoRent.Text = "Telefon Numarası:";
            // 
            // tb_RentalPeriod
            // 
            this.tb_RentalPeriod.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_RentalPeriod.Location = new System.Drawing.Point(148, 144);
            this.tb_RentalPeriod.Name = "tb_RentalPeriod";
            this.tb_RentalPeriod.Size = new System.Drawing.Size(145, 22);
            this.tb_RentalPeriod.TabIndex = 20;
            this.tb_RentalPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_RentalPeriod_KeyPress);
            // 
            // lb_RentalPeriod
            // 
            this.lb_RentalPeriod.AutoSize = true;
            this.lb_RentalPeriod.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_RentalPeriod.Location = new System.Drawing.Point(14, 147);
            this.lb_RentalPeriod.Name = "lb_RentalPeriod";
            this.lb_RentalPeriod.Size = new System.Drawing.Size(132, 15);
            this.lb_RentalPeriod.TabIndex = 19;
            this.lb_RentalPeriod.Text = "Kiralama süresi (gün):";
            // 
            // btn_RentBook
            // 
            this.btn_RentBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_RentBook.Location = new System.Drawing.Point(43, 184);
            this.btn_RentBook.Name = "btn_RentBook";
            this.btn_RentBook.Size = new System.Drawing.Size(103, 45);
            this.btn_RentBook.TabIndex = 24;
            this.btn_RentBook.Text = "Kirala";
            this.btn_RentBook.UseVisualStyleBackColor = true;
            this.btn_RentBook.Click += new System.EventHandler(this.btn_RentBook_Click);
            // 
            // btn_ExitFromRentBook
            // 
            this.btn_ExitFromRentBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ExitFromRentBook.Location = new System.Drawing.Point(172, 184);
            this.btn_ExitFromRentBook.Name = "btn_ExitFromRentBook";
            this.btn_ExitFromRentBook.Size = new System.Drawing.Size(96, 45);
            this.btn_ExitFromRentBook.TabIndex = 23;
            this.btn_ExitFromRentBook.Text = "Geri";
            this.btn_ExitFromRentBook.UseVisualStyleBackColor = true;
            this.btn_ExitFromRentBook.Click += new System.EventHandler(this.btn_ExitFromRentBook_Click);
            // 
            // mtb_PhoneNoRent
            // 
            this.mtb_PhoneNoRent.Location = new System.Drawing.Point(148, 116);
            this.mtb_PhoneNoRent.Mask = "(999) 000-0000";
            this.mtb_PhoneNoRent.Name = "mtb_PhoneNoRent";
            this.mtb_PhoneNoRent.Size = new System.Drawing.Size(145, 20);
            this.mtb_PhoneNoRent.TabIndex = 18;
            this.mtb_PhoneNoRent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtb_PhoneNoRent_KeyPress);
            // 
            // cb_BookNameRent
            // 
            this.cb_BookNameRent.FormattingEnabled = true;
            this.cb_BookNameRent.Location = new System.Drawing.Point(148, 15);
            this.cb_BookNameRent.Name = "cb_BookNameRent";
            this.cb_BookNameRent.Size = new System.Drawing.Size(145, 21);
            this.cb_BookNameRent.TabIndex = 13;
            this.cb_BookNameRent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_BookNameRent_KeyPress);
            // 
            // RentBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 250);
            this.Controls.Add(this.cb_BookNameRent);
            this.Controls.Add(this.mtb_PhoneNoRent);
            this.Controls.Add(this.btn_RentBook);
            this.Controls.Add(this.btn_ExitFromRentBook);
            this.Controls.Add(this.tb_RentalPeriod);
            this.Controls.Add(this.lb_RentalPeriod);
            this.Controls.Add(this.lb_PhoneNoRent);
            this.Controls.Add(this.tb_NameRent);
            this.Controls.Add(this.lb_NameRent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_BookNameRent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RentBook";
            this.Text = "Kitap Kiralat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RentBook_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_BookNameRent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_NameRent;
        private System.Windows.Forms.Label lb_NameRent;
        private System.Windows.Forms.Label lb_PhoneNoRent;
        private System.Windows.Forms.TextBox tb_RentalPeriod;
        private System.Windows.Forms.Label lb_RentalPeriod;
        private System.Windows.Forms.Button btn_RentBook;
        private System.Windows.Forms.Button btn_ExitFromRentBook;
        private System.Windows.Forms.MaskedTextBox mtb_PhoneNoRent;
        private System.Windows.Forms.ComboBox cb_BookNameRent;
    }
}