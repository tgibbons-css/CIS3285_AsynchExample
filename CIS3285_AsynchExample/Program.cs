using System;
using System.Threading.Tasks;

namespace CIS3285_AsynchExample
{
    class Program
    {
        //static async Task Main(string[] args)

        static void Main(string[] args)
        {
            Console.WriteLine("Starting Samples");

            //SyncClass mySyncClass = new SyncClass();
            //mySyncClass.RunThings();

            //AsyncClass myAsyncClass = new AsyncClass();
            //myAsyncClass.RunThings();

            AsyncReturnClass myAsyncReturn = new AsyncReturnClass();
            // === RunThingsAsync returns a future value which must be awaited
            //int val = await myAsyncReturn.RunThingsAsync();
            // === RunThingsTask starts up a task and waits for it and returns a int
            int val =  myAsyncReturn.RunThingsTask();

            Console.WriteLine("Value returns = "+val);

            Console.WriteLine("Done with Samples");
            Console.ReadLine();         // keep screen up
        }
    }
}
