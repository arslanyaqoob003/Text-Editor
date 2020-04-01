using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextEditor.Actions
{
    public class OpenTextAction
    {
        RichTextBox rTb;
        Stream myStream;
        public OpenTextAction(RichTextBox tb,Stream myStream)
        {
            rTb = tb;
            this.myStream = myStream;
        }

        public void Execute()
        {
            var streamRead = new StreamReader(this.myStream);
            string filetext = streamRead.ReadToEnd();
            rTb.Text = filetext;
        }
    }
}
