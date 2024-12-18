using System;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit.Security;
using MimeKit;

namespace Lab05
{
    public partial class Ex02 : Form
    {
        public Ex02()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            
            try
            {
                using (var client = new ImapClient())
                {
                    string email = txtEmail.Text.Trim();
                    string password = txtPassword.Text.Trim();
                    client.Connect("127.0.0.1", 143, SecureSocketOptions.None);
                    client.Authenticate(email, password);
                    var inbox = client.Inbox;
                    inbox.Open(MailKit.FolderAccess.ReadOnly);
                    lblTotal.Text = $"Total: {inbox.Count}";
                    lblRecent.Text = $"Recent: {inbox.Recent}";

                    if (listView1.Columns.Count == 0)
                    {
                        listView1.Columns.Add("Email", 200);
                        listView1.Columns.Add("From", 200);
                        listView1.Columns.Add("Thời gian", 200);
                    }

                    for (int i = 0; i < inbox.Count; i++)
                    {
                        var message = inbox.GetMessage(i);
                        ListViewItem item = new ListViewItem(message.Subject);
                        item.SubItems.Add(message.From.ToString());
                        item.SubItems.Add(message.Date.DateTime.ToString());

                        listView1.Items.Add(item);
                    }

                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

    }
}
