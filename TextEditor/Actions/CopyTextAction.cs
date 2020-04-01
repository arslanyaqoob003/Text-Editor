using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor.Actions
{
    public class CopyTextAction
    {
           RichTextBox rtB;


        public CopyTextAction(RichTextBox rTB)
        {
            rtB = rTB;
        }

        public void Execute()
        {
            Clipboard.SetText(rtB.SelectedText);
        }
    }
    }

