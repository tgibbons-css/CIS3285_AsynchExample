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

            // This first examples are from https://www.tutorialsteacher.com/articles/asynchronous-programming-with-async-await-task-csharp
            SyncClass mySyncClass = new SyncClass();
            mySyncClass.RunThings();

            //AsyncClass myAsyncClass = new AsyncClass();
            //myAsyncClass.RunThings();

            AsyncReturnClass myAsyncReturn = new AsyncReturnClass();
            // === RunThingsAsync returns a future value which must be awaited
            //int value = await myAsyncReturn.RunThingsAsync();
            // === RunThingsTask starts up a task and waits for it and returns a int
            //int value =  myAsyncReturn.RunThingsTask();
            //Console.WriteLine("Value returns = "+value);

            // This is from Microsoft's tutorial -- https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/
            //BreakfastSync myBreakfast = new BreakfastSync();
            //myBreakfast.MakeBreakfast();

            //BreakfastAsync myBreakfast = new BreakfastAsync();
            //myBreakfast.MakeBreakfastAsync();

            Console.WriteLine("Done with Samples");
            Console.ReadLine();         // keep screen up
        }
    }
}
