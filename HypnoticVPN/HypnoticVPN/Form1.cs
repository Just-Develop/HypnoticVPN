using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace HypnoticVPN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void disconnect()
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "taskkill",
                Arguments = $"/f /im openvpn.exe",
                CreateNoWindow = true,
                UseShellExecute = false
            }).WaitForExit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (guna2ComboBox1.Text == "UnitedKingdom#1" && guna2RadioButton1.Checked)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = @"C:\Program Files\OpenVPN\bin\openvpn.exe";
                startInfo.Arguments = "--config justdevelop.ovpn";
                startInfo.Verb = "runas";
                process.StartInfo = startInfo;
                process.Start();
                MessageBox.Show("YOUR CONNECTED ENJOY MADE BY JUSTDEVELOP");

            }
            else if (guna2ComboBox1.Text == "UnitedKingdom#1" && guna2RadioButton2.Checked)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = @"C:\Program Files\OpenVPN\bin\openvpn.exe";
                startInfo.Arguments = "--config justdevelop2.ovpn";
                startInfo.Verb = "runas";
                process.StartInfo = startInfo;
                process.Start();
                MessageBox.Show("YOUR CONNECTED ENJOY MADE BY JUSTDEVELOP");
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            disconnect();
            MessageBox.Show("YOU HAVE DISCONNECTED SAD TO SEE YOU LEAVING SO SOON :(");
        }
    }
}