// 配列の最大値
// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__max
// 配列 A の要素数 N と配列 A の各要素である整数 A_1, A_2, ..., A_N が与えられるので、配列 A の要素の最大値 max を求めてください。

using System;

class Paiza
{
  static void Main()
  {
    int N = int.Parse(Console.ReadLine());

    int max = 0;

    for (int i = 0; i < N; i++)
    {
      int num = int.Parse(Console.ReadLine());

      if (max < num)
      {
        max = num;
      }
    }

    Console.WriteLine(max);
  }
}

// ---------------------------------------------

using System;

class Program
{
  static void Main()
  {
    // 入力を取得
    int n = int.Parse(Console.ReadLine());

    // 数列を格納する配列を作成
    int[] a = new int[n];
    for (int i = 0; i < n; i++)
    {
      a[i] = int.Parse(Console.ReadLine());
    }

    // 最大値を求める
    int max = 0;
    foreach (int x in a)
    {
      if (max < x)
      {
        max = x;
      }
      // C#では Math.Max を使うこともできます
      // max = Math.Max(max, x);
    }

    // 結果を出力
    Console.WriteLine(max);
  }
}