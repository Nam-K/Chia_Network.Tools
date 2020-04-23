using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

// I am not a programmer. Thanks StackOverflow for having soooo many answers ^^
namespace Chia_Config_GUI
{
    public partial class Form1 : Form
    {
        //GLOBALS
        private string _chiaLogsFolder;
        private int _hoveredIndex;
        private  ToolTip _toolTip1 = new ToolTip();
        private readonly Timer _tmr = new Timer();

        //THINGS
        private void ReadLogs()
        {
            try
            {
                var regStr = string.Empty;
                var regStrNot = string.Empty;
                if (checkBoxLogAll.Checked)
                {
                    regStr += ".*";
                }
                else
                {
                    if (checkBoxLogFarmer.Checked)
                        regStr = iif(regStr,"Farmer");
                    if (checkBoxLogHarvester.Checked)
                        regStr = iif(regStr, "Harvester");
                    if (checkBoxLogFullNode.Checked)
                        regStr = iif(regStr, "FullNode");
                    if (checkBoxLogWallet.Checked)
                        regStr = iif(regStr, "Wallet");
                    if (checkBoxLogTimelord.Checked)
                        regStr = iif(regStr, "Timelord");
                }
                if (checkBoxLogNot.Checked)
                {
                    regStrNot = "?!";
                }
                var rge = new Regex("^("+regStrNot+regStr+')');
                    IEnumerable<string> text = Form1.ReadLines(Path.Combine(_chiaLogsFolder, @"debug.log")).Where( f => rge.IsMatch(f)).Reverse().Take(50).Reverse().ToList();
                    listBoxLogs.Items.Clear();
                    listBoxLogs.BeginUpdate();
                    foreach (var s in text)
                    {
                       _= listBoxLogs.Items.Add(s);
                    }
                    listBoxLogs.EndUpdate();
                    text = default;
                    labelLogDate.Text = DateTime.Now.ToString("HH:mm:ss").ToString(CultureInfo.CurrentCulture);
                    listBoxLogs.TopIndex = listBoxLogs.Items.Count - 1;

            }
            catch (Exception x)
            {
                Alert("Err: " + x.Message);
                throw;
            }
        }

        public static IEnumerable<string> ReadLines(string path)
        {
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 0x1000, FileOptions.SequentialScan))
            using (var sr = new StreamReader(fs, Encoding.UTF8))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                     yield return line;
                }
            }
        }



        //INITS
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.listBoxLogs.MouseMove += this.lsbox_MouseMove;
            if (Properties.Settings.Default.first_run)
            {
                FirstRun();
                Properties.Settings.Default.first_run = false;
                LoadConfig();
            }
            else
            {
                LoadConfig();
            }
            GoFront();
            StartThings();
        }
        private static void FirstRun()
        {
            Alert("Please, get \"Log\" Directory containing \"debug.log\" file in the next window."+Environment.NewLine+"This is ReadOnly/NoLock => Safe for your file.");
            Properties.Settings.Default.log_folder = FolderBrowser();
        }
        private void LoadConfig()
        {
            _chiaLogsFolder = Properties.Settings.Default.log_folder;
            toolStripTextBoxLogsPath.Text = _chiaLogsFolder;
            comboBox1.SelectedIndex = Properties.Settings.Default.log_refresh;
        }

        private void StartThings()
        {
            ReadLogs();
        }

        private void lsbox_MouseMove(object sender, MouseEventArgs e)
        {
            int newHoveredIndex = listBoxLogs.IndexFromPoint(e.Location);
            if (_hoveredIndex != newHoveredIndex) {
                _hoveredIndex = newHoveredIndex;
                if (_hoveredIndex > -1)
                {
                    _toolTip1.SetToolTip(listBoxLogs, (listBoxLogs.Items[_hoveredIndex]).ToString());
                }
            }
        }




        //EVENTS
        private void button1_Click(object sender, EventArgs e)
        {
            ReadLogs();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                RunTimerLog();
            }
            else
            {
                StopTimerLog();
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
        private void TimerHandler(object sender, EventArgs e)
        {
            _tmr.Stop();
            ReadLogs();
           if (checkBox1.Checked) _tmr.Start();
        }
        private void RunTimerLog()
        {
            try
            {
                DataTable dt = new DataTable();
                _tmr.Interval = (int)dt.Compute(comboBox1.SelectedItem.ToString().Replace("s", "*1000").Replace("mn", "*60000"), "");
                _tmr.Tick += TimerHandler;
                _tmr.Stop();
                _tmr.Start();
            }
            catch (Exception x)
            {
                Alert("Err: "+x.Message);
                throw;
            }
        }
        private void StopTimerLog()
        {
            _tmr.Stop();
        }

        private void ToolStripTextBoxLogsPath_DoubleClick(object sender, EventArgs e)
        {
            if ((_chiaLogsFolder = FolderBrowser()) != string.Empty)
            {
                toolStripTextBoxLogsPath.Text = _chiaLogsFolder;
                ReadLogs();
            }
            else
            {
                Application.Exit();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.log_refresh = comboBox1.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        //SHORTCUTS
        public static void Alert(string m)
        {
            MessageBox.Show(m);
        }
        public static string FolderBrowser()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                var result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    return fbd.SelectedPath;
                }
                else
                {
                    Alert("Err: No Directory selected.");
                    return string.Empty;
                }
            }
        }
        private void GoFront()
        {
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private static string iif(string tmp, string app)
        {
            if (tmp == string.Empty)
            {
                tmp += app;
            }
            else
            {
                tmp += '|'+app;
            }
            return tmp;
        }

    }
}
