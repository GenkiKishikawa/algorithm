// XNOR 演算の基本
// https://paiza.jp/works/mondai/logical_operation/logical_operation__basic_step7
// 0 または 1 の整数 A と B が与えられます。 A XNOR B の結果を出力してください。

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza {
  static void Main() {
    List<int> A = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();

    Console.WriteLine(~(A[0] ^ A[1]) & 0x01);
  }
}