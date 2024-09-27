// 内定
// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__offer
// 人事のあなたは、N 人の中から採用者を決定します。
// N 人のテストの点数はそれぞれ A_i (1 ≦ i ≦ N)です。
// テストの点数が K 点以上の人全員を採用したいのですが、得点の高い方から M 人に辞退されてしまいました。
// あなたの採用することのできる最大の人数を答えてください。採用できる人数が 0 人の場合もあることに気をつけてください。

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza
{
  static void Main()
  {
    string[] inputs = Console.ReadLine().Split();
    int N = int.Parse(inputs[0]);
    int K = int.Parse(inputs[1]);
    int M = int.Parse(inputs[2]);

    List<int> A = Enumerable.Range(0, N)
                            .Select(_ => int.Parse(Console.ReadLine()))
                            .Where(x => x >= K)
                            .ToList();

    Console.WriteLine(A.Count() - M >= 0 ? A.Count() - M : 0);
  }
}

// ---------------------------------------------------

using System;
using System.Linq;

class Program
{
  static void Main()
  {
    int[] nkm = Console.ReadLine()
                       .Split(' ')
                       .Select(x => int.Parse(x))
                       .ToArray();

    int c = Enumerable.Range(0, nkm[0])
                      .Select(_ => int.Parse(Console.ReadLine()))
                      .Where(x => x >= nkm[1])
                      .Skip(nkm[2])
                      .Count();

    Console.WriteLine(c);
  }
}