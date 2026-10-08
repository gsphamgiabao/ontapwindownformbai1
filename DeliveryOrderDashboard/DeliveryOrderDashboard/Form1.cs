using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryOrderDashboard
{
    public partial class Form1 : Form
    {
        private const int COLUMN_ITEM_NAME = 0;
        private const int COLUMN_QUANTITY = 1;
        private const int COLUMN_WEIGHT = 2;
        private const int COLUMN_UNIT_PRICE = 3;
        private const int COLUMN_TOTAL_PRICE = 4;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize DataGridView columns
            InitializeDataGridView();

            // Start timer for system time display
            tmrSystemTime.Interval = 1000;
            tmrSystemTime.Start();

            // Display initial time
            UpdateSystemTime();
        }

        private void InitializeDataGridView()
        {
            dgvItems.Columns.Clear();

            // Add columns
            DataGridViewTextBoxColumn colItemName = new DataGridViewTextBoxColumn();
            colItemName.Name = "ItemName";
            colItemName.HeaderText = "Item Name";
            colItemName.Width = 150;
            dgvItems.Columns.Add(colItemName);

            DataGridViewTextBoxColumn colQuantity = new DataGridViewTextBoxColumn();
            colQuantity.Name = "Quantity";
            colQuantity.HeaderText = "Quantity";
            colQuantity.Width = 80;
            colQuantity.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvItems.Columns.Add(colQuantity);

            DataGridViewTextBoxColumn colWeight = new DataGridViewTextBoxColumn();
            colWeight.Name = "Weight";
            colWeight.HeaderText = "Weight (kg)";
            colWeight.Width = 80;
            colWeight.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvItems.Columns.Add(colWeight);

            DataGridViewTextBoxColumn colUnitPrice = new DataGridViewTextBoxColumn();
            colUnitPrice.Name = "UnitPrice";
            colUnitPrice.HeaderText = "Unit Price";
            colUnitPrice.Width = 100;
            colUnitPrice.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvItems.Columns.Add(colUnitPrice);

            DataGridViewTextBoxColumn colTotalPrice = new DataGridViewTextBoxColumn();
            colTotalPrice.Name = "TotalPrice";
            colTotalPrice.HeaderText = "Total Price";
            colTotalPrice.Width = 100;
            colTotalPrice.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colTotalPrice.ReadOnly = true;
            dgvItems.Columns.Add(colTotalPrice);

            // Event handlers
            dgvItems.CellEndEdit += DgvItems_CellEndEdit;
            dgvItems.CellValidating += DgvItems_CellValidating;
            dgvItems.DataError += DgvItems_DataError;

            // Add a blank row
            AddNewRow();
        }

        private void AddNewRow()
        {
            dgvItems.Rows.Add();
        }

        private void DgvItems_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Validate Quantity and Weight columns
            if (e.ColumnIndex == COLUMN_QUANTITY || e.ColumnIndex == COLUMN_WEIGHT)
            {
                try
                {
                    string value = e.FormattedValue.ToString().Trim();

                    // Allow empty cells
                    if (string.IsNullOrEmpty(value))
                    {
                        errorProvider1.SetError(dgvItems, string.Empty);
                        return;
                    }

                    decimal numValue = decimal.Parse(value);

                    if (numValue <= 0)
                    {
                        e.Cancel = true;
                        dgvItems.Rows[e.RowIndex].ErrorText = e.ColumnIndex == COLUMN_QUANTITY 
                            ? "Quantity must be greater than 0" 
                            : "Weight must be greater than 0";
                        errorProvider1.SetError(dgvItems, 
                            e.ColumnIndex == COLUMN_QUANTITY 
                                ? "Quantity must be greater than 0" 
                                : "Weight must be greater than 0");
                    }
                    else
                    {
                        e.Cancel = false;
                        dgvItems.Rows[e.RowIndex].ErrorText = string.Empty;
                        errorProvider1.SetError(dgvItems, string.Empty);
                    }
                }
                catch (FormatException)
                {
                    e.Cancel = true;
                    dgvItems.Rows[e.RowIndex].ErrorText = "Invalid number format";
                    errorProvider1.SetError(dgvItems, "Invalid number format");
                }
                catch (OverflowException)
                {
                    e.Cancel = true;
                    dgvItems.Rows[e.RowIndex].ErrorText = "Number too large";
                    errorProvider1.SetError(dgvItems, "Number too large");
                }
            }
        }

        private void DgvItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // When Quantity or Unit Price changes, calculate Total Price
            if (e.ColumnIndex == COLUMN_QUANTITY || e.ColumnIndex == COLUMN_UNIT_PRICE)
            {
                CalculateTotalPrice(e.RowIndex);
            }

            // Update status bar totals after any cell edit
            UpdateStatusStripTotals();
        }

        private void CalculateTotalPrice(int rowIndex)
        {
            try
            {
                DataGridViewRow row = dgvItems.Rows[rowIndex];

                string qtyStr = row.Cells[COLUMN_QUANTITY].Value?.ToString() ?? "0";
                string priceStr = row.Cells[COLUMN_UNIT_PRICE].Value?.ToString() ?? "0";

                if (decimal.TryParse(qtyStr, out decimal qty) &&
                    decimal.TryParse(priceStr, out decimal unitPrice))
                {
                    decimal totalPrice = qty * unitPrice;
                    row.Cells[COLUMN_TOTAL_PRICE].Value = totalPrice.ToString("F2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total price: " + ex.Message);
            }
        }

        private void UpdateStatusStripTotals()
        {
            try
            {
                decimal totalQty = 0;
                decimal totalWeight = 0;
                decimal totalAmount = 0;

                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    // Sum quantities
                    if (row.Cells[COLUMN_QUANTITY].Value != null &&
                        decimal.TryParse(row.Cells[COLUMN_QUANTITY].Value.ToString(), out decimal qty))
                    {
                        totalQty += qty;
                    }

                    // Sum weights
                    if (row.Cells[COLUMN_WEIGHT].Value != null &&
                        decimal.TryParse(row.Cells[COLUMN_WEIGHT].Value.ToString(), out decimal weight))
                    {
                        totalWeight += weight;
                    }

                    // Sum total prices
                    if (row.Cells[COLUMN_TOTAL_PRICE].Value != null &&
                        decimal.TryParse(row.Cells[COLUMN_TOTAL_PRICE].Value.ToString(), out decimal totalPrice))
                    {
                        totalAmount += totalPrice;
                    }
                }

                tslblTotalQty.Text = $"Total Qty: {totalQty}";
                tslblTotalWeight.Text = $"Total Weight: {totalWeight:F2} kg";
                tslblTotalAmount.Text = $"Total: {totalAmount:F2} VND";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating totals: " + ex.Message);
            }
        }

        private void TmrSystemTime_Tick(object sender, EventArgs e)
        {
            UpdateSystemTime();
        }

        private void UpdateSystemTime()
        {
            tslblSystemTime.Text = $"Time: {DateTime.Now:HH:mm:ss}";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // F2 to add new row
            if (e.KeyCode == Keys.F2)
            {
                AddNewRow();
                e.Handled = true;
            }

            // Delete to remove selected row
            if (e.KeyCode == Keys.Delete)
            {
                if (dgvItems.SelectedRows.Count > 0)
                {
                    // Don't allow deleting if there's only one row
                    if (dgvItems.Rows.Count > 1)
                    {
                        int selectedRowIndex = dgvItems.SelectedRows[0].Index;
                        dgvItems.Rows.RemoveAt(selectedRowIndex);
                        UpdateStatusStripTotals();
                    }
                    e.Handled = true;
                }
            }
        }

        private void DgvItems_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Handle data errors in DataGridView cells
            e.ThrowException = false;
        }
    }
}
