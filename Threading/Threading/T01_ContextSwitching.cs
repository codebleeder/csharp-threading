using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    public static class T01_ContextSwitching
    {
        /*
         * worker-thread and main-thread will run randomly
         */
        public static void Run()
        {
            // worker thread
            var thread = new Thread(WriteUsingNewThread);
            thread.Name = "worker1"; // you can name threads
            thread.Start();

            // main thread
            for (var i = 0; i < 100; i++)
            {
                Console.WriteLine($"A{i}");
            }
        }

        private static void WriteUsingNewThread()
        {
            for(var i = 0; i < 100; i++) 
            {
                Console.WriteLine($"Z{i}");
            }
        }
    }
}
