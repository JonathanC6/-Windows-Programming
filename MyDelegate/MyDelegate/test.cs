using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegate
{
    public class test
    {
        private delegate void MyDelegate();
        private MyDelegate myDelegate;
        private void SayHelloWorld()
        {
            Console.WriteLine("Hello world!");
        }

        public void Main()
        {
            myDelegate = SayHelloWorld;
            myDelegate();
        }
    }
}
