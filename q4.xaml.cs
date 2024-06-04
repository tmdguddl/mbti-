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
    /// q4.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class q4 : Window
    {
        private string mbtiValue;
        public q4(string mbtiValue) // 매개변수로 mbtiValue를 받음
        {
            InitializeComponent();
            this.mbtiValue = mbtiValue;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            mbtiValue += "P"; // 선택된 값에 따라 적절한 값으로 설정

            // MBTI 결과값에 따른 페이지 이동
            switch (mbtiValue)
            {
                case "ENTJ":
                    ENTJPage entjPage = new ENTJPage();
                    entjPage.Show();
                    break;
                case "ENTP":
                    ENTPPage entpPage = new ENTPPage();
                    entpPage.Show();
                    break;
                case "ENFJ":
                    ENFJPage enfjPage = new ENFJPage();
                    enfjPage.Show();
                    break;
                case "ENFP":
                    ENFPPage enfpPage = new ENFPPage();
                    enfpPage.Show();
                    break;
                case "ESTJ":
                    ESTJPage estjPage = new ESTJPage();
                    estjPage.Show();
                    break;
                case "ESTP":
                    ESTPPage estpPage = new ESTPPage();
                    estpPage.Show();
                    break;
                case "ESFJ":
                    ESFJPage esfjPage = new ESFJPage();
                    esfjPage.Show();
                    break;
                case "ESFP":
                    ESFPPage esfpPage = new ESFPPage();
                    esfpPage.Show();
                    break;
                case "INTJ":
                    INTJPage intjPage = new INTJPage();
                    intjPage.Show();
                    break;
                case "INTP":
                    INTPPage intpPage = new INTPPage();
                    intpPage.Show();
                    break;
                case "INFJ":
                    INFJPage infjPage = new INFJPage();
                    infjPage.Show();
                    break;
                case "INFP":
                    INFPPage infpPage = new INFPPage();
                    infpPage.Show();
                    break;
                case "ISTJ":
                    ISTJPage istjPage = new ISTJPage();
                    istjPage.Show();
                    break;
                case "ISTP":
                    ISTPPage istpPage = new ISTPPage();
                    istpPage.Show();
                    break;
                case "ISFJ":
                    ISFJPage isfjPage = new ISFJPage();
                    isfjPage.Show();
                    break;
                case "ISFP":
                    ISFPPage isfpPage = new ISFPPage();
                    isfpPage.Show();
                    break;
                default:
                    MessageBox.Show("MBTI 결과 페이지를 찾을 수 없습니다.");
                    break;
            }

            Close(); // 현재 창 닫기
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            mbtiValue += "J"; // 선택된 값에 따라 적절한 값으로 설정

            // MBTI 결과값에 따른 페이지 이동
            switch (mbtiValue)
            {
                case "ENTJ":
                    ENTJPage entjPage = new ENTJPage();
                    entjPage.Show();
                    break;
                case "ENTP":
                    ENTPPage entpPage = new ENTPPage();
                    entpPage.Show();
                    break;
                case "ENFJ":
                    ENFJPage enfjPage = new ENFJPage();
                    enfjPage.Show();
                    break;
                case "ENFP":
                    ENFPPage enfpPage = new ENFPPage();
                    enfpPage.Show();
                    break;
                case "ESTJ":
                    ESTJPage estjPage = new ESTJPage();
                    estjPage.Show();
                    break;
                case "ESTP":
                    ESTPPage estpPage = new ESTPPage();
                    estpPage.Show();
                    break;
                case "ESFJ":
                    ESFJPage esfjPage = new ESFJPage();
                    esfjPage.Show();
                    break;
                case "ESFP":
                    ESFPPage esfpPage = new ESFPPage();
                    esfpPage.Show();
                    break;
                case "INTJ":
                    INTJPage intjPage = new INTJPage();
                    intjPage.Show();
                    break;
                case "INTP":
                    INTPPage intpPage = new INTPPage();
                    intpPage.Show();
                    break;
                case "INFJ":
                    INFJPage infjPage = new INFJPage();
                    infjPage.Show();
                    break;
                case "INFP":
                    INFPPage infpPage = new INFPPage();
                    infpPage.Show();
                    break;
                case "ISTJ":
                    ISTJPage istjPage = new ISTJPage();
                    istjPage.Show();
                    break;
                case "ISTP":
                    ISTPPage istpPage = new ISTPPage();
                    istpPage.Show();
                    break;
                case "ISFJ":
                    ISFJPage isfjPage = new ISFJPage();
                    isfjPage.Show();
                    break;
                case "ISFP":
                    ISFPPage isfpPage = new ISFPPage();
                    isfpPage.Show();
                    break;
                default:
                    MessageBox.Show("MBTI 결과 페이지를 찾을 수 없습니다.");
                    break;
            }

            Close(); // 현재 창 닫기
        }
    }
}