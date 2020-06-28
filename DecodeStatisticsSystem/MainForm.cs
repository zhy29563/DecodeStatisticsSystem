using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using HPSocket;
using HPSocket.Tcp;
using MetroFramework.Forms;
using NLog;
using NLog.Windows.Forms;

namespace DecodeStatisticsSystem
{
    public partial class MainForm : MetroForm
    {
        private const string FILE_PATH = "./Records/";
        private static readonly object Locker = new object();
        private static readonly ILogger LogHelper = LogManager.GetCurrentClassLogger();
        private static readonly IniHelper IniHelper = new IniHelper();
        private readonly TcpClient m_TcpClient = new TcpClient();

        private string m_FailFlag;

        private string m_NetworkHost;
        private ushort m_NetworkPort;


        private long m_ReadMulti;
        private long m_ReadFail;
        private long m_ReadSingle;
        private long m_ReadTotal;

        public MainForm()
        {
            InitializeComponent();
            RichTextBoxTarget.ReInitializeAllTextboxes(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(FILE_PATH))
                    Directory.CreateDirectory(FILE_PATH);

                MTxtIPAddr.Text = IniHelper.ReadIni("System", "NetworkHost", "127.0.0.1");
                MTxtIPPort.Text = IniHelper.ReadIni("System", "NetworkPort", "5001");
                m_FailFlag = IniHelper.ReadIni("System", "FailFlag", "NoRead");

                m_NetworkHost = MTxtIPAddr.Text;
                m_NetworkPort = ushort.Parse(MTxtIPPort.Text);

                InitTcpClient();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (m_TcpClient.IsConnected)
                    m_TcpClient.Stop();
            }
            catch
            {
                // ignored
            }
        }

        private void InitTcpClient()
        {
            try
            {
                //Sdk.SYS_SSO_NoDelay(this.m_TcpClient.ConnectionId, true);

                m_TcpClient.OnConnect += sender =>
                {
                    MLConnectedClv.BeginInvoke(new Action(() => { MLConnectedClv.BackColor = Color.Green; }));
                    LogHelper.Info($"{m_NetworkHost}:{m_NetworkPort} is connected");

                    return HandleResult.Ok;
                };
                m_TcpClient.OnClose += (sender, enOperation, errorCode) =>
                {
                    MLConnectedClv.BeginInvoke(new Action(() => { MLConnectedClv.BackColor = Color.Red; }));
                    LogHelper.Info($"{m_NetworkHost}:{m_NetworkPort} is disconnected");

                    return HandleResult.Ok;
                };
                m_TcpClient.OnReceive += (client, bytes) =>
                {
                    lock (Locker)
                    {
                        try
                        {
                            if (bytes.Length < 2)
                                throw new Exception("The length of data is less two");

                            if (bytes[0] != 0X02 || bytes[bytes.Length - 1] != 0X03)
                                throw new Exception("The data is not start with 0X02 and end with 0X03");

                            var message = Encoding.ASCII.GetString(bytes).Substring(1, bytes.Length - 2);
                            LogHelper.Info(message);
                            if (message.Trim().Length == 0)
                                throw new Exception("The length of valid data is zero");

                            if (message == this.m_FailFlag)
                                this.m_ReadFail++;
                            else
                            {
                                if (message.Contains(";"))
                                    this.m_ReadMulti++;
                                else
                                    this.m_ReadSingle++;
                            }
                            m_ReadTotal++;

                            var sendTime = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                            var sendCode = message;

                            // 界面显示数据
                            MGClv.BeginInvoke(new Action<string, string>(AddDataToMetroGrid), sendTime, sendCode);

                            // 按天保存数据到CSV文件
                            var fileName = $"{FILE_PATH}{DateTime.Now:yyyyMMdd}.CSV";
                            using (var fs = new FileStream(fileName, FileMode.Append, FileAccess.Write))
                            {
                                using (var sw = new StreamWriter(fs, Encoding.UTF8))
                                {
                                    sw.WriteLine($"{sendTime},{sendCode}");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            LogHelper.Error(ex, ex.Message);
                        }
                    }

                    return HandleResult.Ok;
                };


                m_TcpClient.Connect(m_NetworkHost, m_NetworkPort);
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex, nameof(InitTcpClient) + " -> " + ex.Message);
            }
        }

        private void AddDataToMetroGrid(string strTime, string strCode)
        {
            try
            {
                MTxtReadFail.Text = this.m_ReadFail.ToString();
                MTxtReadTotal.Text = m_ReadTotal.ToString();
                MTxtReadMulti.Text = this.m_ReadMulti.ToString();
                MTxtReadSingle.Text = m_ReadSingle.ToString();

                if (MGClv.Rows.Count > 200)
                {
                    MGClv.Rows.Clear();
                }
                else
                {
                    MGClv.Rows.Add(MGClv.Rows.Count + 1, strTime, strCode);
                    MGClv.FirstDisplayedScrollingRowIndex = MGClv.Rows.Count - 1;
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex, ex.Message);
            }
        }


        private void MBtnCommSet_Click(object sender, EventArgs e)
        {
            try
            {
                if (MTxtIPAddr.BackColor == Color.Red || MTxtIPPort.BackColor == Color.Red)
                {
                    LogHelper.Error("网络地址或者网络端口设置不正确");
                    return;
                }

                m_NetworkHost = MTxtIPAddr.Text;
                m_NetworkPort = ushort.Parse(MTxtIPPort.Text);

                LogHelper.Info($"修改网络地址与网络端口分别为({m_NetworkHost}:{m_NetworkPort})");

                IniHelper.WriteIni("System", "NetworkHost", m_NetworkHost);
                IniHelper.WriteIni("System", "NetworkPort", m_NetworkPort);
                IniHelper.WriteIni("System", "FailFlag", m_FailFlag);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MBtnCommRestart_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_TcpClient.IsConnected)
                    m_TcpClient.Stop();
                m_TcpClient.Connect(m_NetworkHost, m_NetworkPort);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MTxtIPAddr_Click(object sender, EventArgs e)
        {
            try
            {
                MTxtIPAddr.BackColor = IPAddress.TryParse(MTxtIPAddr.Text, out _) ? Color.White : Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MTxtIPPort_Click(object sender, EventArgs e)
        {
            try
            {
                MTxtIPPort.BackColor = ushort.TryParse(MTxtIPPort.Text, out _) ? Color.White : Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}