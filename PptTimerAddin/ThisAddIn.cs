using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.PowerPoint;
using PptTimerAddin.Properties;

namespace PptTimerAddin
{
    public partial class ThisAddIn
    {
        private TimerForm form;
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            Application.SlideShowBegin += PresentationStart;
            Application.SlideShowEnd += PresentationEnd;
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        private void PresentationStart(SlideShowWindow Wn)
        {
            if (Settings.Default.PresenTimerMode)
            {
                form = new TimerForm();
                form.Show();
            }
        }
        private void PresentationEnd(Presentation pres)
        {
            try
            {
                if (Settings.Default.PresenTimerMode)
                {
                    form.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        #region VSTO で生成されたコード

        /// <summary>
        /// デザイナーのサポートに必要なメソッドです。
        /// このメソッドの内容をコード エディターで変更しないでください。
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
