using System;
using System.Threading.Tasks;

namespace ConsolePractice
{
    public class Delegate
    {
        public class SendShortMessageRequest
        {
            public string Mobile { get; set; }
            public string FromAddress { get; set; }
            public string ToAddress { get; set; }
            public string MsgTime { get; set; }
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
            sendShortMessage(new SendShortMessageRequest { FromAddress= "请问晚饭吃啥：" });
            Console.ReadKey();
        }
    }
}
