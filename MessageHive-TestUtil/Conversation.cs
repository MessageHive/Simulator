using System;
using System.Net.Security;
using System.Windows.Forms;

namespace MessageHive_TestUtil
{
    public partial class Conversation : Form
    {
        private string host;
        private int port;
        private ClientCredentials credentials;
        private Client _client;
        private SslStream _stream;

        public Conversation(string host, int port, ClientCredentials credentials)
        {
            this.host = host;
            this.port = port;
            this.credentials = credentials;
            _client = new Client(host, port, credentials);
            _stream = _client.Connect();
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Message.Container msg = new Message.Container();
            msg.SID = this.credentials.UID;
            msg.RID = textRID.Text.Trim();
            msg.STIME = Utilities.UnixTime();
            msg.BODY = richTextEditor.Text;
            byte[] data = Packet.Pack(msg);            
            _stream.Write(data);
        }

        void Conversation_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            _client.Dispose();
        }
    }
}
