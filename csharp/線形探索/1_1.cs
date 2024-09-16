// 指定された値の個数
// https://paiza.jp/works/mondai/sequence_search_problems/sequence_search_problems_search_value_step0
// 整数 n と、数列 a_1, ... , a_n と、整数 k が与えられます。
// a_1, ... , a_n のうち k は何個あるかを求めてください。

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] inputs = Console.ReadLine().Split(' ');
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(inputs[i]);
        }

        int k = int.Parse(Console.ReadLine());

        int numOfK = 0;
        for (int i = 0; i < n; i++)
        {
            if (a[i] == k)
            {
                numOfK++;
            }
        }
        Console.WriteLine(numOfK);
    }
}