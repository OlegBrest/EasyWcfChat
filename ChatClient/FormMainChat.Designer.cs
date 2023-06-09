﻿namespace ChatClient
{
    partial class FormMainChat
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainChat));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolsConnection = new System.Windows.Forms.ToolStripDropDownButton();
            this.ConnectItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisconnectItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsSettings = new System.Windows.Forms.ToolStripButton();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstbxUsers = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bttnSend = new System.Windows.Forms.Button();
            this.txtbxMssg = new System.Windows.Forms.TextBox();
            this.lstbxMainChat = new System.Windows.Forms.ListBox();
            this.toolStripMain.SuspendLayout();
            this.PanelMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsConnection,
            this.toolsSettings});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(541, 25);
            this.toolStripMain.TabIndex = 0;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolsConnection
            // 
            this.toolsConnection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolsConnection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectItem,
            this.DisconnectItem});
            this.toolsConnection.Image = ((System.Drawing.Image)(resources.GetObject("toolsConnection.Image")));
            this.toolsConnection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsConnection.Name = "toolsConnection";
            this.toolsConnection.Size = new System.Drawing.Size(60, 22);
            this.toolsConnection.Text = "Сервер";
            this.toolsConnection.ToolTipText = "Соединение с сервером";
            // 
            // ConnectItem
            // 
            this.ConnectItem.Name = "ConnectItem";
            this.ConnectItem.Size = new System.Drawing.Size(156, 22);
            this.ConnectItem.Text = "Подключиться";
            this.ConnectItem.Click += new System.EventHandler(this.ConnectItem_Click);
            // 
            // DisconnectItem
            // 
            this.DisconnectItem.Enabled = false;
            this.DisconnectItem.Name = "DisconnectItem";
            this.DisconnectItem.Size = new System.Drawing.Size(156, 22);
            this.DisconnectItem.Text = "Отключиться";
            this.DisconnectItem.Click += new System.EventHandler(this.DisconnectItem_Click);
            // 
            // toolsSettings
            // 
            this.toolsSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolsSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolsSettings.Image")));
            this.toolsSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsSettings.Name = "toolsSettings";
            this.toolsSettings.Size = new System.Drawing.Size(71, 22);
            this.toolsSettings.Text = "Настройки";
            this.toolsSettings.ToolTipText = "Настройки клиента";
            this.toolsSettings.Click += new System.EventHandler(this.toolsSettings_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.Controls.Add(this.tabControl1);
            this.PanelMain.Controls.Add(this.bttnSend);
            this.PanelMain.Controls.Add(this.txtbxMssg);
            this.PanelMain.Controls.Add(this.lstbxMainChat);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 25);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(541, 396);
            this.PanelMain.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(385, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(152, 319);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstbxUsers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(144, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Участники";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstbxUsers
            // 
            this.lstbxUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbxUsers.FormattingEnabled = true;
            this.lstbxUsers.Location = new System.Drawing.Point(3, 3);
            this.lstbxUsers.Name = "lstbxUsers";
            this.lstbxUsers.Size = new System.Drawing.Size(138, 287);
            this.lstbxUsers.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(144, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Смайлики";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bttnSend
            // 
            this.bttnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnSend.Location = new System.Drawing.Point(389, 328);
            this.bttnSend.Name = "bttnSend";
            this.bttnSend.Size = new System.Drawing.Size(144, 56);
            this.bttnSend.TabIndex = 2;
            this.bttnSend.Text = "Отправить";
            this.bttnSend.UseVisualStyleBackColor = true;
            this.bttnSend.Click += new System.EventHandler(this.bttnSend_Click);
            // 
            // txtbxMssg
            // 
            this.txtbxMssg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxMssg.Location = new System.Drawing.Point(3, 328);
            this.txtbxMssg.Multiline = true;
            this.txtbxMssg.Name = "txtbxMssg";
            this.txtbxMssg.Size = new System.Drawing.Size(380, 59);
            this.txtbxMssg.TabIndex = 1;
            this.txtbxMssg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbxMssg_KeyDown);
            // 
            // lstbxMainChat
            // 
            this.lstbxMainChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbxMainChat.FormattingEnabled = true;
            this.lstbxMainChat.Location = new System.Drawing.Point(3, 3);
            this.lstbxMainChat.Name = "lstbxMainChat";
            this.lstbxMainChat.Size = new System.Drawing.Size(380, 316);
            this.lstbxMainChat.TabIndex = 0;
            // 
            // FormMainChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 421);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.toolStripMain);
            this.Name = "FormMainChat";
            this.Text = "Чат";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMainChat_FormClosing);
            this.Load += new System.EventHandler(this.FormMainChat_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.ToolStripDropDownButton toolsConnection;
        private System.Windows.Forms.ToolStripMenuItem ConnectItem;
        private System.Windows.Forms.ToolStripMenuItem DisconnectItem;
        private System.Windows.Forms.ToolStripButton toolsSettings;
        private System.Windows.Forms.ListBox lstbxMainChat;
        private System.Windows.Forms.Button bttnSend;
        private System.Windows.Forms.TextBox txtbxMssg;
        private System.Windows.Forms.ListBox lstbxUsers;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

