// 2番目に大きな値
// https://paiza.jp/works/mondai/sequence_search_problems/sequence_search_problems_kthmax_step0
// 整数 n と、数列 a_1, ... , a_n が与えられます。
// 数列に含まれる数のうち、2 番目に大きいものを出力してください。

using System;

class Paiza
{
  static void Main()
  {
    // 整数 n
    int n = int.Parse(Console.ReadLine());

    // 数列 a_1, ... , a_n
    string[] inputs = Console.ReadLine().Split(' ');
    int[] nums = new int[n];
    for (int i = 0; i < n; i++)
    {
      nums[i] = int.Parse(inputs[i]);
    }

    // 線形探索で最大値を求める
    int max = nums[0];
    for (int i = 0; i < n; i++)
    {
      if (max <= nums[i])
      {
        max = nums[i];
      }
    }

    // 線形探索で2番目に大きい数値を求める
    int second_max = nums[0];
    for (int i = 0; i < n; i++)
    {
      if (second_max <= nums[i] && nums[i] != max)
      {
        second_max = nums[i];
      }
    }

    Console.WriteLine(second_max);
  }
}

// -----------------------------------------------------------

using System;

class paiza
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

        int maximum = 1000000001;
        for (int i = 0; i < 2; i++)
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