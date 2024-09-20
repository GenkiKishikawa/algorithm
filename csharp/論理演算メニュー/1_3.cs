// 否定( NOT )の基本
// https://paiza.jp/works/mondai/logical_operation/logical_operation__basic_step3
// 0 または 1 の整数 A が与えられます。 NOT A の結果を出力してください。

using System;

class Paiza
{
  static void Main()
  {
    int A = int.Parse(Console.ReadLine());

    // 論理演算
    Console.WriteLine(!(A == 1) ? 1 : 0);
  }
}