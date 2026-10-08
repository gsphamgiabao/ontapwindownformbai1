namespace ItemListManager
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
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.labelUnit = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.labelItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.labelItemCode = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.listViewItems = new System.Windows.Forms.ListView();
            this.colCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxList.SuspendLayout();
            this.groupBoxButtons.SuspendLayout();
            this.SuspendLayout();

            // groupBoxInput
            this.groupBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxInput.Controls.Add(this.labelPrice);
            this.groupBoxInput.Controls.Add(this.txtPrice);
            this.groupBoxInput.Controls.Add(this.labelUnit);
            this.groupBoxInput.Controls.Add(this.cmbUnit);
            this.groupBoxInput.Controls.Add(this.labelItemName);
            this.groupBoxInput.Controls.Add(this.txtItemName);
            this.groupBoxInput.Controls.Add(this.labelItemCode);
            this.groupBoxInput.Controls.Add(this.txtItemCode);
            this.groupBoxInput.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(250, 540);
            this.groupBoxInput.TabIndex = 0;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Khung nhập liệu";

            // labelItemCode
            this.labelItemCode.AutoSize = true;
            this.labelItemCode.Location = new System.Drawing.Point(10, 30);
            this.labelItemCode.Name = "labelItemCode";
            this.labelItemCode.Size = new System.Drawing.Size(64, 13);
            this.labelItemCode.TabIndex = 0;
            this.labelItemCode.Text = "Mã vật tư:";

            // txtItemCode
            this.txtItemCode.Location = new System.Drawing.Point(10, 50);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(230, 20);
            this.txtItemCode.TabIndex = 1;

            // labelItemName
            this.labelItemName.AutoSize = true;
            this.labelItemName.Location = new System.Drawing.Point(10, 85);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(66, 13);
            this.labelItemName.TabIndex = 2;
            this.labelItemName.Text = "Tên vật tư:";

            // txtItemName
            this.txtItemName.Location = new System.Drawing.Point(10, 105);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(230, 20);
            this.txtItemName.TabIndex = 3;

            // labelUnit
            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new System.Drawing.Point(10, 140);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(71, 13);
            this.labelUnit.TabIndex = 4;
            this.labelUnit.Text = "Đơn vị tính:";

            // cmbUnit
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Items.AddRange(new object[] {
                "Cái",
                "Bộ",
                "Kg",
                "Mét"});
            this.cmbUnit.Location = new System.Drawing.Point(10, 160);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(230, 21);
            this.cmbUnit.TabIndex = 5;

            // labelPrice
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(10, 195);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(69, 13);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Đơn giá nhập:";

            // txtPrice
            this.txtPrice.Location = new System.Drawing.Point(10, 215);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(230, 20);
            this.txtPrice.TabIndex = 7;

            // groupBoxList
            this.groupBoxList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                | System.Windows.Forms.AnchorStyles.Left) 
                | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxList.Controls.Add(this.listViewItems);
            this.groupBoxList.Location = new System.Drawing.Point(275, 12);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Size = new System.Drawing.Size(500, 475);
            this.groupBoxList.TabIndex = 1;
            this.groupBoxList.TabStop = false;
            this.groupBoxList.Text = "Khung danh sách";

            // listViewItems
            this.listViewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colCode,
                this.colName,
                this.colUnit,
                this.colPrice});
            this.listViewItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewItems.FullRowSelect = true;
            this.listViewItems.GridLines = true;
            this.listViewItems.Location = new System.Drawing.Point(3, 16);
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(494, 456);
            this.listViewItems.TabIndex = 0;
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            this.listViewItems.View = System.Windows.Forms.View.Details;
            this.listViewItems.SelectedIndexChanged += new System.EventHandler(this.listViewItems_SelectedIndexChanged);

            // colCode
            this.colCode.Text = "Mã VT";
            this.colCode.Width = 100;

            // colName
            this.colName.Text = "Tên VT";
            this.colName.Width = 150;

            // colUnit
            this.colUnit.Text = "Đơn vị tính";
            this.colUnit.Width = 80;

            // colPrice
            this.colPrice.Text = "Đơn giá";
            this.colPrice.Width = 100;

            // groupBoxButtons
            this.groupBoxButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
                | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxButtons.Controls.Add(this.btnDeleteAll);
            this.groupBoxButtons.Controls.Add(this.btnDelete);
            this.groupBoxButtons.Controls.Add(this.btnUpdate);
            this.groupBoxButtons.Controls.Add(this.btnAdd);
            this.groupBoxButtons.Location = new System.Drawing.Point(275, 495);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(500, 57);
            this.groupBoxButtons.TabIndex = 2;
            this.groupBoxButtons.TabStop = false;
            this.groupBoxButtons.Text = "Nút chức năng";

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(10, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnUpdate
            this.btnUpdate.Location = new System.Drawing.Point(130, 23);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(250, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa dòng";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnDeleteAll
            this.btnDeleteAll.Location = new System.Drawing.Point(370, 23);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(110, 23);
            this.btnDeleteAll.TabIndex = 3;
            this.btnDeleteAll.Text = "Xóa toàn bộ";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 564);
            this.Controls.Add(this.groupBoxButtons);
            this.Controls.Add(this.groupBoxList);
            this.Controls.Add(this.groupBoxInput);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý danh mục Vật tư / Linh kiện";
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxList.ResumeLayout(false);
            this.groupBoxButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Label labelItemCode;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.ColumnHeader colCode;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colUnit;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}

