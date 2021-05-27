using System;
using System.Threading;
using System.Threading.Tasks;

namespace DiningPhilosophers
{
    class Program
    {
        static int philosophersNumber = 5;
        static Task[] philosophers;
        static SemaphoreSlim[] forks;
        static SemaphoreSlim waiter;

        static void Main(string[] args)
        {
            philosophers = new Task[philosophersNumber];
            forks = new SemaphoreSlim[philosophersNumber];
            waiter = new SemaphoreSlim(1);

            for (int i = 0; i < philosophersNumber; ++i)
            {
                philosophers[i] = GenerateNewPhilosopher(i);
                forks[i] = new SemaphoreSlim(1);
            }

            Task.WaitAll(philosophers);
            Console.WriteLine("Обед закончен.");
            Console.ReadLine();
        }

        private static Task GenerateNewPhilosopher(int philosopherIndex)
        {
            return Task.Run(() =>
            {

                for (int i = 0; i < 100; ++i)
                {
                    Console.WriteLine($"Философ {philosopherIndex}: Вызывает официанта");
                    waiter.Wait();
                    var f1 = GetChopstickIndex(philosopherIndex);
                    var f2 = GetChopstickIndex(philosopherIndex + 1);

                    Console.WriteLine($"Философ {philosopherIndex}: [1] {forks[f1].CurrentCount} [2] {forks[f2].CurrentCount}");
                    if (forks[f1].CurrentCount == 1 && forks[f2].CurrentCount == 1)
                    {
                        Console.WriteLine($"Философ {philosopherIndex}: Пытается получить вилки");
                        forks[f1].Wait();
                        forks[f2].Wait();
                    }
                    else
                    {
                        Console.WriteLine($"Философ {philosopherIndex}: Не удалось получить вилки");
                        i -= 1;
                        waiter.Release();
                        continue;
                    }
                    waiter.Release();

                    Console.WriteLine($"Философ {philosopherIndex}: Обедает");
                    Task.Delay(100);

                    forks[f1].Release();
                    forks[f2].Release();
                }
            });
        }

        private static int GetChopstickIndex(int index)
        {
            return index % philosophersNumber;
        }
    }
}
