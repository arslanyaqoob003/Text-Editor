using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor.Actions
{
   public class ClearTextAction
    {
        RichTextBox rtb;


        public ClearTextAction (RichTextBox rTB)
        {
            rtb = rTB;
        }



        public void Execute()
        {
           
            rtb.SelectedText = "";
        }
    }

}

