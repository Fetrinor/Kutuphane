
namespace Kütüphane
{
    partial class ShowSellList
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
            this.lv_SellBookList = new System.Windows.Forms.ListView();
            this.btn_ExitFromSellBookList = new System.Windows.Forms.Button();
            this.btn_RefreshSoldList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_SellBookList
            // 
            this.lv_SellBookList.HideSelection = false;
            this.lv_SellBookList.Location = new System.Drawing.Point(12, 12);
            this.lv_SellBookList.Name = "lv_SellBookList";
            this.lv_SellBookList.Size = new System.Drawing.Size(521, 148);
            this.lv_SellBookList.TabIndex = 0;
            this.lv_SellBookList.UseCompatibleStateImageBehavior = false;
            // 
            // btn_ExitFromSellBookList
            // 
            this.btn_ExitFromSellBookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ExitFromSellBookList.Location = new System.Drawing.Point(282, 166);
            this.btn_ExitFromSellBookList.Name = "btn_ExitFromSellBookList";
            this.btn_ExitFromSellBookList.Size = new System.Drawing.Size(103, 45);
            this.btn_ExitFromSellBookList.TabIndex = 24;
            this.btn_ExitFromSellBookList.Text = "Geri";
            this.btn_ExitFromSellBookList.UseVisualStyleBackColor = true;
            this.btn_ExitFromSellBookList.Click += new System.EventHandler(this.btn_ExitFromSellBookList_Click);
            // 
            // btn_RefreshSoldList
            // 
            this.btn_RefreshSoldList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_RefreshSoldList.Location = new System.Drawing.Point(173, 166);
            this.btn_RefreshSoldList.Name = "btn_RefreshSoldList";
            this.btn_RefreshSoldList.Size = new System.Drawing.Size(103, 45);
            this.btn_RefreshSoldList.TabIndex = 25;
            this.btn_RefreshSoldList.Text = "Listeyi yenile";
            this.btn_RefreshSoldList.UseVisualStyleBackColor = true;
            this.btn_RefreshSoldList.Click += new System.EventHandler(this.btn_RefreshSoldList_Click);
            // 
            // ShowSellList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 233);
            this.Controls.Add(this.btn_RefreshSoldList);
            this.Controls.Add(this.btn_ExitFromSellBookList);
            this.Controls.Add(this.lv_SellBookList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ShowSellList";
            this.Text = "Satılan Kitaplar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_SellBookList;
        private System.Windows.Forms.Button btn_ExitFromSellBookList;
        private System.Windows.Forms.Button btn_RefreshSoldList;
    }
}