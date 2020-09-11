namespace PptTimerAddin
{
    partial class ColorSettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CharColorComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.PreviewLabel = new System.Windows.Forms.Label();
            this.HighlightColorComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BackGroundColorComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CharColorComboBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.HighlightColorComboBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BackGroundColorComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.ApplyButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 362);
            this.panel1.TabIndex = 0;
            // 
            // CharColorComboBox
            // 
            this.CharColorComboBox.FormattingEnabled = true;
            this.CharColorComboBox.ItemHeight = 12;
            this.CharColorComboBox.Location = new System.Drawing.Point(61, 56);
            this.CharColorComboBox.Name = "CharColorComboBox";
            this.CharColorComboBox.Size = new System.Drawing.Size(113, 20);
            this.CharColorComboBox.TabIndex = 0;
            this.CharColorComboBox.SelectedIndexChanged += new System.EventHandler(this.CharColorComboBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.PreviewLabel);
            this.panel2.Location = new System.Drawing.Point(14, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 127);
            this.panel2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(21, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "プレビュー\r\n(マウスホバーで強調時表示)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PreviewLabel
            // 
            this.PreviewLabel.AutoSize = true;
            this.PreviewLabel.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PreviewLabel.Location = new System.Drawing.Point(21, 37);
            this.PreviewLabel.Name = "PreviewLabel";
            this.PreviewLabel.Size = new System.Drawing.Size(156, 64);
            this.PreviewLabel.TabIndex = 0;
            this.PreviewLabel.Text = "7：00";
            this.PreviewLabel.MouseEnter += new System.EventHandler(this.PreviewLabel_MouseEnter);
            this.PreviewLabel.MouseLeave += new System.EventHandler(this.PreviewLabel_MouseLeave);
            // 
            // HighlightColorComboBox
            // 
            this.HighlightColorComboBox.FormattingEnabled = true;
            this.HighlightColorComboBox.Location = new System.Drawing.Point(61, 151);
            this.HighlightColorComboBox.Name = "HighlightColorComboBox";
            this.HighlightColorComboBox.Size = new System.Drawing.Size(113, 20);
            this.HighlightColorComboBox.TabIndex = 2;
            this.HighlightColorComboBox.SelectedIndexChanged += new System.EventHandler(this.HighlightColorComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(33, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "強調色";
            // 
            // BackGroundColorComboBox
            // 
            this.BackGroundColorComboBox.FormattingEnabled = true;
            this.BackGroundColorComboBox.Location = new System.Drawing.Point(61, 103);
            this.BackGroundColorComboBox.Name = "BackGroundColorComboBox";
            this.BackGroundColorComboBox.Size = new System.Drawing.Size(113, 20);
            this.BackGroundColorComboBox.TabIndex = 1;
            this.BackGroundColorComboBox.SelectedIndexChanged += new System.EventHandler(this.BackGroundColorComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(33, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "背景色";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(58, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "タイマー色設定";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "文字色";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(116, 322);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "キャンセル";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(35, 322);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 3;
            this.ApplyButton.Text = "適用";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // ColorSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 386);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorSettingForm";
            this.ShowIcon = false;
            this.Text = "タイマーの色の設定";
            this.Load += new System.EventHandler(this.ColorSettingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label PreviewLabel;
        private System.Windows.Forms.ComboBox HighlightColorComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox BackGroundColorComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CharColorComboBox;
        private System.Windows.Forms.Button CancelButton;
    }
}