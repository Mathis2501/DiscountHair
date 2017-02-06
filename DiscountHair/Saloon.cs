using System;
using System.Threading;

namespace DiscountHair
{
    public class Saloon
    {
        public int threadId;
        private object lockThis = new object();
        Random _random = new Random();
        
        public void CutHair()
        {
            Chair myChair;
            lock (lockThis)
            {
                 myChair = new Chair(threadId);
            }
            

            for (int i = 0; i < 10;)
            {
                if (Monitor.TryEnter(myChair.scissorL, _random.Next(100, 600)))
                {
                    if (Monitor.TryEnter(myChair.scissorR, _random.Next(100, 600)))
                    {
                        i++;
                        Thread.Sleep(_random.Next(100, 600));
                        Monitor.Exit(myChair.scissorR);
                    }
                    Monitor.Exit(myChair.scissorL);
                }
                Thread.Sleep(_random.Next(100, 600));
            }
            Console.WriteLine(Thread.CurrentThread.Name + "has finished");
        }
    }
}
