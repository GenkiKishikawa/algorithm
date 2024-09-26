// 【配列への副作用を伴う操作】条件を満たす要素のみの配列作成
// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__filter
// 配列 A の要素数 N と整数 K , 配列 A の各要素 A_1 ... A_N が与えられるので、K 以上であるような配列 A の要素のみを要素として持つ配列 B を作成し、その要素を出力してください。 
// B の要素の順は A と同じにしてください。

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza
{
  static void Main()
  {
    string[] inputs = Console.ReadLine().Split(' ');
    int N = int.Parse(inputs[0]);
    int K = int.Parse(inputs[1]);

    List<int> A = Enumerable.Range(0, N)
                           .Select(_ => int.Parse(Console.ReadLine()))
                           .Where(x => x >= K)
                           .ToList();

    foreach (int a in A)
    {
      Console.WriteLine(a);
    }
  }
}

// --------------------------------------------------------

using System;
using System.Linq;

class Program
{
  static void Main()
  {
    int[] nk = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
    Enumerable.Range(0, nk[0])
              .Select(_ => int.Parse(Console.ReadLine()))
              .Where(x => x >= nk[1])
              .ToList()
              .ForEach(x => Console.WriteLine(x));
  }
}