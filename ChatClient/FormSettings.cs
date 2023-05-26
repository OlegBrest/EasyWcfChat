using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void bttnOk_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserName = txtbxUserName.Text;
            Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
        }

        private void txtbx_TextChanged(object sender, EventArgs e)
        {
            bttnOk.Enabled = true;
        }
    }
}
