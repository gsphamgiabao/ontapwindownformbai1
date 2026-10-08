using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemListManager
{
    public partial class Form1 : Form
    {
        private List<Item> items = new List<Item>();
        private int selectedIndex = -1;

        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            if (cmbUnit.Items.Count == 0)
            {
                cmbUnit.Items.Add("Cái");
                cmbUnit.Items.Add("Bộ");
                cmbUnit.Items.Add("Kg");
                cmbUnit.Items.Add("Mét");
            }
            if (cmbUnit.Items.Count > 0)
                cmbUnit.SelectedIndex = 0;
        }

        private void ClearInputFields()
        {
            txtItemCode.Clear();
            txtItemName.Clear();
            txtPrice.Clear();
            cmbUnit.SelectedIndex = 0;
            txtItemCode.Focus();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtItemCode.Text))
            {
                MessageBox.Show("Vui lòng nhập mã vật tư!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtItemCode.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtItemName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên vật tư!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtItemName.Focus();
                return false;
            }

            if (cmbUnit.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đơn vị tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbUnit.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Vui lòng nhập đơn giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Đơn giá phải là số dương hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return false;
            }

            return true;
        }

        private bool IsDuplicateCode(string code, int excludeIndex = -1)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (i != excludeIndex && items[i].ItemCode.Equals(code, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        private void RefreshListView()
        {
            listViewItems.Items.Clear();
            foreach (var item in items)
            {
                ListViewItem lvi = new ListViewItem(item.ItemCode);
                lvi.SubItems.Add(item.ItemName);
                lvi.SubItems.Add(item.Unit);
                lvi.SubItems.Add(item.Price.ToString("F2"));
                listViewItems.Items.Add(lvi);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            if (IsDuplicateCode(txtItemCode.Text))
            {
                MessageBox.Show("Mã vật tư này đã tồn tại trong danh sách! Vui lòng nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtItemCode.Focus();
                return;
            }

            Item newItem = new Item(
                txtItemCode.Text.Trim(),
                txtItemName.Text.Trim(),
                cmbUnit.SelectedItem.ToString(),
                decimal.Parse(txtPrice.Text)
            );

            items.Add(newItem);
            RefreshListView();
            ClearInputFields();

            MessageBox.Show("Thêm vật tư thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một dòng trong danh sách để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput())
                return;

            // Check if the new code is different and already exists
            if (!items[selectedIndex].ItemCode.Equals(txtItemCode.Text, StringComparison.OrdinalIgnoreCase) 
                && IsDuplicateCode(txtItemCode.Text, selectedIndex))
            {
                MessageBox.Show("Mã vật tư này đã tồn tại trong danh sách! Vui lòng nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtItemCode.Focus();
                return;
            }

            items[selectedIndex].ItemCode = txtItemCode.Text.Trim();
            items[selectedIndex].ItemName = txtItemName.Text.Trim();
            items[selectedIndex].Unit = cmbUnit.SelectedItem.ToString();
            items[selectedIndex].Price = decimal.Parse(txtPrice.Text);

            RefreshListView();
            ClearInputFields();
            selectedIndex = -1;

            MessageBox.Show("Cập nhật vật tư thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một dòng trong danh sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa dòng này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                items.RemoveAt(selectedIndex);
                RefreshListView();
                ClearInputFields();
                selectedIndex = -1;

                MessageBox.Show("Xóa vật tư thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (items.Count == 0)
            {
                MessageBox.Show("Danh sách đã trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa toàn bộ dữ liệu?",
                "Xác nhận xóa toàn bộ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                items.Clear();
                RefreshListView();
                ClearInputFields();
                selectedIndex = -1;

                MessageBox.Show("Xóa toàn bộ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listViewItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewItems.SelectedItems.Count > 0)
            {
                selectedIndex = listViewItems.SelectedIndices[0];
                Item item = items[selectedIndex];

                txtItemCode.Text = item.ItemCode;
                txtItemName.Text = item.ItemName;
                cmbUnit.SelectedItem = item.Unit;
                txtPrice.Text = item.Price.ToString("F2");
            }
            else
            {
                selectedIndex = -1;
            }
        }
    }
}
