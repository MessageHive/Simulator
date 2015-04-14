using System;
using System.Windows.Forms;
using System.Net.Security;

namespace MessageHive_TestUtil
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ClientCredentials credentials = new ClientCredentials();
            credentials.UID = textUID.Text.Trim();
            credentials.Token = textToken.Text.Trim();
            string host = textHost.Text.Trim();
            int port;
            try
            {
                port = Convert.ToInt32(textPort.Text.Trim());
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                textPort.Text = "";
                textPort.Focus();
                return;
            }
            Conversation form = new Conversation(host, port, credentials);
            form.Show();
            form.Focus();
            textUID.Text = "";
            textToken.Text = "";
        }
    }
}
