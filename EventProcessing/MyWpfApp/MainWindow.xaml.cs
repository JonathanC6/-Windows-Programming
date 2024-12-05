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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyWpfApp
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private FireAlarmPublisher fireAlarmPublisher = new FireAlarmPublisher();
        private FireAlarmSubscriber fireAlarmSubscriber = new FireAlarmSubscriber();
        private FireAlarmManager fireAlarmManager;

        public MainWindow()
        {
            InitializeComponent();
            fireAlarmManager = new FireAlarmManager(fireAlarmPublisher, fireAlarmSubscriber);
        }

        private void btnTrigger_Click(object sender, RoutedEventArgs e)
        {
            //设置火情发生地
            fireAlarmPublisher.btnTrigger("A大楼");
        }

        private void Bind1_Click(object sender, RoutedEventArgs e)
        {
            fireAlarmManager.Bind1();
        }

        private void Bind2_Click(object sender, RoutedEventArgs e)
        {
            fireAlarmManager.Bind2(txtLog);
        }

        private void Unbind1_Click(object sender, RoutedEventArgs e)
        {
            fireAlarmManager.Unbind1();
        }

        private void Unbind2_Click(object sender, RoutedEventArgs e)
        {
            fireAlarmManager.Unbind2(txtLog);
        }
    }
}
