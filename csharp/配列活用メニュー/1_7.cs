// 要素の種類数
// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__kind
// 配列 A の要素数 N と配列 A の各要素 A_1, A_2, ..., A_N が与えられるので、配列 A には何種類の値が含まれているかを求めてください。

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

    int ans = A.Distinct().ToArray().Length;

    Console.WriteLine(ans);
  }
}

// -------------------------------------------------------------------

using System;
using System.Linq;

class Program
{
  static void Main()
  {
    int i = Enumerable.Range(0, int.Parse(Console.ReadLine()))
                      .Select(_ => int.Parse(Console.ReadLine()))
                      .Distinct()
                      .Count();
    Console.WriteLine(i);
  }
}