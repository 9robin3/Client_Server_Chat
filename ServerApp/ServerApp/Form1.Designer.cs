namespace ServerApp
{
    partial class ServerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Message_TextBox = new System.Windows.Forms.TextBox();
            this.Send_Button = new System.Windows.Forms.Button();
            this.Chat_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Message_TextBox
            // 
            this.Message_TextBox.Location = new System.Drawing.Point(12, 372);
            this.Message_TextBox.Name = "Message_TextBox";
            this.Message_TextBox.Size = new System.Drawing.Size(325, 22);
            this.Message_TextBox.TabIndex = 0;
            // 
            // Send_Button
            // 
            this.Send_Button.BackColor = System.Drawing.Color.Aquamarine;
            this.Send_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Send_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_Button.Location = new System.Drawing.Point(363, 360);
            this.Send_Button.Name = "Send_Button";
            this.Send_Button.Size = new System.Drawing.Size(119, 43);
            this.Send_Button.TabIndex = 1;
            this.Send_Button.Text = "Send";
            this.Send_Button.UseVisualStyleBackColor = false;
            this.Send_Button.Click += new System.EventHandler(this.Send_Button_Click);
            // 
            // Chat_RichTextBox
            // 
            this.Chat_RichTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Chat_RichTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.Chat_RichTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Chat_RichTextBox.Location = new System.Drawing.Point(13, 24);
            this.Chat_RichTextBox.Name = "Chat_RichTextBox";
            this.Chat_RichTextBox.ReadOnly = true;
            this.Chat_RichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Chat_RichTextBox.Size = new System.Drawing.Size(469, 305);
            this.Chat_RichTextBox.TabIndex = 2;
            this.Chat_RichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Message to client:";
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Chat_RichTextBox);
            this.Controls.Add(this.Send_Button);
            this.Controls.Add(this.Message_TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ServerForm";
            this.ShowIcon = false;
            this.Text = "Multi Chat Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerForm_FormClosing);
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Message_TextBox;
        private System.Windows.Forms.Button Send_Button;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox Chat_RichTextBox;
    }
}

