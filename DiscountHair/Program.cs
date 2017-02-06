using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DiscountHair
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {
            for (int threadId = 0; threadId < 6; threadId++)
            {
                CreateThread(threadId);
            }
        }

        private void CreateThread(int threadId)
        {
            Saloon saloon = new Saloon();
            saloon.threadId = threadId;
            
            

            Thread Hairdresser = new Thread(saloon.CutHair);

            Hairdresser.Name = threadId.ToString();
            Hairdresser.Start();
        }
    }
}