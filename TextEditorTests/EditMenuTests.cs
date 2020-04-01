using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextEditor.Actions;
using System.Windows.Forms;
using System.IO;

namespace TextEditorTests
{
    [TestClass]
    public class EditMenuTests
    {

        // Cut Text Test
        [TestMethod]
        public void CutActionRemovesTextAndSavesToClipboard()
        {
            RichTextBox rtb = new RichTextBox();
            rtb.Text = "All Watched Over By Machines Of Loving Grace";
            rtb.Select(12, 5);
            CutTextAction ac = new CutTextAction(rtb);
            ac.Execute();
            Assert.AreEqual("All Watched By Machines Of Loving Grace", rtb.Text, "Text disappears from textbox.");
            Assert.AreEqual("Over ", Clipboard.GetText(), "Clipboard has the text.");
        }

        //Copy Text Test
        [TestMethod]
        public void CopyActionToClipboard()
        {

            RichTextBox rtb = new RichTextBox();
            rtb.Text = "All Watched Over By Machines Of Loving Grace";
            rtb.Select(12, 5);
            var ac = new CopyTextAction(rtb);
            ac.Execute();
            Assert.AreEqual("All Watched Over By Machines Of Loving Grace", rtb.Text, "Text is not disappear from textbox.");
            Assert.AreEqual("Over ", Clipboard.GetText(), "Clipboard has the text.");
        }

        //Paste Text on the screen Test
        [TestMethod]
        public void PasteActionToClipboard()
        {

            RichTextBox rtb = new RichTextBox();
            Clipboard.SetText("All Watched Over By Machines Of Loving Grace");
            var ac = new PasteTextAction(rtb);
            ac.Execute();
            Assert.AreEqual("All Watched Over By Machines Of Loving Grace", rtb.Text, "Text appears on the textbox.");
        }

        //Save File Test
        [TestMethod]
        public void WriteFileActionTest()
        {
            String path = "..\\Debug\\Items\\data.txt"; 

            RichTextBox rtb = new RichTextBox();
            rtb.Text = "All Watched Over By Machines Of Loving Grace";

            // Write to file
            var saveAction = new SaveTextAction(rtb, path);
            saveAction.Execute();
            rtb.Text = "";

            // Read from file
            var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            var readAction = new OpenTextAction(rtb, fs);
            readAction.Execute();
            Assert.AreEqual("All Watched Over By Machines Of Loving Grace", rtb.Text, "File has been created.");
        }


        //Open File Tests
        [TestMethod]
        public void ReadFileActionTest()
        {
            String path = "..\\Debug\\Items\\test.txt";;

            RichTextBox rtb = new RichTextBox();
            var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            var ac = new OpenTextAction(rtb, fs);
            ac.Execute();
            Assert.AreEqual("All Watched Over By Machines Of Loving Grace", rtb.Text, "File is opened.");
        }

      
       
        }

    }

