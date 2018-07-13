using System;
using System.Windows.Forms;

namespace WinIpTray
{
    public partial class MainWin : Form
    {
        private string IpAddress { get { return "172.217.26.100";/* new Api().GetIpAddress();*/ } }

        public MainWin()
        {
            InitializeComponent();
        }

        private void Reload()
        {
            lblAddress.Text = IpAddress;
            Tray.Text = $"WinIpTray: {IpAddress}";
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Reload();
        }

        private void OnCopyToClipboard(object sender, EventArgs e)
        {
            Clipboard.SetText(IpAddress);
        }

        private void OnHideToTray(object sender, EventArgs e)
        {
            Hide();
        }

        private void OnShowFromTray(object sender, EventArgs e)
        {
            Reload();
            Show();
            DisplayTimer.Enabled = true;
        }

        private void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnTimer(object sender, EventArgs e)
        {
            Hide();
            DisplayTimer.Enabled = false;
        }

        private void OnTrayDoubleClicked(object sender, EventArgs e)
        {
            OnCopyToClipboard(sender, e);
        }

        private void OnTrayMouseDoubleClicked(object sender, MouseEventArgs e)
        {
            OnCopyToClipboard(sender, e);
        }

        private void OnLabelDoubleClicked(object sender, EventArgs e)
        {
            OnCopyToClipboard(sender, e);
        }

        private void OnLabelMouseDoubleClicked(object sender, MouseEventArgs e)
        {
            OnCopyToClipboard(sender, e);
        }
    }
}