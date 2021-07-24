using System;

namespace Email_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Email em1 = new Email("Person1", "Person2");
            Console.WriteLine(em1.Show_Info());
        }
    }
}
