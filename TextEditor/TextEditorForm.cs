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
using TextEditor.Actions;

namespace TextEditor
{
    public partial class TextEditorForm : Form
    {
        public TextEditorForm()
        {
            InitializeComponent();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CutTextAction ac = new CutTextAction(RTB);
            ac.Execute();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyTextAction accc = new CopyTextAction(RTB);
            accc.Execute();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteTextAction acc = new PasteTextAction(RTB);
            acc.Execute();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            
           
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK && (myStream = openFile.OpenFile()) != null)
            {
                OpenTextAction accc = new OpenTextAction(RTB, myStream);
                accc.Execute();
            }
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            SaveFileDialog savefile = new SaveFileDialog();
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                SaveTextAction acccc = new SaveTextAction(RTB,savefile.FileName);
                acccc.Execute();
                
            }
           

        }
    }
}
