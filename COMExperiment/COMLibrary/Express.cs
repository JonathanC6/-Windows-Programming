using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace COMLibrary
{
    [Guid("A473A7F1-0E94-4293-AD8A-B02592A8377B")]
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    [Description("计算方法")]
    public class Express : IExpress
    {
        public string minus(int a, int b)
        {
            int result = a - b;
            return $"{result} = {a} - {b}";
        }

        public string divide(int a, int b)
        {
            if (b == 0)
            {
                return "除零错误";
            }
            int result = a / b;
            return $"{result} = {a} / {b}";
        }
    }
}
