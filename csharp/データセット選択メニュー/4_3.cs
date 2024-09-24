// 重複の判定 1
// https://paiza.jp/works/mondai/data_structure/data_structure__set_step3
// N 個の要素からなる数列 A が与えられます。
// 2 ≦ i ≦ N の各 i に対して、A_i と同じ値が A_1 から A_{i-1} の間にあるかどうかを判定してください。

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
  static void Main()
  {
    // N: 数列の要素数を取得
    int N = int.Parse(Console.ReadLine());

    // 数列 A を入力
    List<int> A = Console.ReadLine()
                         .Split(' ')
                         .Select(int.Parse)
                         .ToList();

    // 最初の要素 A[0] をセットに追加
    HashSet<int> memo = new HashSet<int> { A[0] };

    // 2番目の要素から N番目の要素までを処理
    for (int i = 1; i < N; i++)
    {
      if (memo.Contains(A[i]))
      {
        // A[i] が memo に既に存在する場合
        Console.WriteLine("Yes");
      }
      else
      {
        // A[i] を memo に追加し "No" を出力
        memo.Add(A[i]);
        Console.WriteLine("No");
      }
    }
  }
}


// -------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
  static void Main()
  {
    Console.ReadLine();
    List<int> vs = Console.ReadLine()
                          .Split(' ')
                          .Select(x => int.Parse(x))
                          .ToList();

    foreach (int i in Enumerable.Range(1, vs.Count() - 1))
    {
      bool isFind = vs.Take(i)
                      .Any(x => x == vs[i]);

      Console.WriteLine(isFind ? "Yes" : "No");
    }
  }
}
