// 排他的論理和( XOR )の基本
// https://paiza.jp/works/mondai/logical_operation/logical_operation__basic_step4
// 0 または 1 の整数 A と B が与えられます。 A XOR B の結果を出力してください。

using System;

class Paiza {
  static void Main() {
    string[] inputs = Console.ReadLine().Split(' ');
    int A = int.Parse(inputs[0]);
    int B = int.Parse(inputs[1]);

    Console.WriteLine(A ^ B);
  }
}