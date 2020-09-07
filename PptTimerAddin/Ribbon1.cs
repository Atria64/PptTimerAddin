using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace PptTimerAddin
{
    public partial class Ribbon1
    {
        public static bool PresenTimerMode = false;
        public static int setMinTime = -1;
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            //後でちゃんと実装
            setMinTime = int.Parse(editBox.Text);//初期設定のロード
        }

        private void checkBox_Click(object sender, RibbonControlEventArgs e)
        {
            if (checkBox.Checked)
            {
                editBox.Visible = true;
                PresenTimerMode = true;
            }
            else
            {
                editBox.Visible = false;
                PresenTimerMode = false;
            }
        }

        private void editBox_TextChanged(object sender, RibbonControlEventArgs e)
        {
            int tmp = -1;
            string s = editBox.Text;
            if (int.TryParse(s,out tmp) &&(0 < tmp && tmp <= 100))
            {
                setMinTime = tmp;
            }
            else
            {
                editBox.Text = "";
            }
        }
    }
}
