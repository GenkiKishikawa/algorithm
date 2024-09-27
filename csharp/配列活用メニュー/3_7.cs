// 【配列に対しての複雑な処理】集団行動
// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__group_move
// あなたは集団行動のリーダーです。次のような指示を出すことで様々な列の操作ができます。

// ・swap A B
// 先頭から A 番目の人と、先頭から B 番目の人の位置を入れ替える。
// ・reverse
// 列の前後を入れ替える。
// ・resize C
// 先頭から C 人を列に残し、それ以外の人を全員列から離れさせる。ただし、列が既に C 人以下の場合、何も行わない。

// 初め、列には番号 1 〜 N の N 人がおり、先頭から番号の昇順に並んでいます。(1, 2 , 3, ..., N)
// あなたの出した指示の回数 Q とその指示の内容 S_i (1 ≦ i ≦ Q) が順に与えられるので、全ての操作を順に行った後の列を出力してください。

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza
{
  static void Main()
  {
    int[] inputs = Console.ReadLine()
                          .Split(' ')
                          .Select(x => int.Parse(x))
                          .ToArray();

    int N = inputs[0];
    int Q = inputs[1];

    string[] controlls = Enumerable.Range(0, Q)
                                   .Select(_ => Console.ReadLine())
                                   .ToArray();

    List<int> A = Enumerable.Range(1, N)
                            .ToList();

    foreach (string controll in controlls)
    {
      string[] c = controll.Split(' ');
      switch (c[0])
      {
        case "swap":
          Swap(A, int.Parse(c[1]), int.Parse(c[2]));
          break;
        case "reverse":
          A.Reverse();
          break;
        case "resize":
          Resize(A, int.Parse(c[1]));
          break;
      }
    }

    foreach (int a in A)
    {
      Console.WriteLine(a);
    }
  }

  static void Swap(List<int> A, int a, int b)
  {
    int tmp = A[a - 1];
    A[a - 1] = A[b - 1];
    A[b - 1] = tmp;
  }

  static void Resize(List<int> A, int c)
  {
    if (A.Count() > c)
    {
      List<int> tmp = A.Take(c).ToList();
      A.Clear();
      A.AddRange(tmp);
    }
  }
}

// ----------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
  static void Main()
  {
    int[] nq = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
    string[] qs = Enumerable.Range(0, nq[1]).Select(_ => Console.ReadLine()).ToArray();

    List<int> ns = Enumerable.Range(1, nq[0]).ToList();
    foreach (string q in qs)
    {
      string[] c = q.Split(' ');
      switch (c[0])
      {
        case "swap":
          Swap(ns, int.Parse(c[1]), int.Parse(c[2]));
          break;
        case "reverse":
          ns.Reverse();
          break;
        case "resize":
          Resize(ns, int.Parse(c[1]));
          break;
      }
    }

    ns.ForEach(x => Console.WriteLine(x));
  }

  static void Swap(List<int> ns, int a, int b)
  {
    int ia = a - 1;
    int ib = b - 1;

    int t = ns[ia];
    ns[ia] = ns[ib];
    ns[ib] = t;
  }

  static void Resize(List<int> ns, int c)
  {
    if (ns.Count() > c)
    {
      List<int> tmp = ns.Take(c).ToList();
      ns.Clear();
      ns.AddRange(tmp);
    }
  }
}