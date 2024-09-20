// 最大値と最小値
// https://paiza.jp/works/mondai/data_structure/data_structure__array_step3
// 自然数 A, B, C が与えられます。(A, B, C の最大値) - (A, B, C の最小値)を答えてください。

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza
{
  static void Main()
  {
    List<int> A = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();

    int max = A.Max();
    int min = A.Min();

    int ans = max - min;
    Console.WriteLine(ans);
  }
}