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
    /// q2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class q3 : Window
    {
        private string mbtiValue;
        public q3(string mbtiValue) // 매개변수로 mbtiValue를 받음
        {
            InitializeComponent();
            this.mbtiValue = mbtiValue;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            mbtiValue += "T"; // 선택된 값에 따라 적절한 값으로 설정

            q4 page3 = new q4(mbtiValue);
            page3.Show();

            Close(); // 현재 창 닫기
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            mbtiValue += "F"; // 선택된 값에 따라 적절한 값으로 설정

            q4 page3 = new q4(mbtiValue);
            page3.Show();

            Close(); // 현재 창 닫기
        }
    }
}
