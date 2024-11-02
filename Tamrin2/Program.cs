
using System;

class Program
{
    static void Main()
    {
        Console.Write("Adad aval ra vared kon (n): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Adad dovom ra vared kon (m): ");
        int m = int.Parse(Console.ReadLine());

        for (int i = n; i <= m; i++)
        {
            if (IsMirror(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool IsMirror(int number)
    {
        string str = number.ToString();
        int len = str.Length;

        for (int i = 0; i < len / 2; i++)
        {
            if (str[i] != str[len - i - 1])
            {
                return false;
            }
        }

        return true;
    }
}
