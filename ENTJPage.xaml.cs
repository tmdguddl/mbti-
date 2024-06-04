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

namespace Termproject__v0._1._0
{
    /// <summary>
    /// ENTJPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ENTJPage : Window
    {
        public ENTJPage()
        {
            InitializeComponent();
        }
        private void Backbtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (mainWindow != null)
            {
                mainWindow.Show();
                this.Close();
            }
            else
            {
                // MainWindow.xaml이 열려있지 않은 경우 처리
                MainWindow newMainWindow = new MainWindow();
                newMainWindow.Show();
                this.Close();
            }
        }

        private void exitbtn_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
