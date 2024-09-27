// 二人三脚
// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__find_pair
// 生徒の身長が A_1, ...., A_N であるような N 人のクラスで二人三脚の代表を決めることにしました。
// 代表には、身長の差が最も小さいような 2 人を選出することにしました。選ばれた 2 人の身長を昇順に出力してください。

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

    int minDiff = 100;
    int C = 0;
    int B = 0;

    for (int i = 0; i < N; i++)
    {
      for (int j = 0; j < N; j++)
      {
        int diff = Math.Abs(A[i] - A[j]);
        if (minDiff >= diff && i != j)
        {
          minDiff = diff;
          C = A[i];
          B = A[j];
        }
      }
    }

    if (C < B)
    {
      Console.WriteLine(C);
      Console.WriteLine(B);
    }
    else
    {
      Console.WriteLine(B);
      Console.WriteLine(C);
    }
  }
}

// -----------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
  static void Main()
  {
    int[] a_s = Enumerable.Range(0, int.Parse(Console.ReadLine()))
                          .Select(_ => int.Parse(Console.ReadLine()))
                          .OrderBy(x => x)
                          .ToArray();

    List<Pair> pairs = new List<Pair>();
    for (int i = 0; i < a_s.Length - 1; i++)
    {
      for (int j = i + 1; j < a_s.Length; j++)
      {
        pairs.Add(new Pair(a_s[i], a_s[j]));
      }
    }

    Pair pair = pairs.OrderBy(x => x.s).First();
    Console.WriteLine(pair.x);
    Console.WriteLine(pair.y);
  }
}

class Pair
{
  public readonly int x;
  public readonly int y;
  public readonly int s;

  public Pair(int x, int y)
  {
    this.x = x;
    this.y = y;
    this.s = Math.Abs(x - y);
  }
}