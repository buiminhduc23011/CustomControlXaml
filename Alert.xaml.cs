using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace CustomControlXaml
{
    /// <summary>
    /// Interaction logic for Alert.xaml
    /// </summary>
    public partial class Alert : Window
    {
        private DispatcherTimer timer;
        private enmAction action;
        public Alert()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
        }
        public enum enmAction
        {
            wait,
            start,
            close
        }
        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }

        public void ShowAlert(string msg, enmType type)
        {
            this.Opacity = 1.0;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                Alert frm = (Alert)Application.Current.Windows.OfType<Alert>().FirstOrDefault(window => window.Name == fname);

                if (frm == null)
                {
                    this.Name = fname;
                    this.Left = SystemParameters.WorkArea.Width - this.Width + 15;
                    //this.Top = SystemParameters.WorkArea.Height - this.Height * i - 5 * i; // Sắp xếp chồng lên (Tạm chưa xử lý được)
                    this.Top = SystemParameters.WorkArea.Height - this.Height * 1 - 5 * 1;
                    break;
                }
            }
            this.Left = SystemParameters.WorkArea.Width - this.Width - 5;

            switch (type)
            {
                case enmType.Success:
                    Custom_AlertICon.Source = new BitmapImage(new Uri("pack://application:,,,/CustomControlXaml;component/Images/success.png", UriKind.Absolute));
                    this.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                    break;
                case enmType.Error:
                    Custom_AlertICon.Source = new BitmapImage(new Uri("pack://application:,,,/CustomControlXaml;component/Images/error.png", UriKind.Absolute));
                    this.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0)); // Màu nền đỏ
                    break;
                case enmType.Info:
                    Custom_AlertICon.Source = new BitmapImage(new Uri("pack://application:,,,/CustomControlXaml;component/Images/info.png", UriKind.Absolute));
                    this.Background = new SolidColorBrush(Color.FromRgb(0, 0, 255)); // Màu nền xanh lam
                    break;
                case enmType.Warning:
                    Custom_AlertICon.Source = new BitmapImage(new Uri("pack://application:,,,/CustomControlXaml;component/Images/warning.png", UriKind.Absolute));
                    this.Background = new SolidColorBrush(Color.FromRgb(255, 165, 0)); // Màu nền cam
                    break;
            }

            lblMsg.Content = msg;

            this.Show();
            this.action = enmAction.start;
            this.timer.Interval = TimeSpan.FromMilliseconds(5000);
            this.timer.Start();
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Tick -= Timer_Tick;
            timer = null;
            HideAlert();
        }

        public void HideAlert()
        {

            Hide();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            HideAlert();
        }
    }
}
