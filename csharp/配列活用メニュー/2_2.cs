// 変数の入れ替え
// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__excange
// 整数型の変数を 2 つ宣言して整数 X, Y を格納したのち、2 つの変数の中身を入れ替えた後の 2 つの変数の値を出力してください。

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza
{
  static void Main()
  {
    string[] inputs = Console.ReadLine().Split(' ');
    Console.WriteLine($"{inputs[1]} {inputs[0]}");
  }
}