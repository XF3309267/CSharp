namespace project2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开form2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭FormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水平ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.垂直ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.叠加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.窗口ToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开form2ToolStripMenuItem,
            this.关闭FormToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.文件ToolStripMenuItem.Text = "文件（&F）";
            this.文件ToolStripMenuItem.Click += new System.EventHandler(this.文件ToolStripMenuItem_Click);
            // 
            // 打开form2ToolStripMenuItem
            // 
            this.打开form2ToolStripMenuItem.Name = "打开form2ToolStripMenuItem";
            this.打开form2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.打开form2ToolStripMenuItem.Text = "打开Form2";
            this.打开form2ToolStripMenuItem.Click += new System.EventHandler(this.打开form2ToolStripMenuItem_Click);
            // 
            // 关闭FormToolStripMenuItem
            // 
            this.关闭FormToolStripMenuItem.Name = "关闭FormToolStripMenuItem";
            this.关闭FormToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关闭FormToolStripMenuItem.Text = "关闭Form2";
            this.关闭FormToolStripMenuItem.Click += new System.EventHandler(this.关闭FormToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 窗口ToolStripMenuItem
            // 
            this.窗口ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.水平ToolStripMenuItem,
            this.垂直ToolStripMenuItem,
            this.叠加ToolStripMenuItem});
            this.窗口ToolStripMenuItem.Name = "窗口ToolStripMenuItem";
            this.窗口ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.窗口ToolStripMenuItem.Text = "窗口（&W）";
            // 
            // 水平ToolStripMenuItem
            // 
            this.水平ToolStripMenuItem.Name = "水平ToolStripMenuItem";
            this.水平ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.水平ToolStripMenuItem.Text = "水平";
            this.水平ToolStripMenuItem.Click += new System.EventHandler(this.水平ToolStripMenuItem_Click);
            // 
            // 垂直ToolStripMenuItem
            // 
            this.垂直ToolStripMenuItem.Name = "垂直ToolStripMenuItem";
            this.垂直ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.垂直ToolStripMenuItem.Text = "垂直";
            this.垂直ToolStripMenuItem.Click += new System.EventHandler(this.垂直ToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.帮助HToolStripMenuItem.Text = "帮助（&H）";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // 叠加ToolStripMenuItem
            // 
            this.叠加ToolStripMenuItem.Name = "叠加ToolStripMenuItem";
            this.叠加ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.叠加ToolStripMenuItem.Text = "叠加";
            this.叠加ToolStripMenuItem.Click += new System.EventHandler(this.叠加ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开form2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭FormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水平ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 垂直ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 叠加ToolStripMenuItem;

    }
}

