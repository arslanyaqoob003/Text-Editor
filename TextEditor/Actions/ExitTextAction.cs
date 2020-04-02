using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor.Actions
{
    public class ExitTextAction
    {
        RichTextBox rtb;
        

        public ExitTextAction (RichTextBox rTB)
        {
            rtb = rTB;
        }



        public void Execute()
        {
            DialogResult result = MessageBox.Show("Save Your File", "Question", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                SaveFileDialog savefile = new SaveFileDialog();
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    SaveTextAction acccc = new SaveTextAction(rtb, savefile.FileName);
                    acccc.Execute();

                }
            }
            else
            {
                return;
            }
            Application.Exit();
        }

    }
            
}
    

