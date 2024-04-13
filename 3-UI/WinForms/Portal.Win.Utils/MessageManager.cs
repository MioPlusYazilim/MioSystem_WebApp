using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Portal.Win.Utils
{
    public class MessageManager
    {
        public static void MessageBoxHata(string Baslik, string Msg, string DetailMsg)
        {
            MessageBox.Show(Msg + " \n" + DetailMsg, Baslik, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MessageBoxBilgi(string Baslik, string Msg, string DetailMsg)
        {
            MessageBox.Show(Msg + " \n" + DetailMsg, Baslik, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public static DialogResult MessageBoxOnay(string Baslik, string Msg, string DetailMsg)
        {
            return MessageBox.Show(Msg + " \n" + DetailMsg, Baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
