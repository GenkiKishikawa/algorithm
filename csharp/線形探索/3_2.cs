// 奇数の探索
// https://paiza.jp/works/mondai/sequence_search_problems/sequence_search_problems_search_condition_step1
// 整数 n と、数列 a_1, ... , a_n が与えられます。
// 数列を先頭から順に見たときに、最後に現れる奇数が何番目にあるかを求めてください。最初の要素 (a_1) を 1 番目とします。
// なお、与えられる数列には必ず奇数が含まれていることが保証されています。

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

    for (int i = n - 1; i >= 0; i--)
    {
      if (nums[i] % 2 == 1)
      {
        Console.WriteLine(i + 1);
        break;
      }
    }
  }
}