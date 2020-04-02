using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor.Actions
{
    public class ColourTextAction
    {
        RichTextBox rtb;


        public ColourTextAction(RichTextBox rTB)
        {
            rtb = rTB;
        }



        public void Execute()
        {
            ColorDialog col = new ColorDialog();
            col.ShowDialog();
            rtb.SelectionColor = col.Color ;
        }
    }
}
