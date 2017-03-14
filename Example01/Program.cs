using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Status response = Status.error;

            switch (response)
            {
                case Status.error:
                    //你要寫的程式
                    Console.WriteLine("狀態成功");
                    Console.WriteLine((int)response);
                    break;

                case Status.success:
                    //你要寫的程式
                    Console.WriteLine("狀態錯誤");
                    Console.WriteLine((int)response);
                    break;

                default:
                    //你要寫的程式
                    Console.WriteLine("狀態不明");
                    Console.WriteLine(response);
                    break;
            }
        }
    }
}