using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Lab05
{
    public partial class Ex01 : Form
    {
        public Ex01()
        {
            InitializeComponent();
        }

        /*private string smtp_pass = "1234qwer";
        private CheckBox chkIsHtml;*/


        private void btnSend_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(txtFrom.Text) ||
                string.IsNullOrWhiteSpace(txtTo.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtSubject.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Cấu hình SMTP cho MDaemon
                using (SmtpClient smtpClient = new SmtpClient("127.0.0.1", 25)) // IP và cổng MDaemon
                {
                    string mailFrom = txtFrom.Text.Trim();
                    string mailTo = txtTo.Text.Trim();
                    string password = txtPassword.Text.Trim();

                    // Xác thực tài khoản người gửi
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(mailFrom, password);
                    smtpClient.EnableSsl = false; // Không cần SSL cho mail nội bộ

                    // Tạo email
                    using (MailMessage message = new MailMessage())
                    {
                        message.From = new MailAddress(mailFrom);
                        message.To.Add(mailTo);
                        message.Subject = txtSubject.Text.Trim();
                        message.Body = richTextBody.Text;
                        message.IsBodyHtml = true; // Cho phép gửi HTML

                        // Gửi email
                        smtpClient.Send(message);
                        MessageBox.Show("Gửi email thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi chi tiết
                MessageBox.Show($"Lỗi gửi email: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            txtFrom.Clear();
            txtTo.Clear();
            txtSubject.Clear();
            richTextBody.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }
    }
}
