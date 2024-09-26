// 指定要素の削除
// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__delete
// 配列 A とその要素数 N と削除する要素の番号 n が与えられるので、A から A_n を削除し、A を要素数 N - 1 の配列とした後の A の各要素を出力してください。

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza
{
  static void Main()
  {
    int N = int.Parse(Console.ReadLine());

    List<int> A = Enumerable.Range(0, N)
                            .Select(_ => int.Parse(Console.ReadLine()))
                            .ToList();

    int n = int.Parse(Console.ReadLine());

    A.RemoveAt(n - 1);

    foreach (int a in A)
    {
      Console.WriteLine(a);
    }
  }
}

// ----------------------------------------

using System;

class Program
{
  static void Main()
  {
    // 入力を取得
    int N = int.Parse(Console.ReadLine());

    // 配列 a を作成
    int[] a = new int[N];
    for (int i = 0; i < N; i++)
    {
      a[i] = int.Parse(Console.ReadLine());
    }

    // n の入力を取得
    int n = int.Parse(Console.ReadLine());

    // ans 配列を作成 (サイズ N-1)
    int[] ans = new int[N - 1];

    // 配列 ans に a から n 番目の要素を除いてコピー
    for (int i = 0; i < N; i++)
    {
      if (i < n - 1)
      {
        ans[i] = a[i];
      }
      else if (i > n - 1)
      {
        ans[i - 1] = a[i];
      }
    }

    // 結果を出力
    foreach (int x in ans)
    {
      Console.WriteLine(x);
    }
  }
}
