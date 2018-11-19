using System;
using System.Threading.Tasks;

namespace ConsolePractice
{
    public class IsLeapYear
    {
        async public static Task Run()
        {
            try
            {
                Console.WriteLine("请输入年份");
                string str = Console.ReadLine();
                switch (str)
                {
                    case "Y":
                        break;
                    default:
                        int year = Convert.ToInt32(str);
                        var leep = (year % 400 == 0 || year % 4 == 0 && year % 100 != 0);
                        Console.WriteLine(string.Format(leep ? "{0}年{1}{3}。" : "{0}年{2}{3},{4}。", year, "是", "不是", "闰年", "是平年"));
                        Console.WriteLine("请继续输入年份运算或者按Y退出");
                        str = Console.ReadLine().ToUpper();
                        if (str == "Y")
                        {
                            goto case "Y";
                        }
                        goto default;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey(true);
                throw;
            }
        }
        public string Money()
        {
            var ret = string.Empty;
            
            return ret;
        }
    }
}
