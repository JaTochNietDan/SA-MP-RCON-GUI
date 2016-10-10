using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace SA_MP_RCON_GUI
{
    public partial class frmMain : Form
    {
        int[] playerID = new int[500];

        public frmMain()
        {
            InitializeComponent();

            txtConnection.Text = Properties.Settings.Default.IP;
            txtPassword.Text = Properties.Settings.Default.Password;
        }

        public bool IsValidIPAddress(string ipAddr)
        {
            string pattern = @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";
            Regex reg = new Regex(pattern, RegexOptions.Singleline | RegexOptions.ExplicitCapture);
            return reg.IsMatch(ipAddr);
        }

        public void SendRCONQuery(string query, bool message = false)
        {
            string[] IP = txtConnection.Text.Split(':');
            if (IsValidIPAddress(IP[0]))
            {
                Query.RCONQuery sQuery = new Query.RCONQuery(IP[0], Convert.ToInt32(IP[1]), txtPassword.Text);
                sQuery.Send(query);

                if (message == true)
                {
                    lstRCON2.Items.Clear();

                    int count = sQuery.Recieve();
                    lstRCON2.Items.AddRange(sQuery.Store(count));
                }
            }
            else MessageBox.Show("Invalid server IP");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string[] IP = txtConnection.Text.Split(':');
            if (IsValidIPAddress(IP[0]))
            {
                Properties.Settings.Default.IP = txtConnection.Text;
                Properties.Settings.Default.Password = txtPassword.Text;

                Properties.Settings.Default.Save();

                string[] playerInfo;
                string[] serverInfo;

                Query.Query sQuery = new Query.Query(IP[0], Convert.ToInt32(IP[1]));
                sQuery.Send('d');

                int count = sQuery.Recieve();

                playerInfo = sQuery.Store(count);

                lstPlayers.Items.Clear();

                lstPlayers.Items.Add("ID\tName");
                lstPlayers.Items.Add("--\t----");

                int counter = 0;

                for (int i = 0; i < count; i++)
                {
                    playerID[counter] = Convert.ToInt32(playerInfo[i]);
                    lstPlayers.Items.Add(playerInfo[i] + "\t" + playerInfo[i + 1]);
                    i += 3;
                    counter++;
                }

                Query.Query sQuery2 = new Query.Query(IP[0], Convert.ToInt32(IP[1]));
                sQuery.Send('i');

                int count2 = sQuery.Recieve();

                if (count2 == 0) MessageBox.Show("Query failed, please try again and check that the IP is correct!");
                else
                {
                    serverInfo = sQuery.Store(count2);

                    txtName.Text = serverInfo[3];
                    txtHostname.Text = serverInfo[3];
                    txtPlayers.Text = serverInfo[1] + "/" + serverInfo[2];
                    txtMode.Text = serverInfo[4];
                    txtGamemode.Text = serverInfo[4];
                    txtMap.Text = serverInfo[5];
                    txtMapname.Text = serverInfo[5];

                    lstPlayers.SelectedIndex = 0;

                }
            }
            else MessageBox.Show("The server IP is invalid!");
        }

        private void lstPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedIndex > 1)
            {
                btnKick.Enabled = true;
                btnBan.Enabled = true;
            }
            else
            {
                btnKick.Enabled = false;
                btnBan.Enabled = false;
            }
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            string[] IP = txtConnection.Text.Split(':');
            if (IsValidIPAddress(IP[0]))
            {
                Query.RCONQuery sQuery = new Query.RCONQuery(IP[0], Convert.ToInt32(IP[1]), txtPassword.Text);
                sQuery.Send("ban " + playerID[lstPlayers.SelectedIndex - 2]);

                lstRCON.Items.Clear();

                int count = sQuery.Recieve();
                lstRCON.Items.AddRange(sQuery.Store(count));
            }
            else MessageBox.Show("Invalid server IP");
        }

        private void btnKick_Click(object sender, EventArgs e)
        {
            string[] IP = txtConnection.Text.Split(':');
            if (IsValidIPAddress(IP[0]))
            {
                Query.RCONQuery sQuery = new Query.RCONQuery(IP[0], Convert.ToInt32(IP[1]), txtPassword.Text);
                sQuery.Send("kick " + playerID[lstPlayers.SelectedIndex - 2]);

                lstRCON.Items.Clear();

                int count = sQuery.Recieve();
                lstRCON.Items.AddRange(sQuery.Store(count));
            }
            else MessageBox.Show("Invalid server IP");
        }

        private void btnSetHost_Click(object sender, EventArgs e)
        {
            SendRCONQuery("hostname " + txtHostname.Text);
        }

        private void btnGameText_Click(object sender, EventArgs e)
        {
            SendRCONQuery("gamemodetext " + txtGamemode.Text);
        }

        private void btnMapname_Click(object sender, EventArgs e)
        {
            SendRCONQuery("mapname " + txtMapname.Text);
        }

        private void btnChangemode_Click(object sender, EventArgs e)
        {
            SendRCONQuery("changemode " + txtChangemode.Text);
        }

        private void btnBanIP_Click(object sender, EventArgs e)
        {
            if (IsValidIPAddress(txtBanIP.Text)) SendRCONQuery("banip " + txtBanIP.Text, true);
            else MessageBox.Show("Invalid Ban IP was entered!");
        }

        private void btnUnbanIP_Click(object sender, EventArgs e)
        {
            if (IsValidIPAddress(txtBanIP.Text)) SendRCONQuery("unbanip " + txtBanIP.Text, true);
            else MessageBox.Show("Invalid Ban IP was entered!");
        }

        private void btnSetGravity_Click(object sender, EventArgs e)
        {
            SendRCONQuery("gravity " + txtGravity.Text);
        }

        private void btnLoadFS_Click(object sender, EventArgs e)
        {
            SendRCONQuery("loadfs " + txtFilterscript.Text, true);
        }

        private void btnUnloadFS_Click(object sender, EventArgs e)
        {
            SendRCONQuery("unloadfs " + txtFilterscript.Text, true);
        }

        private void btnReloadFS_Click(object sender, EventArgs e)
        {
            SendRCONQuery("reloadfs " + txtFilterscript.Text, true);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            SendRCONQuery("exit");
        }

        private void btnReloadLog_Click(object sender, EventArgs e)
        {
            SendRCONQuery("reloadlog");
        }

        private void btnReloadBans_Click(object sender, EventArgs e)
        {
            SendRCONQuery("reloadbans");
        }

        private void btnGMX_Click(object sender, EventArgs e)
        {
            SendRCONQuery("gmx");
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            SendRCONQuery("say " + txtMessage.Text);
        }
    }
}

namespace Query
{
    class RCONQuery
    {
        Socket qSocket;
        IPAddress address;
        int _port = 0;
        string _password = null;

        string[] results = new string[50];
        int _count = 0;

        public RCONQuery(string IP, int port, string password)
        {
            qSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            qSocket.SendTimeout = 5000;
            qSocket.ReceiveTimeout = 5000;

            try
            {
                address = Dns.GetHostAddresses(IP)[0];
            }

            catch
            {

            }

            _port = port;
            _password = password;
        }

        public bool Send(string command)
        {
            try
            {
                IPEndPoint endpoint = new IPEndPoint(address, _port);

                using (MemoryStream stream = new MemoryStream())
                {
                    using (BinaryWriter writer = new BinaryWriter(stream))
                    {
                        writer.Write("SAMP".ToCharArray());

                        string[] SplitIP = address.ToString().Split('.');

                        writer.Write(Convert.ToByte(Convert.ToInt32(SplitIP[0])));
                        writer.Write(Convert.ToByte(Convert.ToInt32(SplitIP[1])));
                        writer.Write(Convert.ToByte(Convert.ToInt32(SplitIP[2])));
                        writer.Write(Convert.ToByte(Convert.ToInt32(SplitIP[3])));

                        writer.Write((ushort)_port);

                        writer.Write('x');

                        writer.Write((ushort)_password.Length);
                        writer.Write(_password.ToCharArray());

                        writer.Write((ushort)command.Length);
                        writer.Write(command.ToCharArray());
                    }

                    if (qSocket.SendTo(stream.ToArray(), endpoint) > 0)
                        return true;
                }
            }

            catch
            {
                return false;
            }

            return false;
        }

        public int Recieve()
        {
            try
            {
                for (int i = 0; i < results.GetLength(0); i++)
                    results.SetValue(null, i);

                _count = 0;

                EndPoint endpoint = new IPEndPoint(address, _port);

                byte[] rBuffer = new byte[500];

                int count = qSocket.ReceiveFrom(rBuffer, ref endpoint);

                using (MemoryStream stream = new MemoryStream(rBuffer))
                {
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        if (stream.Length <= 11)
                            return _count;

                        reader.ReadBytes(11);
                        short len;

                        try
                        {
                            while ((len = reader.ReadInt16()) != 0)
                                results[_count++] = new string(reader.ReadChars(Convert.ToInt32(len)));
                        }

                        catch
                        {
                            return _count;
                        }
                    }
                }
            }

            catch
            {
                return _count;
            }

            return _count;
        }

        public string[] Store(int count)
        {
            string[] rString = new string[count];

            for (int i = 0; i < count && i < _count; i++)
                rString[i] = results[i];

            _count = 0;

            return rString;
        }
    }

    class Query
    {
        Socket qSocket;
        IPAddress address;
        int _port = 0;

        string[] results;
        int _count = 0;

        DateTime[] timestamp = new DateTime[2];

        public Query(string IP, int port)
        {
            qSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            qSocket.SendTimeout = 5000;
            qSocket.ReceiveTimeout = 5000;

            try
            {
                address = Dns.GetHostAddresses(IP)[0];
            }

            catch
            {

            }

            _port = port;
        }

        public bool Send(char opcode)
        {
            try
            {
                EndPoint endpoint = new IPEndPoint(address, _port);

                using (MemoryStream stream = new MemoryStream())
                {
                    using (BinaryWriter writer = new BinaryWriter(stream))
                    {
                        writer.Write("SAMP".ToCharArray());

                        string[] SplitIP = address.ToString().Split('.');

                        writer.Write(Convert.ToByte(Convert.ToInt32(SplitIP[0])));
                        writer.Write(Convert.ToByte(Convert.ToInt32(SplitIP[1])));
                        writer.Write(Convert.ToByte(Convert.ToInt32(SplitIP[2])));
                        writer.Write(Convert.ToByte(Convert.ToInt32(SplitIP[3])));

                        writer.Write((ushort)_port);

                        writer.Write(opcode);

                        if (opcode == 'p')
                            writer.Write("8493".ToCharArray());

                        timestamp[0] = DateTime.Now;
                    }

                    if (qSocket.SendTo(stream.ToArray(), endpoint) > 0)
                        return true;
                }
            }

            catch
            {
                return false;
            }

            return false;
        }

        public int Recieve()
        {
            try
            {
                _count = 0;

                EndPoint endpoint = new IPEndPoint(address, _port);

                byte[] rBuffer = new byte[1000];
                qSocket.ReceiveFrom(rBuffer, ref endpoint);

                timestamp[1] = DateTime.Now;

                using (MemoryStream stream = new MemoryStream(rBuffer))
                {
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        if (stream.Length <= 10)
                            return _count;

                        reader.ReadBytes(10);

                        switch (reader.ReadChar())
                        {
                            case 'i': // Information
                                {
                                    results = new string[6];

                                    results[_count++] = Convert.ToString(reader.ReadByte());

                                    results[_count++] = Convert.ToString(reader.ReadInt16());

                                    results[_count++] = Convert.ToString(reader.ReadInt16());

                                    int hostnamelen = reader.ReadInt32();
                                    results[_count++] = new string(reader.ReadChars(hostnamelen));

                                    int gamemodelen = reader.ReadInt32();
                                    results[_count++] = new string(reader.ReadChars(gamemodelen));

                                    int mapnamelen = reader.ReadInt32();
                                    results[_count++] = new string(reader.ReadChars(mapnamelen));

                                    return _count;
                                }

                            case 'r': // Rules
                                {
                                    int rulecount = reader.ReadInt16();

                                    results = new string[rulecount * 2];

                                    for (int i = 0; i < rulecount; i++)
                                    {
                                        int rulelen = reader.ReadByte();
                                        results[_count++] = new string(reader.ReadChars(rulelen));

                                        int valuelen = reader.ReadByte();
                                        results[_count++] = new string(reader.ReadChars(valuelen));
                                    }

                                    return _count;
                                }

                            case 'c': // Client list
                                {
                                    int playercount = reader.ReadInt16();

                                    results = new string[playercount * 2];

                                    for (int i = 0; i < playercount; i++)
                                    {
                                        int namelen = reader.ReadByte();
                                        results[_count++] = new string(reader.ReadChars(namelen));

                                        results[_count++] = Convert.ToString(reader.ReadInt32());
                                    }

                                    return _count;
                                }

                            case 'd': // Detailed player information
                                {
                                    int playercount = reader.ReadInt16();

                                    results = new string[playercount * 4];

                                    for (int i = 0; i < playercount; i++)
                                    {
                                        results[_count++] = Convert.ToString(reader.ReadByte());

                                        int namelen = reader.ReadByte();
                                        results[_count++] = new string(reader.ReadChars(namelen));

                                        results[_count++] = Convert.ToString(reader.ReadInt32());
                                        results[_count++] = Convert.ToString(reader.ReadInt32());
                                    }

                                    return _count;
                                }

                            case 'p': // Ping
                                {
                                    results = new string[1];

                                    results[_count++] = timestamp[1].Subtract(timestamp[0]).Milliseconds.ToString();

                                    return _count;
                                }

                            default:
                                return _count;
                        }
                    }
                }
            }

            catch
            {
                return _count;
            }
        }

        public string[] Store(int count)
        {
            string[] rString = new string[count];

            for (int i = 0; i < count && i < _count; i++)
                rString[i] = results[i];

            _count = 0;

            return rString;
        }
    }
}
