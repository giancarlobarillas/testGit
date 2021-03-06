using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;

namespace WebJob1
{
    public class Functions
    {
        // This function will get triggered/executed when a new message is written 
        // on an Azure Queue called queue.
        public static void ProcessQueueMessage([QueueTrigger("queue")] string message, TextWriter log)
        {
            log.WriteLine(message);
            log.WriteLine("Commit1");
            log.WriteLine("Commit2");
            testMethod();
        }

        public static void testMethod()
        {
            Console.WriteLine("Commit3");
        }
    }
}
