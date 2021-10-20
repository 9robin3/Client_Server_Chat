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
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace ClientApp
{
    public partial class ClientForm : Form
    {
        /// <summary>
        /// This class is the main form of the Client application
        /// </summary>
        
        private Client client;

        /// <summary>
        /// Constructor:
        /// </summary>
        public ClientForm()
        {
            InitializeComponent();
            client = new Client(this);
        }

        /// <summary>
        ///  Loads the forms and it's content.
        ///  In this case, it starts a task running a client object's Run method.
        /// <param name="sender"> is a forms button input </param>
        /// <param name="e"> represents the components event arguments</param>
        /// </summary>
        private void ClientForm_Load(object sender, EventArgs e)
        {
            Task main_task = Task.Factory.StartNew(client.Run);
        }

        /// <summary>
        ///  Writes to a client objects binarywriter when Send_button is clicked on.
        /// <param name="sender"> is a forms button input </param>
        /// <param name="e"> represents the components event arguments</param>
        /// </summary>
        private void Send_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Message_TextBox.Text))
            {
                client.writer.Write(Message_TextBox.Text);
            }
            else
            {
                MessageBox.Show("Please write something!");
            }
        }

        /// <summary>
        /// Exits the code as the application is closed, so it doesn't try to run tasks/threadpool threads.
        /// <param name="sender"> is a forms button input </param>
        /// <param name="e"> represents the components event arguments</param>
        /// </summary>
        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                System.Environment.Exit(System.Environment.ExitCode);
            }
            catch(Exception ex)
            {
                Application.Exit();
            }
        }
    }
}
