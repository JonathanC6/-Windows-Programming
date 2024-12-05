using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MyWpfApp
{
    public class FireAlarmManager
    {
        private FireAlarmPublisher fireAlarmPublisher;
        private FireAlarmSubscriber fireAlarmSubscriber;

        //保存事件处理程序的实例
        private FireAlarmHandler logFireHandler;
        private FireAlarmHandler fireHandlingHandler;

        //构造函数
        public FireAlarmManager(FireAlarmPublisher publisher, FireAlarmSubscriber subscriber)
        {
            fireAlarmPublisher = publisher;
            fireAlarmSubscriber = subscriber;
        }

        public void Bind1()
        {
            fireAlarmPublisher.fireAlarmHandler += fireAlarmSubscriber.RespondToFire;
        }

        public void Bind2(TextBox logBox)
        {
            logFireHandler = (sender, e) => fireAlarmSubscriber.LogFireToTextBox(sender, e, logBox);
            fireHandlingHandler = async (sender, e) => await fireAlarmSubscriber.FireHandling(sender, e, logBox);

            fireAlarmPublisher.fireAlarmHandler += logFireHandler;
            fireAlarmPublisher.fireAlarmHandler += fireHandlingHandler;
        }

        public void Unbind1()
        {
            fireAlarmPublisher.fireAlarmHandler -= fireAlarmSubscriber.RespondToFire;
        }

        public void Unbind2(TextBox logBox)
        {
            fireAlarmPublisher.fireAlarmHandler -= logFireHandler;
            fireAlarmPublisher.fireAlarmHandler -= fireHandlingHandler;
        }
    }
}
