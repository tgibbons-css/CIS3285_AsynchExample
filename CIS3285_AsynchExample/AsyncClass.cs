using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CIS3285_AsynchExample
{
    class AsyncClass
    {
        public void RunThings()
        {
            LongProcess();

            ShortProcess();
        }

        // Make this async
        private async void LongProcess()
        {
            Console.WriteLine("LongProcess Started");

            //some code that takes long execution time 
            //System.Threading.Thread.Sleep(4000); // hold execution for 4 seconds
            await Task.Delay(4000);

            Console.WriteLine("LongProcess Completed");
        }

        private void ShortProcess()
        {
            Console.WriteLine("ShortProcess Started");

            //do something here

            Console.WriteLine("ShortProcess Completed");
        }
    }

}
