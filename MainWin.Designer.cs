namespace WinIpTray
{
    partial class MainWin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnHideToTray = new System.Windows.Forms.Button();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.Tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCopyToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayTimer = new System.Windows.Forms.Timer(this.components);
            this.tlpMain.SuspendLayout();
            this.TrayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.btnHideToTray, 0, 1);
            this.tlpMain.Controls.Add(this.btnCopyToClipboard, 1, 1);
            this.tlpMain.Controls.Add(this.lblAddress, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.Size = new System.Drawing.Size(384, 161);
            this.tlpMain.TabIndex = 0;
            // 
            // btnHideToTray
            // 
            this.btnHideToTray.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHideToTray.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHideToTray.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideToTray.Location = new System.Drawing.Point(3, 134);
            this.btnHideToTray.Name = "btnHideToTray";
            this.btnHideToTray.Size = new System.Drawing.Size(186, 24);
            this.btnHideToTray.TabIndex = 2;
            this.btnHideToTray.Text = "Hide To Tray";
            this.btnHideToTray.UseVisualStyleBackColor = true;
            this.btnHideToTray.Click += new System.EventHandler(this.OnHideToTray);
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopyToClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyToClipboard.Location = new System.Drawing.Point(195, 134);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(186, 24);
            this.btnCopyToClipboard.TabIndex = 1;
            this.btnCopyToClipboard.Text = "Copy To Clipboard";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.OnCopyToClipboard);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlpMain.SetColumnSpan(this.lblAddress, 2);
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(3, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(378, 131);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "255.255.255.255";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddress.Click += new System.EventHandler(this.OnLabelDoubleClicked);
            this.lblAddress.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnLabelMouseDoubleClicked);
            // 
            // Tray
            // 
            this.Tray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Tray.ContextMenuStrip = this.TrayMenu;
            this.Tray.Icon = ((System.Drawing.Icon)(resources.GetObject("Tray.Icon")));
            this.Tray.Text = "Public IP Address";
            this.Tray.Visible = true;
            this.Tray.DoubleClick += new System.EventHandler(this.OnTrayDoubleClicked);
            this.Tray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnTrayMouseDoubleClicked);
            // 
            // TrayMenu
            // 
            this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCopyToClipboard,
            this.showToolStripMenuItem,
            this.tsmiExit});
            this.TrayMenu.Name = "TrayMenu";
            this.TrayMenu.Size = new System.Drawing.Size(161, 70);
            this.TrayMenu.DoubleClick += new System.EventHandler(this.OnTrayDoubleClicked);
            this.TrayMenu.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnTrayMouseDoubleClicked);
            // 
            // tsmiCopyToClipboard
            // 
            this.tsmiCopyToClipboard.Name = "tsmiCopyToClipboard";
            this.tsmiCopyToClipboard.Size = new System.Drawing.Size(160, 22);
            this.tsmiCopyToClipboard.Text = "Copy IP Address";
            this.tsmiCopyToClipboard.Click += new System.EventHandler(this.OnCopyToClipboard);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.showToolStripMenuItem.Text = "Show Dialog";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.OnShowFromTray);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(160, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.OnExit);
            // 
            // DisplayTimer
            // 
            this.DisplayTimer.Enabled = true;
            this.DisplayTimer.Interval = 5000;
            this.DisplayTimer.Tick += new System.EventHandler(this.OnTimer);
            // 
            // MainWin
            // 
            this.AcceptButton = this.btnCopyToClipboard;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnHideToTray;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Public IP Address";
            this.Load += new System.EventHandler(this.OnLoad);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.TrayMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnHideToTray;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.NotifyIcon Tray;
        private System.Windows.Forms.ContextMenuStrip TrayMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyToClipboard;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.Timer DisplayTimer;
    }
}

