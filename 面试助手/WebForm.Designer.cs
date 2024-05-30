namespace 面试助手
{
    partial class WebForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebForm));
            toolStrip1 = new ToolStrip();
            toolStripSplitButton1 = new ToolStripSplitButton();
            英文精简引擎ToolStripMenuItem = new ToolStripMenuItem();
            英文完整版引擎ToolStripMenuItem = new ToolStripMenuItem();
            中文精简引擎ToolStripMenuItem = new ToolStripMenuItem();
            中文完整版引擎ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripLabel2 = new ToolStripLabel();
            toolStripLabel1 = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            refreshBtn = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            progress = new ToolStripProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            splitContainer1 = new SplitContainer();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSplitButton1, toolStripSeparator3, toolStripLabel2, toolStripLabel1, toolStripSeparator1, toolStripButton2, toolStripSeparator2, toolStripButton1, toolStripSeparator4, refreshBtn });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 3, 0);
            toolStrip1.Size = new Size(2370, 33);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { 英文精简引擎ToolStripMenuItem, 英文完整版引擎ToolStripMenuItem, 中文精简引擎ToolStripMenuItem, 中文完整版引擎ToolStripMenuItem });
            toolStripSplitButton1.Image = Properties.Resources.c5ff081df233843d6c330e1fbf017d61_69_512;
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(45, 28);
            toolStripSplitButton1.Text = "toolStripSplitButton1";
            toolStripSplitButton1.ButtonClick += toolStripSplitButton1_ButtonClick;
            // 
            // 英文精简引擎ToolStripMenuItem
            // 
            英文精简引擎ToolStripMenuItem.Name = "英文精简引擎ToolStripMenuItem";
            英文精简引擎ToolStripMenuItem.Size = new Size(236, 34);
            英文精简引擎ToolStripMenuItem.Text = "英文精简引擎";
            英文精简引擎ToolStripMenuItem.Click += 英文精简引擎ToolStripMenuItem_Click;
            // 
            // 英文完整版引擎ToolStripMenuItem
            // 
            英文完整版引擎ToolStripMenuItem.Name = "英文完整版引擎ToolStripMenuItem";
            英文完整版引擎ToolStripMenuItem.Size = new Size(236, 34);
            英文完整版引擎ToolStripMenuItem.Text = "英文完整版引擎";
            英文完整版引擎ToolStripMenuItem.Click += 英文完整版引擎ToolStripMenuItem_Click;
            // 
            // 中文精简引擎ToolStripMenuItem
            // 
            中文精简引擎ToolStripMenuItem.Name = "中文精简引擎ToolStripMenuItem";
            中文精简引擎ToolStripMenuItem.Size = new Size(236, 34);
            中文精简引擎ToolStripMenuItem.Text = "中文精简引擎";
            中文精简引擎ToolStripMenuItem.Click += 中文精简引擎ToolStripMenuItem_Click;
            // 
            // 中文完整版引擎ToolStripMenuItem
            // 
            中文完整版引擎ToolStripMenuItem.Name = "中文完整版引擎ToolStripMenuItem";
            中文完整版引擎ToolStripMenuItem.Size = new Size(236, 34);
            中文完整版引擎ToolStripMenuItem.Text = "中文完整版引擎";
            中文完整版引擎ToolStripMenuItem.Click += 中文完整版引擎ToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 33);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(57, 28);
            toolStripLabel2.Text = "Index";
            toolStripLabel2.Click += toolStripLabel2_Click_1;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(44, 28);
            toolStripLabel1.Text = "GPT";
            toolStripLabel1.Click += toolStripLabel1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 33);
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(34, 28);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 33);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(34, 28);
            toolStripButton1.Text = "Clear";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 33);
            // 
            // refreshBtn
            // 
            refreshBtn.Checked = true;
            refreshBtn.CheckOnClick = true;
            refreshBtn.CheckState = CheckState.Checked;
            refreshBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            refreshBtn.Image = Properties.Resources.Refresh_icon;
            refreshBtn.ImageTransparentColor = Color.Magenta;
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(34, 28);
            refreshBtn.Text = "toolStripButton3";
            refreshBtn.Click += toolStripButton3_Click_1;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { progress });
            statusStrip1.Location = new Point(0, 1045);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(2, 0, 14, 0);
            statusStrip1.Size = new Size(2370, 31);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // progress
            // 
            progress.Name = "progress";
            progress.Size = new Size(101, 23);
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Interval = 200;
            // 
            // timer4
            // 
            timer4.Interval = 200;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 33);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Size = new Size(2370, 1012);
            splitContainer1.SplitterDistance = 790;
            splitContainer1.TabIndex = 2;
            // 
            // WebForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2370, 1076);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Name = "WebForm";
            Text = "WebForm";
            FormClosing += WebForm_FormClosing;
            Load += WebForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator1;
        private StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem 英文精简引擎ToolStripMenuItem;
        private ToolStripMenuItem 中文精简引擎ToolStripMenuItem;
        private ToolStripMenuItem 中文完整版引擎ToolStripMenuItem;
        private ToolStripMenuItem 英文完整版引擎ToolStripMenuItem;
        public ToolStripProgressBar progress;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private ToolStripLabel toolStripLabel2;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton refreshBtn;
        private SplitContainer splitContainer1;
    }
}