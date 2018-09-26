using System;

namespace ConsolePractice
{
    public abstract class Base
    {
        public void Write()
        {
            Console.WriteLine("This is Base.Write");
        }
        public void One()
        {

        }
        delegate void two();
        public delegate void SendShortMessage(SendShortMessageRequest request);
        public static event SendShortMessage sendShortMessage;

        public static void SendATEShortMessage(SendShortMessageRequest request)
        {
            Console.WriteLine(request.FromAddress + "到港日期");
        }
        public static void SendTCCShortMessage(SendShortMessageRequest request)
        {
            Console.WriteLine(request.FromAddress + "可能是赋税时间吧");
        }
        public static void SendATDShortMessage(SendShortMessageRequest request)
        {
            Console.WriteLine(request.FromAddress + "这个真不知道了");
        }
        public static void HuotuShortMessage()
        {
            sendShortMessage += new SendShortMessage(SendATEShortMessage);
        }

        async public static Task Run()
        {
            sendShortMessage += new SendShortMessage(SendATEShortMessage);
        }
    }
}
