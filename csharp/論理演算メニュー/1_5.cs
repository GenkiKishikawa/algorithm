// NAND 演算の基本
// https://paiza.jp/works/mondai/logical_operation/logical_operation__basic_step5
// 0 または 1 の整数 A と B が与えられます。 A NAND B の結果を出力してください。

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza {
  static void Main() {
    List<int> inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();

    // 論理演算
    Console.WriteLine(!(inputs[0] == 1 & inputs[1] == 1) ? 1 : 0);
  }
}

// -------------------------------------------------

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