using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpAssignment2
{
    class AsyncAssignment2
    {

        public static void taskOne() {
            Task.Delay(5000).Wait();
        }
        public static void taskTwo()
        {
            Task.Delay(2000).Wait();
        }
        public static void taskThree()
        {
            Task.Delay(15000).Wait();
        }
        public static void taskFour()
        {
            Task.Delay(7000).Wait();
        }
        public static async Task<int> asynctaskOne() {
            await Task.Delay(5000);
            return await Task<int>.Factory.StartNew(() => 1);           
        }

        public static async Task<int> asynctaskTwo()
        {
            await Task.Delay(2000);
            var val = await Task<int>.Factory.StartNew(() => 2);
            return val;
        }
        public static async Task<int> asynctaskThree()
        {
            await Task .Delay(15000);
            return await Task<int>.Factory.StartNew(() => 3);
        }
        public static async Task<int> asynctaskFour()
        {
            await Task.Delay(7000);
            return await Task<int>.Factory.StartNew(() => 4);
        }


        
    }
}
