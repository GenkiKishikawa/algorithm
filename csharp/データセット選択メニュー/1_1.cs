// ランダムアクセス
// https://paiza.jp/works/mondai/data_structure/data_structure__array_step1
// 要素数 N の数列 A と数値 M が与えられます。A の M 番目の値を出力してください。

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza
{
  static void Main()
  {
    List<int> inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
    int N = inputs[0];
    int M = inputs[1];

    List<int> A = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();

    Console.WriteLine(A[M - 1]);
  }
}