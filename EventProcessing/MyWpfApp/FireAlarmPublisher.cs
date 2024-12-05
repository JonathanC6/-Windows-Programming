using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWpfApp
{
    public delegate void FireAlarmHandler(object sender, FireAlarmEventArgs e);

    //火警事件触发者
    public class FireAlarmPublisher
    {
        public event FireAlarmHandler fireAlarmHandler;

        //触发火警事件的方法
        public void btnTrigger(string location)
        {
            fireAlarmHandler?.Invoke(this, new FireAlarmEventArgs(location, DateTime.Now));
        }
    }
}
