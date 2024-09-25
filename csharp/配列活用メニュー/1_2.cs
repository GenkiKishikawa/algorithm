// 全ての要素の和
// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__sum
// 配列 A の要素数 N と配列 A の各要素 A_1, A_2, ..., A_N が整数として与えられるので、配列 A の全ての要素の和を求めてください。

using System;

class Paiza
{
  static void Main()
  {
    int N = int.Parse(Console.ReadLine());

    int sum = 0;

    for (int i = 0; i < N; i++)
    {
      int num = int.Parse(Console.ReadLine());
      sum += num;
    }

    Console.WriteLine(sum);
  }
}