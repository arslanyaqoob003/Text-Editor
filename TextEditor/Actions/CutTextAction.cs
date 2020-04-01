using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor.Actions
{
    public class CutTextAction
    {
        RichTextBox _rtb;
        public CutTextAction(RichTextBox tb)
        {
            _rtb = tb;
        }
        public void Execute()
        {
            Clipboard.SetText(_rtb.SelectedText);
            _rtb.SelectedText="";
        }
    }
}
