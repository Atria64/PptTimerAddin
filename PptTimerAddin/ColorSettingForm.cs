using PptTimerAddin.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PptTimerAddin
{
    public partial class ColorSettingForm : Form
    {
        private List<string> colors = new List<string>{ "Black", "White","Red" };
        public ColorSettingForm()
        {
            InitializeComponent();
        }

        private void ColorSettingForm_Load(object sender, EventArgs e)
        {
            CharColorComboBox.Items.AddRange(colors.ToArray());
            CharColorComboBox.SelectedItem = Settings.Default.CharColor;
            BackGroundColorComboBox.Items.AddRange(colors.ToArray());
            BackGroundColorComboBox.SelectedItem = Settings.Default.BackGroundColor;
            HighlightColorComboBox.Items.AddRange(colors.ToArray());
            HighlightColorComboBox.SelectedItem = Settings.Default.HighlightColor;
        }

        private void CharColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.CharColor = CharColorComboBox.SelectedItem.ToString();
            Settings.Default.Save();
        }

        private void BackGroundColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.BackGroundColor = BackGroundColorComboBox.SelectedItem.ToString();
            Settings.Default.Save();
        }

        private void HighlightColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.HighlightColor = HighlightColorComboBox.SelectedItem.ToString();
            Settings.Default.Save();
        }

    }
}
