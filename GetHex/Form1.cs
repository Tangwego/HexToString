using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GetHex.Utils;

namespace GetHex
{
    public partial class Form1 : Form
    {
        Boolean whichBox = false;
        public Form1()
        {
            whichBox = false;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HexUtils utils = new HexUtils();
            this.resTextBox.Text = utils.fromString(this.hexTextBox.Text.ToString().Trim(),this.encodeFmt.Text.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (whichBox) {
                this.resTextBox.SelectAll();
                return;
            }
            this.hexTextBox.SelectAll();
        }

        private void resTextBox_MouseEnter(object sender, EventArgs e)
        {
            whichBox = true;
        }

        private void hexTextBox_MouseEnter(object sender, EventArgs e)
        {
            whichBox = false;
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (whichBox)
            {
                this.resTextBox.Copy();
                return;
            }
            this.hexTextBox.Copy();
        }

        private void 剪切ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (whichBox)
            {
                this.resTextBox.Cut();
                return;
            }
            this.hexTextBox.Cut();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (whichBox)
            {
                this.resTextBox.Paste();
                return;
            }
            this.hexTextBox.Paste();
        }

        private void 取消ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.hexMenu.Hide();
        }
    }
}
