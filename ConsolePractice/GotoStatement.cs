using System;

namespace ConsolePractice
{
    public class GoTOStatement
    {
        static void DoStatement(string[] args)
        {
            string s;
            do
            {
                s = Console.ReadLine();
                Console.WriteLine(s);
            } while (!string.IsNullOrEmpty(s));
        }
        //static void GoToStatement(string[] args)
        //{
        //    int i = 0;
        //    goto check;
        //    asdfa:
        //    Console.WriteLine(args[i++]);
        //    check:
        //    if (i < args.Length)
        //    {
        //        goto asdfa;
        //    }
        //}
    }
}
