using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Windows.Forms;


namespace ClientApp
{
    class Client
    {
        /// <summary>
        /// This class handles connections to a server process
        /// </summary>
        
        private ClientForm client_form;
        public TcpClient tcp_client;
        private NetworkStream net_stream;
        private IPAddress ip_adress;
        public BinaryWriter writer;
        public BinaryReader reader;
        private delegate void Display(string message);

        private int port;
        private string message;

        /// <summary>
        /// Constructor:
        /// <param name="client_form"> is the ClientForm windows forms class </param>
        /// </summary>
        public Client(ClientForm client_form)
        {
            this.client_form = client_form;
            tcp_client = new TcpClient();
            ip_adress = IPAddress.Parse("127.0.0.1");
            port = 50000;
        }

        /// <summary>
        /// Runs the connection to a server process, and reads what the binarywriter wrote to the buffer
        /// </summary>
        public void Run()
        {
                try
                {
                    client_form.Chat_RichTextBox.Invoke(new Display(SendMessage), new object[] { "Client started..." });
                    tcp_client.Connect(ip_adress, port);
                    net_stream = tcp_client.GetStream();
                    writer = new BinaryWriter(net_stream);
                    reader = new BinaryReader(net_stream);

                    while(true)
                    {
                        try
                        {
                            message = reader.ReadString();
                            client_form.Chat_RichTextBox.Invoke(new Display(SendMessage), new object[] { message });
                        }
                        catch(Exception ex)
                        {

                        }
                    }
                }
                catch(Exception ex)
                {

                }
        }

        /// <summary>
        /// Sends a message to a server process
        /// <param name="message"> is the text which the user wrote in the 
        ///   message box component of ClientForm windows form </param>
        /// </summary>
        public void SendMessage(string message)
        {
            client_form.Chat_RichTextBox.Text = client_form.Chat_RichTextBox.Text + Environment.NewLine + "Server >> " + message;
        }
    }
}

