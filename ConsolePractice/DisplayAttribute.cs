using System;

namespace ConsolePractice
{
    [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = true)]
    public sealed class DisplayAttribute : Attribute
    {
        public DisplayAttribute(string displayString)
        {
            DisplayString = displayString;
        }
        public string DisplayString { get; }
    }
}