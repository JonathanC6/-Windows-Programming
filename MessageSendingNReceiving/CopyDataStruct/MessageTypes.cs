using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CopyDataStruct
{
    //定义消息类型常量
    public static class MessageTypes
    {
        public const int WM_COPYDATA = 0x004A;
    }

    //定义传递消息的结构体
    [StructLayout(LayoutKind.Sequential)]
    public struct COPYDATASTRUCT
    {
        public IntPtr dwData;    //用户定义的数据
        public int cbData;       //数据大小
        public IntPtr lpData;    //指向数据的指针
    }
}
