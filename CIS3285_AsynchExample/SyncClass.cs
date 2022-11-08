using System;
using System.Collections.Generic;
using System.Text;

namespace CIS3285_AsynchExample
{
    class SyncClass
    {

        public void RunThings()
        {
            LongProcess();

            ShortProcess();
        }

        private void LongProcess()
        {
            Console.WriteLine("LongProcess Started");

            //some code that takes long execution time 
            System.Threading.Thread.Sleep(4000); // hold execution for 4 seconds

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
