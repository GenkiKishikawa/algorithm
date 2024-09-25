// 配列の最小値
// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__min
// 配列 A の要素数 N と配列 A の各要素である整数 A_1, A_2, ..., A_N が与えられるので、配列 A の要素の最小値 min を求めてください。

using System;

class Paiza
{
  static void Main()
  {
    int N = int.Parse(Console.ReadLine());
    int[] A = new int[N];

    for (int i = 0; i < N; i++)
    {
      A[i] = int.Parse(Console.ReadLine());
    }

    int min = 100;
    for (int i = 0; i < N; i++)
    {
      if (min > A[i])
      {
        min = A[i];
      }
    }

    Console.WriteLine(min);
  }
}