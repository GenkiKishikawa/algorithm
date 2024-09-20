// 動的配列
// https://paiza.jp/works/mondai/data_structure/data_structure__array_boss
// N 個の要素からなる数列 A が与えられます。数列 A に対し、次の 3 つの操作を行うプログラムを作成してください。
// ・ push_back x : A の末尾に x を追加する
// ・ pop_back : A の末尾を削除する
// ・ print : A を半角スペース区切りで1行に出力する

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza
{
  static void Main()
  {
    List<int> inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
    // 要素数N
    int N = inputs[0];
    // 操作回数Q
    int Q = inputs[1];

    // 数列A
    List<int> A = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();

    for (int i = 0; i < Q; i++)
    {
      List<int> controll = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();

      // push_back
      if (controll[0] == 0)
      {
        int target = controll[1];
        A.Add(target);
      }
      // pop_back
      else if (controll[0] == 1)
      {
        A.RemoveAt(A.Count - 1);
      }
      // print
      else if (controll[0] == 2)
      {
        Console.WriteLine(string.Join(" ", A));
      }
    }
  }
}