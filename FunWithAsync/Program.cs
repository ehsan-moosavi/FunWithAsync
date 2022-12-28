using System;
using System.Threading;
using System.Threading.Tasks;

namespace FunWithAsync
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           string answer =await DoWOrkAsync();
            Console.WriteLine(answer);
            Console.WriteLine();
            Console.WriteLine("Completed!!");
        }
        static async Task<string> DoWOrkAsync()
        {
            return await Task.Run(() => {
                Thread.Sleep(5000);
                return "Work Is Done!";
            });
        }
    }
}
