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
    /// Question.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Question : Window
    {
        public Question()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            string mbtiValue = "I"; // 선택된 값에 따라 적절한 값으로 설정

            q2 page2 = new q2(mbtiValue);
            page2.Show();

            Close(); // 현재 창 닫기
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            string mbtiValue = "E"; // 선택된 값에 따라 적절한 값으로 설정

            q2 page2 = new q2(mbtiValue);
            page2.Show();

            Close(); // 현재 창 닫기
        }
    }
}
