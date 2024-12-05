using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWpfApp
{
    //火警事件参数类
    public class FireAlarmEventArgs : EventArgs
    {
        public string Location { get; set; }
        public DateTime TriggerTime { get; set; }

        public FireAlarmEventArgs(string location, DateTime triggerTime)
        {
            Location = location;
            TriggerTime = triggerTime;
        }
    }
}
