using System;
using System.Diagnostics;

namespace dotnet_exercises.tricky
{
	public class t1
	{
		public async Task Execute() {


            async Task DoSomething()
            {
                Thread.Sleep(1000);
                await Task.Delay(1000);
            }

            var watch = Stopwatch.StartNew();
            var t1 = DoSomething();
            var t2 = DoSomething();
            await Task.WhenAll(t1, t2);

            Console.WriteLine($"It took {watch.ElapsedMilliseconds}");
            Console.ReadKey();
        }
	}
}

