using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor.Actions
{
    public class CapitalTextAction
    {
        RichTextBox rtb;
        string text;

        public CapitalTextAction(RichTextBox rTB)
        {
            rtb = rTB;
        }



        public void Execute()
        {
            text = rtb.SelectedText.ToUpper();

            rtb.SelectedText = text;
        }
    }
}
