namespace GetHex
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.hexTextBox = new System.Windows.Forms.RichTextBox();
            this.hexMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.全选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resTextBox = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.encodeFmt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.hexMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(347, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "转换";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(2, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.hexTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.resTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(879, 364);
            this.splitContainer1.SplitterDistance = 401;
            this.splitContainer1.TabIndex = 2;
            // 
            // hexTextBox
            // 
            this.hexTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.hexTextBox.ContextMenuStrip = this.hexMenu;
            this.hexTextBox.Location = new System.Drawing.Point(0, 4);
            this.hexTextBox.Name = "hexTextBox";
            this.hexTextBox.Size = new System.Drawing.Size(402, 357);
            this.hexTextBox.TabIndex = 0;
            this.hexTextBox.Text = "";
            this.hexTextBox.Click += new System.EventHandler(this.hexTextBox_MouseEnter);
            // 
            // hexMenu
            // 
            this.hexMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全选ToolStripMenuItem,
            this.复制ToolStripMenuItem,
            this.剪切ToolStripMenuItem1,
            this.粘贴ToolStripMenuItem,
            this.取消ToolStripMenuItem});
            this.hexMenu.Name = "hexMenu";
            this.hexMenu.Size = new System.Drawing.Size(101, 114);
            // 
            // 全选ToolStripMenuItem
            // 
            this.全选ToolStripMenuItem.Name = "全选ToolStripMenuItem";
            this.全选ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.全选ToolStripMenuItem.Text = "全选";
            this.全选ToolStripMenuItem.Click += new System.EventHandler(this.全选ToolStripMenuItem_Click);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // 剪切ToolStripMenuItem1
            // 
            this.剪切ToolStripMenuItem1.Name = "剪切ToolStripMenuItem1";
            this.剪切ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.剪切ToolStripMenuItem1.Text = "剪切";
            this.剪切ToolStripMenuItem1.Click += new System.EventHandler(this.剪切ToolStripMenuItem1_Click);
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            this.粘贴ToolStripMenuItem.Click += new System.EventHandler(this.粘贴ToolStripMenuItem_Click);
            // 
            // 取消ToolStripMenuItem
            // 
            this.取消ToolStripMenuItem.Name = "取消ToolStripMenuItem";
            this.取消ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.取消ToolStripMenuItem.Text = "取消";
            this.取消ToolStripMenuItem.Click += new System.EventHandler(this.取消ToolStripMenuItem_Click);
            // 
            // resTextBox
            // 
            this.resTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.resTextBox.ContextMenuStrip = this.hexMenu;
            this.resTextBox.Location = new System.Drawing.Point(-1, 4);
            this.resTextBox.Name = "resTextBox";
            this.resTextBox.Size = new System.Drawing.Size(472, 357);
            this.resTextBox.TabIndex = 0;
            this.resTextBox.Text = "";
            this.resTextBox.Click += new System.EventHandler(this.resTextBox_MouseEnter);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(457, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // encodeFmt
            // 
            this.encodeFmt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.encodeFmt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.encodeFmt.FormattingEnabled = true;
            this.encodeFmt.Items.AddRange(new object[] {
            "UTF-8",
            "GBK",
            "ASCII"});
            this.encodeFmt.Location = new System.Drawing.Point(239, 383);
            this.encodeFmt.Name = "encodeFmt";
            this.encodeFmt.Size = new System.Drawing.Size(82, 20);
            this.encodeFmt.TabIndex = 4;
            this.encodeFmt.Text = "UTF-8";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "选择编码格式：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encodeFmt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "十六进制工具";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.hexMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox resTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip hexMenu;
        private System.Windows.Forms.ToolStripMenuItem 全选ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox hexTextBox;
        private System.Windows.Forms.ToolStripMenuItem 剪切ToolStripMenuItem1;
        private System.Windows.Forms.ComboBox encodeFmt;
        private System.Windows.Forms.Label label1;
    }
}

