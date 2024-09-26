// 配列の順序の反転
// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__reverse
// 配列 A の要素数 N と配列 A の各要素 A_1, A_2, ..., A_N が与えられるので、A の要素の順序を逆にした配列 B を作成し、出力してください。

using System;
using System.Collections.Generic;
using System.Linq;

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

    Array.Reverse(A);

    foreach (int a in A)
    {
      Console.WriteLine(a);
    }
  }
}