namespace DeliveryOrderDashboard
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grbCustomerInfo = new System.Windows.Forms.GroupBox();
            this.lblShippingType = new System.Windows.Forms.Label();
            this.cmbShippingType = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblSystemTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblSeparator1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblTotalQty = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblSeparator2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblTotalWeight = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblSeparator3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblTotalAmount = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tmrSystemTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grbCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();

            // splitContainer1
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(1000, 600);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 0;

            // splitContainer1.Panel1
            this.splitContainer1.Panel1.Controls.Add(this.grbCustomerInfo);

            // splitContainer1.Panel2
            this.splitContainer1.Panel2.Controls.Add(this.dgvItems);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);

            // grbCustomerInfo
            this.grbCustomerInfo.Controls.Add(this.lblShippingType);
            this.grbCustomerInfo.Controls.Add(this.cmbShippingType);
            this.grbCustomerInfo.Controls.Add(this.lblAddress);
            this.grbCustomerInfo.Controls.Add(this.txtAddress);
            this.grbCustomerInfo.Controls.Add(this.lblCustomerName);
            this.grbCustomerInfo.Controls.Add(this.txtCustomerName);
            this.grbCustomerInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbCustomerInfo.Location = new System.Drawing.Point(0, 0);
            this.grbCustomerInfo.Name = "grbCustomerInfo";
            this.grbCustomerInfo.Padding = new System.Windows.Forms.Padding(10);
            this.grbCustomerInfo.Size = new System.Drawing.Size(300, 150);
            this.grbCustomerInfo.TabIndex = 0;
            this.grbCustomerInfo.TabStop = false;
            this.grbCustomerInfo.Text = "Customer Information";

            // lblCustomerName
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(13, 25);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(91, 13);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name:";

            // txtCustomerName
            this.txtCustomerName.Location = new System.Drawing.Point(13, 40);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(274, 20);
            this.txtCustomerName.TabIndex = 1;

            // lblAddress
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(13, 63);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address:";

            // txtAddress
            this.txtAddress.Location = new System.Drawing.Point(13, 78);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(274, 20);
            this.txtAddress.TabIndex = 3;

            // lblShippingType
            this.lblShippingType.AutoSize = true;
            this.lblShippingType.Location = new System.Drawing.Point(13, 101);
            this.lblShippingType.Name = "lblShippingType";
            this.lblShippingType.Size = new System.Drawing.Size(78, 13);
            this.lblShippingType.TabIndex = 4;
            this.lblShippingType.Text = "Shipping Type:";

            // cmbShippingType
            this.cmbShippingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShippingType.FormattingEnabled = true;
            this.cmbShippingType.Items.AddRange(new object[] {
            "Standard",
            "Express",
            "Overnight"});
            this.cmbShippingType.Location = new System.Drawing.Point(13, 117);
            this.cmbShippingType.Name = "cmbShippingType";
            this.cmbShippingType.Size = new System.Drawing.Size(274, 21);
            this.cmbShippingType.TabIndex = 5;

            // dgvItems
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.Location = new System.Drawing.Point(0, 0);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(696, 575);
            this.dgvItems.TabIndex = 0;

            // statusStrip1
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblSystemTime,
            this.tslblSeparator1,
            this.tslblTotalQty,
            this.tslblSeparator2,
            this.tslblTotalWeight,
            this.tslblSeparator3,
            this.tslblTotalAmount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 575);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(696, 25);
            this.statusStrip1.TabIndex = 1;

            // tslblSystemTime
            this.tslblSystemTime.Name = "tslblSystemTime";
            this.tslblSystemTime.Size = new System.Drawing.Size(118, 20);
            this.tslblSystemTime.Text = "Time: 00:00:00";
            this.tslblSystemTime.AutoSize = true;

            // tslblSeparator1
            this.tslblSeparator1.Name = "tslblSeparator1";
            this.tslblSeparator1.Size = new System.Drawing.Size(10, 20);
            this.tslblSeparator1.Text = "|";

            // tslblTotalQty
            this.tslblTotalQty.Name = "tslblTotalQty";
            this.tslblTotalQty.Size = new System.Drawing.Size(110, 20);
            this.tslblTotalQty.Text = "Total Qty: 0";
            this.tslblTotalQty.AutoSize = true;

            // tslblSeparator2
            this.tslblSeparator2.Name = "tslblSeparator2";
            this.tslblSeparator2.Size = new System.Drawing.Size(10, 20);
            this.tslblSeparator2.Text = "|";

            // tslblTotalWeight
            this.tslblTotalWeight.Name = "tslblTotalWeight";
            this.tslblTotalWeight.Size = new System.Drawing.Size(125, 20);
            this.tslblTotalWeight.Text = "Total Weight: 0 kg";
            this.tslblTotalWeight.AutoSize = true;

            // tslblSeparator3
            this.tslblSeparator3.Name = "tslblSeparator3";
            this.tslblSeparator3.Size = new System.Drawing.Size(10, 20);
            this.tslblSeparator3.Text = "|";

            // tslblTotalAmount
            this.tslblTotalAmount.Name = "tslblTotalAmount";
            this.tslblTotalAmount.Size = new System.Drawing.Size(95, 20);
            this.tslblTotalAmount.Text = "Total: 0 VND";
            this.tslblTotalAmount.AutoSize = true;

            // errorProvider1
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;

            // tmrSystemTime
            this.tmrSystemTime.Tick += new System.EventHandler(this.TmrSystemTime_Tick);

            // Form1
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Delivery Order Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPreview = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grbCustomerInfo.ResumeLayout(false);
            this.grbCustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grbCustomerInfo;
        private System.Windows.Forms.Label lblShippingType;
        private System.Windows.Forms.ComboBox cmbShippingType;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblSystemTime;
        private System.Windows.Forms.ToolStripStatusLabel tslblSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel tslblTotalQty;
        private System.Windows.Forms.ToolStripStatusLabel tslblSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel tslblTotalWeight;
        private System.Windows.Forms.ToolStripStatusLabel tslblSeparator3;
        private System.Windows.Forms.ToolStripStatusLabel tslblTotalAmount;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer tmrSystemTime;
    }
}

