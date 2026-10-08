namespace ServiceChargeCalculator
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
            this.components = new System.ComponentModel.Container();
            this.labelUnitPrice = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.labelTotalText = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUnitPrice
            // 
            this.labelUnitPrice.AutoSize = true;
            this.labelUnitPrice.Location = new System.Drawing.Point(24, 24);
            this.labelUnitPrice.Name = "labelUnitPrice";
            this.labelUnitPrice.Size = new System.Drawing.Size(98, 17);
            this.labelUnitPrice.TabIndex = 0;
            this.labelUnitPrice.Text = "Đơn giá dịch vụ:";
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(160, 21);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(160, 22);
            this.textBoxUnitPrice.TabIndex = 0;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(24, 64);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(95, 17);
            this.labelQuantity.TabIndex = 0;
            this.labelQuantity.Text = "Số lượng khách:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(160, 61);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(160, 22);
            this.textBoxQuantity.TabIndex = 1;
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(24, 104);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(84, 17);
            this.labelDiscount.TabIndex = 0;
            this.labelDiscount.Text = "Mã giảm giá (%):";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Location = new System.Drawing.Point(160, 101);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(160, 22);
            this.textBoxDiscount.TabIndex = 2;
            // 
            // labelTotalText
            // 
            this.labelTotalText.AutoSize = true;
            this.labelTotalText.Location = new System.Drawing.Point(24, 148);
            this.labelTotalText.Name = "labelTotalText";
            this.labelTotalText.Size = new System.Drawing.Size(97, 17);
            this.labelTotalText.TabIndex = 0;
            this.labelTotalText.Text = "Tổng thanh toán:";
            // 
            // labelTotal
            // 
            this.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotal.Location = new System.Drawing.Point(160, 142);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(160, 28);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "0.00";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(160, 190);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 30);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "Tính tiền";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(245, 190);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 30);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Làm mới";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 250);
            this.Controls.Add(this.labelUnitPrice);
            this.Controls.Add(this.textBoxUnitPrice);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.labelTotalText);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonReset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Charge Calculator";
            this.AcceptButton = this.buttonCalculate;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelUnitPrice;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.TextBox textBoxUnitPrice;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.Label labelTotalText;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonReset;

        #endregion
    }
}

