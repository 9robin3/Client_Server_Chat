namespace ClientApp
{
    partial class ClientForm
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
            this.Chat_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.Message_TextBox = new System.Windows.Forms.TextBox();
            this.Send_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Chat_RichTextBox
            // 
            this.Chat_RichTextBox.BackColor = System.Drawing.Color.LightSalmon;
            this.Chat_RichTextBox.Location = new System.Drawing.Point(13, 13);
            this.Chat_RichTextBox.Name = "Chat_RichTextBox";
            this.Chat_RichTextBox.ReadOnly = true;
            this.Chat_RichTextBox.Size = new System.Drawing.Size(476, 305);
            this.Chat_RichTextBox.TabIndex = 0;
            this.Chat_RichTextBox.Text = "";
            // 
            // Message_TextBox
            // 
            this.Message_TextBox.Location = new System.Drawing.Point(13, 371);
            this.Message_TextBox.Name = "Message_TextBox";
            this.Message_TextBox.Size = new System.Drawing.Size(323, 22);
            this.Message_TextBox.TabIndex = 1;
            // 
            // Send_button
            // 
            this.Send_button.BackColor = System.Drawing.Color.LightSalmon;
            this.Send_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Send_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_button.Location = new System.Drawing.Point(358, 358);
            this.Send_button.Name = "Send_button";
            this.Send_button.Size = new System.Drawing.Size(131, 47);
            this.Send_button.TabIndex = 2;
            this.Send_button.Text = "Send";
            this.Send_button.UseVisualStyleBackColor = false;
            this.Send_button.Click += new System.EventHandler(this.Send_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Message to server:";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Send_button);
            this.Controls.Add(this.Message_TextBox);
            this.Controls.Add(this.Chat_RichTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ClientForm";
            this.ShowIcon = false;
            this.Text = "Multi Chat Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Message_TextBox;
        private System.Windows.Forms.Button Send_button;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox Chat_RichTextBox;
    }
}

