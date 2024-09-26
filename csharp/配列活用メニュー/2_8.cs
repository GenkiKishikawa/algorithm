// 全ての要素を用いた処理 
// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__reduce
// 配列 A の要素数 N と配列 A の各要素 A_1, A_2, ..., A_N が与えられるので、A の要素の全てのペアについてのかけ算の結果を出力してください。

using System;
using System.Linq;

class Program
{
  static void Main()
  {
    int[] a = Enumerable.Range(0, int.Parse(Console.ReadLine()))
                        .Select(_ => int.Parse(Console.ReadLine()))
                        .ToArray();
    for (int i = 1; i < a.Length; i++)
    {
      for (int j = 0; j < i; j++)
      {
        Console.WriteLine(a[i] * a[j]);
      }
    }
  }
}