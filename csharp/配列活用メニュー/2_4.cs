// 末尾への要素の追加
// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__push_back
// 配列 A と追加する要素 B が与えられるので、B を A の末尾に追加したのち、A の全ての要素を出力してください。

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

    int B = int.Parse(Console.ReadLine());

    Array.Resize(ref A, N + 1);
    A[N] = B;

    foreach (int a in A)
    {
      Console.WriteLine(a);
    }
  }
}