using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor.Actions
{
    public class CountWordTextAction
    {
        
        RichTextBox _rtb;
        public CountWordTextAction(RichTextBox tb)
        {
           _rtb = tb;
        }
        public void Execute()
        {
            var formPopup = new Form();
            int count = _rtb.Text.Count();
            string total=count.ToString();
            MessageBox.Show(total, "Total Words are: ");

        }

    }
}
