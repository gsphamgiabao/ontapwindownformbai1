using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceChargeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // Validate unit price
            if (string.IsNullOrWhiteSpace(textBoxUnitPrice.Text) ||
                !decimal.TryParse(textBoxUnitPrice.Text, out decimal unitPrice))
            {
                MessageBox.Show("Vui lòng nhập Đơn giá hợp lệ (số).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxUnitPrice.Focus();
                return;
            }

            // Validate quantity
            if (string.IsNullOrWhiteSpace(textBoxQuantity.Text) ||
                !int.TryParse(textBoxQuantity.Text, out int quantity))
            {
                MessageBox.Show("Vui lòng nhập Số lượng khách hợp lệ (số nguyên).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxQuantity.Focus();
                return;
            }

            // Validate discount (optional, default 0)
            decimal discount = 0m;
            if (!string.IsNullOrWhiteSpace(textBoxDiscount.Text))
            {
                if (!decimal.TryParse(textBoxDiscount.Text, out discount))
                {
                    MessageBox.Show("Vui lòng nhập Mã giảm giá hợp lệ (số: 0 - 100).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxDiscount.Focus();
                    return;
                }
            }

            if (discount < 0m || discount > 100m)
            {
                MessageBox.Show("Phần trăm giảm phải nằm trong khoảng 0 đến 100.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxDiscount.Focus();
                return;
            }

            // Compute total
            decimal total = unitPrice * quantity * (100m - discount) / 100m;

            labelTotal.Text = total.ToString("C");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxUnitPrice.Text = string.Empty;
            textBoxQuantity.Text = string.Empty;
            textBoxDiscount.Text = string.Empty;
            labelTotal.Text = "0.00";
            textBoxUnitPrice.Focus();
        }
    }
}
