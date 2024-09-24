// 集合の探索
// https://paiza.jp/works/mondai/data_structure/data_structure__set_step1
// N 個の要素からなる数列 A と、整数 B が与えられます。B が A に含まれているかどうかを判定してください。

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza
{
  static void Main()
  {
    string[] inputs = Console.ReadLine().Split(' ');
    int N = int.Parse(inputs[0]);
    int B = int.Parse(inputs[1]);

    List<int> A = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();

    if (A.IndexOf(B) == -1)
    {
      Console.WriteLine("No");
    }
    else
    {
      Console.WriteLine("Yes");
    }
  }
}

// --------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
  static void Main()
  {
    string[] ab = Console.ReadLine().Split(' ');
    int b = int.Parse(ab[1]);

    IEnumerable<int> vs = Console.ReadLine()
                                 .Split(' ')
                                 .Select(x => int.Parse(x));

    Console.WriteLine(vs.Any(x => x == b) ? "Yes" : "No");
  }
}