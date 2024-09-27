// 傾斜配点
// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__exam
// paiza の入社試験では 科目 1 〜 5 の 5 科目のテストが課せられており、それぞれの科目には重みが設定されています。
// 受験者の得点は各科目の (とった点数) * (科目の重み) となります。 5 科目の得点の合計が最も高かった受験者の得点を求めてください。

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza
{
  static void Main()
  {
    int N = int.Parse(Console.ReadLine());

    List<int> RATIO = Console.ReadLine()
                             .Split(' ')
                             .Select(x => int.Parse(x))
                             .ToList();

    List<int> maxScores = new List<int>();
    for (int i = 0; i < N; i++)
    {
      List<int> scores = Console.ReadLine()
                                .Split(' ')
                                .Select(x => int.Parse(x))
                                .ToList();
      int sum = CalcSum(RATIO, scores);
      maxScores.Add(sum);
    }

    Console.WriteLine(maxScores.Max());
  }

  static int CalcSum(List<int> ratio, List<int> scores)
  {
    int sum = 0;
    for (int i = 0; i < 5; i++)
    {
      sum += scores[i] * ratio[i];
    }

    return sum;
  }
}

// ----------------------------------------------

using System;
using System.Linq;

class Program
{
  static void Main()
  {
    int n = int.Parse(Console.ReadLine());
    int[] m = Console.ReadLine()
                     .Split(' ')
                     .Select(x => int.Parse(x))
                     .ToArray();
    int s = Enumerable.Range(0, n)
                      .Select(_ =>
                        Console.ReadLine()
                               .Split(' ')
                               .Select((x, i) => int.Parse(x) * m[i])
                               .Sum()
                       )
                      .Max();
    Console.WriteLine(s);
  }
}