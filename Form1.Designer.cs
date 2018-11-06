namespace POP3
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.POPServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Connect_Btn = new System.Windows.Forms.Button();
            this.Disconnect_Btn = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.TextBox();
            this.Retrieve_Btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.ListBox();
            this.NewMail = new System.Windows.Forms.Label();
            this.Ok_btn = new System.Windows.Forms.Button();
            this.Mails = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // POPServer
            // 
            this.POPServer.Location = new System.Drawing.Point(81, 6);
            this.POPServer.Name = "POPServer";
            this.POPServer.Size = new System.Drawing.Size(123, 20);
            this.POPServer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "POP Server";
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(81, 32);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(218, 20);
            this.User.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(81, 58);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(218, 20);
            this.Password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // Connect_Btn
            // 
            this.Connect_Btn.Location = new System.Drawing.Point(305, 12);
            this.Connect_Btn.Name = "Connect_Btn";
            this.Connect_Btn.Size = new System.Drawing.Size(75, 23);
            this.Connect_Btn.TabIndex = 6;
            this.Connect_Btn.Text = "Connect";
            this.Connect_Btn.UseVisualStyleBackColor = true;
            this.Connect_Btn.Click += new System.EventHandler(this.Connect_Btn_Click);
            // 
            // Disconnect_Btn
            // 
            this.Disconnect_Btn.Location = new System.Drawing.Point(305, 41);
            this.Disconnect_Btn.Name = "Disconnect_Btn";
            this.Disconnect_Btn.Size = new System.Drawing.Size(75, 23);
            this.Disconnect_Btn.TabIndex = 7;
            this.Disconnect_Btn.Text = "Disconnect";
            this.Disconnect_Btn.UseVisualStyleBackColor = true;
            this.Disconnect_Btn.Click += new System.EventHandler(this.Disconnect_Btn_Click);
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(12, 111);
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            this.Message.Size = new System.Drawing.Size(366, 117);
            this.Message.TabIndex = 8;
            this.Message.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Message";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mail Number";
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(81, 234);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(61, 20);
            this.Number.TabIndex = 11;
            // 
            // Retrieve_Btn
            // 
            this.Retrieve_Btn.Location = new System.Drawing.Point(148, 232);
            this.Retrieve_Btn.Name = "Retrieve_Btn";
            this.Retrieve_Btn.Size = new System.Drawing.Size(75, 23);
            this.Retrieve_Btn.TabIndex = 12;
            this.Retrieve_Btn.Text = "Retrieve";
            this.Retrieve_Btn.UseVisualStyleBackColor = true;
            this.Retrieve_Btn.Click += new System.EventHandler(this.Retrieve_Btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Status";
            // 
            // Status
            // 
            this.Status.FormattingEnabled = true;
            this.Status.Location = new System.Drawing.Point(12, 285);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(366, 69);
            this.Status.TabIndex = 14;
            // 
            // NewMail
            // 
            this.NewMail.AutoSize = true;
            this.NewMail.Location = new System.Drawing.Point(246, 237);
            this.NewMail.Name = "NewMail";
            this.NewMail.Size = new System.Drawing.Size(51, 13);
            this.NewMail.TabIndex = 15;
            this.NewMail.Text = "New Mail";
            // 
            // Ok_btn
            // 
            this.Ok_btn.Location = new System.Drawing.Point(339, 232);
            this.Ok_btn.Name = "Ok_btn";
            this.Ok_btn.Size = new System.Drawing.Size(39, 23);
            this.Ok_btn.TabIndex = 16;
            this.Ok_btn.Text = "Ok";
            this.Ok_btn.UseVisualStyleBackColor = true;
            this.Ok_btn.Click += new System.EventHandler(this.Ok_btn_Click);
            // 
            // Mails
            // 
            this.Mails.AutoSize = true;
            this.Mails.Location = new System.Drawing.Point(246, 259);
            this.Mails.Name = "Mails";
            this.Mails.Size = new System.Drawing.Size(31, 13);
            this.Mails.TabIndex = 17;
            this.Mails.Text = "Mails";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Port";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(242, 6);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(57, 20);
            this.Port.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 361);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Mails);
            this.Controls.Add(this.Ok_btn);
            this.Controls.Add(this.NewMail);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Retrieve_Btn);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Disconnect_Btn);
            this.Controls.Add(this.Connect_Btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.User);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.POPServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POP3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox POPServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Connect_Btn;
        private System.Windows.Forms.Button Disconnect_Btn;
        private System.Windows.Forms.RichTextBox Message;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.Button Retrieve_Btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox Status;
        private System.Windows.Forms.Label NewMail;
        private System.Windows.Forms.Button Ok_btn;
        private System.Windows.Forms.Label Mails;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Port;
    }
}

