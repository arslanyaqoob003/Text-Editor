using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor.Actions
{
   public class NewWindowTextAction
    {
        RichTextBox rtb;
        string path;

        public NewWindowTextAction(RichTextBox rTB)
        {
            rtb = rTB;
        }



        public void Execute()
        {
            path = string.Empty;
            rtb.Clear();
        }


    }
}
