// 集合の結合
// https://paiza.jp/works/mondai/data_structure/data_structure__set_boss
// N 個の要素からなる数列 A, B が与えられます。
// A または B に含まれる値をすべて列挙し、重複を取り除いて昇順に出力してください。

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

    List<int> B = Console.ReadLine()
                          .Split(' ')
                          .Select(x => int.Parse(x))
                          .ToList();

    List<int> ans = A.Concat(B)
                      .ToList()
                      .Distinct()
                      .ToList();

    ans.Sort();

    Console.WriteLine(string.Join(' ', ans));
  }
}

// -------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
  static void Main()
  {
    Console.ReadLine();
    List<int> a = Input();
    List<int> b = Input();
    List<int> c = a.Union(b)
                   .Distinct()
                   .OrderBy(x => x)
                   .ToList();

    Console.WriteLine(string.Join(" ", c));
  }

  static List<int> Input()
  {
    return Console.ReadLine()
                  .Split(' ')
                  .Select(x => int.Parse(x))
                  .ToList();
  }
}