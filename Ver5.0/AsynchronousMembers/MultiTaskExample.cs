using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousMembers
{
    public static class MultiTaskExample
    {
        public static void TestMultiTaskWithSemaphoreSlim()
        {
            using (SemaphoreSlim concurrencySemaphore = new SemaphoreSlim(3))
            {
                List<Task> tasks = new List<Task>();
                for (int i = 0; i < 10; i++)
                {
                    concurrencySemaphore.Wait();

                    int taskId = i;
                    // Do not use Task.Factory.StartNew(Action).
                    var t = Task.Run(async () =>
                    {
                        try
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                await Task.Delay(50);
                                Console.WriteLine($"Task {taskId}: Count {j}");
                            }
                        }
                        finally
                        {
                            concurrencySemaphore.Release();
                        }
                        Console.WriteLine($"Task {taskId}: finished");
                    });
                    Console.WriteLine(t.IsCompleted);
                    tasks.Add(t);
                }
                Task.WaitAll(tasks.ToArray());
            }
        }
    }
}
