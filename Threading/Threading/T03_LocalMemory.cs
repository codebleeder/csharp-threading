using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    public static class T03_LocalMemory
    {
        public static void Run()
        {
            // worker thread
            var thread = new Thread(PrintOneToThirty);
            thread.Start();

            // main thread
            PrintOneToThirty();
        }

        public static void PrintOneToThirty()
        {
            /* each thread - worker and main thread 
             * will have its own
             * copy of variable i stored in its 
             * stack
             */
            for(var i=1; i<31; ++i)
            {
                Console.WriteLine(i);
            }
        }
    }
}
