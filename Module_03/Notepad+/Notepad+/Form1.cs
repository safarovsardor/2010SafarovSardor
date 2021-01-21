using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad_
{
    public partial class Form1 : Form
    {
        private string FilePath;
        public Form1()
        {
            InitializeComponent();
            // saveFileDialog1.FileName = "Text File(*.txt)|*.txt|Text File (*.rtf)|*.rtf|";
        } 

        private void fileMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (openStripMenuItem.Selected)
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        FilePath = dialog.FileName;
                        richTextBox1.Text = File.ReadAllText(FilePath);
                    }
                }
            }
            else if (saveStripMenuItem.Selected)
            {
                if (string.IsNullOrEmpty(FilePath))
                {
                    using (SaveFileDialog dialog = new SaveFileDialog())
                    {
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            FilePath = dialog.FileName;
                            richTextBox1.SaveFile(FilePath);
                        }
                    }
                }
                else
                {
                    File.WriteAllText(FilePath, richTextBox1.Text);
                }
            }
            else if (saveUsStripMenuItem.Selected)
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        FilePath = dialog.FileName;
                        richTextBox1.SaveFile(FilePath);
                    }
                }
            }
            else if (exitStripMenuItem.Selected)
            {
                Close();
            }
        }

        private void editMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (Вренуть.Selected)
            {
                richTextBox1.Undo();
            }
            else if (Вперед.Selected)
            {
                richTextBox1.Redo();
            }
            else if (Вырезать.Selected)
            {
                richTextBox1.Cut();
            }
            else if (Копировать.Selected)
            {
                richTextBox1.Copy();
            }
            else if (Вставить.Selected)
            {
                richTextBox1.Paste();
            }
            else if (Выделить_всё.Selected)
            {
                richTextBox1.SelectAll();
            }
        }

        private void toolsMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (Перенос_по_словам.Selected)
            {
                Перенос_по_словам.Checked = !Перенос_по_словам.Checked;
                richTextBox1.WordWrap = Перенос_по_словам.Checked;
            }
            else if (Шрифт.Selected)
            {
                using (FontDialog dialog = new FontDialog())
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox1.Font = dialog.Font;
                    }
                }
            }
        }

        private void helpMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show("4");
        }

    }
}
