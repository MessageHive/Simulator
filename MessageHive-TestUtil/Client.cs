using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace MessageHive_TestUtil
{
    class ClientCredentials
    {
        private string uid;
        private string token;

        public string UID
        {
            get
            {
                return uid;
            }
            set
            {
                uid = value;
            }
        }

        public string Token
        {
            get
            {
                return token;
            }
            set
            {
                token = value;
            }
        }
    }

    class Client
    {
        private string host;
        private int port;
        private ClientCredentials credentials;

        private TcpClient _client = null;
        private SslStream _stream = null;

        public Client(string host, int port, ClientCredentials credentials)
        {
            this.host = host;
            this.port = port;
            this.credentials = credentials;
        }

        private bool validateServerCertificate(object sender,
              X509Certificate certificate,
              X509Chain chain,
              SslPolicyErrors sslPolicyErrors)
        {
            if (sslPolicyErrors == SslPolicyErrors.None)
                return true;

            return false;
        }

        public SslStream Connect()
        {
            TcpClient client = new TcpClient(host, port);
            _client = client;
            SslStream sslStream = new SslStream(
                client.GetStream(),
                false,
                null,
                null
                );
            sslStream.AuthenticateAsClient(host);
            // Authenticate
            Message.Container msg = new Message.Container();
            msg.SID = credentials.UID;
            msg.RID = "";
            msg.STIME = Utilities.UnixTime();
            msg.TYPE = 2;
            msg.BODY = "{\"token\": \"" + credentials.Token + "\"}";

            sslStream.Write(Packet.Pack(msg));
            sslStream.Flush();
            return sslStream;
        }

        ~Client()
        {
            if (_client != null)
            {
                _client.Close();
            }
            if (_stream != null)
            {
                _stream.Close();
            }
        }
    }
}
