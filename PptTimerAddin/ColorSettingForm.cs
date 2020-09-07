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
        private List<string> colors = new List<string>{ "Black", "White","Red","Blue","SkyBlue"
                                                       ,"Pink", "Green"};
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
            UpdatePreview();
        }

        private void BackGroundColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void HighlightColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void UpdatePreview()
        {
            PreviewLabel.ForeColor = Color.FromName(CharColorComboBox.Text);
            PreviewLabel.BackColor = Color.FromName(BackGroundColorComboBox.Text);
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Settings.Default.CharColor = CharColorComboBox.SelectedItem.ToString();
            Settings.Default.BackGroundColor = BackGroundColorComboBox.SelectedItem.ToString();
            Settings.Default.HighlightColor = HighlightColorComboBox.SelectedItem.ToString();
            Settings.Default.Save();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PreviewLabel_MouseEnter(object sender, EventArgs e)
        {
            PreviewLabel.ForeColor = Color.FromName(HighlightColorComboBox.Text);
        }

        private void PreviewLabel_MouseLeave(object sender, EventArgs e)
        {
            PreviewLabel.ForeColor = Color.FromName(CharColorComboBox.Text);
        }
    }
}
