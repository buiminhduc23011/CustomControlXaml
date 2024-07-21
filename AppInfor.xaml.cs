using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomControlXaml
{
    /// <summary>
    /// Interaction logic for AppInfor.xaml
    /// </summary>
    public partial class AppInfor : Window
    {
        public AppInfor(string sofName, string version, string releaseDate, string copyright, string website,
                     string po, string createDate, string upgradeDate, string hotline, string logo)
        {
            InitializeComponent();

            // Khởi tạo ViewModel và thiết lập DataContext
            var viewModel = new AppInforModel
            {
                SofName = sofName,
                Version = version,
                ReleaseDate = releaseDate,
                Copyright = copyright,
                Website = website,
                PO = po,
                Createdate = createDate,
                Upgradedate = upgradeDate,
                Hotline = hotline,
                Logo = logo
            };

            DataContext = viewModel;
        }

        private void CloseClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri) { UseShellExecute = true });
            e.Handled = true;
        }

    }
}
public class AppInforModel
{
    public string SofName { get; set; }
    public string Version { get; set; }
    public string ReleaseDate { get; set; }
    public string Copyright { get; set; }
    public string Website { get; set; }
    public string PO { get; set; }
    public string Createdate { get; set; }
    public string Upgradedate { get; set; }
    public string Hotline { get; set; }
    public string Logo { get; set; }
}
