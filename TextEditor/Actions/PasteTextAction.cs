using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace TextEditor.Actions
{
    public class PasteTextAction
    {
        RichTextBox rtb;
        

        public PasteTextAction(RichTextBox rTB)
        {
            rtb = rTB;
        }

 

        public void Execute()
        {  
            rtb.Paste();
        }
    }
    }

