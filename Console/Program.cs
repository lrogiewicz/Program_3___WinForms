using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Timers;

namespace ConsoleClient
{
    class Program
    {
        static Dictionary<Timer, Counter> counterList = new Dictionary<Timer, Counter>();

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj typ licznika: ");
            CounterType counterType = CounterTypeProvider.GetCounterType(Console.ReadLine());
            Console.WriteLine("Podaj ilość liczników: ");
            int countersNumber = Int32.Parse(Console.ReadLine());
            for (int counterNumberIndex = 1; counterNumberIndex <= countersNumber; counterNumberIndex++)
            {
                Console.WriteLine("Konfigurujemy licznik nr " + counterNumberIndex);
                Console.WriteLine("Podaj ilośćpowtórzeń: ");
                int repetitionsNumber = RepetitionsNumberProvider.GetRepetitionsNumber(counterType, Console.ReadLine());
                Console.WriteLine("Podaj interwał: ");
                int interval = IntervalProvider.GetInterval(counterType, Console.ReadLine());
                Counter counter = new Counter(counterNumberIndex, repetitionsNumber, interval);
                Timer timer = new Timer(interval);
                timer.Elapsed += Timer_Elapsed;
                counterList.Add(timer, counter);
            }

            Console.WriteLine("Wciśnij dowolny klawisz aby uruchomić liczniki. ");
            Console.ReadLine();

            foreach (var timer in counterList)
            {
                timer.Key.Start();
            }

            wait();
            Console.ReadLine();
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Timer timer = sender as Timer;
            Counter counter1 = counterList[timer];
            counter1.Tick += 1;
            Console.Clear();

            foreach (var counter in counterList)
            {
                Console.WriteLine($"Licznik {counter.Value.Index}: ilość powtórzeń: {counter.Value.RepetitionsNumber} interwał: {counter.Value.Interval}, stan odliczania: {counter.Value.Tick}");
            }
            if (counter1.Tick == counter1.RepetitionsNumber)
            {
                timer.Stop();
                
            }
        }

        static void wait()
        {
            while (true)
            {
                int countersNumberDone=0;

                foreach (var counter in counterList)
                {
                    if ((counter.Value.Tick == counter.Value.RepetitionsNumber))
                    {
                        countersNumberDone += 1;
                    }
                }
                if (countersNumberDone == counterList.Count)
                {
                    break;
                }
            }
        }
    }
}
