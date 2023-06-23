using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    public static class T02_SharedResources
    {
        /* how to make HelloWorld() run only once?
         * it is being called by both main thread and worker thread
         * 
         * we can't have a static variable to keep track of the execution
         * because the context switch would be fast, and there is no way to 
         * prevent the threads from printing twice before the variable is set
         * 
         * the correct way is to create a lock for the variable
         */

        public static bool isCompleted = false;
        static readonly object codeLock = new object();

        public static void Run()
        {
            var thread = new Thread(HelloWorld); 
            thread.Start();

            // main thread
            HelloWorld();
        }
        /* This approach will not work
         * Both threads can access the code simultaneously
         * There is no guarantee that it will only print once.
         */
        public static void HelloWorld()
        {
            if(!isCompleted)
            {
                isCompleted = true;
                Console.WriteLine("Hello world should print only once");
            }            
        }
        /* The correct way is to lock the code,
         * so that only one thread at a time has
         * access to the code.
         */
        public static void HelloWorldWithLock()
        {
            lock(codeLock)
            {
                if (!isCompleted)
                {
                    isCompleted = true;
                    Console.WriteLine("Hello world should print only once");
                }
            }
        }
    }
}
