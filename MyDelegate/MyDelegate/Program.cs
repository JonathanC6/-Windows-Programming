using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegate
{
    public class Program
    {
        //private delegate void MyDelegate();
        //private MyDelegate myDelegate;

        private Action myAction;
        private Func<int, int, int> myFunc;

        private void SayHelloWorld()
        {
            Console.WriteLine("Hello world!");
        }

        private int Add(int x, int y)
        {
            return x + y;
        }


        static void Main(string[] args)
        {
            Program program = new Program();

            program.myFunc = (a, b) => a + b;


            //program.myFunc = (x, y) => program.Add(x, y); 
            //program.myFunc = delegate (int x, int y)
            //{
            //    return program.Add(x, y);
            //};


            var result = program.myFunc(3,5);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
