using System;
using System.Security.AccessControl;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;

namespace VoiceControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            NotifyIcon ni = new NotifyIcon { Icon = Properties.Resources.Main, Visible = true };
            ni.DoubleClick += new System.EventHandler(this.ni_DoubleClick);
        }

        private void ni_DoubleClick(object Sender, EventArgs e)
        {
            this.Show();
            this.WindowState = WindowState.Normal;
        }

        protected override void OnStateChanged(EventArgs e)
        {
            if (WindowState == WindowState.Minimized)
                this.Hide();

            base.OnStateChanged(e);
        }

    }
}
