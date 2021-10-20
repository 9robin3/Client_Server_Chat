using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Windows.Forms;

namespace ServerApp
{
    class User
    {

        /// <summary>
        /// This class handles message handling and process instance list management (for every client process).
        /// </summary>
        
        private ServerForm server_form;
        private NetworkStream net_stream;
        public BinaryWriter writer;
        public BinaryReader reader;
        private delegate void Display(string message);

        private string message;

        /// <summary>
        /// Constructor:
        /// <param name="connection"> is the socket needed to create a connection </param>
        /// <param name="server_form"> is the ServerForm windows forms class </param>
        /// </summary>
        public User(Socket connection, ServerForm server_form)
        {
            this.server_form = server_form;
            net_stream = new NetworkStream(connection);
            reader = new BinaryReader(net_stream);
            writer = new BinaryWriter(net_stream);
        }

        /// <summary>
        /// Reads what the binarywriter wrote to the buffer.
        /// </summary>
        public void Run()
        {
            while(true)
            {
                try
                {
                    message = reader.ReadString();
                    server_form.Chat_RichTextBox.Invoke(new Display(SendMessage), new object[] { message });
                }
                catch(Exception ex)
                {
                }
            }
               
        }

        /// <summary>
        /// Sends a message to a client process
        /// <param name="message"> is the text which the user wrote in the 
        ///   message box component of ServerForm windows form </param>
        /// </summary>
        public void SendMessage(string message)
        {
            server_form.Chat_RichTextBox.Text = server_form.Chat_RichTextBox.Text + Environment.NewLine + "Client >> " + message;
        }
    }
}

