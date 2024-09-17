// 【第 k 要素の探索】k番目に大きな値
// https://paiza.jp/works/mondai/sequence_search_problems/sequence_search_problems_kthmax_boss
// 整数 n と、数列 a_1, ... , a_n と、整数 k が与えられます。
// 数列に含まれる数のうち、k 番目に大きいものを出力してください。

using System;

class paiza
{
    static void Main()
    {
        // 整数 n
        int n = int.Parse(Console.ReadLine());

        // 数列 a_1, ... , a_n 
        string[] inputs = Console.ReadLine().Split(' ');
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(inputs[i]);
        }

        // 整数 k 
        int k = int.Parse(Console.ReadLine());

        // k番目に大きいものを線形探索
        int maximum = 1000000001;
        for (int i = 0; i < k; i++)
        {
            int nextMaximum = -1000000001;
            for (int j = 0; j < n; j++)
            {
                if (a[j] < maximum)
                {
                    nextMaximum = Math.Max(nextMaximum, a[j]);
                }
            }
            maximum = nextMaximum;
        }

        Console.WriteLine(maximum);
    }
}