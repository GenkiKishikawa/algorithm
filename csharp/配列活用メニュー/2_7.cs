// 九九表
// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__reduse_easy
// 期待する出力にあるような、九九表を出力してください。

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza
{
  static void Main()
  {
    for (int low = 1; low < 10; low++)
    {
      List<int> A = new List<int>();

      for (int col = 1; col < 10; col++)
      {
        A.Add(low * col);
      }
      Console.WriteLine(string.Join(' ', A));
    }
  }
}