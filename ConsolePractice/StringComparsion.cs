using System;
using System.Threading.Tasks;

namespace ConsolePractice
{
    public class StringComparsion
    {
        async public static Task Run()
        {
            try
            {
                var result = Comparsion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private static string Comparsion()
        {
            //Console.WriteLine("Equals".Equals("Equals", StringComparison.Ordinal));
            //Console.WriteLine("Equals".Equals("Equals", StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine("Equals".Equals("Equals", StringComparison.CurrentCulture));
            //Console.WriteLine("Equals".Equals("Equals", StringComparison.CurrentCultureIgnoreCase));
            //Console.WriteLine("Equals".Equals("Equals", StringComparison.InvariantCulture));
            //Console.WriteLine("Equals".Equals("Equals", StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine("Equals".StartsWith("eq", StringComparison.InvariantCulture));
            Console.WriteLine("Equals".StartsWith("eq", StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine("Equals".StartsWith("eq", StringComparison.CurrentCulture));
            Console.WriteLine("Equals".StartsWith("eq", StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine("Equals".StartsWith("eq", StringComparison.Ordinal));
            Console.WriteLine("Equals".StartsWith("eq", StringComparison.OrdinalIgnoreCase));
            Console.ReadKey(true);
            return string.Empty;
        }
    }
}
