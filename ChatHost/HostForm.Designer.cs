namespace ChatHost
{
    partial class HostForm
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
            this.consoleListBox = new System.Windows.Forms.ListBox();
            this.lstbxUsers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // consoleListBox
            // 
            this.consoleListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleListBox.FormattingEnabled = true;
            this.consoleListBox.Location = new System.Drawing.Point(3, 34);
            this.consoleListBox.Name = "consoleListBox";
            this.consoleListBox.Size = new System.Drawing.Size(596, 407);
            this.consoleListBox.TabIndex = 0;
            // 
            // lstbxUsers
            // 
            this.lstbxUsers.FormattingEnabled = true;
            this.lstbxUsers.Location = new System.Drawing.Point(605, 35);
            this.lstbxUsers.Name = "lstbxUsers";
            this.lstbxUsers.Size = new System.Drawing.Size(183, 407);
            this.lstbxUsers.TabIndex = 1;
            // 
            // HostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstbxUsers);
            this.Controls.Add(this.consoleListBox);
            this.Name = "HostForm";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.HostForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox consoleListBox;
        private System.Windows.Forms.ListBox lstbxUsers;
    }
}

