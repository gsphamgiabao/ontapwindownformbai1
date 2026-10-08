namespace Interactive_Slot_Booking
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSelectedCount = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.comboBoxTimeFrame = new System.Windows.Forms.ComboBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancelAll = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelStats = new System.Windows.Forms.Panel();
            this.labelCountText = new System.Windows.Forms.Label();
            this.labelTimeText = new System.Windows.Forms.Label();
            this.labelPriceText = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.SuspendLayout();

            // tableLayoutPanel1
            this.tableLayoutPanel1.AutoScroll = false;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 320);
            this.tableLayoutPanel1.TabIndex = 0;

            // labelTitle
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(600, 50);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "CHỌN VỊ TRÍ CHỖ NGỒI";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // panelTitle
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(600, 50);
            this.panelTitle.TabIndex = 5;

            // labelCountText
            this.labelCountText.AutoSize = true;
            this.labelCountText.Font = new System.Drawing.Font("Arial", 11F);
            this.labelCountText.Location = new System.Drawing.Point(10, 10);
            this.labelCountText.Name = "labelCountText";
            this.labelCountText.Size = new System.Drawing.Size(150, 17);
            this.labelCountText.TabIndex = 0;
            this.labelCountText.Text = "Số vị trí đang chọn:";

            // labelSelectedCount
            this.labelSelectedCount.BackColor = System.Drawing.Color.LightGray;
            this.labelSelectedCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSelectedCount.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.labelSelectedCount.Location = new System.Drawing.Point(170, 10);
            this.labelSelectedCount.Name = "labelSelectedCount";
            this.labelSelectedCount.Size = new System.Drawing.Size(100, 25);
            this.labelSelectedCount.TabIndex = 1;
            this.labelSelectedCount.Text = "0";
            this.labelSelectedCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // labelTimeText
            this.labelTimeText.AutoSize = true;
            this.labelTimeText.Font = new System.Drawing.Font("Arial", 11F);
            this.labelTimeText.Location = new System.Drawing.Point(10, 45);
            this.labelTimeText.Name = "labelTimeText";
            this.labelTimeText.Size = new System.Drawing.Size(82, 17);
            this.labelTimeText.TabIndex = 2;
            this.labelTimeText.Text = "Khung giờ:";

            // comboBoxTimeFrame
            this.comboBoxTimeFrame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTimeFrame.Font = new System.Drawing.Font("Arial", 11F);
            this.comboBoxTimeFrame.FormattingEnabled = true;
            this.comboBoxTimeFrame.Items.AddRange(new object[] {
            "Sáng - 100.000đ",
            "Tối - 150.000đ"});
            this.comboBoxTimeFrame.Location = new System.Drawing.Point(170, 42);
            this.comboBoxTimeFrame.Name = "comboBoxTimeFrame";
            this.comboBoxTimeFrame.Size = new System.Drawing.Size(200, 25);
            this.comboBoxTimeFrame.TabIndex = 3;

            // labelPriceText
            this.labelPriceText.AutoSize = true;
            this.labelPriceText.Font = new System.Drawing.Font("Arial", 11F);
            this.labelPriceText.Location = new System.Drawing.Point(10, 80);
            this.labelPriceText.Name = "labelPriceText";
            this.labelPriceText.Size = new System.Drawing.Size(100, 17);
            this.labelPriceText.TabIndex = 4;
            this.labelPriceText.Text = "Tạm tính tiền:";

            // labelTotalPrice
            this.labelTotalPrice.BackColor = System.Drawing.Color.LightGray;
            this.labelTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalPrice.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.labelTotalPrice.Location = new System.Drawing.Point(170, 80);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(200, 25);
            this.labelTotalPrice.TabIndex = 5;
            this.labelTotalPrice.Text = "0đ";
            this.labelTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // buttonConfirm
            this.buttonConfirm.BackColor = System.Drawing.Color.Green;
            this.buttonConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfirm.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.buttonConfirm.ForeColor = System.Drawing.Color.White;
            this.buttonConfirm.Location = new System.Drawing.Point(170, 115);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(95, 30);
            this.buttonConfirm.TabIndex = 6;
            this.buttonConfirm.Text = "Xác nhận đặt";
            this.buttonConfirm.UseVisualStyleBackColor = false;

            // buttonCancelAll
            this.buttonCancelAll.BackColor = System.Drawing.Color.Red;
            this.buttonCancelAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelAll.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.buttonCancelAll.ForeColor = System.Drawing.Color.White;
            this.buttonCancelAll.Location = new System.Drawing.Point(275, 115);
            this.buttonCancelAll.Name = "buttonCancelAll";
            this.buttonCancelAll.Size = new System.Drawing.Size(95, 30);
            this.buttonCancelAll.TabIndex = 7;
            this.buttonCancelAll.Text = "Hủy chọn tất cả";
            this.buttonCancelAll.UseVisualStyleBackColor = false;

            // panelStats
            this.panelStats.Controls.Add(this.buttonCancelAll);
            this.panelStats.Controls.Add(this.buttonConfirm);
            this.panelStats.Controls.Add(this.labelTotalPrice);
            this.panelStats.Controls.Add(this.labelPriceText);
            this.panelStats.Controls.Add(this.comboBoxTimeFrame);
            this.panelStats.Controls.Add(this.labelTimeText);
            this.panelStats.Controls.Add(this.labelSelectedCount);
            this.panelStats.Controls.Add(this.labelCountText);
            this.panelStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStats.Location = new System.Drawing.Point(0, 370);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(600, 160);
            this.panelStats.TabIndex = 6;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(600, 530);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt Bàn Hẹn Giờ - Interactive Slot Booking";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelStats.ResumeLayout(false);
            this.panelStats.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelSelectedCount;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.ComboBox comboBoxTimeFrame;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancelAll;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label labelCountText;
        private System.Windows.Forms.Label labelTimeText;
        private System.Windows.Forms.Label labelPriceText;
    }
}

