// 重複の削除
// https://paiza.jp/works/mondai/data_structure/data_structure__set_step2
// N 個の要素からなる数列 A が与えられます。
// 数列 A は昇順にソートされています。
// A の重複した要素を取り除いて昇順に出力してください

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza
{
  static void Main()
  {
    int N = int.Parse(Console.ReadLine());

    IEnumerable<int> ans = Console.ReadLine()
                                .Split(' ')
                                .Select(x => int.Parse(x))
                                .ToList()
                                .Distinct();
    Console.WriteLine(string.Join(' ', ans));
  }
}