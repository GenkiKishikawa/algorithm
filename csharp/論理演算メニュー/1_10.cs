// 論理演算を用いた計算のまとめ
// https://paiza.jp/works/mondai/logical_operation/logical_operation__basic_boss
// 0 または 1 の整数 A, B, C, D が与えられます。 以下の式を計算した結果を出力してください。

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza
{
  static void Main()
  {
    List<bool> inputs = Console.ReadLine()
                                .Split(' ')
                                .Select(x => int.Parse(x))
                                .Select(x => Convert.ToBoolean(x))
                                .ToList();

    bool A = inputs[0];
    bool B = inputs[1];
    bool C = inputs[2];
    bool D = inputs[3];

    Console.WriteLine(Convert.ToByte(!((!A & !B) | !C) ^ D));
  }
}