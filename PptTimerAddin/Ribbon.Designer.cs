namespace PptTimerAddin
{
    partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.checkBox = this.Factory.CreateRibbonCheckBox();
            this.editBox = this.Factory.CreateRibbonEditBox();
            this.button1 = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.AutoTimerCheckBox = this.Factory.CreateRibbonCheckBox();
            this.ColorSetButton = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.checkBox);
            this.group1.Items.Add(this.editBox);
            this.group1.Items.Add(this.button1);
            this.group1.Label = "プレゼンタイマー制御";
            this.group1.Name = "group1";
            // 
            // checkBox
            // 
            this.checkBox.Label = "プレゼンタイマー有効化";
            this.checkBox.Name = "checkBox";
            this.checkBox.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.checkBox_Click);
            // 
            // editBox
            // 
            this.editBox.Label = "時間(分)";
            this.editBox.Name = "editBox";
            this.editBox.ScreenTip = "1<= x <= 100";
            this.editBox.Text = "5";
            this.editBox.Visible = false;
            this.editBox.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.editBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Label = "";
            this.button1.Name = "button1";
            // 
            // group2
            // 
            this.group2.Items.Add(this.AutoTimerCheckBox);
            this.group2.Items.Add(this.ColorSetButton);
            this.group2.Label = "各種設定・その他";
            this.group2.Name = "group2";
            // 
            // AutoTimerCheckBox
            // 
            this.AutoTimerCheckBox.Label = "プレゼンテーション開始時に自動でタイマーを開始する";
            this.AutoTimerCheckBox.Name = "AutoTimerCheckBox";
            this.AutoTimerCheckBox.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AutoTimerCheckBox_Click);
            // 
            // ColorSetButton
            // 
            this.ColorSetButton.Label = "タイマーの色の設定";
            this.ColorSetButton.Name = "ColorSetButton";
            this.ColorSetButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ColorSetButton_Click);
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.PowerPoint.Presentation";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBox;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ColorSetButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox AutoTimerCheckBox;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon1
        {
            get { return this.GetRibbon<Ribbon>(); }
        }
    }
}
