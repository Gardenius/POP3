using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading.Tasks;

namespace POP3
{

    public partial class Form1 : Form
    {
        public TcpClient Server;
        public NetworkStream NetStrm;
        public StreamReader RdStrm;
        public string Data;
        public byte[] szData;

        List<string> uidl1 = new List<string>();
        List<string> uidl2 = new List<string>();
        Timer timer1;
        int New = 0;
        public Form1()
        {
            InitializeComponent();
            this.POPServer.Text = "pop3.onet.pl";
            this.User.Text = "testpop_3@onet.pl";
            this.Password.Text = "Testowaniepop3";
            this.Port.Text = "110";
            Disconnect_Btn.Enabled = false;
            Retrieve_Btn.Enabled = false;
            NewMail.Visible = false;
            Ok_btn.Visible = false;
            Mails.Visible = false;
            Number.Enabled = false;

        }
        private void Connect_Btn_Click(object sender, EventArgs e)
        {
            InitTimer();
            timer1.Stop();
            Status.Items.Clear();
            Login();
        }
        private void Disconnect_Btn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            NewMail.Visible = false;
            Ok_btn.Visible = false;
            Mails.Visible = false;
            POPServer.Enabled = true;
            User.Enabled = true;
            Password.Enabled = true;
            Port.Enabled = true;
            Number.Text = "";
            Number.Enabled = false;
            Status.Items.Clear();

            Data = "QUIT" + "\r\n";
            szData = System.Text.Encoding.ASCII.GetBytes(Data.ToCharArray());
            NetStrm.Write(szData, 0, szData.Length);
            Status.Items.Add(RdStrm.ReadLine());

            NetStrm.Close();
            RdStrm.Close();

            Connect_Btn.Enabled = true;
            Disconnect_Btn.Enabled = false;
            Retrieve_Btn.Enabled = false;
            Message.Clear();
        }
        private void Retrieve_Btn_Click(object sender, EventArgs e)
        {
            string szTemp;
            Message.Clear();

            Data = "RETR " + Number.Text + "\r\n";
            szData = System.Text.Encoding.ASCII.GetBytes(Data.ToCharArray());
            NetStrm.Write(szData, 0, szData.Length);

            szTemp = RdStrm.ReadLine();
            if (szTemp[0] != '-')
            {
                while (szTemp != ".")
                {
                    Message.Text += szTemp + "\r\n";
                    szTemp = RdStrm.ReadLine();
                }
            }
            else
            {
                Status.Items.Add(szTemp);
            }
        }
        private void Ok_btn_Click(object sender, EventArgs e)
        {
            NewMail.Visible = false;
            Ok_btn.Visible = false;
            New = 0;
        }
        private void Mails_Number()
        {
            Data = "UIDL " + "\r\n";
            szData = System.Text.Encoding.ASCII.GetBytes(Data.ToCharArray());
            NetStrm.Write(szData, 0, szData.Length);
            int nr = 0;
            bool equals;
            String line = RdStrm.ReadLine();
            if (line.StartsWith("+OK"))
            {
                while (true)
                {
                    line = RdStrm.ReadLine();
                    if (line.StartsWith("."))
                    {
                        Mails.Visible = true;
                        Mails.Text = "Mails: " + (nr).ToString();
                        break;
                    }
                    else
                    {
                        string[] param = line.Trim().Split(new char[] { ' ' });
                        nr = Int32.Parse(param[0]);
                        string uid = param[1];
                        uidl1.Add(uid);
                    }
                }
                if (uidl2.Count == 0)
                {
                    for (int i = 0; i < nr; i++)
                    {
                        uidl2.Add(uidl1[i]);
                    }
                    uidl1.Clear();
                }
                else
                {
                    for (int i = 0; i < uidl1.Count; i++)
                    {
                        equals = false;
                        for (int j = 0; j < uidl2.Count; j++)
                        {
                            if (string.Equals(uidl1[i], uidl2[j]))
                            {
                                equals = true;
                            }
                        }
                        if (!equals)
                        {
                            New++;
                            uidl2.Add(uidl1[i]);
                            equals = false;
                        }
                    }
                    if(New != 0)
                    {
                        NewMail.ForeColor = Color.Red;
                        NewMail.Text = "New mails: " + New.ToString();
                        NewMail.Visible = true;
                        Ok_btn.Visible = true;
                    }
                    uidl1.Clear();
                }
                
            }
        }
        private void Login()
        {
            bool failed = false;
            string line;
            Status.Items.Clear();
            try
            {
                Server = new TcpClient(POPServer.Text, Int32.Parse(Port.Text));
                NetStrm = Server.GetStream();
                RdStrm = new StreamReader(Server.GetStream());
                Status.Items.Add(RdStrm.ReadLine());
            }
            catch
            {
                Status.Items.Add("Failed to connect.");
                failed = true;
            }

            if (!failed)
            {
                Data = "USER " + User.Text + "\r\n";
                szData = System.Text.Encoding.ASCII.GetBytes(Data.ToCharArray());
                NetStrm.Write(szData, 0, szData.Length);
                Status.Items.Add(RdStrm.ReadLine());
            }

            if (!failed)
            {
                Data = "PASS " + Password.Text + "\r\n";
                szData = System.Text.Encoding.ASCII.GetBytes(Data.ToCharArray());
                NetStrm.Write(szData, 0, szData.Length);
                line = RdStrm.ReadLine();
                Status.Items.Add(line);

                if (line.StartsWith("-"))
                {
                    Status.Items.Add("");
                    Status.Items.Add("Wrong email or password.");
                    failed = true;
                }

            }
            if (!failed)
            {
                timer1.Start();
                Mails_Number();
                POPServer.Enabled = false;
                User.Enabled = false;
                Password.Enabled = false;
                Port.Enabled = false;
                Number.Enabled = true;

                Connect_Btn.Enabled = false;
                Disconnect_Btn.Enabled = true;
                Retrieve_Btn.Enabled = true;
            }



        }
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 10000; // in miliseconds
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Login();
            Mails_Number();
        }

    }

}
