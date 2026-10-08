using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Interactive_Slot_Booking
{
    public partial class Form1 : Form
    {
        // Constants for button parameters
        private const int ROWS = 4;
        private const int COLS = 5;
        private const int TOTAL_POSITIONS = 20;
        private const int MORNING_PRICE = 100000;
        private const int EVENING_PRICE = 150000;

        // Dictionary to track button states: position number -> button state
        // State values: 0 = Empty (White), 1 = Selected (Green), 2 = Booked (Red)
        private Dictionary<int, int> positionStates = new Dictionary<int, int>();
        private List<Button> positionButtons = new List<Button>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize all position states as empty
            for (int i = 0; i < TOTAL_POSITIONS; i++)
            {
                positionStates[i] = 0; // 0 = Empty
            }

            // Generate 20 buttons dynamically in 4x5 grid
            CreatePositionButtons();

            // Register event handlers for control changes
            this.comboBoxTimeFrame.SelectedIndexChanged += ComboBoxTimeFrame_SelectedIndexChanged;
            this.buttonConfirm.Click += ButtonConfirm_Click;
            this.buttonCancelAll.Click += ButtonCancelAll_Click;

            // Set initial UI state
            UpdateStats();
        }

        /// <summary>
        /// Create 20 buttons dynamically in TableLayoutPanel (4x5 grid)
        /// </summary>
        private void CreatePositionButtons()
        {
            int buttonIndex = 0;

            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    Button btn = new Button();
                    btn.Text = (buttonIndex + 1).ToString(); // Position number 1-20
                    btn.Font = new Font("Arial", 12, FontStyle.Bold);
                    btn.Height = 60;
                    btn.Width = 80;
                    btn.BackColor = Color.White; // Initially empty (White)
                    btn.ForeColor = Color.Black;
                    btn.Cursor = Cursors.Hand;
                    btn.Tag = buttonIndex; // Store position number as tag

                    // Attach the shared event handler to all buttons
                    btn.Click += PositionButton_Click;

                    this.tableLayoutPanel1.Controls.Add(btn, col, row);
                    positionButtons.Add(btn);
                    buttonIndex++;
                }
            }
        }

        /// <summary>
        /// Shared event handler for all 20 position buttons (Event Aggregation pattern)
        /// </summary>
        private void PositionButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null) return;

            int positionNum = (int)clickedButton.Tag;

            // Toggle state between Empty (0) and Selected (1)
            // Don't allow toggling booked positions (2)
            if (positionStates[positionNum] == 0)
            {
                // Empty -> Selected
                positionStates[positionNum] = 1;
                clickedButton.BackColor = Color.LimeGreen; // Green for selected
            }
            else if (positionStates[positionNum] == 1)
            {
                // Selected -> Empty
                positionStates[positionNum] = 0;
                clickedButton.BackColor = Color.White; // White for empty
            }
            // If booked (2), do nothing

            // Update statistics in real-time
            UpdateStats();
        }

        /// <summary>
        /// Update the statistics display (selected count and total price)
        /// </summary>
        private void UpdateStats()
        {
            // Count selected positions
            int selectedCount = 0;
            foreach (var state in positionStates.Values)
            {
                if (state == 1) // Selected
                    selectedCount++;
            }

            // Get current time frame price
            int pricePerPosition = this.comboBoxTimeFrame.SelectedIndex == 0 ? MORNING_PRICE : EVENING_PRICE;
            int totalPrice = selectedCount * pricePerPosition;

            // Update labels
            this.labelSelectedCount.Text = selectedCount.ToString();
            this.labelTotalPrice.Text = string.Format("{0:N0}đ", totalPrice);
        }

        /// <summary>
        /// Event handler for ComboBox time frame selection change
        /// Recalculates and updates price when time frame changes
        /// </summary>
        private void ComboBoxTimeFrame_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStats();
        }

        /// <summary>
        /// Event handler for Confirm Booking button
        /// </summary>
        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            int selectedCount = 0;
            foreach (var state in positionStates.Values)
            {
                if (state == 1) selectedCount++;
            }

            if (selectedCount == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một vị trí!", 
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get time frame and price
            string timeFrame = this.comboBoxTimeFrame.SelectedIndex == 0 ? "Sáng" : "Tối";
            int pricePerPosition = this.comboBoxTimeFrame.SelectedIndex == 0 ? MORNING_PRICE : EVENING_PRICE;
            int totalPrice = selectedCount * pricePerPosition;

            // Show confirmation dialog with booking details
            string selectedPositions = GetSelectedPositionsString();
            string message = string.Format(
                "Đặt thành công!\n\nThông tin đặt bàn:\n" +
                "Số vị trí: {0}\n" +
                "Khung giờ: {1}\n" +
                "Tạm tính: {2:N0}đ\n\n" +
                "Vị trí chọn: {3}",
                selectedCount, timeFrame, totalPrice, selectedPositions);

            MessageBox.Show(message, "Xác nhận đặt bàn", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Mark selected positions as booked and disable them
            foreach (var kvp in positionStates)
            {
                if (kvp.Value == 1) // Selected
                {
                    positionStates[kvp.Key] = 2; // Mark as booked
                    positionButtons[kvp.Key].BackColor = Color.Red;
                    positionButtons[kvp.Key].Enabled = false;
                }
            }

            UpdateStats();
        }

        /// <summary>
        /// Event handler for Cancel All Selections button
        /// Clears all selected positions (but not booked ones)
        /// </summary>
        private void ButtonCancelAll_Click(object sender, EventArgs e)
        {
            // Clear only selected positions, leave booked ones as is
            for (int i = 0; i < TOTAL_POSITIONS; i++)
            {
                if (positionStates[i] == 1) // Only clear selected
                {
                    positionStates[i] = 0; // Back to empty
                    positionButtons[i].BackColor = Color.White;
                }
            }

            UpdateStats();
            MessageBox.Show("Đã hủy chọn tất cả vị trí!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Helper method to get comma-separated list of selected position numbers
        /// </summary>
        private string GetSelectedPositionsString()
        {
            var selectedList = new List<int>();
            foreach (var kvp in positionStates)
            {
                if (kvp.Value == 1) // Selected
                    selectedList.Add(kvp.Key + 1); // Convert 0-based to 1-based positions
            }

            return string.Join(", ", selectedList);
        }
    }
}
