// 条件付き最大値
// https://paiza.jp/works/mondai/sequence_search_problems/sequence_search_problems_search_condition_step3
// 整数 n と、数列 a_1, ... , a_n と、整数 k が与えられます。
// 数列に含まれる値で、k 以下であるもののうち、値が最大のものを出力してください。
// なお、k 以下である値が必ず数列に含まれていることが保証されています。

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

    // ループで最大値を線形探索
    int max = -100;
    for (int i = 0; i < n; i++)
    {
      if (k >= nums[i] && max <= nums[i])
      {
        max = nums[i];
      }
    }
    Console.WriteLine(max);
  }
}