// 論理積( AND )の基本
// https://paiza.jp/works/mondai/logical_operation/logical_operation__basic_step1
// 0 または 1 の整数 A と B が与えられます。 A AND B の結果を出力してください。

using System;

class Paiza
{
  static void Main()
  {
    string[] inputs = Console.ReadLine().Split(' ');
    int A = int.Parse(inputs[0]);
    int B = int.Parse(inputs[1]);

    // 論理演算
    // C#では、&& 演算子はブール型のオペランドを期待しますが、A と B は整数型です。そのため、&& を使用するとコンパイルエラーが発生します。
    // 整数に対してビットごとのAND演算を行う場合、ビット演算子 (&) を使用する必要があります。
    Console.WriteLine(A & B);
  }
}