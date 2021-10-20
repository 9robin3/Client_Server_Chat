using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Diagnostics;

    namespace ServerApp
    {
        public partial class ServerForm : Form
        {
            /// <summary>
            /// This class is the main form of the Server application
            /// </summary>
            
            private TcpListener tcp_listener;
            private IPAddress ip_adress;
            private Socket connection;
            private List<User> user_list;
            private User user;
            private delegate void Display(string message);
            private delegate void Clear();

            private bool is_listening = false;
            private int port;


            /// <summary>
            /// Constructor:
            /// </summary>
            public ServerForm()
            {
                InitializeComponent();
                user_list = new List<User>();
            }

            /// <summary>
            ///  Loads the forms and it's content.
            ///  In this case, it starts a task running Setup method
            /// <param name="sender"> is a forms button input </param>
            /// <param name="e"> represents the components event arguments</param>
            /// </summary>
            private void ServerForm_Load(object sender, EventArgs e)
            {
                Task main_task = Task.Factory.StartNew(Setup);
            }

            /// <summary>
            /// Sets up IPadress and host to listen for connections, and adds a user
            /// object to a list for every process instance of client that is running
            /// </summary>
            public void Setup()
            {
               Chat_RichTextBox.Invoke(new Action(() => Chat_RichTextBox.AppendText("Waiting for connection...")));
               ip_adress = IPAddress.Parse("127.0.0.1");
               port = 50000;
               tcp_listener = new TcpListener(ip_adress, port);
               tcp_listener.Start();
               is_listening = true;
               while(is_listening)
               {
                   try
                   {
                       connection = tcp_listener.AcceptSocket();
                       user = new User(connection, this);
                       user_list.Add(user);
                       Chat_RichTextBox.Invoke(new Action(() => Chat_RichTextBox.Clear()));
                       Task task = Task.Factory.StartNew(user_list[user_list.Count - 1].Run);

                   }
                   catch(Exception ex)
                   {
                       MessageBox.Show("No client found! Try again!" + ex);
                   }
               }
            }

            /// <summary>
            ///  Writes to every user object's binary writer in user list when Send_button is clicked on.
            /// <param name="sender"> is a forms button input </param>
            /// <param name="e"> represents the components event arguments</param>
            /// </summary>
            private void Send_Button_Click(object sender, EventArgs e)
            {
               try
               {
                    if(!string.IsNullOrWhiteSpace(Message_TextBox.Text))
                    {
                    foreach (User user in user_list)
                        {
                            user.writer.Write(Message_TextBox.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please write something!");
                    }
               }
               catch(Exception ex)
               {

               }
            }

            /// <summary>
            /// Exits the code as the application is closed, so it doesn't try to run tasks/threadpool threads.
            /// <param name="sender"> is a forms button input </param>
            /// <param name="e"> represents the components event arguments</param>
            /// </summary>
            private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
            {
                try
                {
                    System.Environment.Exit(System.Environment.ExitCode);
                }
                catch (Exception ex)
                {
                    Application.Exit();
                }
            }
       }
  }

