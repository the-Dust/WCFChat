using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCF_MyChatClient
{
    public partial class MyForm : Form
    {
        //localhost.MyChatService servise = new localhost.MyChatService();
        //zyxel.MyChatService servise = new zyxel.MyChatService();
        MyInternetWCF.MyChatService servise = new MyInternetWCF.MyChatService();

        public MyForm()
        {
            InitializeComponent();
            timer.Start();
            timer_Tick(null, EventArgs.Empty);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            bool focused = tbUsername.Focused;
            richTextBox.Text = servise.GetChat();
            richTextBox.Focus();
            richTextBox.SelectionStart = richTextBox.Text.Length;
            if (focused)
                tbUsername.Focus();
            else rtbMessage.Focus();
            /*
            string answer = servise.GetChat();
            Clipboard.SetData(DataFormats.Rtf, (object)answer);
            richTextBox.Paste();
            Clipboard.Clear();
            */
        }

        private void btnSend_Click(object sender, EventArgs e)
        {/*
            string message = @"{\rtf1\b " + DateTime.Now.ToString() + " " + tbUsername.Text +
                @"\b0\par\line}}" + Environment.NewLine + rtbMessage.Text;*/
            string message = DateTime.Now.ToString() + " " + tbUsername.Text +
                Environment.NewLine + rtbMessage.Text + Environment.NewLine;
            servise.SendMessageAsync(message);
            rtbMessage.Text = "";
            timer_Tick(null, EventArgs.Empty);
        }
    }
}
