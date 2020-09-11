using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;
using PptTimerAddin.Properties;

namespace PptTimerAddin
{
    public partial class Ribbon
    {
        public static int setMinTime = -1;
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            //後でちゃんと実装
            //初期設定のロード
            setMinTime = int.Parse(editBox.Text);
            checkBox.Checked = Settings.Default.PresenTimerMode;
            editBox.Visible = Settings.Default.PresenTimerMode;
            AutoTimerCheckBox.Checked = Settings.Default.AutoTimerStartMode;
        }

        private void checkBox_Click(object sender, RibbonControlEventArgs e)
        {
            editBox.Visible = checkBox.Checked;
            Settings.Default.PresenTimerMode = checkBox.Checked;
            Properties.Settings.Default.Save();
        }
        private void AutoTimerCheckBox_Click(object sender, RibbonControlEventArgs e)
        {
            Settings.Default.AutoTimerStartMode = AutoTimerCheckBox.Checked;
            Properties.Settings.Default.Save();
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

        private void ColorSetButton_Click(object sender, RibbonControlEventArgs e)
        {
            var f = new ColorSettingForm();
            f.ShowDialog();
            f.Dispose();
        }

        private void SupportLinkButton_Click(object sender, RibbonControlEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Atria64/PptTimerAddin");
        }
    }
}
