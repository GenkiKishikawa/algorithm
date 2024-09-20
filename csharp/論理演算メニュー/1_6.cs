// NOR 演算の基本
// https://paiza.jp/works/mondai/logical_operation/logical_operation__basic_step6
// 0 または 1 の整数 A と B が与えられます。 A NOR B の結果を出力してください。

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza {
  static void Main() {
      List<int> A = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();

      Console.WriteLine(!(A[0] == 1 | A[1] == 1) ? 1 : 0);
  }
}

// -----------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> vs = Console.ReadLine()
                              .Split(' ')
                              .Select(x => int.Parse(x))
                              .ToList();

        Console.WriteLine(~(vs[0] | vs[1]) & 0x01);
    }
}