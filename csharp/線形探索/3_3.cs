// 条件付き最小値
// https://paiza.jp/works/mondai/sequence_search_problems/sequence_search_problems_search_condition_step2
// 整数 n と、数列 a_1, ... , a_n と、整数 k が与えられます。
// 数列に含まれる値で、k 以上であるもののうち、値が最小のものを出力してください。
// なお、k 以上である値が必ず数列に含まれていることが保証されています。

using System;

class Paiza
{
  static void Main()
  {
    int n = int.Parse(Console.ReadLine());

    string[] inputs = Console.ReadLine().Split(' ');
    int[] nums = new int[n];
    for (int i = 0; i < n; i++)
    {
      nums[i] = int.Parse(inputs[i]);
    }

    int k = int.Parse(Console.ReadLine());

    int min = int.MaxValue;

    // ループで線形探索
    for (int i = 0; i < n; i++)
    {
      if (k <= nums[i] && min > nums[i])
      {
        min = nums[i];
      }
    }
    Console.WriteLine(min);
  }
}

// ----------------------------------------------------------

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

        int k = int.Parse(Console.ReadLine());

        int answer = 101;
        for (int i = 0; i < n; i++)
        {
            if (a[i] >= k)
            {
                answer = Math.Min(answer, a[i]);
            }
        }

        Console.WriteLine(answer);
    }
}