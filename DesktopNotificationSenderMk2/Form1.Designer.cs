namespace DesktopNotificationSenderMk2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            notificationsListBox = new ListBox();
            StartListeningButton = new Button();
            SendListeningButton = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            SettingToolStripMenuItem = new ToolStripMenuItem();
            EndToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // notificationsListBox
            // 
            notificationsListBox.FormattingEnabled = true;
            notificationsListBox.ItemHeight = 15;
            notificationsListBox.Location = new Point(12, 81);
            notificationsListBox.Name = "notificationsListBox";
            notificationsListBox.Size = new Size(507, 289);
            notificationsListBox.TabIndex = 0;
            // 
            // StartListeningButton
            // 
            StartListeningButton.Location = new Point(12, 31);
            StartListeningButton.Name = "StartListeningButton";
            StartListeningButton.Size = new Size(75, 23);
            StartListeningButton.TabIndex = 1;
            StartListeningButton.Text = "通知の受信を開始";
            StartListeningButton.UseVisualStyleBackColor = true;
            StartListeningButton.Click += StartListeningButton_Click;
            // 
            // SendListeningButton
            // 
            SendListeningButton.Location = new Point(93, 31);
            SendListeningButton.Name = "SendListeningButton";
            SendListeningButton.Size = new Size(75, 23);
            SendListeningButton.TabIndex = 2;
            SendListeningButton.Text = "通知の送信";
            SendListeningButton.UseVisualStyleBackColor = true;
            SendListeningButton.Click += SendListeningButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 63);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 3;
            label1.Text = "受信した通知";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { SettingToolStripMenuItem, EndToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(532, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // SettingToolStripMenuItem
            // 
            SettingToolStripMenuItem.Name = "SettingToolStripMenuItem";
            SettingToolStripMenuItem.Size = new Size(43, 20);
            SettingToolStripMenuItem.Text = "設定";
            // 
            // EndToolStripMenuItem
            // 
            EndToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            EndToolStripMenuItem.Name = "EndToolStripMenuItem";
            EndToolStripMenuItem.Size = new Size(43, 20);
            EndToolStripMenuItem.Text = "終了";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 383);
            Controls.Add(label1);
            Controls.Add(SendListeningButton);
            Controls.Add(StartListeningButton);
            Controls.Add(notificationsListBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox notificationsListBox;
        private Button StartListeningButton;
        private Button SendListeningButton;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem SettingToolStripMenuItem;
        private ToolStripMenuItem EndToolStripMenuItem;
    }
}
