// 半加算器
// https://paiza.jp/works/mondai/logical_operation/logical_operation__basic_step8
// 京子ちゃんは 二進数 1 けたの整数 A と B を使って、 A + B を計算したいと思っています。
// 上記の画像のように、 A と B を足した結果 (2 進表記) の下から 2 けた目の値を C 、下から 1 けた目の値を S とします。 C と S を出力してください。

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza
{
  static void Main()
  {
    List<int> A = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();

    // 論理演算
    int sum = A[0] ^ A[1];
    int carry = A[0] & A[1];
    Console.WriteLine($"{carry} {sum}");
  }
}