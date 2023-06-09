﻿namespace ChatClient
{
    partial class FormSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnOk = new System.Windows.Forms.Button();
            this.portUpDown = new System.Windows.Forms.NumericUpDown();
            this.txtbxUserName = new System.Windows.Forms.TextBox();
            this.txtbxServerAddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.portUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Адрес и порт сервера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Имя пользователя";
            // 
            // bttnOk
            // 
            this.bttnOk.Enabled = false;
            this.bttnOk.Location = new System.Drawing.Point(305, 65);
            this.bttnOk.Name = "bttnOk";
            this.bttnOk.Size = new System.Drawing.Size(75, 23);
            this.bttnOk.TabIndex = 2;
            this.bttnOk.Text = "Применить";
            this.bttnOk.UseVisualStyleBackColor = true;
            this.bttnOk.Click += new System.EventHandler(this.bttnOk_Click);
            // 
            // portUpDown
            // 
            this.portUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::ChatClient.Properties.Settings.Default, "ServerPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.portUpDown.Location = new System.Drawing.Point(303, 6);
            this.portUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.portUpDown.Name = "portUpDown";
            this.portUpDown.Size = new System.Drawing.Size(77, 20);
            this.portUpDown.TabIndex = 3;
            this.portUpDown.Value = global::ChatClient.Properties.Settings.Default.ServerPort;
            // 
            // txtbxUserName
            // 
            this.txtbxUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ChatClient.Properties.Settings.Default, "UserName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtbxUserName.Location = new System.Drawing.Point(121, 34);
            this.txtbxUserName.Name = "txtbxUserName";
            this.txtbxUserName.Size = new System.Drawing.Size(259, 20);
            this.txtbxUserName.TabIndex = 1;
            this.txtbxUserName.Text = global::ChatClient.Properties.Settings.Default.UserName;
            this.txtbxUserName.TextChanged += new System.EventHandler(this.txtbx_TextChanged);
            // 
            // txtbxServerAddress
            // 
            this.txtbxServerAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ChatClient.Properties.Settings.Default, "serverAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtbxServerAddress.Location = new System.Drawing.Point(132, 6);
            this.txtbxServerAddress.Name = "txtbxServerAddress";
            this.txtbxServerAddress.Size = new System.Drawing.Size(161, 20);
            this.txtbxServerAddress.TabIndex = 1;
            this.txtbxServerAddress.Text = global::ChatClient.Properties.Settings.Default.serverAddress;
            this.txtbxServerAddress.TextChanged += new System.EventHandler(this.txtbx_TextChanged);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 100);
            this.Controls.Add(this.portUpDown);
            this.Controls.Add(this.bttnOk);
            this.Controls.Add(this.txtbxUserName);
            this.Controls.Add(this.txtbxServerAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            ((System.ComponentModel.ISupportInitialize)(this.portUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxServerAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxUserName;
        private System.Windows.Forms.Button bttnOk;
        private System.Windows.Forms.NumericUpDown portUpDown;
    }
}