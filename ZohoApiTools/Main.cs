using System;
using System.Windows.Forms;

namespace ZohoApiTools
{
    public partial class Main : Form
    {
        private System.Timers.Timer _myTimer = new System.Timers.Timer();
        private int _logipd = 0;

        public Main()
        {
            InitializeComponent();
            OnRegisterEvents();
        }

        private void OnRegisterEvents()
        {
            this.SizeChanged += Main_SizeChanged;
            nicon.Click += Nicon_Click;
            tmclick.Click += Tmclick_Click;
            pbar.Visible = false;
        }

        /// <summary>
        /// 开始执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tmclick_Click(object sender, System.EventArgs e)
        {
            try
            {
                //LogHelper.WriteLog("OK");

            }
            catch (Exception ex)
            {
                LogHelper.WriteErrorLog("出现异常:",ex);
            }
        }




        /// <summary>
        /// 窗体最小化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Nicon_Click(object sender, System.EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        /// <summary>
        /// 窗体最小化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_SizeChanged(object sender, System.EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }
    }
}
