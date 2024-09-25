// 指定の要素のカウント
// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__count
// 配列 A の要素数 N と整数 K, 配列 A の各要素 A_1, A_2, ..., A_N が与えられるので、
// 配列 A に K がいくつ含まれるか数えてください。

using System;

class Paiza
{
  static void Main()
  {
    string[] inputs = Console.ReadLine().Split(' ');
    int N = int.Parse(inputs[0]);
    int K = int.Parse(inputs[1]);

    int count = 0;

    for (int i = 0; i < N; i++)
    {
      int elem = int.Parse(Console.ReadLine());
      if (elem == K)
      {
        count++;
      }
    }

    Console.WriteLine(count);
  }
}