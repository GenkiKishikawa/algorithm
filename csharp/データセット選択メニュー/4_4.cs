// 重複の判定 2
// https://paiza.jp/works/mondai/data_structure/data_structure__set_step4
// N 個の要素からなる数列 A が与えられます。2 ≦ i ≦ N の各 i に対して、A_i と同じ値が A_1 から A_{i-1} の間にあるかどうかを判定してください。
// ただし、A_i は非常に大きくなることがあります。

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza
{
  static void Main()
  {
    int N = int.Parse(Console.ReadLine());

    List<int> A = Console.ReadLine()
                          .Split(' ')
                          .Select(x => int.Parse(x))
                          .ToList();

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