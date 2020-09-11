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
    public partial class TimerForm : Form
    {
        private int secTime = Ribbon.setMinTime * 60;
        public TimerForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timeLabel.DoubleClick += TimerControl;
            //配置変更系/-----
            timeLabel.MouseDown += new MouseEventHandler(MouseDown);
            timeLabel.MouseMove += new MouseEventHandler(MouseMove);
            //----------------
            
            timer.Enabled = Settings.Default.AutoTimerStartMode;
            if (timer.Enabled)
            {
                timeLabel.ForeColor = Color.FromName(Settings.Default.CharColor);
            }
            else timeLabel.ForeColor = Color.FromName(Settings.Default.HighlightColor);

            timeLabel.Text = CalLabelTime();
            timeLabel.BackColor = Color.FromName(Settings.Default.BackGroundColor);
        }

        private string CalLabelTime()
        {
            string min = (secTime / 60).ToString();
            return string.Format("{0}:{1:00}", min, secTime % 60);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (secTime > 0)secTime--;
            if (secTime <= 0)
            {
                timeLabel.ForeColor = Color.FromName(Settings.Default.HighlightColor); ;
            }
            timeLabel.Text = CalLabelTime();
        }

        private void TimerControl(object sender,EventArgs e)
        {
            if (secTime <= 0) return;
            timer.Enabled = !timer.Enabled;
            if (timer.Enabled)
            {
                timeLabel.ForeColor = Color.FromName(Settings.Default.CharColor);
            }else timeLabel.ForeColor = Color.FromName(Settings.Default.HighlightColor);
        }

        //配置変更系-------
        private Point mousePoint;
        private new void MouseDown(object sender,MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                //位置を記憶する
                mousePoint = new Point(e.X, e.Y);
            }
        }

        private new void MouseMove(object sender,MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
                //または、つぎのようにする
                //this.Location = new Point(
                //    this.Location.X + e.X - mousePoint.X,
                //    this.Location.Y + e.Y - mousePoint.Y);
            }
        }
    }
}
