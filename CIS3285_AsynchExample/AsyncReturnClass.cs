using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CIS3285_AsynchExample
{
    class AsyncReturnClass
    {
        // This method returns a Task<int> which is still waiting for a value
        public async Task<int> RunThingsAsync()
        {
            // Run the long process in a task
            Task<int> result = LongProcess();
            // wait unit task finishes to set val
            int value = await result;

            ShortProcess();

            return value;
        }

        // This task returns a int since it waits for the value
        public int RunThingsTask()
        {
            var task = Task.Run(() => LongProcess());
            task.Wait();
            int value =  task.Result;

            ShortProcess();

            return value;
        }

        // Make this async
        private async Task<int> LongProcess()
        {
            Console.WriteLine("LongProcess Started");

            //some code that takes long execution time 
            //System.Threading.Thread.Sleep(4000); // hold execution for 4 seconds
            await Task.Delay(4000);

            Console.WriteLine("LongProcess Completed");
            return 42;
        }

        private void ShortProcess()
        {
            Console.WriteLine("ShortProcess Started");

            //do something here

            Console.WriteLine("ShortProcess Completed");
        }

    }
}
