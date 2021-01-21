
namespace Notepad_
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveUsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Вренуть = new System.Windows.Forms.ToolStripMenuItem();
            this.Вперед = new System.Windows.Forms.ToolStripMenuItem();
            this.Вырезать = new System.Windows.Forms.ToolStripMenuItem();
            this.Копировать = new System.Windows.Forms.ToolStripMenuItem();
            this.Вставить = new System.Windows.Forms.ToolStripMenuItem();
            this.Выделить_всё = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Перенос_по_словам = new System.Windows.Forms.ToolStripMenuItem();
            this.Шрифт = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.new_1 = new System.Windows.Forms.TabPage();
            this.menuStrip.SuspendLayout();
            this.fileMenuStrip.SuspendLayout();
            this.editMenuStrip.SuspendLayout();
            this.toolsMenuStrip.SuspendLayout();
            this.helpMenuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.new_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDown = this.fileMenuStrip;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "&Файл";
            // 
            // fileMenuStrip
            // 
            this.fileMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openStripMenuItem,
            this.saveStripMenuItem,
            this.saveUsStripMenuItem,
            this.exitStripMenuItem});
            this.fileMenuStrip.Name = "contextMenuStrip1";
            this.fileMenuStrip.OwnerItem = this.fileToolStripMenuItem;
            this.fileMenuStrip.Size = new System.Drawing.Size(155, 92);
            this.fileMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fileMenuStrip_ItemClicked);
            // 
            // openStripMenuItem
            // 
            this.openStripMenuItem.Name = "openStripMenuItem";
            this.openStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.openStripMenuItem.Text = "&Открыть";
            // 
            // saveStripMenuItem
            // 
            this.saveStripMenuItem.Name = "saveStripMenuItem";
            this.saveStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.saveStripMenuItem.Text = "&Сохранить";
            // 
            // saveUsStripMenuItem
            // 
            this.saveUsStripMenuItem.Name = "saveUsStripMenuItem";
            this.saveUsStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.saveUsStripMenuItem.Text = "&Сохранить как";
            // 
            // exitStripMenuItem
            // 
            this.exitStripMenuItem.Name = "exitStripMenuItem";
            this.exitStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitStripMenuItem.Text = "&Выйти";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDown = this.editMenuStrip;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.editToolStripMenuItem.Text = "&Правка";
            // 
            // editMenuStrip
            // 
            this.editMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Вренуть,
            this.Вперед,
            this.Вырезать,
            this.Копировать,
            this.Вставить,
            this.Выделить_всё});
            this.editMenuStrip.Name = "editMenuStrip";
            this.editMenuStrip.OwnerItem = this.editToolStripMenuItem;
            this.editMenuStrip.Size = new System.Drawing.Size(149, 136);
            this.editMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.editMenuStrip_ItemClicked);
            // 
            // Вренуть
            // 
            this.Вренуть.Name = "Вренуть";
            this.Вренуть.Size = new System.Drawing.Size(148, 22);
            this.Вренуть.Text = "Вернуть";
            // 
            // Вперед
            // 
            this.Вперед.Name = "Вперед";
            this.Вперед.Size = new System.Drawing.Size(148, 22);
            this.Вперед.Text = "Вперед";
            // 
            // Вырезать
            // 
            this.Вырезать.Name = "Вырезать";
            this.Вырезать.Size = new System.Drawing.Size(148, 22);
            this.Вырезать.Text = "Вырезать";
            // 
            // Копировать
            // 
            this.Копировать.Name = "Копировать";
            this.Копировать.Size = new System.Drawing.Size(148, 22);
            this.Копировать.Text = "Копировать";
            // 
            // Вставить
            // 
            this.Вставить.Name = "Вставить";
            this.Вставить.Size = new System.Drawing.Size(148, 22);
            this.Вставить.Text = "Вставить";
            // 
            // Выделить_всё
            // 
            this.Выделить_всё.Name = "Выделить_всё";
            this.Выделить_всё.Size = new System.Drawing.Size(148, 22);
            this.Выделить_всё.Text = "Выделить всё";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDown = this.toolsMenuStrip;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.toolsToolStripMenuItem.Text = "&Формат";
            // 
            // toolsMenuStrip
            // 
            this.toolsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Перенос_по_словам,
            this.Шрифт});
            this.toolsMenuStrip.Name = "toolsMenuStrip";
            this.toolsMenuStrip.OwnerItem = this.toolsToolStripMenuItem;
            this.toolsMenuStrip.Size = new System.Drawing.Size(184, 48);
            this.toolsMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolsMenuStrip_ItemClicked);
            // 
            // Перенос_по_словам
            // 
            this.Перенос_по_словам.Name = "Перенос_по_словам";
            this.Перенос_по_словам.Size = new System.Drawing.Size(183, 22);
            this.Перенос_по_словам.Text = "Перенос по словам";
            // 
            // Шрифт
            // 
            this.Шрифт.Name = "Шрифт";
            this.Шрифт.Size = new System.Drawing.Size(183, 22);
            this.Шрифт.Text = "Шрифт";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDown = this.helpMenuStrip;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.helpToolStripMenuItem.Text = "&Настройки";
            // 
            // helpMenuStrip
            // 
            this.helpMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.helpMenuStrip.Name = "helpMenuStrip";
            this.helpMenuStrip.OwnerItem = this.helpToolStripMenuItem;
            this.helpMenuStrip.Size = new System.Drawing.Size(181, 48);
            this.helpMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.helpMenuStrip_ItemClicked);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem7.Text = "toolStripMenuItem7";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem8.Text = "toolStripMenuItem8";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.new_1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 426);
            this.tabControl1.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(786, 392);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // new_1
            // 
            this.new_1.Controls.Add(this.richTextBox1);
            this.new_1.Location = new System.Drawing.Point(4, 24);
            this.new_1.Name = "new_1";
            this.new_1.Padding = new System.Windows.Forms.Padding(3);
            this.new_1.Size = new System.Drawing.Size(792, 398);
            this.new_1.TabIndex = 0;
            this.new_1.Text = "new 1";
            this.new_1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.fileMenuStrip.ResumeLayout(false);
            this.editMenuStrip.ResumeLayout(false);
            this.toolsMenuStrip.ResumeLayout(false);
            this.helpMenuStrip.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.new_1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip fileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveUsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip editMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Вренуть;
        private System.Windows.Forms.ToolStripMenuItem Вперед;
        private System.Windows.Forms.ToolStripMenuItem Вырезать;
        private System.Windows.Forms.ToolStripMenuItem Копировать;
        private System.Windows.Forms.ContextMenuStrip toolsMenuStrip;
        private System.Windows.Forms.ContextMenuStrip helpMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Перенос_по_словам;
        private System.Windows.Forms.ToolStripMenuItem Шрифт;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem openStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Вставить;
        private System.Windows.Forms.ToolStripMenuItem Выделить_всё;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage new_1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

