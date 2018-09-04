using System;
using System.Threading.Tasks;

namespace ConsolePractice
{
    public class EnumTest
    {
        async public static Task Run()
        {
            try
            {
                var result = GetDisplay();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private static object GetDisplay()
        {
            var a = BoringLevel.lg;
            var s = GetEnumDescriptionn<BoringLevel>(a);
            return s.ToString();
        }

        private static object GetEnumDescriptionn<TEnum>(object value)
        {
            var enumType = typeof(TEnum);
            if (!enumType.IsEnum)
            {
                throw new ArgumentException($"enumItem req{value.ToString()}uires a Enum ");
            }
            var name = Enum.GetName(enumType, Convert.ToInt32(value));
            if (name == null)
                return "";
            var objs = enumType.GetField(name).GetCustomAttributes(typeof(DisplayAttribute), false);
            var attr = objs[0] as DisplayAttribute;
            if (objs.Length == 0)
            {
                return string.Empty;
            }
            else
            {
                return attr != null ? attr.DisplayString : string.Empty;
            }
        }
    }
}
