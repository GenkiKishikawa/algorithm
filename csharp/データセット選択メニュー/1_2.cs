// 複数回のランダムアクセス
// https://paiza.jp/works/mondai/data_structure/data_structure__array_step2
// 要素数 N の数列 A と要素数 Q の数列 B が与えられます。 1 ≦ i ≦ Q の各 i について、i 行目に A の B_i 番目の値を出力してください。

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza
{
  static void Main()
  {
    // 要素数N
    int N = int.Parse(Console.ReadLine());

    // 数列A
    List<int> A = Console.ReadLine()
                          .Split(' ')
                          .Select(x => int.Parse(x))
                          .ToList();

    // 要素数Q
    int Q = int.Parse(Console.ReadLine());

    // 数列B
    List<int> B = Console.ReadLine()
                          .Split(' ')
                          .Select(x => int.Parse(x))
                          .ToList();

    foreach (int b in B)
    {
      Console.WriteLine(A[b - 1]);
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
    Console.ReadLine();
    List<int> vs = Console.ReadLine()
                          .Split(' ')
                          .Select(x => int.Parse(x))
                          .ToList();

    Console.ReadLine();
    Console.ReadLine()
           .Split(' ')
           .Select(x => int.Parse(x))
           .ToList()
           .ForEach(x => Console.WriteLine(vs[x - 1]));
  }
}