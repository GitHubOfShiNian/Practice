using System;

namespace ConsolePractice
{
    class Program
    {
        public class SendShortMessageRequest
        {
            public string Mobile { get; set; }
            public string 汉字的 { get; set; }
            public string ToAddress { get; set; }
            public string MsgTime { get; set; }
        }

        static void Main()
        {
            var s = new SendShortMessageRequest { Mobile = "汉字的" };
            Console.WriteLine(nameof(s.Mobile));
            Console.ReadKey();
        }
        //static void Main(string[] args) => Delegate.Run().Wait();
    }
}
