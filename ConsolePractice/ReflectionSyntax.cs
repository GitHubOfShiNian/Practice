using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace ConsolePractice
{
    public class ReflectionSyntax
    {
        public static void Excute()
        {
            Type type = GetType("Syntax.Kiba");
            Kiba kiba = (Kiba)Activator.CreateInstance(type);
            Type type2 = GetType2("Syntax.Kiba");
            Kiba kiba2 = (Kiba)Activator.CreateInstance(type2);

        }
        public static Type GetType(string fullName)
        {
            Assembly assembly = Assembly.Load("Syntax");
            Type type = assembly.GetType(fullName, true, false);
            return type;
        }
        public static Type GetType2(string fullName)
        {
            Type t = Type.GetType(fullName);
            return t;
        }

    }
    public class Kiba
    {
        public void PrintName()
        {
            Console.WriteLine("Kiba518");
        }
    }
}
