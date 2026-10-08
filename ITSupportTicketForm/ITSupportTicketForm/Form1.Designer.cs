namespace ITSupportTicketForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.TextBox txtRequester;
        private System.Windows.Forms.TextBox txtTicketId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpRecorded;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxPriority;
        private System.Windows.Forms.RadioButton rbUrgent;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbLow;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbIssueType;
        private System.Windows.Forms.GroupBox groupBoxDevices;
        private System.Windows.Forms.CheckBox cbPhone;
        private System.Windows.Forms.CheckBox cbPrinter;
        private System.Windows.Forms.CheckBox cbLaptop;
        private System.Windows.Forms.CheckBox cbDesktop;
        private System.Windows.Forms.PictureBox pictureBoxError;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnReset;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.txtRequester = new System.Windows.Forms.TextBox();
            this.txtTicketId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpRecorded = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxPriority = new System.Windows.Forms.GroupBox();
            this.rbUrgent = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbLow = new System.Windows.Forms.RadioButton();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbIssueType = new System.Windows.Forms.ComboBox();
            this.groupBoxDevices = new System.Windows.Forms.GroupBox();
            this.cbPhone = new System.Windows.Forms.CheckBox();
            this.cbPrinter = new System.Windows.Forms.CheckBox();
            this.cbLaptop = new System.Windows.Forms.CheckBox();
            this.cbDesktop = new System.Windows.Forms.CheckBox();
            this.pictureBoxError = new System.Windows.Forms.PictureBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxPriority.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.groupBoxDevices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(18, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(306, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "IT Support Ticket Reception";

            // groupBoxInfo
            this.groupBoxInfo.Controls.Add(this.txtRequester);
            this.groupBoxInfo.Controls.Add(this.txtTicketId);
            this.groupBoxInfo.Controls.Add(this.label3);
            this.groupBoxInfo.Controls.Add(this.label2);
            this.groupBoxInfo.Controls.Add(this.dtpRecorded);
            this.groupBoxInfo.Controls.Add(this.label1);
            this.groupBoxInfo.Location = new System.Drawing.Point(18, 56);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(480, 130);
            this.groupBoxInfo.TabIndex = 1;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Ticket Information";

            // txtRequester
            this.txtRequester.Location = new System.Drawing.Point(130, 56);
            this.txtRequester.Name = "txtRequester";
            this.txtRequester.Size = new System.Drawing.Size(320, 27);
            this.txtRequester.TabIndex = 3;

            // txtTicketId
            this.txtTicketId.Location = new System.Drawing.Point(130, 24);
            this.txtTicketId.Name = "txtTicketId";
            this.txtTicketId.Size = new System.Drawing.Size(200, 27);
            this.txtTicketId.TabIndex = 1;

            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Requester:";

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ticket ID:";

            // dtpRecorded
            this.dtpRecorded.Location = new System.Drawing.Point(130, 92);
            this.dtpRecorded.Name = "dtpRecorded";
            this.dtpRecorded.Size = new System.Drawing.Size(250, 27);
            this.dtpRecorded.TabIndex = 5;

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Recorded date:";

            // groupBoxPriority
            this.groupBoxPriority.Controls.Add(this.rbUrgent);
            this.groupBoxPriority.Controls.Add(this.rbMedium);
            this.groupBoxPriority.Controls.Add(this.rbLow);
            this.groupBoxPriority.Location = new System.Drawing.Point(510, 56);
            this.groupBoxPriority.Name = "groupBoxPriority";
            this.groupBoxPriority.Size = new System.Drawing.Size(150, 130);
            this.groupBoxPriority.TabIndex = 2;
            this.groupBoxPriority.TabStop = false;
            this.groupBoxPriority.Text = "Priority Level";

            // rbUrgent
            this.rbUrgent.AutoSize = true;
            this.rbUrgent.Location = new System.Drawing.Point(16, 30);
            this.rbUrgent.Name = "rbUrgent";
            this.rbUrgent.Size = new System.Drawing.Size(73, 24);
            this.rbUrgent.TabIndex = 0;
            this.rbUrgent.TabStop = true;
            this.rbUrgent.Text = "Urgent";
            this.rbUrgent.UseVisualStyleBackColor = true;

            // rbMedium
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(16, 60);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(83, 24);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;

            // rbLow
            this.rbLow.AutoSize = true;
            this.rbLow.Location = new System.Drawing.Point(16, 90);
            this.rbLow.Name = "rbLow";
            this.rbLow.Size = new System.Drawing.Size(57, 24);
            this.rbLow.TabIndex = 2;
            this.rbLow.TabStop = true;
            this.rbLow.Text = "Low";
            this.rbLow.UseVisualStyleBackColor = true;

            // groupBoxDetails
            this.groupBoxDetails.Controls.Add(this.label4);
            this.groupBoxDetails.Controls.Add(this.cmbIssueType);
            this.groupBoxDetails.Location = new System.Drawing.Point(18, 200);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(480, 100);
            this.groupBoxDetails.TabIndex = 3;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Issue Details";

            // label4
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Issue Type:";

            // cmbIssueType
            this.cmbIssueType.FormattingEnabled = true;
            this.cmbIssueType.Items.AddRange(new object[] {
            "Hardware",
            "Software",
            "Network",
            "Security",
            "Other"});
            this.cmbIssueType.Location = new System.Drawing.Point(130, 27);
            this.cmbIssueType.Name = "cmbIssueType";
            this.cmbIssueType.Size = new System.Drawing.Size(320, 28);
            this.cmbIssueType.TabIndex = 1;

            // groupBoxDevices
            this.groupBoxDevices.Controls.Add(this.cbPhone);
            this.groupBoxDevices.Controls.Add(this.cbPrinter);
            this.groupBoxDevices.Controls.Add(this.cbLaptop);
            this.groupBoxDevices.Controls.Add(this.cbDesktop);
            this.groupBoxDevices.Location = new System.Drawing.Point(510, 200);
            this.groupBoxDevices.Name = "groupBoxDevices";
            this.groupBoxDevices.Size = new System.Drawing.Size(150, 150);
            this.groupBoxDevices.TabIndex = 4;
            this.groupBoxDevices.TabStop = false;
            this.groupBoxDevices.Text = "Devices";

            // cbPhone
            this.cbPhone.AutoSize = true;
            this.cbPhone.Location = new System.Drawing.Point(16, 30);
            this.cbPhone.Name = "cbPhone";
            this.cbPhone.Size = new System.Drawing.Size(72, 24);
            this.cbPhone.TabIndex = 0;
            this.cbPhone.Text = "Phone";
            this.cbPhone.UseVisualStyleBackColor = true;

            // cbPrinter
            this.cbPrinter.AutoSize = true;
            this.cbPrinter.Location = new System.Drawing.Point(16, 60);
            this.cbPrinter.Name = "cbPrinter";
            this.cbPrinter.Size = new System.Drawing.Size(77, 24);
            this.cbPrinter.TabIndex = 1;
            this.cbPrinter.Text = "Printer";
            this.cbPrinter.UseVisualStyleBackColor = true;

            // cbLaptop
            this.cbLaptop.AutoSize = true;
            this.cbLaptop.Location = new System.Drawing.Point(16, 90);
            this.cbLaptop.Name = "cbLaptop";
            this.cbLaptop.Size = new System.Drawing.Size(79, 24);
            this.cbLaptop.TabIndex = 2;
            this.cbLaptop.Text = "Laptop";
            this.cbLaptop.UseVisualStyleBackColor = true;

            // cbDesktop
            this.cbDesktop.AutoSize = true;
            this.cbDesktop.Location = new System.Drawing.Point(16, 120);
            this.cbDesktop.Name = "cbDesktop";
            this.cbDesktop.Size = new System.Drawing.Size(85, 24);
            this.cbDesktop.TabIndex = 3;
            this.cbDesktop.Text = "Desktop";
            this.cbDesktop.UseVisualStyleBackColor = true;

            // pictureBoxError
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).EndInit();
            this.pictureBoxError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxError.Location = new System.Drawing.Point(18, 370);
            this.pictureBoxError.Name = "pictureBoxError";
            this.pictureBoxError.Size = new System.Drawing.Size(480, 150);
            this.pictureBoxError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxError.TabIndex = 5;
            this.pictureBoxError.TabStop = false;

            // btnLoadImage
            this.btnLoadImage.Location = new System.Drawing.Point(510, 370);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(150, 40);
            this.btnLoadImage.TabIndex = 6;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;

            // btnSend
            this.btnSend.Location = new System.Drawing.Point(510, 420);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(150, 40);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send Ticket";
            this.btnSend.UseVisualStyleBackColor = true;

            // btnReset
            this.btnReset.Location = new System.Drawing.Point(510, 470);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 40);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 540);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.pictureBoxError);
            this.Controls.Add(this.groupBoxDevices);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.groupBoxPriority);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "IT Support Ticket Reception";
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxPriority.ResumeLayout(false);
            this.groupBoxPriority.PerformLayout();
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.groupBoxDevices.ResumeLayout(false);
            this.groupBoxDevices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
