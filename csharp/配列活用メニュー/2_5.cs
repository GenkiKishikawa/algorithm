// 指定位置への要素の追加
// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__insert
// 配列 A と追加する位置 n と追加する要素 B が与えられるので、B を A_n の後ろに追加した後の A を出力してください。

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza
{
  static void Main()
  {
    int N = int.Parse(Console.ReadLine());

    List<int> A = Enumerable.Range(0, N)
                            .Select(_ => int.Parse(Console.ReadLine()))
                            .ToList();

    string[] inputs = Console.ReadLine().Split(' ');
    int n = int.Parse(inputs[0]);
    int B = int.Parse(inputs[1]);

    A.Insert(n, B);

    foreach (int a in A)
    {
      Console.WriteLine(a);
    }

  }
}