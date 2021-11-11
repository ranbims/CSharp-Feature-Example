using System;
using System.Threading.Tasks;

namespace AsynchronousMembers
{
    public class TaskIdExample
    {
        // Test Task static API.
        public static async Task testTaskApiAsync()
        {
            Console.WriteLine(Task.CurrentId);
            Task task1 = new Task(async () =>
            {
                Console.WriteLine(Task.CurrentId);
                for (int i = 0; i < 10; i++)
                {
                    await Task.Delay(100);
                }
            });

            Task task2 = new Task(async () =>
            {
                Console.WriteLine(Task.CurrentId);
                for (int i = 0; i < 1000; i++)
                {
                    await Task.Delay(100);
                }
            });

            task1.Start();
            task2.Start();

            for (int i = 0; i < 2000; i++)
            {
                Task task = new Task(() => { });
                task.Start();
                await task;
                Console.WriteLine(Task.CurrentId);
                await Task.Delay(100);
            }
        }
    }
}
