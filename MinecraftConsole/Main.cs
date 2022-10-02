using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

using BigCookieKit;
using BigCookieKit.File;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Text.RegularExpressions;

namespace MinecraftConsole
{
    public partial class Main : Form
    {
        MinecraftRcon minecraft { get; set; }
        TimingCommand timingCommand;
        IniMap iniMap = new IniMap(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "setting.ini"));

        static string prefix = string.Empty;
        static List<string> cacheOnlineUser = new List<string>();
        static object _lock = new object();

        bool enterOnline = false;
        bool enterBans = false;

        Dictionary<string, string> gameRules = new Dictionary<string, string>()
        {
            { "生物是否能进行破坏行为", "mobGriefing" },
            { "死亡后不丢物品和经验", "keepInventory" },
            { "火是否蔓延及自然熄灭", "doFireTick" },
            { "生物是否掉落物品", "doMobLoot" },
            { "生物是否自然生成", "doMobSpawning" },
            { "饥饿值满时自然恢复生命", "naturalRegeneration" },
            { "白天黑夜是否交替", "doDaylightCycle" },
            { "命令方块执行结果是否展示", "commandBlockOutput" },
            { "命令方块是否启用", "commandBlocksEnabled" },
            { "是否禁用袭击", "disableRaids" },
            { "非生物是否掉落物品", "doEntityDrops" },
            { "死了不需要确认直接重生", "doImmediateRespawn" },
            { "幻翼是否晚上生成", "doInsomnia" },
            { "是否服务器日志记录执行", "logAdminCommands" },
            { "玩家是否能互殴", "pvp" },
            { "命令结果是否在聊天展示", "sendCommandFeedback" },
        };

        public Main()
        {
            InitializeComponent();

            if (minecraft == null)
            {
                minecraft = new MinecraftRcon();
            }

            txtAddress.Text = iniMap["LOGIN"]["HOST"];
            txtPassword.Text = iniMap["LOGIN"]["PWD"];
            txtPort.Text = iniMap["LOGIN"]["PROT"];

            int index = 0;
            plGameRule.Controls.Clear();
            foreach (var item in gameRules)
            {
                Label title = new Label();
                title.Font = new Font("Microsoft YaHei UI", 11);
                title.Location = new Point(3, (index * 24) + 3);
                title.Text = item.Key;
                title.BorderStyle = BorderStyle.FixedSingle;
                title.Width = 190;
                plGameRule.Controls.Add(title);

                Label tirgger = new Label();
                tirgger.Font = new Font("Microsoft YaHei UI", 12);
                tirgger.Location = new Point(195, (index * 24) + 3);
                tirgger.Text = "否";
                tirgger.Tag = item.Value;
                tirgger.BackColor = Color.Black;
                tirgger.ForeColor = Color.Red;
                tirgger.Width = 26;
                tirgger.DoubleClick += Label_DoubleClick;
                plGameRule.Controls.Add(tirgger);
                index++;
            }

            lbxOlineUser.MouseDoubleClick += ListBoxUser_MouseDoubleClick;
            lbxOlineUser.MouseDown += LbxOlineUser_MouseDown; ;
            lbxBan.MouseDoubleClick += ListBoxUser_MouseDoubleClick;
            timer1_Tick(null, null);
            timer1.Enabled = true;
        }

        /// <summary>
        /// 右键在线名单 到目标人输入框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbxOlineUser_MouseDown(object sender, MouseEventArgs e)
        {
            var item = (ListBox)sender;
            if (e.Button == MouseButtons.Right)
            {
                if (!string.IsNullOrEmpty(item.SelectedItem?.ToString()))
                {
                    txtTPID.Text = item.SelectedItem?.ToString();
                }
            }
        }

        /// <summary>
        /// 双击黑名单 在线名单的人到操作人输入框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxUser_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var item = (ListBox)sender;
            if (e.Button == MouseButtons.Left)
            {
                if (!string.IsNullOrEmpty(item.SelectedItem?.ToString()))
                {
                    txtID.Text = item.SelectedItem?.ToString();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (minecraft != null)
            {
                if (minecraft.IsConnect)
                {
                    Text = "Minecraft后台控制器[状态:连接中]";
                    RefreshOlineUser();
                    RefreshBanlist();
                    RefreshGameRule();
                    RefreshDifficulty();

                    gbxDirectorate.Visible = true;
                    plGameRule.Visible = true;
                    txtAddress.Enabled = false;
                    txtPassword.Enabled = false;
                    txtPort.Enabled = false;
                }
                else
                {
                    Text = "Minecraft后台控制器[状态:未连接]";
                    gbxDirectorate.Visible = false;
                    plGameRule.Visible = false;
                    txtAddress.Enabled = true;
                    txtPassword.Enabled = true;
                    txtPort.Enabled = true;
                }
            }
        }

        /// <summary>
        /// 刷新在线名单
        /// </summary>
        private void RefreshOlineUser()
        {
            if (enterOnline) return;
            var allUser = RunCommand("list", false);
            var titleIndex = allUser.IndexOf(":");
            var nameS = allUser.Substring(titleIndex + 1);
            var splits = nameS.Split(',');

            var except = splits.Union(cacheOnlineUser);

            if (except.Count() > 0)
            {
                cacheOnlineUser.Clear();
                cacheOnlineUser.AddRange(splits);

                for (int i = lbxOlineUser.Items.Count - 1; i >= 0; i--)
                {
                    if (!splits.Contains(lbxOlineUser.Items[i]?.ToString()))
                    {
                        lbxOlineUser.Items.RemoveAt(i);
                    }
                }
                for (int i = 0; i < splits.Length; i++)
                {
                    if (!lbxOlineUser.Items.Contains(splits[i]))
                    {
                        lbxOlineUser.Items.Add(splits[i].Trim());
                    }
                }
            }
        }

        /// <summary>
        /// 刷新黑名单
        /// </summary>
        private void RefreshBanlist()
        {
            if (enterBans) return;
            var allUser = RunCommand("banlist", false);
            var segment = allUser.Split('\n');
            var splits = segment[0..(segment.Length - 1)];
            splits = splits.Select(x =>
            {
                var nameIndex = x.IndexOf(" ");
                return x.Substring(0, nameIndex).Trim();
            }).ToArray();

            for (int i = lbxBan.Items.Count - 1; i >= 0; i--)
            {
                if (!splits.Contains(lbxBan.Items[i]?.ToString()))
                {
                    lbxBan.Items.RemoveAt(i);
                }
            }
            for (int i = 0; i < splits.Length; i++)
            {
                if (!lbxBan.Items.Contains(splits[i]))
                {
                    lbxBan.Items.Add(splits[i]);
                }
            }
        }

        /// <summary>
        /// 刷新游戏规则
        /// </summary>
        private void RefreshGameRule()
        {
            foreach (Control item in plGameRule.Controls)
            {
                if (item.Tag == null) continue;
                if (item is Label label)
                {
                    var bl = GetGameRuleResult(label.Tag.ToString());
                    if (bl)
                    {
                        label.Text = "是";
                        label.ForeColor = Color.Green;
                    }
                    else
                    {
                        label.Text = "否";
                        label.ForeColor = Color.Red;
                    }
                }
            }
        }

        /// <summary>
        /// 刷新游戏难度
        /// </summary>
        private void RefreshDifficulty()
        {
            var command = RunCommand("difficulty", false);
            if (command.ToLower().Contains("peaceful"))
            {
                if (cbxDifficulty.Text != "和平")
                    cbxDifficulty.SelectedIndex = 0;
            }
            if (command.ToLower().Contains("easy"))
            {
                if (cbxDifficulty.Text != "简单")
                    cbxDifficulty.SelectedIndex = 1;
            }
            if (command.ToLower().Contains("normal"))
            {
                if (cbxDifficulty.Text != "普通")
                    cbxDifficulty.SelectedIndex = 2;
            }
            if (command.ToLower().Contains("hard"))
            {
                if (cbxDifficulty.Text != "困难")
                    cbxDifficulty.SelectedIndex = 3;
            }
        }

        private void Label_DoubleClick(object sender, EventArgs e)
        {
            var label = (Label)sender;
            var value = label.Text switch
            {
                "是" => "false",
                "否" => "true",
                _ => throw new NotImplementedException(),
            };
            RunCommand($"gamerule {label.Tag} {value}");
            RefreshGameRule();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            minecraft.Address = txtAddress.Text;
            minecraft.Password = txtPassword.Text;
            minecraft.Port = Convert.ToInt32(txtPort.Text);
            if (minecraft.Connect())
            {
                txtLog.Text = minecraft.Address + ":" + minecraft.Port + " 连接成功!\r\n" + txtLog.Text;
                if (minecraft.SignIn())
                {
                    txtLog.Text = minecraft.Address + ":" + minecraft.Port + " 登录成功!\r\n" + txtLog.Text;
                    btnLogin.Enabled = false;
                    btnLogout.Enabled = true;
                    timer1_Tick(null, null);

                    iniMap["LOGIN"]["HOST"] = txtAddress.Text;
                    iniMap["LOGIN"]["PWD"] = txtPassword.Text;
                    iniMap["LOGIN"]["PROT"] = txtPort.Text;
                    iniMap.Save();

                    timingCommand = new TimingCommand(TimingCommand_Tick);

                    object start = false;
                    iniMap["TIMING"]["START"]?.TryParse<bool>(out start);
                    timingCommand.Start = (bool)start;

                    object interval = 1000;
                    iniMap["TIMING"]["INTERVAL"]?.TryParse<int>(out interval);
                    timingCommand.Interval = (int)interval;

                    timingCommand.Command = iniMap["TIMING"]["COMMAND"];
                }
                else txtLog.Text = minecraft.Address + ":" + minecraft.Port + " 登录失败!\r\n" + txtLog.Text;
            }
            else txtLog.Text = minecraft.Address + ":" + minecraft.Port + " 连接失败!\r\n" + txtLog.Text;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            minecraft.SignOut();
            if (!minecraft.IsConnect)
            {
                txtLog.Text = minecraft.Address + ":" + minecraft.Port + " 登出成功!\r\n" + txtLog.Text;
                btnLogin.Enabled = true;
                btnLogout.Enabled = false;
                timer1_Tick(null, null);
            }
        }

        private void btnPromote_Click(object sender, EventArgs e)
        {
            RunCommand("op " + txtID.Text);
        }

        private void btnDemotion_Click(object sender, EventArgs e)
        {
            RunCommand("deop " + txtID.Text);
        }

        private void btnNotice_Click(object sender, EventArgs e)
        {
            RunCommand("say " + txtNotice.Text);
        }

        private void btnSendCommand_Click(object sender, EventArgs e)
        {
            RunCommand(txtCommand.Text);
        }

        private void btnAddBlack_Click(object sender, EventArgs e)
        {
            RunCommand("ban " + txtID.Text);
        }

        private void btnReBlack_Click(object sender, EventArgs e)
        {
            RunCommand("pardon " + txtID.Text);
        }

        private void btnTP_Click(object sender, EventArgs e)
        {
            string command;
            if (!string.IsNullOrEmpty(txtTPID.Text))
            {
                command = $"tp {txtID.Text} {txtTPID.Text}";
            }
            else
            {
                command = $"tp {txtID.Text} {txtTPX.Text} {txtTPY.Text} {txtTPZ.Text}";
            }
            RunCommand(command);
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            RunCommand("kill " + txtID.Text);
        }

        private void cbxDifficulty_TextChanged(object sender, EventArgs e)
        {
            RunCommand("difficulty " + cbxDifficulty.SelectedIndex switch
            {
                0 => "peaceful",
                1 => "easy",
                2 => "normal",
                3 => "hard",
                _ => throw new NotImplementedException(),
            });
        }

        private void btnFly_Click(object sender, EventArgs e)
        {
            RunCommand($"ability {txtID.Text} mayfly true");
        }

        private void btnNoFly_Click(object sender, EventArgs e)
        {
            RunCommand($"ability {txtID.Text} mayfly false");
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            RunCommand($"ability {txtID.Text} mute true");
        }

        private void btnNoMute_Click(object sender, EventArgs e)
        {
            RunCommand($"ability {txtID.Text} mute false");
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            txtLog.Text = string.Empty;
        }

        private void btnTell_Click(object sender, EventArgs e)
        {
            RunCommand($"tell {txtID.Text} {txtNotice.Text}");
        }

        private void cbxPrefix_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            if (checkbox.Checked)
            {
                prefix = "/";
            }
            else
            {
                prefix = "";
            }
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            RunCommand($"time set 1000");
        }

        private void btnNight_Click(object sender, EventArgs e)
        {
            RunCommand($"time set 14400");
        }

        private void btnGameMode_Click(object sender, EventArgs e)
        {
            GameMode form = new GameMode();
            form.ShowDialog();
            if (string.IsNullOrEmpty(form.ReturnValue)) return;
            if (string.IsNullOrEmpty(txtID.Text)) return;
            RunCommand($"gamemode {form.ReturnValue} {txtID.Text}");
        }

        private void btnUpLevels_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)) return;
            if (string.IsNullOrEmpty(txtLevels.Text)) return;
            minecraft.Command = $"xp set {txtID.Text} {txtLevels.Text} levels";
            txtLog.Text += minecraft.RunCommand() + "\r\n";
        }

        private void btnTiming_Click(object sender, EventArgs e)
        {
            timingCommand.ShowDialog();

            iniMap["TIMING"]["START"] = timingCommand.Start.ToString();
            iniMap["TIMING"]["INTERVAL"] = timingCommand.Interval.ToString();
            iniMap["TIMING"]["COMMAND"] = timingCommand.Command;
            iniMap.Save();
        }

        private void TimingCommand_Tick(object sender, EventArgs e)
        {
            TextReader reader = new StringReader(timingCommand.Command);
            var posCache = new Dictionary<string, (string, string, string)>();
            while (reader.Peek() > 0)
            {
                var command = reader.ReadLine();
                var matchs = Regex.Matches(command, "{{.*?}}");
                if (matchs.Count > 0)
                {
                    foreach (var item in matchs)
                    {
                        var orign = item.ToString();
                        var content = orign.Replace("{{", "").Replace("}}", "");
                        var first = content.IndexOf(":");
                        var name = content.Substring(0, first);
                        var paramter = content.Substring(first + 1);

                        (string, string, string) pos = default;
                        if (!posCache.ContainsKey(name))
                        {
                            pos = GetUserPos(name);
                            posCache.Add(name, pos);
                        }
                        else
                        {
                            pos = posCache[name];
                        }

                        switch (paramter)
                        {
                            case "x":
                            case "X":
                                command = command.Replace(orign, pos.Item1);
                                break;
                            case "y":
                            case "Y":
                                command = command.Replace(orign, pos.Item2);
                                break;
                            case "z":
                            case "Z":
                                command = command.Replace(orign, pos.Item3);
                                break;
                        }
                    }
                }
                if (!string.IsNullOrEmpty(command))
                {
                    RunCommand(command, false);
                }
            }
        }

        private string RunCommand(string command, bool wlog = true)
        {
            lock (_lock)
            {
                minecraft.Command = prefix + command;
                var rec = minecraft.RunCommand();
                if (wlog)
                {
                    if (txtLog.Text.Length > 5000)
                        txtLog.Text = "";
                    txtLog.Text = rec + "\r\n" + txtLog.Text;
                }
                return rec;
            }
        }

        private bool GetGameRuleResult(string rulename)
        {
            try
            {
                var rec = RunCommand("gamerule " + rulename, false);
                var titleIndex = rec.IndexOf(':');
                var res = rec.Substring(titleIndex + 1);
                return Convert.ToBoolean(res.Trim());
            }
            catch
            {
                return false;
            }
        }

        private (string, string, string) GetUserPos(string username)
        {
            try
            {
                var rec = RunCommand($"execute run data get entity {username} Pos", false);
                var titleIndex = rec.IndexOf(':');
                var res = rec.Substring(titleIndex + 1);
                res = res.Replace("d", "");
                var pos = JsonSerializer.Deserialize<decimal[]>(res);
                return (Math.Round(pos[0]).ToString(), Math.Round(pos[1]).ToString(), Math.Round(pos[2]).ToString());
            }
            catch
            {
                return ("0", "0", "0");
            }
        }

        private void lbxOlineUser_MouseEnter(object sender, EventArgs e)
        {
            enterOnline = true;
        }

        private void lbxOlineUser_MouseLeave(object sender, EventArgs e)
        {
            enterOnline = false;
        }

        private void lbxBan_MouseEnter(object sender, EventArgs e)
        {
            enterBans = true;
        }

        private void lbxBan_MouseLeave(object sender, EventArgs e)
        {
            enterBans = false;
        }
    }

    class MinecraftRcon
    {
        TcpClient Client { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string Command { get; set; }
        public int Port { get; set; }

        public bool IsConnect { get => Client == null ? false : Client.Connected; }

        private byte[] GetPassword()
        {
            byte[] numberPassword = Encoding.Default.GetBytes(Password);//密码组
            byte lengh = Convert.ToByte(numberPassword.Length + 9);//密码长度+9
            byte[] template = { lengh, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0 };//数据模板
            byte[] zero = { 0 };//数据模板
            byte[] passWord;
            passWord = new byte[4 + lengh];
            template.CopyTo(passWord, 0);
            numberPassword.CopyTo(passWord, template.Length);
            zero.CopyTo(passWord, passWord.Length - 1);
            return passWord;
        }

        private byte[] GetCommand()
        {
            byte[] numberPassword = Encoding.UTF8.GetBytes(Command);//命令组
            byte lengh = Convert.ToByte(numberPassword.Length + 9);//命令长度+9
            byte[] template = { lengh, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0 };//数据模板
            byte[] zero = { 0 };//数据模板
            byte[] returnCommand;
            returnCommand = new byte[4 + lengh];
            template.CopyTo(returnCommand, 0);
            numberPassword.CopyTo(returnCommand, template.Length);
            zero.CopyTo(returnCommand, returnCommand.Length - 1);
            return returnCommand;
        }

        private string GetReturn(byte[] buffer)
        {
            int num = buffer[0];
            byte[] Copy = buffer;
            var buffer1 = new byte[num - 10];
            int i = 12;
            while (i < (num + 2))
            {
                buffer1[i - 12] = Copy[i];
                i++;
            }

            var text = Encoding.Default.GetString(buffer1, 0, num - 10);

            num = Kit.BitToInt32(buffer.AsSpan(0, 4).ToArray());
            var list = buffer.ToList();
            var first = list.IndexOf(0);

            List<byte> bytes = new List<byte>();
            var head = buffer[0..first];
            var body = buffer[12..];
            //bytes.AddRange(head);
            bytes.AddRange(body);

            int index = bytes.Count - 1;
            if (bytes[index] == 0)
            {
                while (index > 1 && bytes[index - 1] == 0)
                    index--;
            }

            buffer = bytes.ToArray().AsSpan(0..index).ToArray();

            return Encoding.Default.GetString(buffer);
        }

        public bool Connect()
        {

            try
            {
                IPHostEntry hostinfo = Dns.GetHostByName(Address);
                IPAddress[] ipadd = hostinfo.AddressList;
                string result = ipadd[0].ToString();
                IPAddress remoteHost = IPAddress.Parse(result);
                IPEndPoint iep = new IPEndPoint(remoteHost, Port);
                Client = new TcpClient();
                Client.Connect(iep);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }

        public bool SignIn()
        {
            NetworkStream streamToServer = Client.GetStream();
            byte[] buffer = GetPassword();
            try
            {
                lock (streamToServer)
                {
                    streamToServer.Write(buffer, 0, buffer.Length);     // 发往服务器
                }
                buffer = new byte[14];
                lock (streamToServer)
                {
                    streamToServer.Read(buffer, 0, 14);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error", "Sign in error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (buffer[4] == 0 && (buffer[5] == 0) && (buffer[6] == 0) && (buffer[7] == 0) && buffer[0] == 10 && (buffer[8]) == 2) return true;
            else return false;
        }

        public void SignOut()
        {
            //断开连接
            Client.Close();
        }

        public string RunCommand()
        {
            //获取需发送的命令
            byte[] buffer = GetCommand();
            if (Client.Connected)
            {
                NetworkStream streamToServer = Client.GetStream();
                try
                {
                    lock (streamToServer)
                    {
                        streamToServer.Write(buffer, 0, buffer.Length);     // 发往服务器
                    }
                    //buffer = new byte[250];
                    lock (streamToServer)
                    {
                        //streamToServer.Read(buffer, 0, 250);
                        List<byte> receivce = new List<byte>();
                        do
                        {
                            buffer = new byte[4096];
                            streamToServer.Read(buffer, 0, 4096);
                            receivce.AddRange(buffer);
                        } while (streamToServer.DataAvailable);

                        buffer = receivce.ToArray();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Error", "Command error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SignOut();
                    return "Error";
                }
                return GetReturn(buffer);
            }
            else return "lost";
        }
    }
}
