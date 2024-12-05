using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace MyWpfApp
{
    //火警事件响应者
    public class FireAlarmSubscriber
    {
        public void RespondToFire(object sender, FireAlarmEventArgs e)
        {
            MessageBox.Show($"{e.Location} 发生了火灾！ 报警时间: {e.TriggerTime}");
        }

        public void LogFireToTextBox(object sender, FireAlarmEventArgs e, TextBox logBox)
        {
            logBox.AppendText($"{e.Location} 发生了火灾！ 报警时间: {e.TriggerTime}\n");
        }

        public async Task FireHandling(object sender, FireAlarmEventArgs e, TextBox logBox)
        {
            //等待3秒
            await Task.Delay(3000);
            var dispatchTime = DateTime.Now;
            logBox.AppendText($"已派出消防员赶赴现场！ 出警时间: {dispatchTime}\n");
        }
    }
}
