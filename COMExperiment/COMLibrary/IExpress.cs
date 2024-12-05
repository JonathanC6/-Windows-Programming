using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace COMLibrary
{
    [Guid("9FA418CC-427B-473B-87C3-890B02FFC49E")]
    [ComVisible(true)]
    public interface IExpress
    {
        string minus(int a, int b);
        string divide(int a, int b);
    }
}
