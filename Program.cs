using System;

namespace CsharpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator programmer = new Programmer();
            Creator youtuber = new Youtuber();
            
            Creator[] creators = new Creator[] {new Youtuber(), new Programmer(), new Youtuber()};
            
            foreach (var creator in creators)
            {
                Console.WriteLine(creator.GetType().Name);
                creator.Create();
                Console.WriteLine();
            }
            
        }
    }
}
