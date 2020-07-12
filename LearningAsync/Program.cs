using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearningAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Computing...");
            Download();
            Console.ReadLine();
        }
        static void Download()
        {
            //Inline anonymous function
            //function embedded in Task.Run
            //Everything in the braces is a function w/o name
            //The task is like a helper; it is resting as readline operates

            Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Data assimilated");
            });
        }
    }
}
