using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class _BubbleSort
    {
        async public static Task Run()
        {
            try
            {
                int[] data = new int[10];
                Random rdm = new Random();
                for (int i = 0; i < 10; i++)
                {
                    int j = rdm.Next(10, 99);
                    data.SetValue(j, i);
                }
                //var result1 = await BubbleSort(data);
                //Console.WriteLine(JsonConvert.SerializeObject(result1));
                //var result2 = await recursiveBubble(data, data.Length);
                //Console.WriteLine(JsonConvert.SerializeObject(result2));
                var result3 = await selectinoSort(data);
                Console.WriteLine(JsonConvert.SerializeObject(result3));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }
        async public static Task<int[]> BubbleSort(int[] data)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = data.Length - 1; j > i; j--)
                {
                    if (data[j] > data[j - 1])
                    {
                        data[j] = data[j] + data[j - 1];
                        data[j - 1] = data[j] - data[j - 1];
                        data[j] = data[j] - data[j - 1];
                    }
                }
            }
            return data;
        }

        async public static Task<int[]> recursiveBubble(int[] data, int i)
        {
            if (i == 0)
            {
                return data;
            }
            else
            {
                for (int j = 1; j < i;)
                {
                    if (data[j] > data[j - 1])
                    {
                        data[j] = data[j] + data[j - 1];
                        data[j - 1] = data[j] - data[j - 1];
                        data[j] = data[j] - data[j - 1];
                    }
                    j++;
                }
                i--;
                await recursiveBubble(data, i);
            }
            return data;
        }

        async public static Task<int[]> selectinoSort(int[] data)
        {
            try
            {
                var length = data.Length;
                for (int i = 0; i < length; i++)
                {
                    int minIndex = i;
                    for (int j = i + 1; j < length; j++)
                    {
                        if (data[j] > data[minIndex])
                        {
                            minIndex = j;
                        }
                    }
                    Console.WriteLine(data[i]);
                    Console.WriteLine(data[minIndex]);
                    //data[i] = data[i] + data[minIndex];
                    //data[minIndex] = data[i] - data[minIndex];
                    //data[i] = data[i] - data[minIndex];
                    var temp = data[i];
                    data[i] = data[minIndex];
                    data[minIndex] = temp;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return data;
        }
    }
}
