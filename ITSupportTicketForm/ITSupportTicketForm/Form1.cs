using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace ITSupportTicketForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WireEvents();
            InitializeData();
        }

        private void WireEvents()
        {
            this.btnLoadImage.Click += BtnLoadImage_Click;
            this.btnSend.Click += BtnSend_Click;
            this.btnReset.Click += BtnReset_Click;
        }

        private void InitializeData()
        {
            // set default values
            this.dtpRecorded.Value = DateTime.Now;
            this.cmbIssueType.Items.AddRange(new object[] { "Hardware", "Software", "Network", "Account" });
            if (this.cmbIssueType.Items.Count > 0) this.cmbIssueType.SelectedIndex = 0;
            this.txtTicketId.Text = GenerateTicketId();
        }

        private string GenerateTicketId()
        {
            return "TCK-" + DateTime.Now.ToString("yyyyMMdd-HHmmss");
        }

        private void BtnLoadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                ofd.Title = "Select error image";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var img = Image.FromFile(ofd.FileName);
                        this.pictureBoxError.Image = img;
                        this.pictureBoxError.Tag = ofd.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to load image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            var ticketId = this.txtTicketId.Text.Trim();
            var requester = this.txtRequester.Text.Trim();
            var date = this.dtpRecorded.Value.ToString("yyyy-MM-dd");
            string priority = this.rbLow.Checked ? "Low" : this.rbMedium.Checked ? "Medium" : "Urgent";
            var issueType = this.cmbIssueType.SelectedItem?.ToString() ?? "(not set)";

            List<string> devices = new List<string>();
            if (cbDesktop.Checked) devices.Add("Desktop PC");
            if (cbLaptop.Checked) devices.Add("Laptop");
            if (cbPrinter.Checked) devices.Add("Printer");
            if (cbPhone.Checked) devices.Add("Phone");
            var devicesText = devices.Count > 0 ? string.Join(", ", devices) : "(none)";

            var imagePath = this.pictureBoxError.Tag as string;
            var imageText = !string.IsNullOrEmpty(imagePath) ? Path.GetFileName(imagePath) : "No image";

            var summary = new StringBuilder();
            summary.AppendLine("Ticket summary:");
            summary.AppendLine($"Ticket ID: {ticketId}");
            summary.AppendLine($"Requester: {requester}");
            summary.AppendLine($"Recorded: {date}");
            summary.AppendLine($"Priority: {priority}");
            summary.AppendLine($"Issue type: {issueType}");
            summary.AppendLine($"Affected devices: {devicesText}");
            summary.AppendLine($"Attached image: {imageText}");

            MessageBox.Show(summary.ToString(), "Request submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            this.txtRequester.Clear();
            this.cmbIssueType.SelectedIndex = this.cmbIssueType.Items.Count > 0 ? 0 : -1;
            this.cbDesktop.Checked = this.cbLaptop.Checked = this.cbPrinter.Checked = this.cbPhone.Checked = false;
            this.pictureBoxError.Image = null;
            this.pictureBoxError.Tag = null;
            this.dtpRecorded.Value = DateTime.Now;
            this.rbLow.Checked = true;
            this.txtTicketId.Text = GenerateTicketId();
        }
    }
}
