#define PI

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

        //static void Main()
        //{
        //    using (var _context = new ConsolePracticeContext())
        //    {
        //        var company = new Company
        //        {
        //            Contact = "",
        //            ContactMoblie = "",
        //            Name = ""
        //        };
        //        _context.Company.Add(company);
        //        _context.SaveChanges();
        //    }
        //}
        //static void Main(string[] args) => IsLeapYear.Run().Wait();

        static void Main(string[] args)
        {
#if (!PI)
            Console.WriteLine("PI is defind");
#else
            Console.WriteLine("PI is defind");
#endif
            Console.ReadKey();
        }
    }
}
